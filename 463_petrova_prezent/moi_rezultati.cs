﻿using System;
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
    public partial class moi_rezultati : Form
    {
        public moi_rezultati()
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
            rezultat_predidush_gonok x = new rezultat_predidush_gonok();
            Hide();
            x.ShowDialog();
            Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            menu_beguna x = new  menu_beguna();
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
