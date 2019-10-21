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
    public partial class test : Form
    {
        public test()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            menu_beguna x = new menu_beguna();
            Hide();
            x.ShowDialog();
            Show();
           // Form_aftorizachia close = new Form_aftorizachia();
            //close.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form_aftorizachia x = new Form_aftorizachia();
            Hide();
            x.ShowDialog();
            Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            meny_coordinator x = new meny_coordinator();
            Hide();
            x.ShowDialog();
            Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            meny_administratora x = new meny_administratora();
            Hide();
            x.ShowDialog();
            Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            menu_zritel x = new menu_zritel();
            Hide();
            x.ShowDialog();
            Show();
        }
        }
    }

