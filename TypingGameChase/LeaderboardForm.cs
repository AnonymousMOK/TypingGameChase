namespace TypingGameChase
{
    public partial class LeaderboardForm : Form
    {
        private Form1 mainMenuRef;

        public LeaderboardForm(Form1 mainMenu)
        {
            InitializeComponent();
            mainMenuRef = mainMenu;
            LoadLeaderboard();
        }

        // 🔹 Back button click: return to Main Menu
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            mainMenuRef.Show();
        }

        // 🔹 Loads leaderboard entries from text file and populates DataGridView
        private void LoadLeaderboard()
        {
            try
            {
                string filePath = "leaderboard.txt";

                if (!File.Exists(filePath))
                {
                    File.Create(filePath).Close();
                    return;
                }

                var lines = File.ReadAllLines(filePath)
                                .Where(line => !string.IsNullOrWhiteSpace(line))
                                .Select(line => line.Split(','))
                                .Where(parts => parts.Length == 2)
                                .Select(parts => new
                                {
                                    Name = parts[0].Trim(),
                                    WPM = parts[1].Trim()
                                })
                                .OrderByDescending(entry => int.Parse(entry.WPM))
                                .ToList();

                dataGridViewLeaderboard.DataSource = lines;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading leaderboard:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
