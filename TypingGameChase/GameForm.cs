using System.Media;

namespace TypingGameChase
{
    public partial class GameForm : Form
    {
        private GameEngine gameEngine;
        private DateTime lastTypedTime;
        private SoundPlayer backgroundMusicPlayer;
        private Random random = new Random();
        private Form1 _mainMenu;
        public GameForm(Form1 mainMenuRef, string playerName)
        {
            InitializeComponent();
            _mainMenu = mainMenuRef;
            this.Resize += (s, e) => SetupGameUI();
            SetFullscreen();

            backgroundMusicPlayer = LoadSound("C:\\Users\\muham\\Documents\\Project\\TypingGameChase\\TypingGameChase\\bin\\Debug\\net8.0-windows\\Resources\\Audio\\BabyBG.wav");
            backgroundMusicPlayer?.PlayLooping();

            gameEngine = new GameEngine
            {
                Player = new Player { Name = playerName },
                Fish = new Fish { Picture = picFish },
                Shark = new Shark { Picture = picShark }
            };

            SetupGameUI();
        }
        private void SetFullscreen()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.TopMost = true;
        }

        private void SetupGameUI()
        {
            if (gameEngine == null) return;
            // Reset game state
            lblSentence.Text = gameEngine.SentenceManager.GetRandomSentence();
            txtUserInput.Clear();
            txtUserInput.Focus();

            lastTypedTime = DateTime.Now;
            gameEngine.TypingStopwatch.Reset();
            gameEngine.MistakeCount = 0;
            lblWPM.Text = "WPM: 0";

            int formWidth = this.ClientSize.Width;
            int formHeight = this.ClientSize.Height;

            // ========== TEXTBOX ==========
            txtUserInput.Enabled = true;
            txtUserInput.Width = formWidth - 100;
            txtUserInput.Height = 35;
            txtUserInput.Left = 50;
            txtUserInput.Top = formHeight - 160;
            txtUserInput.Font = new Font("Segoe UI", 14);

            // ========== LABELS ==========

            // Sentence label (above textbox, centered, large)
            lblSentence.Visible = true;
            lblSentence.Width = formWidth - 40;
            lblSentence.Left = 20;
            lblSentence.Top = txtUserInput.Top - lblSentence.Height - 10;
            lblSentence.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            lblSentence.ForeColor = Color.Black;
            lblSentence.BackColor = Color.Transparent;
            lblSentence.TextAlign = ContentAlignment.MiddleCenter;

            // WPM label (top-right)
            lblWPM.AutoSize = true;
            lblWPM.Top = 20;
            lblWPM.Left = formWidth - 120;
            lblWPM.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            lblWPM.ForeColor = Color.White;
            lblWPM.BackColor = Color.Transparent;

            // ========== FISH & SHARK ==========

            picFish.Size = new Size(formWidth / 14, formHeight / 12);
            picShark.Size = new Size(formWidth / 12, formHeight / 10);

            int centerY = formHeight / 2;
            picFish.Top = centerY - picFish.Height / 2;
            picFish.Left = formWidth / 4;

            int sharkX = picFish.Left - picShark.Width - 100;
            if (sharkX < 10) sharkX = 10;
            picShark.Top = picFish.Top;
            picShark.Left = sharkX;

            // ========== BUTTONS ==========

            int btnTop = txtUserInput.Bottom + 20;
            int btnWidth = 120;
            int btnHeight = 35;
            int btnSpacing = 20;

            btnRestart.Size = new Size(btnWidth, btnHeight);
            btnRestart.Left = (formWidth - (btnWidth * 3 + btnSpacing * 2)) / 2;
            btnRestart.Top = btnTop;

            btnLeaderboard.Size = new Size(btnWidth, btnHeight);
            btnLeaderboard.Left = btnRestart.Right + btnSpacing;
            btnLeaderboard.Top = btnTop;

            btnExitGame.Size = new Size(btnWidth, btnHeight);
            btnExitGame.Left = btnLeaderboard.Right + btnSpacing;
            btnExitGame.Top = btnTop;

            btnRestart.FlatStyle = FlatStyle.Flat;
            btnLeaderboard.FlatStyle = FlatStyle.Flat;
            btnExitGame.FlatStyle = FlatStyle.Flat;

            btnRestart.Visible = false;
            btnExitGame.Visible = false;
            btnLeaderboard.Visible = false;

            // ========== START TIMERS ==========

            timerSharkMove.Interval = 100;
            timerSharkMove.Start();

            timerInputMonitor.Interval = 1000;
            timerInputMonitor.Start();
        }


        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.FormBorderStyle = FormBorderStyle.Sizable;
                this.WindowState = FormWindowState.Normal;
                this.TopMost = false;
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void txtUserInput_TextChanged(object sender, EventArgs e)
        {
            string expected = lblSentence.Text;
            string typed = txtUserInput.Text;
            lastTypedTime = DateTime.Now;

            if (!gameEngine.TypingStopwatch.IsRunning)
                gameEngine.TypingStopwatch.Start();

            gameEngine.MistakeCount = expected.Zip(typed, (a, b) => a != b).Count(x => x);

            if (typed == expected)
            {
                picFish.Left = this.ClientSize.Width - picFish.Width;
                CheckForWin();
                return;
            }

            if (picFish.Right + gameEngine.Fish.Speed < this.ClientSize.Width)
            {
                picFish.Left += gameEngine.Fish.Speed;
            }

            double minutes = gameEngine.TypingStopwatch.Elapsed.TotalMinutes;
            int wordCount = typed.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;
            gameEngine.Player.WPM = (int)(wordCount / (minutes > 0 ? minutes : 1));
            lblWPM.Text = $"WPM: {gameEngine.Player.WPM}";

            CheckForWin();
        }

        private void timerSharkMove_Tick(object sender, EventArgs e)
        {
            int boost = gameEngine.Shark.Speed + random.Next(1, 2);
            picShark.Left += boost;

            if (gameEngine.TypingStopwatch.Elapsed.TotalSeconds > 10)
                gameEngine.Shark.Speed += 1;
            CheckForLoss();
        }

        private void timerInputMonitor_Tick(object sender, EventArgs e)
        {
            TimeSpan delay = DateTime.Now - lastTypedTime;

            if (gameEngine.MistakeCount >= 3 || delay.TotalSeconds > 2)
            {
                picShark.Left += random.Next(4, 7);
            }
            CheckForLoss();
        }

        private void CheckForWin()
        {
            if (picFish.Right == this.ClientSize.Width)
            {
                GameOver(true);
            }
        }

        private void CheckForLoss()
        {
            if (picShark.Bounds.IntersectsWith(picFish.Bounds))
            {
                GameOver(false);
            }
        }

        private void GameOver(bool win)
        {
            timerSharkMove.Stop();
            timerInputMonitor.Stop();
            gameEngine.TypingStopwatch.Stop();

            string message = win ? "🏆 You Escaped the Shark!" : "💀 Shark Caught You!";
            MessageBox.Show(message);

            SaveScore();

            btnRestart.Visible = true;
            btnExitGame.Visible = true;
            btnLeaderboard.Visible = true;
            txtUserInput.Visible = false;
            lblSentence.Visible = false;
        }

        private void SaveScore()
        {
            try
            {
                string record = $"{gameEngine.Player.Name},{gameEngine.Player.WPM}";
                File.AppendAllLines("leaderboard.txt", new[] { record });
            }
            catch (Exception ex)
            {
                MessageBox.Show("⚠️ Error saving score: " + ex.Message);
            }
        }

        private SoundPlayer LoadSound(string filename)
        {
            try
            {
                string path = Path.Combine(Application.StartupPath, "Resources", "Audio", "BabyBG.wav");
                if (!File.Exists(path))
                    throw new FileNotFoundException("Missing sound file: " + path);

                return new SoundPlayer(path);
            }
            catch (Exception ex)
            {
                MessageBox.Show("⚠️ Audio loading error:\n" + ex.Message, "Audio Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }


        private void btnRestart_Click(object sender, EventArgs e) => SetupGameUI();
        private void btnExitGame_Click(object sender, EventArgs e) => Application.Exit();
        private void btnLeaderboard_Click(object sender, EventArgs e)
        {
            LeaderboardForm leaderboard = new LeaderboardForm(_mainMenu);
            leaderboard.Show();
            this.Hide();
        }
    }
}
