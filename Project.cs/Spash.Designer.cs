namespace Project.cs
{
    partial class Spash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Spash));
            this.pbuser = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.lblsplash = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbuser)).BeginInit();
            this.SuspendLayout();
            // 
            // pbuser
            // 
            this.pbuser.BackColor = System.Drawing.Color.White;
            this.pbuser.Image = ((System.Drawing.Image)(resources.GetObject("pbuser.Image")));
            this.pbuser.Location = new System.Drawing.Point(-169, -132);
            this.pbuser.Margin = new System.Windows.Forms.Padding(4);
            this.pbuser.Name = "pbuser";
            this.pbuser.Size = new System.Drawing.Size(1974, 1116);
            this.pbuser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbuser.TabIndex = 21;
            this.pbuser.TabStop = false;
            this.pbuser.Click += new System.EventHandler(this.pbuser_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 25);
            this.button1.TabIndex = 23;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblsplash
            // 
            this.lblsplash.AutoSize = true;
            this.lblsplash.BackColor = System.Drawing.Color.Transparent;
            this.lblsplash.Font = new System.Drawing.Font("Cooper Black", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsplash.ForeColor = System.Drawing.Color.YellowGreen;
            this.lblsplash.Location = new System.Drawing.Point(372, 108);
            this.lblsplash.Name = "lblsplash";
            this.lblsplash.Size = new System.Drawing.Size(677, 74);
            this.lblsplash.TabIndex = 24;
            this.lblsplash.Text = "Dashboard Manager";
            // 
            // Spash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1420, 743);
            this.Controls.Add(this.lblsplash);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pbuser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Spash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Spash";
            this.Load += new System.EventHandler(this.Spash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbuser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbuser;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblsplash;
    }
}