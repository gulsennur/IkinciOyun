namespace IkinciOyun
{
    partial class Oyun2
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
            this.tmrSure = new System.Windows.Forms.Timer(this.components);
            this.tmrButton = new System.Windows.Forms.Timer(this.components);
            this.pnl = new System.Windows.Forms.Panel();
            this.lblSkor = new System.Windows.Forms.Label();
            this.lblSure = new System.Windows.Forms.Label();
            this.lblKullanıcı = new System.Windows.Forms.Label();
            this.pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrSure
            // 
            this.tmrSure.Interval = 1000;
            this.tmrSure.Tick += new System.EventHandler(this.TmrSure_Tick);
            // 
            // tmrButton
            // 
            this.tmrButton.Interval = 1000;
            this.tmrButton.Tick += new System.EventHandler(this.TmrButton_Tick);
            // 
            // pnl
            // 
            this.pnl.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pnl.Controls.Add(this.lblSkor);
            this.pnl.Controls.Add(this.lblSure);
            this.pnl.Controls.Add(this.lblKullanıcı);
            this.pnl.Location = new System.Drawing.Point(243, -2);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(78, 253);
            this.pnl.TabIndex = 0;
            this.pnl.Paint += new System.Windows.Forms.PaintEventHandler(this.Pnl_Paint);
            // 
            // lblSkor
            // 
            this.lblSkor.AutoSize = true;
            this.lblSkor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.lblSkor.Location = new System.Drawing.Point(18, 106);
            this.lblSkor.Name = "lblSkor";
            this.lblSkor.Size = new System.Drawing.Size(44, 22);
            this.lblSkor.TabIndex = 2;
            this.lblSkor.Text = "skor";
            this.lblSkor.Click += new System.EventHandler(this.LblSkor_Click);
            // 
            // lblSure
            // 
            this.lblSure.AutoSize = true;
            this.lblSure.Location = new System.Drawing.Point(19, 64);
            this.lblSure.Name = "lblSure";
            this.lblSure.Size = new System.Drawing.Size(30, 13);
            this.lblSure.TabIndex = 1;
            this.lblSure.Text = "Time";
            // 
            // lblKullanıcı
            // 
            this.lblKullanıcı.AutoSize = true;
            this.lblKullanıcı.Location = new System.Drawing.Point(19, 25);
            this.lblKullanıcı.Name = "lblKullanıcı";
            this.lblKullanıcı.Size = new System.Drawing.Size(29, 13);
            this.lblKullanıcı.TabIndex = 0;
            this.lblKullanıcı.Text = "User";
            // 
            // Oyun2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 247);
            this.Controls.Add(this.pnl);
            this.Name = "Oyun2";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Oyun2_Resize);
            this.pnl.ResumeLayout(false);
            this.pnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tmrSure;
        private System.Windows.Forms.Timer tmrButton;
        private System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.Label lblSkor;
        private System.Windows.Forms.Label lblSure;
        private System.Windows.Forms.Label lblKullanıcı;
    }
}

