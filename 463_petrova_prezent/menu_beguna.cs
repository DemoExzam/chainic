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
    public partial class menu_beguna : Form
    {
        public menu_beguna()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan delta = Program.start - DateTime.Now;
            label2.Text = delta.Days.ToString() + "дней,  " + delta.Hours.ToString() + "часов,  " + delta.Minutes.ToString() + "минут(и) до начала гонки";
            // Select country code, [User].firstname, [User].lastname from runner inner join [User] OnActivated runner.email=[UserControl].email;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            registra_na_maraf x = new registra_na_maraf();
            Hide();
            x.ShowDialog();
            Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            redactirovanie_profila x = new redactirovanie_profila();
            Hide();
            x.ShowDialog();
            Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            contact x = new contact();
            
            x.ShowDialog();
            Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            moi_rezultati x = new moi_rezultati();
            Hide();
            x.ShowDialog();
            Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            moi_sponsori x = new moi_sponsori();
            Hide();
            x.ShowDialog();
            Show();
        }
    }
}
