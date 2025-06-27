namespace TypingGameChase
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button btnPlayGame;
        private System.Windows.Forms.Button btnGameRules;
        private System.Windows.Forms.Button btnLeaderboard;
        private System.Windows.Forms.Button btnExit;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnPlayGame = new Button();
            btnGameRules = new Button();
            btnLeaderboard = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // btnPlayGame
            // 
            btnPlayGame.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnPlayGame.Location = new Point(318, 257);
            btnPlayGame.Name = "btnPlayGame";
            btnPlayGame.Size = new Size(200, 40);
            btnPlayGame.TabIndex = 0;
            btnPlayGame.Text = "Play Game";
            btnPlayGame.UseVisualStyleBackColor = true;
            btnPlayGame.Click += btnPlayGame_Click;
            // 
            // btnGameRules
            // 
            btnGameRules.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnGameRules.Location = new Point(318, 317);
            btnGameRules.Name = "btnGameRules";
            btnGameRules.Size = new Size(200, 40);
            btnGameRules.TabIndex = 1;
            btnGameRules.Text = "Game Rules";
            btnGameRules.UseVisualStyleBackColor = true;
            btnGameRules.Click += btnGameRules_Click;
            // 
            // btnLeaderboard
            // 
            btnLeaderboard.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnLeaderboard.Location = new Point(318, 377);
            btnLeaderboard.Name = "btnLeaderboard";
            btnLeaderboard.Size = new Size(200, 40);
            btnLeaderboard.TabIndex = 2;
            btnLeaderboard.Text = "Leaderboard";
            btnLeaderboard.UseVisualStyleBackColor = true;
            btnLeaderboard.Click += btnLeaderboard_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnExit.Location = new Point(318, 437);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(200, 40);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit Game";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(830, 517);
            Controls.Add(btnPlayGame);
            Controls.Add(btnGameRules);
            Controls.Add(btnLeaderboard);
            Controls.Add(btnExit);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Typing Chase - Main Menu";
            ResumeLayout(false);
        }
    }
}
