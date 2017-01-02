using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsApp1
{
    public partial class Edycja_Window : Form
    {
        Database database;
        DataGridViewRow row;
        Main_Window main;
        public Edycja_Window(Database database,DataGridViewRow row, Main_Window main_window)
        {
            InitializeComponent();
            this.row = row;
            this.database = database;
            main = main_window;
        }

        private void Edycja_Window_Load(object sender, EventArgs e)
        {
            Title_Box.Text = (string)row.Cells[2].Value;
            Year_Box.Text = row.Cells[3].Value.ToString();
            Type_Box.Text = (string)row.Cells[4].Value;
            Price_Box.Text = row.Cells[6].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand("UPDATE filmy SET tytul='" + Title_Box.Text + "', rok='" + Year_Box.Text + "', gatunek='" + Type_Box.Text + "', cena='" + System.Text.RegularExpressions.Regex.Replace(Price_Box.Text,",",".") + "' WHERE id='" + row.Cells[1].Value.ToString() + "'",database.Connection);            
            database.Open();
            cmd.ExecuteNonQuery();
            database.Close();
            main.check = true;
            this.Close();
        }
    }
}
