namespace upg_finalni_projekt
{
    partial class My_Games
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
            this.gravityshift = new System.Windows.Forms.Button();
            this.piskvorky = new System.Windows.Forms.Button();
            this.bugs = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gravityshift
            // 
            this.gravityshift.BackColor = System.Drawing.Color.Yellow;
            this.gravityshift.Location = new System.Drawing.Point(652, 178);
            this.gravityshift.Name = "gravityshift";
            this.gravityshift.Size = new System.Drawing.Size(144, 117);
            this.gravityshift.TabIndex = 0;
            this.gravityshift.Text = "Gravity_Shift";
            this.gravityshift.UseVisualStyleBackColor = false;
            this.gravityshift.Click += new System.EventHandler(this.gravityshift_Click);
            // 
            // piskvorky
            // 
            this.piskvorky.BackColor = System.Drawing.Color.Yellow;
            this.piskvorky.Location = new System.Drawing.Point(252, 178);
            this.piskvorky.Name = "piskvorky";
            this.piskvorky.Size = new System.Drawing.Size(131, 117);
            this.piskvorky.TabIndex = 3;
            this.piskvorky.Text = "Piskvorky";
            this.piskvorky.UseVisualStyleBackColor = false;
            this.piskvorky.Click += new System.EventHandler(this.piskvorky_Click);
            // 
            // bugs
            // 
            this.bugs.BackColor = System.Drawing.Color.Yellow;
            this.bugs.Location = new System.Drawing.Point(452, 178);
            this.bugs.Name = "bugs";
            this.bugs.Size = new System.Drawing.Size(143, 117);
            this.bugs.TabIndex = 7;
            this.bugs.Text = "Bugs";
            this.bugs.UseVisualStyleBackColor = false;
            this.bugs.Click += new System.EventHandler(this.bugs_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(412, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "My Games";
            // 
            // My_Games
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1015, 426);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bugs);
            this.Controls.Add(this.piskvorky);
            this.Controls.Add(this.gravityshift);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "My_Games";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button gravityshift;
        private System.Windows.Forms.Button piskvorky;
        private System.Windows.Forms.Button bugs;
        private System.Windows.Forms.Label label1;
    }
}