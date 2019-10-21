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
    public partial class osnova : Form
    {
        public osnova()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan delta = Program.start - DateTime.Now;
            tam.Text = delta.Days.ToString() + "дней,  " + delta.Hours.ToString() + "часов,  " + delta.Minutes.ToString() + "минут(а, ы) до начала гонки";
           // Select country code, [User].firstname, [User].lastname from runner inner join [User] OnActivated runner.email=[UserControl].email;
        }

        private void Form1_Enter(object sender, EventArgs e)
        {

        }

        

        private void button_sponsor_Click(object sender, EventArgs e)
        {
            sponsor_beguna x = new sponsor_beguna();
            Hide();
            x.ShowDialog();
            Show();
        }

        private void button_begun_Click(object sender, EventArgs e)
        {
            ychastnic x = new ychastnic();
            Hide();
            x.ShowDialog();
            Show();
        }

        private void button_uchastnic_Click(object sender, EventArgs e)
        {
            regestr_zrichelia x = new regestr_zrichelia();
            Hide();
            x.ShowDialog();
            Show();
        }

        private void know_Click(object sender, EventArgs e)
        {
            podrobnaia_inf x = new podrobnaia_inf();
            Hide();
            x.ShowDialog();
            Show();
        }

        private void LOGIN_Click(object sender, EventArgs e)
        {
            Form_aftorizachia x = new Form_aftorizachia();
            Hide();
            x.ShowDialog();
            Show();
        }

      


        
    }
}
