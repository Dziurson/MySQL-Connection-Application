using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql;
using MySql.Data.MySqlClient;

namespace WindowsApp1
{
    public partial class Main_Window : Form
    {
        private Database database;
        public bool check = false;
        public bool first_use = true;        

        public Main_Window()
        {
            InitializeComponent();            
        }
               
        public Main_Window(ref Database database_t)
        {
            InitializeComponent();
            database = database_t;
            Edycja_Button.Location = new Point((this.Width - 4 * Edycja_Button.Width - 2 * 20) / 3 + Edycja_Button.Width + 12, 12);
            Szukaj_Button.Location = new Point((this.Width - 4 * Edycja_Button.Width - 2 * 20) * 2 / 3 + 2 * Edycja_Button.Width + 12, 12);
        }

        private void Main_Window_Load(object sender, EventArgs e)
        {
            //Fill_Grid();
        }

        private void Dodaj_Button_Click(object sender, EventArgs e)
        {              
            new Thread(() => new Dodaj_Window(ref database, this).ShowDialog()).Start();          
        }

        private void Edycja_Button_Click(object sender, EventArgs e)
        {
            List<int> opened_list = new List<int>();
            if (MySQL_Grid.SelectedCells.Count != 0)
            {                
                foreach (DataGridViewCell cell in MySQL_Grid.SelectedCells)
                {                    
                    if (!opened_list.Contains(cell.RowIndex))
                    {
                        new Thread(() => new Edycja_Window(database, MySQL_Grid.Rows[cell.RowIndex], this).ShowDialog()).Start();
                        opened_list.Add(cell.RowIndex);
                    }                   
                }                             
            }
            if(MySQL_Grid.SelectedRows.Count != 0)
            {
                foreach(DataGridViewRow row in MySQL_Grid.SelectedRows)
                {
                    if(!opened_list.Contains(row.Index))
                    {
                        new Thread(() => new Edycja_Window(database, row, this).ShowDialog()).Start();
                        opened_list.Add(row.Index);
                    }
                }                
            }
        }

        private void Szukaj_Button_Click(object sender, EventArgs e)
        {
            new Thread(() => new Szukaj_Window(MySQL_Grid).ShowDialog()).Start();          
        }

        private void Refresh_Button_Click(object sender, EventArgs e)
        {
            Fill_Grid();
        }

        private void Fill_Grid()
        {
            database.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM filmy", database.Connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataSet set = new DataSet();
            adapter.Fill(set);
            database.Close();
            MySQL_Grid.DataSource = set.Tables[0];       
            this.MySQL_Grid.Columns[5].Visible = false;
            this.MySQL_Grid.Columns[1].Visible = false;
            this.MySQL_Grid.Columns[6].DefaultCellStyle.Format = "c";
            foreach(DataGridViewRow row in MySQL_Grid.Rows)
                row.Cells[0].Value = Image.FromFile("D:\\Users\\Grafy\\WindowsApp1\\WindowsApp1\\bin\\Debug\\Images\\" + (string)row.Cells[5].Value);                   
            GC.Collect();
                                
        }

        private void Check_Updates(object sender, EventArgs e)
        {            
            if (check)
            {
                Cursor.Current = Cursors.WaitCursor;
                try
                {
                    Fill_Grid();
                }
                catch(Exception exception)
                {
                    check = false;
                    MessageBox.Show(exception.Message);
                }
                check = false;
                Cursor.Current = Cursors.Default;
            }
        }
        
        private void afterSort(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in MySQL_Grid.Rows)
                row.Cells[0].Value = Image.FromFile("D:\\Users\\Grafy\\WindowsApp1\\WindowsApp1\\bin\\Debug\\Images\\" + (string)row.Cells[5].Value);
            GC.Collect();
        }

        private void Main_Window_ResizeEnd(object sender, EventArgs e)
        {
            Edycja_Button.Location = new Point((this.Width - 4 * Edycja_Button.Width - 2 * 20) / 3 + Edycja_Button.Width + 12, 12);            
            Szukaj_Button.Location = new Point((this.Width - 4 * Edycja_Button.Width - 2 * 20) * 2 / 3 + 2 * Edycja_Button.Width +12, 12);
        }

        private void Cell_Mouse_Click(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1 && e.Button == MouseButtons.Right)
            {
                new Thread(() => new Edycja_Window(database, MySQL_Grid.Rows[e.RowIndex], this).ShowDialog()).Start();
            }                
        }

        private void Cell_Mouse_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1) new Thread(() => new Picture_Show((string)MySQL_Grid.Rows[e.RowIndex].Cells[5].Value, (string)MySQL_Grid.Rows[e.RowIndex].Cells[2].Value).ShowDialog()).Start();
        }       
    }
}
