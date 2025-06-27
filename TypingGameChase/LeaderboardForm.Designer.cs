namespace TypingGameChase
{
    partial class LeaderboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LeaderboardForm));
            this.dataGridViewLeaderboard = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLeaderboard)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewLeaderboard
            // 
            this.dataGridViewLeaderboard.AllowUserToAddRows = false;
            this.dataGridViewLeaderboard.AllowUserToDeleteRows = false;
            this.dataGridViewLeaderboard.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewLeaderboard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLeaderboard.Location = new System.Drawing.Point(0, 78);
            this.dataGridViewLeaderboard.Name = "dataGridViewLeaderboard";
            this.dataGridViewLeaderboard.ReadOnly = true;
            this.dataGridViewLeaderboard.RowHeadersWidth = 51;
            this.dataGridViewLeaderboard.Size = new System.Drawing.Size(801, 319);
            this.dataGridViewLeaderboard.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(310, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Leaderboard";
            // 
            // btnBack
            // 
            this.btnBack.AutoSize = true;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBack.Location = new System.Drawing.Point(340, 410);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(120, 35);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back to Menu";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click); // 🔗 This is CRUCIAL
            // 
            // LeaderboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 460);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewLeaderboard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "LeaderboardForm";
            this.Text = "Leaderboard";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLeaderboard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewLeaderboard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
    }
}
