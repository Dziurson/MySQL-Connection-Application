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
    public partial class Set_Picture_Form : Form
    {
        Dodaj_Window upperForm;
        bool first_use = true;
        public Set_Picture_Form(Form upperForm_t)
        {
            InitializeComponent();
            upperForm = (Dodaj_Window)upperForm_t;
        }

        private void TextBox_Onclick(object sender, EventArgs e)
        {
            if (first_use)
            {
                textBox1.Text = "";
                first_use = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            upperForm.image_source = textBox1.Text;
            this.Close();
        }

        private void Set_Picture_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                Uri tmp = new Uri(textBox1.Text);
                upperForm.on_close_flag = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
