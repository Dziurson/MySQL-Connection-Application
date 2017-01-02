namespace WindowsApp1
{
    partial class Picture_Show
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
            this.Picture_Box_Cell = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Box_Cell)).BeginInit();
            this.SuspendLayout();
            // 
            // Picture_Box_Cell
            // 
            this.Picture_Box_Cell.Location = new System.Drawing.Point(12, 12);
            this.Picture_Box_Cell.Name = "Picture_Box_Cell";
            this.Picture_Box_Cell.Size = new System.Drawing.Size(1280, 720);
            this.Picture_Box_Cell.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Picture_Box_Cell.TabIndex = 0;
            this.Picture_Box_Cell.TabStop = false;
            // 
            // Picture_Show
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 740);
            this.Controls.Add(this.Picture_Box_Cell);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Picture_Show";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Box_Cell)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.PictureBox Picture_Box_Cell;
    }
}