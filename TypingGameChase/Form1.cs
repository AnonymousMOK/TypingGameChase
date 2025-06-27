namespace TypingGameChase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 🔹 "Play Game" button logic
        private void btnPlayGame_Click(object sender, EventArgs e)
        {
            string playerName = Prompt.ShowDialog("Enter your name:", "Player Name");
            if (!string.IsNullOrWhiteSpace(playerName))
            {
                GameForm gameForm = new GameForm(this, playerName);
                gameForm.Show();
                this.Hide();
            }
        }

        // 🔹 "Game Rules" button logic
        private void btnGameRules_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "🌊 Type the sentence fast and accurately!\n\n" +
                "🐟 The fish escapes with each correct word.\n" +
                "🦈 The shark speeds up if you pause or make mistakes.\n" +
                "🏁 Escape the right side to win!",
                "Game Rules",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        // 🔹 "Leaderboard" button logic
        private void btnLeaderboard_Click(object sender, EventArgs e)
        {
            LeaderboardForm leaderboardForm = new LeaderboardForm(this);
            leaderboardForm.Show();
            this.Hide();
        }

        // 🔹 "Exit" button logic
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

    // 🔹 Reusable Input Dialog (used for entering player name)
    public static class Prompt
    {
        public static string ShowDialog(string text, string caption)
        {
            Form prompt = new Form()
            {
                Width = 400,
                Height = 160,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };

            Label textLabel = new Label() { Left = 20, Top = 20, Text = text, AutoSize = true };
            TextBox inputBox = new TextBox() { Left = 20, Top = 50, Width = 340 };

            Button confirmation = new Button() { Text = "OK", Left = 270, Width = 90, Top = 80, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => prompt.Close();

            prompt.Controls.AddRange(new Control[] { textLabel, inputBox, confirmation });
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? inputBox.Text : "";
        }
    }
}
