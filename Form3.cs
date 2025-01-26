using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Note_Taker
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\USER\\source\\repos\\Note_Taker\\Note_Taker\\NoteTaker.mdf;Integrated Security=True");

        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                if (no.Text != "" && Title.Text != "" && Notebx.Text != "" )
                {
                            connection.Open();
                            SqlCommand command = new SqlCommand("insert into NoteTbl(Id,Title,Note) values(@Id,@Title," +
                            "@Note)", connection);

                            command.Parameters.AddWithValue("@Id", no.Text);
                            command.Parameters.AddWithValue("@Title", Title.Text);
                            command.Parameters.AddWithValue("@Note", Notebx.Text);
                            

                            command.ExecuteNonQuery();
                            
                            MessageBox.Show("Your note is saved!");
                            no.Text = "";
                            Title.Text = "";
                            Notebx.Text = "";


                    connection.Close();

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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
