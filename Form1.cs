using System;
using System.Windows.Forms;

namespace BallGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Exit(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_StartGame(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.FormClosed += new FormClosedEventHandler(form2_FormClosed);
            frm2.Show();
            this.Hide();
        }


        private void form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
    }
}