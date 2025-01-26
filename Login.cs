using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace Note_Taker
{
    public partial class Login : Form
    {


        public Login()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\USER\source\repos\Note_Taker\Note_Taker\NoteTaker.mdf;Integrated Security=True");

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {


        }



        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("Select email,password from RegistrationTbl where email = @email and password = @password", connection);
            cmd.Parameters.AddWithValue("email", uname.Text);
            cmd.Parameters.AddWithValue("password", psw.Text);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Welcome to the Note Master");
                Form2 form2 = new Form2();
                form2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Incorrect Username or Password");
            }
            connection.Close();


        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register register = new Register();
            this.Hide();
            register.Show();
        }
    }
}





