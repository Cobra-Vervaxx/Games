namespace upg_finalni_projekt
{
    partial class Bugs
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
            this.enemyOne = new System.Windows.Forms.PictureBox();
            this.enemyTwo = new System.Windows.Forms.PictureBox();
            this.enemyThree = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.attack = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.enemyOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyThree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attack)).BeginInit();
            this.SuspendLayout();
            // 
            // enemyOne
            // 
            this.enemyOne.BackColor = System.Drawing.Color.Transparent;
            this.enemyOne.BackgroundImage = global::upg_finalni_projekt.Properties.Resources.bug;
            this.enemyOne.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.enemyOne.Location = new System.Drawing.Point(73, 40);
            this.enemyOne.Name = "enemyOne";
            this.enemyOne.Size = new System.Drawing.Size(100, 85);
            this.enemyOne.TabIndex = 0;
            this.enemyOne.TabStop = false;
            // 
            // enemyTwo
            // 
            this.enemyTwo.BackColor = System.Drawing.Color.Transparent;
            this.enemyTwo.BackgroundImage = global::upg_finalni_projekt.Properties.Resources.bug;
            this.enemyTwo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.enemyTwo.Location = new System.Drawing.Point(384, 40);
            this.enemyTwo.Name = "enemyTwo";
            this.enemyTwo.Size = new System.Drawing.Size(100, 85);
            this.enemyTwo.TabIndex = 1;
            this.enemyTwo.TabStop = false;
            // 
            // enemyThree
            // 
            this.enemyThree.BackColor = System.Drawing.Color.Transparent;
            this.enemyThree.BackgroundImage = global::upg_finalni_projekt.Properties.Resources.bug;
            this.enemyThree.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.enemyThree.Location = new System.Drawing.Point(679, 40);
            this.enemyThree.Name = "enemyThree";
            this.enemyThree.Size = new System.Drawing.Size(100, 85);
            this.enemyThree.TabIndex = 2;
            this.enemyThree.TabStop = false;
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.BackgroundImage = global::upg_finalni_projekt.Properties.Resources.player;
            this.player.Location = new System.Drawing.Point(384, 478);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(110, 90);
            this.player.TabIndex = 3;
            this.player.TabStop = false;
            // 
            // attack
            // 
            this.attack.BackgroundImage = global::upg_finalni_projekt.Properties.Resources.attack;
            this.attack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.attack.Location = new System.Drawing.Point(435, 435);
            this.attack.Name = "attack";
            this.attack.Size = new System.Drawing.Size(9, 27);
            this.attack.TabIndex = 4;
            this.attack.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtScore
            // 
            this.txtScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtScore.Font = new System.Drawing.Font("Showcard Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.Image = global::upg_finalni_projekt.Properties.Resources.cabbbles;
            this.txtScore.Location = new System.Drawing.Point(-7, 194);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(900, 200);
            this.txtScore.TabIndex = 5;
            this.txtScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Bugs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::upg_finalni_projekt.Properties.Resources.cabbbles;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 681);
            this.Controls.Add(this.attack);
            this.Controls.Add(this.player);
            this.Controls.Add(this.enemyThree);
            this.Controls.Add(this.enemyTwo);
            this.Controls.Add(this.enemyOne);
            this.Controls.Add(this.txtScore);
            this.DoubleBuffered = true;
            this.Name = "Bugs";
            this.Text = "hunaljo";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Bugs_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Bugs_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.enemyOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyThree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox enemyOne;
        private System.Windows.Forms.PictureBox enemyTwo;
        private System.Windows.Forms.PictureBox enemyThree;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox attack;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label txtScore;
    }
}