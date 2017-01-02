namespace WindowsApp1
{
    partial class Main_Window
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Dodaj_Button = new System.Windows.Forms.Button();
            this.Edycja_Button = new System.Windows.Forms.Button();
            this.Szukaj_Button = new System.Windows.Forms.Button();
            this.MySQL_Grid = new System.Windows.Forms.DataGridView();
            this.miniatura = new System.Windows.Forms.DataGridViewImageColumn();
            this.Refresh_Button = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.MySQL_Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // Dodaj_Button
            // 
            this.Dodaj_Button.Location = new System.Drawing.Point(12, 12);
            this.Dodaj_Button.MaximumSize = new System.Drawing.Size(75, 23);
            this.Dodaj_Button.Name = "Dodaj_Button";
            this.Dodaj_Button.Size = new System.Drawing.Size(75, 23);
            this.Dodaj_Button.TabIndex = 0;
            this.Dodaj_Button.Text = "Dodaj";
            this.Dodaj_Button.UseVisualStyleBackColor = true;
            this.Dodaj_Button.Click += new System.EventHandler(this.Dodaj_Button_Click);
            // 
            // Edycja_Button
            // 
            this.Edycja_Button.Location = new System.Drawing.Point(93, 12);
            this.Edycja_Button.Name = "Edycja_Button";
            this.Edycja_Button.Size = new System.Drawing.Size(75, 23);
            this.Edycja_Button.TabIndex = 1;
            this.Edycja_Button.Text = "Edycja";
            this.Edycja_Button.UseVisualStyleBackColor = true;
            this.Edycja_Button.Click += new System.EventHandler(this.Edycja_Button_Click);
            // 
            // Szukaj_Button
            // 
            this.Szukaj_Button.Location = new System.Drawing.Point(174, 12);
            this.Szukaj_Button.Name = "Szukaj_Button";
            this.Szukaj_Button.Size = new System.Drawing.Size(75, 23);
            this.Szukaj_Button.TabIndex = 2;
            this.Szukaj_Button.Text = "Szukaj...";
            this.Szukaj_Button.UseVisualStyleBackColor = true;
            this.Szukaj_Button.Click += new System.EventHandler(this.Szukaj_Button_Click);
            // 
            // MySQL_Grid
            // 
            this.MySQL_Grid.AllowUserToAddRows = false;
            this.MySQL_Grid.AllowUserToDeleteRows = false;
            this.MySQL_Grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MySQL_Grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MySQL_Grid.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.MySQL_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MySQL_Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.miniatura});
            this.MySQL_Grid.Location = new System.Drawing.Point(12, 41);
            this.MySQL_Grid.Name = "MySQL_Grid";
            this.MySQL_Grid.RowTemplate.Height = 50;
            this.MySQL_Grid.RowTemplate.ReadOnly = true;
            this.MySQL_Grid.Size = new System.Drawing.Size(582, 318);
            this.MySQL_Grid.TabIndex = 3;
            this.MySQL_Grid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Cell_Mouse_DoubleClick);
            this.MySQL_Grid.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Cell_Mouse_Click);
            this.MySQL_Grid.Sorted += new System.EventHandler(this.afterSort);
            // 
            // miniatura
            // 
            this.miniatura.HeaderText = "";
            this.miniatura.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.miniatura.Name = "miniatura";
            // 
            // Refresh_Button
            // 
            this.Refresh_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Refresh_Button.Location = new System.Drawing.Point(519, 12);
            this.Refresh_Button.Name = "Refresh_Button";
            this.Refresh_Button.Size = new System.Drawing.Size(75, 23);
            this.Refresh_Button.TabIndex = 4;
            this.Refresh_Button.Text = "Odśwież";
            this.Refresh_Button.UseVisualStyleBackColor = true;
            this.Refresh_Button.Click += new System.EventHandler(this.Refresh_Button_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Check_Updates);
            // 
            // Main_Window
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(608, 371);
            this.Controls.Add(this.Refresh_Button);
            this.Controls.Add(this.MySQL_Grid);
            this.Controls.Add(this.Szukaj_Button);
            this.Controls.Add(this.Edycja_Button);
            this.Controls.Add(this.Dodaj_Button);
            this.MinimumSize = new System.Drawing.Size(360, 235);
            this.Name = "Main_Window";
            this.Text = "Aplikacja";
            this.Load += new System.EventHandler(this.Main_Window_Load);
            this.ResizeEnd += new System.EventHandler(this.Main_Window_ResizeEnd);
            ((System.ComponentModel.ISupportInitialize)(this.MySQL_Grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Dodaj_Button;
        private System.Windows.Forms.Button Edycja_Button;
        private System.Windows.Forms.Button Szukaj_Button;
        private System.Windows.Forms.DataGridView MySQL_Grid;
        private System.Windows.Forms.Button Refresh_Button;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewImageColumn miniatura;
    }
}

