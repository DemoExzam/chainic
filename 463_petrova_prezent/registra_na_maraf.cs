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
    public partial class registra_na_maraf : Form
    {
        public registra_na_maraf()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan delta = Program.start - DateTime.Now;
            label1.Text = delta.Days.ToString() + "дней,  " + delta.Hours.ToString() + "часов,  " + delta.Minutes.ToString() + "минут(и) до начала гонки";
            // Select country code, [User].firstname, [User].lastname from runner inner join [User] OnActivated runner.email=[UserControl].email;
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            blagodar_begun x = new blagodar_begun();
            Hide();
            x.ShowDialog();
            Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            menu_beguna x = new menu_beguna();
            Hide();
            x.ShowDialog();
            Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            menu_beguna x = new menu_beguna();
            Hide();
            x.ShowDialog();
            Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
