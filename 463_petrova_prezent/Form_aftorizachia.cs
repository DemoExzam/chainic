using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _463_petrova_prezent
{
    public partial class Form_aftorizachia : Form
    {
        public static string con = "Data Source=127.0.0.1;Initial Catalog=463_petrova_12;Persist Security Info=True;User ID=student;Password=student";
        private SqlConnection connection;
 
        public Form_aftorizachia()
        {
            InitializeComponent();
            connection = new SqlConnection(con);
            connection.Open();
        }

      

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan delta = Program.start - DateTime.Now;
            label5.Text = delta.Days.ToString() + "дней,  " + delta.Hours.ToString() + "часов,  " + delta.Minutes.ToString() + "минут(и) до начала гонки";
           // Select country code, [User].firstname, [User].lastname from runner inner join [User] OnActivated runner.email=[UserControl].email;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //test x = new test();
            // Hide();
           // x.ShowDialog();
            //Show();
            string login = textBox1.Text;
            string password = textBox2.Text;

             string query = "select RoleId from [User] where [Email] = '"+login+"'";
             SqlCommand role = new SqlCommand(query, connection);
             string user_role = ((string)role.ExecuteScalar());

             string query2 = "select [Password] from [User] where [Email] = '"+login+"'";
             SqlCommand pass = new SqlCommand(query2, connection);
             string user_pass = ((string)pass.ExecuteScalar());
             
            if(login == "Введите маил" || password == "Введите пароль")
             { 
             MessageBox.Show("Pleas, заполните все поля","ошибка",MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
             else if (password != user_pass)
            {
                  MessageBox.Show("Введен неверный логин или пороль.Repid pleas","ошибка",MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
             else if(user_role =="R")
            {
                menu_beguna open = new menu_beguna();
                  open.Show();
            }
             else if (user_role == "C")
            {
                meny_coordinator open = new meny_coordinator();
                 open.Show(); 
            }
             else if(user_role == "A")
            {
             MessageBox.Show("Вы админ");
             meny_administratora open = new meny_administratora();
             open.Show(); 
             }
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            osnova x = new osnova();
            Hide();
            x.ShowDialog();
            Show();
        }

       

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "Введите пароль";
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox1.Text = "Введите маил";
        }
        }
    }

