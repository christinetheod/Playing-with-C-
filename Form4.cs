using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstGame
{
    public partial class Form4 : Form
    {
        private int _ticks; //gia to timer
        private Random r; //gia na kounithei to gif
        private string comboBox1; // gia to level        

        public Form4(string text)
        {
            InitializeComponent();
            timer1.Start();
            comboBox1 = text; // gia to level
            toolStripLabel2.Text = text;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            r = new Random();  //gia na kounithei to gif
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _ticks++;
            this.Text = _ticks.ToString();
            toolStripLabel5.Text = this.Text;

            if (_ticks == 10)
            {
                this.Text = "Time's up!";
                timer1.Stop();
                MessageBox.Show("Time's up!");
                MessageBox.Show(sc, "Your score is:"); //score
                this.Close();
                score = 0; //gia na midenizei tin metavlith
                //save score
                StreamWriter savescore = new StreamWriter("username.txt", true);
                savescore.Write("Score:");
                savescore.WriteLine(sc);  
                savescore.Close();

            }

            pictureBox1.Location = new Point(r.Next(this.Width - pictureBox1.Width), r.Next(this.Height - pictureBox1.Height));
            // gia to level
            if (comboBox1 == "Large")
            {
                Size size = new Size(100, 100);
                pictureBox1.Size = size;
            }
            else if (comboBox1 == "Medium")
            {
                Size size = new Size(50, 50);
                pictureBox1.Size = size;
            }
            else
            {
                Size size = new Size(25, 25);
                pictureBox1.Size = size;
            }

        }

        private void έξοδοςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private static int score=0;
        private string sc=score.ToString();
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            score++;
            sc = score.ToString();
        }     

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            toolStripLabel3.Text = sc;
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
        }
        private void toolStripLabel4_Click(object sender, EventArgs e)
        {
        }

        private void πληροφορίεςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            MessageBox.Show("Σκοπός του παιχνιδιού είναι να πετύχεις όσο το δυνατόν μεγαλύτερο score 'χτυπώντας' την μπάλα");
            timer1.Start();
        }
    }
}
