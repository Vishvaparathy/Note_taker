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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\USER\\source\\repos\\Note_Taker\\Note_Taker\\NoteTaker.mdf;Integrated Security=True");

        private void Notebx_TextChanged(object sender, EventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("Select Note from NoteTbl where Title = @Title", connection);
            cmd.Parameters.AddWithValue("Title" , Titlebx.Text);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                Notebox.Text = dr["Note"].ToString();
            }
            else
            {
                MessageBox.Show("No data found");
            }
            connection.Close();
             

        }
    }
}
    

