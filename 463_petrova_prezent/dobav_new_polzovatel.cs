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
    public partial class dobav_new_polzovatel : Form
    {
        public dobav_new_polzovatel()
        {
            InitializeComponent();
        }

        private void dobav_new_polzovatel_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan delta = Program.start - DateTime.Now;
            label10.Text = delta.Days.ToString() + "дней,  " + delta.Hours.ToString() + "часов,  " + delta.Minutes.ToString() + "минут(и) до начала гонки";
            // Select country code, [User].firstname, [User].lastname from runner inner join [User] OnActivated runner.email=[UserControl].email; 
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ypravlenia_polzovatelem x = new ypravlenia_polzovatelem();
            Hide();
            x.ShowDialog();
            Show();
        }



        

        private void save_Click_1(object sender, EventArgs e)
        {
            ypravlenia_polzovatelem x = new ypravlenia_polzovatelem();
            Hide();
            x.ShowDialog();
            Show();
        }

        private void otmena_Click_1(object sender, EventArgs e)
        {
            ypravlenia_polzovatelem x = new ypravlenia_polzovatelem();
            Hide();
            x.ShowDialog();
            Show();
        }
    }
}
