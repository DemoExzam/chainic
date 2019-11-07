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
    public partial class podrobnaia_inf : Form
    {
        public podrobnaia_inf()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan delta = Program.start - DateTime.Now;
            label2.Text = delta.Days.ToString() + "дней,  " + delta.Hours.ToString() + "часов,  " + delta.Minutes.ToString() + "минут(и) до начала гонки";
            // Select country code, [User].firstname, [User].lastname from runner inner join [User] OnActivated runner.email=[UserControl].email;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            inf x = new inf();
            Hide();
            x.ShowDialog();
            Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nascolko_dolgie_marafon x = new nascolko_dolgie_marafon();
            Hide();
            x.ShowDialog();
            Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            rezultat_predidush_gonok x = new rezultat_predidush_gonok();
            Hide();
            x.ShowDialog();
            Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            map x = new map();
            Hide();
            x.ShowDialog();
            Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
           BMI_KALKULETAR x = new BMI_KALKULETAR();
            Hide();
            x.ShowDialog();
            Show();
        }
    }
}
