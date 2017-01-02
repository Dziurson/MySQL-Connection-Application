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
    public partial class Picture_Show : Form
    {
        string image_name;

        public Picture_Show(string image_name, string film_title)
        {
            InitializeComponent();
            this.Width = Picture_Box_Cell.Width + 40;
            this.Height = Picture_Box_Cell.Height + 65;
            this.image_name = image_name;
            this.Text = film_title;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Picture_Box_Cell.Load("D:\\Users\\Grafy\\WindowsApp1\\WindowsApp1\\bin\\Debug\\Images\\" + image_name);
        }
    }
}
