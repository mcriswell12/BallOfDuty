using System.Windows.Forms;
namespace BallOfDuty
{
    partial class MainMenu
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.title = new System.Windows.Forms.Label();
            this.title2 = new System.Windows.Forms.Label();
            this.exitGame = new System.Windows.Forms.Button();
            this.viewHighScores = new System.Windows.Forms.Button();
            this.startGame = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Image = ((System.Drawing.Image)(resources.GetObject("title.Image")));
            this.title.Location = new System.Drawing.Point(291, 94);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(495, 75);
            this.title.TabIndex = 3;
            // 
            // title2
            // 
            this.title2.Image = ((System.Drawing.Image)(resources.GetObject("title2.Image")));
            this.title2.Location = new System.Drawing.Point(147, 169);
            this.title2.Name = "title2";
            this.title2.Size = new System.Drawing.Size(791, 75);
            this.title2.TabIndex = 4;
            // 
            // exitGame
            // 
            this.exitGame.AutoSize = true;
            this.exitGame.Image = ((System.Drawing.Image)(resources.GetObject("exitGame.Image")));
            this.exitGame.Location = new System.Drawing.Point(435, 400);
            this.exitGame.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exitGame.Name = "exitGame";
            this.exitGame.Size = new System.Drawing.Size(198, 61);
            this.exitGame.TabIndex = 8;
            this.exitGame.UseVisualStyleBackColor = true;
            this.exitGame.Click += new System.EventHandler(this.exitGame_Click);
            // 
            // viewHighScores
            // 
            this.viewHighScores.AutoSize = true;
            this.viewHighScores.Image = ((System.Drawing.Image)(resources.GetObject("viewHighScores.Image")));
            this.viewHighScores.Location = new System.Drawing.Point(380, 334);
            this.viewHighScores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.viewHighScores.Name = "viewHighScores";
            this.viewHighScores.Size = new System.Drawing.Size(310, 61);
            this.viewHighScores.TabIndex = 7;
            this.viewHighScores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.viewHighScores.UseVisualStyleBackColor = true;
            this.viewHighScores.Click += new System.EventHandler(this.viewHighScores_Click);
            // 
            // startGame
            // 
            this.startGame.AutoSize = true;
            this.startGame.Image = ((System.Drawing.Image)(resources.GetObject("startGame.Image")));
            this.startGame.Location = new System.Drawing.Point(420, 270);
            this.startGame.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.startGame.Name = "startGame";
            this.startGame.Size = new System.Drawing.Size(228, 61);
            this.startGame.TabIndex = 6;
            this.startGame.UseVisualStyleBackColor = true;
            this.startGame.Click += new System.EventHandler(this.startGame_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1121, 618);
            this.panel1.TabIndex = 9;
            this.panel1.Visible = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1121, 618);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.title);
            this.Controls.Add(this.title2);
            this.Controls.Add(this.viewHighScores);
            this.Controls.Add(this.startGame);
            this.Controls.Add(this.exitGame);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainMenu";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label title2;
        private System.Windows.Forms.Button exitGame;
        private System.Windows.Forms.Button viewHighScores;
        private System.Windows.Forms.Button startGame;
        protected System.Windows.Forms.Panel panel1;
    }
}

