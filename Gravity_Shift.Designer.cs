namespace upg_finalni_projekt
{
    partial class Gravity_Shift
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
            this.StartBtn = new System.Windows.Forms.Button();
            this.ScoreLbl = new System.Windows.Forms.Label();
            this.HighscoreLbl = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.jumpTimer = new System.Windows.Forms.Timer(this.components);
            this.fallTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(387, 171);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(150, 75);
            this.StartBtn.TabIndex = 0;
            this.StartBtn.Text = "Start";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // ScoreLbl
            // 
            this.ScoreLbl.AutoSize = true;
            this.ScoreLbl.Location = new System.Drawing.Point(413, 130);
            this.ScoreLbl.Name = "ScoreLbl";
            this.ScoreLbl.Size = new System.Drawing.Size(50, 13);
            this.ScoreLbl.TabIndex = 1;
            this.ScoreLbl.Text = "Score:  0";
            // 
            // HighscoreLbl
            // 
            this.HighscoreLbl.AutoSize = true;
            this.HighscoreLbl.Location = new System.Drawing.Point(412, 253);
            this.HighscoreLbl.Name = "HighscoreLbl";
            this.HighscoreLbl.Size = new System.Drawing.Size(70, 13);
            this.HighscoreLbl.TabIndex = 2;
            this.HighscoreLbl.Text = "Highscore:  0";
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 10;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // jumpTimer
            // 
            this.jumpTimer.Interval = 15;
            this.jumpTimer.Tick += new System.EventHandler(this.jumpTimer_Tick);
            // 
            // fallTimer
            // 
            this.fallTimer.Interval = 15;
            this.fallTimer.Tick += new System.EventHandler(this.fallTimer_Tick);
            // 
            // Gravity_Shift
            // 
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.HighscoreLbl);
            this.Controls.Add(this.ScoreLbl);
            this.Controls.Add(this.StartBtn);
            this.Name = "Gravity_Shift";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GravityShift_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GravityShift_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Label ScoreLbl;
        private System.Windows.Forms.Label HighscoreLbl;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Timer jumpTimer;
        private System.Windows.Forms.Timer fallTimer;
    }
}