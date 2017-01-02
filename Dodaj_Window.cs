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
using MySql.Data.MySqlClient;
using System.IO;
using System.Text.RegularExpressions;

namespace WindowsApp1
{
    public partial class Dodaj_Window : Form
    {
        Database database;
        Main_Window main_window;
        public string image_source = null;
        public bool on_close_flag = false;        
        private bool year_box_correct = false;        
        private bool price_box_correct = false;

        public Dodaj_Window()
        {
            InitializeComponent();
        }

        public Dodaj_Window(ref Database database_t, Form main_window)
        {
            InitializeComponent();
            database = database_t;
            this.main_window = (Main_Window)main_window;                        
        }        

        private void Dodaj_Window_Load(object sender, EventArgs e)
        {
            
        }
        
        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new Thread(() => new Set_Picture_Form(this).ShowDialog()).Start();
        }

        private void Gotowe_Click(object sender, EventArgs e)
        {
            if (CheckFields())
            {
                try
                {
                    System.Net.WebClient webClient = new System.Net.WebClient();
                    string image_path = image_path = "D:\\Users\\Grafy\\WindowsApp1\\WindowsApp1\\bin\\Debug\\Images\\";
                    string last_part = null;
                    if (image_source != null)
                    {
                        last_part = image_source.Split('/').Last();
                        image_path += last_part;
                        webClient.DownloadFile(image_source, image_path);
                    }
                    else
                    {
                        last_part = "test.png";
                        image_path += last_part;
                    }
                    MySqlCommand command = new MySqlCommand("INSERT INTO filmy (tytul, rok, gatunek, adres_zdjecia, cena) VALUES ('" + Title_Box.Text + "', '" + Year_Box.Text + "', '" + Gatunek_Box.Text + "', '" + last_part + "', '" + Regex.Replace(Cena_box.Text, ",", ".") + "')", database.Connection);
                    database.Open();
                    command.ExecuteNonQuery();
                    database.Close();
                    MessageBox.Show("Dodawanie zakończone pomyślnie");
                    this.Close();
                    webClient.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                Title_Box.BackColor = (Title_Box.Text == "") ? Color.FromArgb(255, 106, 106) : Color.LightGreen;
                Gatunek_Box.BackColor = (Gatunek_Box.Text == "") ? Color.FromArgb(255, 106, 106) : Color.LightGreen;
                if (Year_Box.Text == "") Year_Box.BackColor = Color.FromArgb(255, 106, 106);
                if (Cena_box.Text == "") Cena_box.BackColor = Color.FromArgb(255, 106, 106);
                label5.Visible = true;
            }
        }

        private bool CheckFields()
        {
            return year_box_correct && price_box_correct && Title_Box.Text != "" && Gatunek_Box.Text != "";
        }

        private void Dodaj_Closed(object sender, FormClosedEventArgs e)
        {            
            main_window.check = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(on_close_flag)
            {
                Cursor.Current = Cursors.WaitCursor;
                try
                {
                    Picture_Box.Load(image_source);
                }
                catch(Exception excepion)
                {
                    on_close_flag = false;
                    MessageBox.Show(excepion.Message);
                }
                on_close_flag = false;
                Cursor.Current = Cursors.Default;
            }
        }

        private void Year_Box_TextChanged(object sender, EventArgs e)
        {            
            if (Regex.IsMatch(Year_Box.Text, @"^[1-9][0-9]*$"))
            {                
                if (Int32.Parse(Year_Box.Text) <= DateTime.Today.Year)
                {
                    year_box_correct = true;
                    Year_Box.BackColor = Color.LightGreen;
                    label7.Visible = false;
                }
                else
                {
                    Year_Box.BackColor = Color.FromArgb(255, 106, 106);
                    label7.Visible = true;
                }
            }
            else
            {
                year_box_correct = false;
                Year_Box.BackColor = Color.FromArgb(255, 106, 106);
                label7.Visible = true;
                if (Year_Box.Text == "") label5.Visible = true;
            }
            if (Everything_Is_Correct()) label5.Visible = false;
        }

        private void Cena_box_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(Cena_box.Text, @"^([0-9]+)$|([.,][0-9]{2}$)"))
            {
                Cena_box.BackColor = Color.LightGreen;
                price_box_correct = true;
                label6.Visible = false;
            }
            else
            {
                Cena_box.BackColor = Color.FromArgb(255, 106, 106);
                price_box_correct = false;
                label6.Visible = true;
                if (Cena_box.Text == "") label5.Visible = true;
            }
            if (Everything_Is_Correct()) label5.Visible = false;            
        }

        private void Title_Box_TextChanged(object sender, EventArgs e)
        {
            if (Title_Box.Text == "")
            {
                Title_Box.BackColor = Color.FromArgb(255, 106, 106);
                label5.Visible = true;
            }
            else Title_Box.BackColor = Color.LightGreen;
            if (Everything_Is_Correct()) label5.Visible = false;
        }

        private void Gatunek_Box_TextChanged(object sender, EventArgs e)
        {
            if (Gatunek_Box.Text == "")
            {
                Gatunek_Box.BackColor = Color.FromArgb(255, 106, 106);
                label5.Visible = true;
            }
            else Gatunek_Box.BackColor = Color.LightGreen;
            if (Everything_Is_Correct()) label5.Visible = false;
        }

        private bool Everything_Is_Correct()
        {
            if ((Title_Box.Text != "" || Title_Box.BackColor.Equals(Color.White)) && (Gatunek_Box.Text != "" || Gatunek_Box.BackColor.Equals(Color.White)) && (Cena_box.Text != "" || Cena_box.BackColor.Equals(Color.White)) && (Year_Box.Text != "" || Year_Box.BackColor.Equals(Color.White)))
            {
                return true;
            }
            else return false;
        }
    }
}
