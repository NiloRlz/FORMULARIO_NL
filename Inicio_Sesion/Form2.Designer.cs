namespace inicio_de_sesion_2
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cerrar2 = new System.Windows.Forms.Button();
            this.Nombre2 = new System.Windows.Forms.TextBox();
            this.Contraseña2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.registrar1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.cerrar2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(434, 44);
            this.panel1.TabIndex = 0;
            // 
            // cerrar2
            // 
            this.cerrar2.BackColor = System.Drawing.Color.Gray;
            this.cerrar2.ForeColor = System.Drawing.Color.White;
            this.cerrar2.Location = new System.Drawing.Point(394, 12);
            this.cerrar2.Name = "cerrar2";
            this.cerrar2.Size = new System.Drawing.Size(28, 23);
            this.cerrar2.TabIndex = 1;
            this.cerrar2.Text = "X";
            this.cerrar2.UseVisualStyleBackColor = false;
            // 
            // Nombre2
            // 
            this.Nombre2.Location = new System.Drawing.Point(106, 229);
            this.Nombre2.Multiline = true;
            this.Nombre2.Name = "Nombre2";
            this.Nombre2.Size = new System.Drawing.Size(194, 34);
            this.Nombre2.TabIndex = 1;
            // 
            // Contraseña2
            // 
            this.Contraseña2.Location = new System.Drawing.Point(106, 308);
            this.Contraseña2.Multiline = true;
            this.Contraseña2.Name = "Contraseña2";
            this.Contraseña2.Size = new System.Drawing.Size(194, 34);
            this.Contraseña2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(103, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(103, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Contraseña";
            // 
            // registrar1
            // 
            this.registrar1.BackColor = System.Drawing.Color.Gray;
            this.registrar1.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrar1.ForeColor = System.Drawing.Color.White;
            this.registrar1.Location = new System.Drawing.Point(144, 359);
            this.registrar1.Name = "registrar1";
            this.registrar1.Size = new System.Drawing.Size(111, 45);
            this.registrar1.TabIndex = 5;
            this.registrar1.Text = "Registrar";
            this.registrar1.UseVisualStyleBackColor = false;
            this.registrar1.Click += new System.EventHandler(this.registrar1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(144, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(434, 501);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.registrar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Contraseña2);
            this.Controls.Add(this.Nombre2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cerrar2;
        private System.Windows.Forms.TextBox Nombre2;
        private System.Windows.Forms.TextBox Contraseña2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button registrar1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}