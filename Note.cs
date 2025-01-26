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
    public partial class Note : Form
    {
        DataTable notes = new DataTable();
        bool editing = false;
        public Note()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\USER\\source\\repos\\Note_Taker\\Note_Taker\\NoteTaker.mdf;Integrated Security=True");


        private void Note_Load_1(object sender, EventArgs e)
        {
            notes.Columns.Add("Title");
            notes.Columns.Add("Note");

            PreviousNotes.DataSource = notes;
        }




        private void Loadbut_Click(object sender, EventArgs e)
        {
            Title.Text = notes.Rows[PreviousNotes.CurrentCell.RowIndex].ItemArray[0].ToString();
            Notebx.Text = notes.Rows[PreviousNotes.CurrentCell.RowIndex].ItemArray[1].ToString();
            editing = true;
        }

      

       

     
        

        private void savebut_Click_1(object sender, EventArgs e)
        {
            if (editing)
            {
                notes.Rows[PreviousNotes.CurrentCell.RowIndex]["Title"] = Title.Text;
                notes.Rows[PreviousNotes.CurrentCell.RowIndex]["Note"] = Notebx.Text;
            }
            else
            {
                notes.Rows.Add(Title.Text, Notebx.Text);
            }
            Title.Text = "";
            Notebx.Text = "";
            editing = false;
        }

        private void delbut_Click_1(object sender, EventArgs e)
        {
            try
            {
                notes.Rows[PreviousNotes.CurrentCell.RowIndex].Delete();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Please enter a valid note");
            }
        }

        private void newbut_Click_1(object sender, EventArgs e)
        {
            Title.Text = "";
            Notebx.Text = "";
        }

        private void PreviousNotes_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            Title.Text = notes.Rows[PreviousNotes.CurrentCell.RowIndex].ItemArray[0].ToString();
            Notebx.Text = notes.Rows[PreviousNotes.CurrentCell.RowIndex].ItemArray[1].ToString();
            editing = true;
        }
    }
}