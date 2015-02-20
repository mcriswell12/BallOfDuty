using System.Windows.Forms;
namespace BallOfDuty
{
    partial class GameWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameWindow));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.scoreBox = new System.Windows.Forms.Label();
            this.easyButton = new System.Windows.Forms.Button();
            this.mediumButton = new System.Windows.Forms.Button();
            this.hardButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // scoreBox
            // 
            this.scoreBox.AutoSize = true;
            this.scoreBox.BackColor = System.Drawing.Color.Transparent;
            this.scoreBox.Font = new System.Drawing.Font("Arial", 25F);
            this.scoreBox.Location = new System.Drawing.Point(900, 670);
            this.scoreBox.Name = "scoreBox";
            this.scoreBox.Size = new System.Drawing.Size(153, 47);
            this.scoreBox.TabIndex = 0;
            this.scoreBox.Text = "Score: ";
            // 
            // easyButton
            // 
            this.easyButton.Location = new System.Drawing.Point(486, 207);
            this.easyButton.Name = "easyButton";
            this.easyButton.Size = new System.Drawing.Size(168, 76);
            this.easyButton.TabIndex = 1;
            this.easyButton.Text = "EASY";
            this.easyButton.UseVisualStyleBackColor = true;
            this.easyButton.Click += new System.EventHandler(this.easyButton_Click);
            // 
            // mediumButton
            // 
            this.mediumButton.Location = new System.Drawing.Point(486, 315);
            this.mediumButton.Name = "mediumButton";
            this.mediumButton.Size = new System.Drawing.Size(168, 76);
            this.mediumButton.TabIndex = 2;
            this.mediumButton.Text = "MEDIUM";
            this.mediumButton.UseVisualStyleBackColor = true;
            this.mediumButton.Click += new System.EventHandler(this.mediumButton_Click);
            // 
            // hardButton
            // 
            this.hardButton.Location = new System.Drawing.Point(486, 418);
            this.hardButton.Name = "hardButton";
            this.hardButton.Size = new System.Drawing.Size(168, 77);
            this.hardButton.TabIndex = 3;
            this.hardButton.Text = "HARD";
            this.hardButton.UseVisualStyleBackColor = true;
            this.hardButton.Click += new System.EventHandler(this.hardButton_Click);
            // 
            // GameWindow
            // 
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1184, 642);
            this.Controls.Add(this.hardButton);
            this.Controls.Add(this.mediumButton);
            this.Controls.Add(this.easyButton);
            this.Controls.Add(this.scoreBox);
            this.DoubleBuffered = true;
            this.Name = "GameWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ball of Duty";
            this.Load += new System.EventHandler(this.GameWindow_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GameWindow_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameWindow_KeyDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GameWindow_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Label scoreBox;
        private Button easyButton;
        private Button mediumButton;
        private Button hardButton;
    }
}