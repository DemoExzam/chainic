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
    public partial class ypravlenia_polzovatelem : Form
    {
        public ypravlenia_polzovatelem()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            meny_administratora x = new meny_administratora();
            Hide();
            x.ShowDialog();
            Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan delta = Program.start - DateTime.Now;
            label7.Text = delta.Days.ToString() + "дней,  " + delta.Hours.ToString() + "часов,  " + delta.Minutes.ToString() + "минут(и) до начала гонки";
            // Select country code, [User].firstname, [User].lastname from runner inner join [User] OnActivated runner.email=[UserControl].email;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dobav_new_polzovatel x = new dobav_new_polzovatel();
            Hide();
            x.ShowDialog();
            Show();
        }
    }
}
