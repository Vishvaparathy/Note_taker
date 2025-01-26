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

namespace Note_Taker
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\USER\\source\\repos\\Note_Taker\\Note_Taker\\NoteTaker.mdf;Integrated Security=True");
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (email.Text != "" && username.Text != "" && password.Text != "" && cpassword.Text != "")
                {
                    if (password.Text == cpassword.Text)
                    {
                        int v = check(email.Text);
                        if (v != 1)
                        {
                            connection.Open();
                            SqlCommand command = new SqlCommand("insert into RegistrationTbl(phoneno,email,username,password) values(@phoneno,@email,"+
                                "@username, @password)", connection);

                            command.Parameters.AddWithValue("@phoneno", phoneno.Text);
                            command.Parameters.AddWithValue("@email", email.Text);
                            command.Parameters.AddWithValue("@username", username.Text);
                            command.Parameters.AddWithValue("@password", password.Text);
               
                            command.ExecuteNonQuery();
                            connection.Close();
                            MessageBox.Show("Register Successfully!");
                            email.Text = "";
                            username.Text = "";
                            password.Text = "";
                            cpassword.Text = "";

                            Login login = new Login();
                            login.Show();


                        }
                        else
                        {
                            MessageBox.Show("You are already registered!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Password is incorrect");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter the details");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        int check(string email)
        {
            connection.Open();
            string query = "select count(*) from RegistrationTbl where email='" + email + "'";
            SqlCommand command = new SqlCommand(query, connection);
            int v = (int)command.ExecuteScalar();
            connection.Close();
            return v;
        }

        

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }
    }
}
