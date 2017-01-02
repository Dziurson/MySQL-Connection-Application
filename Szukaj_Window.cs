using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Text.RegularExpressions;

namespace WindowsApp1
{
    public partial class Szukaj_Window : Form
    {
        DataGridView grid_view;

        public Szukaj_Window(DataGridView grid)
        {
            grid_view = grid;
            InitializeComponent();            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
        }

        private void Szukaj_Button_Click(object sender, EventArgs e)
        {
            bool check;
            foreach(DataGridViewRow row in grid_view.Rows)
            {
                row.DefaultCellStyle.BackColor = Color.White;
                row.DefaultCellStyle.ForeColor = Color.Black;               
                check = true;
                if (Title_Box.Text != "")
                {
                    if (Regex.Replace((string)row.Cells[2].Value," ","").ToLower() == Regex.Replace(Title_Box.Text," ","").ToLower()) check &= true;
                    else check &= false;                    
                }
                if (Year_Box.Text != "")
                {
                    if (row.Cells[3].Value.ToString() == Year_Box.Text) check &= true;
                    else check &= false;
                }
                if (Type_Box.Text != "")
                {
                    if (Regex.Replace((string)row.Cells[4].Value," ","").ToLower() == Regex.Replace(Type_Box.Text," ","").ToLower()) check &= true;
                    else check &= false;
                }
                if (checkBox1.Checked)
                {
                    if ((double)row.Cells[6].Value == 0) check &= true;
                    else check &= false;
                }
                if (check)
                {
                    row.DefaultCellStyle.BackColor = Color.Green;
                    row.DefaultCellStyle.ForeColor = Color.White;
                }
            }            
            this.Close();
        }

        private void Anuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
