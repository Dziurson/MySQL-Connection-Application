namespace WindowsApp1
{
    partial class Dodaj_Window
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dodaj_Window));
            this.Picture_Box = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Title_Box = new System.Windows.Forms.TextBox();
            this.Year_Box = new System.Windows.Forms.TextBox();
            this.Gatunek_Box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Cena_box = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Box)).BeginInit();
            this.SuspendLayout();
            // 
            // Picture_Box
            // 
            this.Picture_Box.Image = ((System.Drawing.Image)(resources.GetObject("Picture_Box.Image")));
            this.Picture_Box.InitialImage = null;
            this.Picture_Box.Location = new System.Drawing.Point(12, 12);
            this.Picture_Box.Name = "Picture_Box";
            this.Picture_Box.Size = new System.Drawing.Size(125, 167);
            this.Picture_Box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Picture_Box.TabIndex = 0;
            this.Picture_Box.TabStop = false;
            this.Picture_Box.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(297, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Gotowe";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Gotowe_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(216, 156);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Anuluj";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // Title_Box
            // 
            this.Title_Box.BackColor = System.Drawing.Color.White;
            this.Title_Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Title_Box.Location = new System.Drawing.Point(200, 12);
            this.Title_Box.Name = "Title_Box";
            this.Title_Box.Size = new System.Drawing.Size(172, 20);
            this.Title_Box.TabIndex = 3;
            this.Title_Box.TextChanged += new System.EventHandler(this.Title_Box_TextChanged);
            // 
            // Year_Box
            // 
            this.Year_Box.BackColor = System.Drawing.Color.White;
            this.Year_Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Year_Box.Location = new System.Drawing.Point(200, 38);
            this.Year_Box.Name = "Year_Box";
            this.Year_Box.Size = new System.Drawing.Size(172, 20);
            this.Year_Box.TabIndex = 4;
            this.Year_Box.TextChanged += new System.EventHandler(this.Year_Box_TextChanged);
            // 
            // Gatunek_Box
            // 
            this.Gatunek_Box.BackColor = System.Drawing.Color.White;
            this.Gatunek_Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Gatunek_Box.Location = new System.Drawing.Point(200, 64);
            this.Gatunek_Box.Name = "Gatunek_Box";
            this.Gatunek_Box.Size = new System.Drawing.Size(172, 20);
            this.Gatunek_Box.TabIndex = 5;
            this.Gatunek_Box.TextChanged += new System.EventHandler(this.Gatunek_Box_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tytuł:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Rok:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Gatunek:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Cena_box
            // 
            this.Cena_box.BackColor = System.Drawing.Color.White;
            this.Cena_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Cena_box.Location = new System.Drawing.Point(200, 91);
            this.Cena_box.Name = "Cena_box";
            this.Cena_box.Size = new System.Drawing.Size(172, 20);
            this.Cena_box.TabIndex = 9;
            this.Cena_box.TextChanged += new System.EventHandler(this.Cena_box_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(159, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Cena:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(164, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Uzupełnij Pola zaznaczone na czerwono";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(164, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Niepoprawna cena";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(164, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Niepoprawny Rok";
            this.label7.Visible = false;
            // 
            // Dodaj_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 187);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Cena_box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Gatunek_Box);
            this.Controls.Add(this.Year_Box);
            this.Controls.Add(this.Title_Box);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Picture_Box);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Dodaj_Window";
            this.Text = "Dodaj";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Dodaj_Closed);
            this.Load += new System.EventHandler(this.Dodaj_Window_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Picture_Box;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox Title_Box;
        private System.Windows.Forms.TextBox Year_Box;
        private System.Windows.Forms.TextBox Gatunek_Box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox Cena_box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}