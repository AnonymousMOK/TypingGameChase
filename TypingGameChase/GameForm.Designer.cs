namespace TypingGameChase
{
    partial class GameForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            lblWPM = new Label();
            lblSentence = new Label();
            timerSharkMove = new System.Windows.Forms.Timer(components);
            timerInputMonitor = new System.Windows.Forms.Timer(components);
            picShark = new PictureBox();
            picFish = new PictureBox();
            txtUserInput = new TextBox();
            btnRestart = new Button();
            btnLeaderboard = new Button();
            btnExitGame = new Button();
            ((System.ComponentModel.ISupportInitialize)picShark).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picFish).BeginInit();
            SuspendLayout();
            // 
            // lblWPM
            // 
            lblWPM.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblWPM.AutoSize = true;
            lblWPM.BackColor = Color.Transparent;
            lblWPM.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblWPM.ForeColor = Color.White;
            lblWPM.Location = new Point(5, 7);
            lblWPM.Name = "lblWPM";
            lblWPM.Size = new Size(70, 28);
            lblWPM.TabIndex = 0;
            lblWPM.Text = "label1";
            // 
            // lblSentence
            // 
            lblSentence.AutoSize = true;
            lblSentence.BackColor = Color.Transparent;
            lblSentence.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblSentence.ForeColor = Color.White;
            lblSentence.Location = new Point(5, 113);
            lblSentence.Name = "lblSentence";
            lblSentence.Size = new Size(70, 28);
            lblSentence.TabIndex = 1;
            lblSentence.Text = "label2";
            // 
            // timerSharkMove
            // 
            timerSharkMove.Tick += timerSharkMove_Tick;
            // 
            // timerInputMonitor
            // 
            timerInputMonitor.Tick += timerInputMonitor_Tick;
            // 
            // picShark
            // 
            picShark.BackColor = Color.Transparent;
            picShark.BackgroundImage = (Image)resources.GetObject("picShark.BackgroundImage");
            picShark.BackgroundImageLayout = ImageLayout.Stretch;
            picShark.Location = new Point(5, 181);
            picShark.Name = "picShark";
            picShark.Size = new Size(110, 62);
            picShark.TabIndex = 2;
            picShark.TabStop = false;
            // 
            // picFish
            // 
            picFish.BackColor = Color.Transparent;
            picFish.BackgroundImage = (Image)resources.GetObject("picFish.BackgroundImage");
            picFish.BackgroundImageLayout = ImageLayout.Stretch;
            picFish.Location = new Point(154, 181);
            picFish.Name = "picFish";
            picFish.Size = new Size(120, 62);
            picFish.SizeMode = PictureBoxSizeMode.Zoom;
            picFish.TabIndex = 3;
            picFish.TabStop = false;
            // 
            // txtUserInput
            // 
            txtUserInput.Anchor = AnchorStyles.Bottom;
            txtUserInput.Location = new Point(5, 365);
            txtUserInput.Name = "txtUserInput";
            txtUserInput.Size = new Size(125, 27);
            txtUserInput.TabIndex = 4;
            txtUserInput.TextChanged += txtUserInput_TextChanged;
            // 
            // btnRestart
            // 
            btnRestart.Location = new Point(258, 284);
            btnRestart.Name = "btnRestart";
            btnRestart.Size = new Size(94, 29);
            btnRestart.TabIndex = 5;
            btnRestart.Text = "Restart";
            btnRestart.UseVisualStyleBackColor = true;
            btnRestart.Click += btnRestart_Click;
            // 
            // btnLeaderboard
            // 
            btnLeaderboard.AutoSize = true;
            btnLeaderboard.Location = new Point(358, 284);
            btnLeaderboard.Name = "btnLeaderboard";
            btnLeaderboard.Size = new Size(104, 30);
            btnLeaderboard.TabIndex = 6;
            btnLeaderboard.Text = "Leaderboard";
            btnLeaderboard.UseVisualStyleBackColor = true;
            btnLeaderboard.Click += btnLeaderboard_Click;
            // 
            // btnExitGame
            // 
            btnExitGame.Location = new Point(468, 284);
            btnExitGame.Name = "btnExitGame";
            btnExitGame.Size = new Size(94, 29);
            btnExitGame.TabIndex = 7;
            btnExitGame.Text = "Exit";
            btnExitGame.UseVisualStyleBackColor = true;
            btnExitGame.Click += btnExitGame_Click;
            // 
            // GameForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExitGame);
            Controls.Add(btnLeaderboard);
            Controls.Add(btnRestart);
            Controls.Add(txtUserInput);
            Controls.Add(picFish);
            Controls.Add(picShark);
            Controls.Add(lblSentence);
            Controls.Add(lblWPM);
            Name = "GameForm";
            Text = "GameForm";
            ((System.ComponentModel.ISupportInitialize)picShark).EndInit();
            ((System.ComponentModel.ISupportInitialize)picFish).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWPM;
        private Label lblSentence;
        private System.Windows.Forms.Timer timerSharkMove;
        private System.Windows.Forms.Timer timerInputMonitor;
        private PictureBox picShark;
        private PictureBox picFish;
        private TextBox txtUserInput;
        private Button btnRestart;
        private Button btnLeaderboard;
        private Button btnExitGame;
    }
}
