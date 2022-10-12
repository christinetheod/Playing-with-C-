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
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter saveusername = new StreamWriter("username.txt", true);
            saveusername.Write("Username:");
            saveusername.Write(textBox1.Text);
            saveusername.Write(" ");
            saveusername.Write("Game Level:");
            saveusername.Write(comboBox1.Text);
            saveusername.Write(" ");
            saveusername.Close();

            //null textbox and open form4
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please enter a username"); 
            }
            else
            {
                MessageBox.Show("You only have 10 seconds to hit the ball! HURRY UP!");
                Form4 form4 = new Form4(comboBox1.Text);
                form4.Show();
                this.Close();

            }


        }
       

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Text = "Mania Ball";
        }
    }
}
