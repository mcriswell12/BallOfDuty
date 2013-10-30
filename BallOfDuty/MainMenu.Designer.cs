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
            this.title.Location = new System.Drawing.Point(212, 94);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(442, 75);
            this.title.TabIndex = 3;
            // 
            // title2
            // 
            this.title2.Image = ((System.Drawing.Image)(resources.GetObject("title2.Image")));
            this.title2.Location = new System.Drawing.Point(127, 169);
            this.title2.Name = "title2";
            this.title2.Size = new System.Drawing.Size(636, 75);
            this.title2.TabIndex = 4;
            // 
            // exitGame
            // 
            this.exitGame.Location = new System.Drawing.Point(370, 377);
            this.exitGame.Name = "exitGame";
            this.exitGame.Size = new System.Drawing.Size(109, 30);
            this.exitGame.TabIndex = 8;
            this.exitGame.Text = "Exit Game";
            this.exitGame.UseVisualStyleBackColor = true;
            // 
            // viewHighScores
            // 
            this.viewHighScores.Location = new System.Drawing.Point(361, 333);
            this.viewHighScores.Name = "viewHighScores";
            this.viewHighScores.Size = new System.Drawing.Size(126, 38);
            this.viewHighScores.TabIndex = 7;
            this.viewHighScores.Text = "View HighScores";
            this.viewHighScores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.viewHighScores.UseVisualStyleBackColor = true;
            this.viewHighScores.Click += new System.EventHandler(this.viewHighScores_Click);
            // 
            // startGame
            // 
            this.startGame.Location = new System.Drawing.Point(370, 294);
            this.startGame.Name = "startGame";
            this.startGame.Size = new System.Drawing.Size(109, 31);
            this.startGame.TabIndex = 6;
            this.startGame.Text = "Play Game!";
            this.startGame.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(857, 541);
            this.panel1.TabIndex = 9;
            this.panel1.Visible = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(857, 541);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.exitGame);
            this.Controls.Add(this.viewHighScores);
            this.Controls.Add(this.startGame);
            this.Controls.Add(this.title);
            this.Controls.Add(this.title2);
            this.Name = "MainMenu";
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label title2;
        private System.Windows.Forms.Button exitGame;
        private System.Windows.Forms.Button viewHighScores;
        private System.Windows.Forms.Button startGame;
        private System.Windows.Forms.Panel panel1;
    }
}

