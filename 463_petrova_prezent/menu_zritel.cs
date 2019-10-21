using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _463_petrova_prezent
{
    public partial class menu_zritel : Form
    {
        public menu_zritel()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan delta = Program.start - DateTime.Now;
            label2.Text = delta.Days.ToString() + "дней,  " + delta.Hours.ToString() + "часов,  " + delta.Minutes.ToString() + "минут(и) до начала гонки";
            // Select country code, [User].firstname, [User].lastname from runner inner join [User] OnActivated runner.email=[UserControl].email;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            test x = new test();
            Hide();
            x.ShowDialog();
            Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ostavit_otzav x = new ostavit_otzav();
            Hide();
            x.ShowDialog();
            Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            statistika x = new statistika();
            Hide();
            x.ShowDialog();
            Show();
        }
    }
}
