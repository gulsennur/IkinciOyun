using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IkinciOyun
{
    public partial class Oyun2 : Form
    {
        Random rnd = new Random();
        int skor = 0, sure = 5;
        List<int> skorlar = new List<int>();
        public Oyun2()
        {
            InitializeComponent();
        }

        private void TmrButton_Tick(object sender, EventArgs e)
        {
            Button btn = new Button();
            btn.Size = new Size(50, 50);
            btn.Location = new Point(rnd.Next(this.ClientSize.Width - btn.Width), rnd.Next(this.ClientSize.Height - btn.Height));
            btn.Text = rnd.Next(10, 100).ToString();
            btn.Click += Btn_Click;
            this.Controls.Add(btn);

        }

        private void Btn_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            Button btn = (Button)sender;
            skor += int.Parse(btn.Text);
            btn.Dispose();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            tmrButton.Start();
            tmrSure.Start();
        }

        private void LblSkor_Click(object sender, EventArgs e)
        {

        }
        private void TmrSure_Tick(object sender, EventArgs e)
        {
            this.Text = sure.ToString();
            sure--;
            if (sure==0)
            {
                tmrSure.Stop();
                tmrButton.Stop();
                DialogResult cvp = MessageBox.Show($"Toplam puan:{skor}\nYeniden başlamak ister misin?","Oyun bitti", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                   if (cvp == DialogResult.Yes)
                   {
                        YenidenBaslat();
                   }
                   else
                   {
                    int max = 0;
                    foreach (int item in skorlar)
                    {
                        if (item > max)
                        {
                            max = item;
                        }
                    }
                    MessageBox.Show($"En yüksek skorunuz:{max}");
                    Application.Exit();
                }
        }
    }
        private void Oyun2_Resize(object sender, EventArgs e)
        {
            Control control = (Control)sender;

            if (control.Size.Height != control.Size.Width)
            {
                control.Size = new Size(control.Size.Width, control.Size.Height);
            }
        }

        private void Pnl_Paint(object sender, PaintEventArgs e)
        {

        }

        void YenidenBaslat()
         {
            for (int i = 0; i < this.Controls.Count; i++)
            {
                this.Controls[i].Dispose();
                i--; 
            }
            sure = 3;
            skor = 0;
            tmrButton.Start();
            tmrSure.Start();
         }


    }

}