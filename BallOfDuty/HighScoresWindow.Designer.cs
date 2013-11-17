namespace BallOfDuty
{
    partial class HighScoresWindow
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HighScoresWindow));
            this.menuButton = new System.Windows.Forms.Button();
            this.highScoresBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // menuButton
            // 
            this.menuButton.AutoSize = true;
            this.menuButton.Image = ((System.Drawing.Image)(resources.GetObject("menuButton.Image")));
            this.menuButton.Location = new System.Drawing.Point(386, 386);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(356, 61);
            this.menuButton.TabIndex = 0;
            this.menuButton.UseVisualStyleBackColor = true;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // highScoresBox
            // 
            this.highScoresBox.BackColor = System.Drawing.SystemColors.GrayText;
            this.highScoresBox.ForeColor = System.Drawing.SystemColors.Menu;
            this.highScoresBox.Location = new System.Drawing.Point(362, 143);
            this.highScoresBox.Multiline = true;
            this.highScoresBox.Name = "highScoresBox";
            this.highScoresBox.ReadOnly = true;
            this.highScoresBox.Size = new System.Drawing.Size(427, 189);
            this.highScoresBox.TabIndex = 1;
            this.highScoresBox.Text = HighScoreTable.displayScores();
            // 
            // label1
            // 
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(316, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(521, 111);
            this.label1.TabIndex = 2;
            // 
            // HighScoresWindow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.highScoresBox);
            this.Controls.Add(this.menuButton);
            this.Name = "HighScoresWindow";
            this.Size = new System.Drawing.Size(1121, 618);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.TextBox highScoresBox;
        private System.Windows.Forms.Label label1;
    }
}
