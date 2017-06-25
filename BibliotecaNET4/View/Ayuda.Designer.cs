namespace BibliotecaNET4.vista {
    partial class Ayuda {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ayuda));
            this.panel1 = new System.Windows.Forms.Panel();
            this.mlbl_bienvenida = new MetroFramework.Controls.MetroLabel();
            this.mlbl_explicacion = new MetroFramework.Controls.MetroLabel();
            this.mbtn_salir = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.mlbl_buscarTip = new MetroFramework.Controls.MetroLabel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.mlbl_bienvenida);
            this.panel1.Controls.Add(this.mlbl_explicacion);
            this.panel1.Location = new System.Drawing.Point(75, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(461, 235);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // mlbl_bienvenida
            // 
            this.mlbl_bienvenida.AutoSize = true;
            this.mlbl_bienvenida.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlbl_bienvenida.Location = new System.Drawing.Point(169, 12);
            this.mlbl_bienvenida.Name = "mlbl_bienvenida";
            this.mlbl_bienvenida.Size = new System.Drawing.Size(83, 20);
            this.mlbl_bienvenida.TabIndex = 5;
            this.mlbl_bienvenida.Text = "Bienvenido";
            // 
            // mlbl_explicacion
            // 
            this.mlbl_explicacion.AutoSize = true;
            this.mlbl_explicacion.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlbl_explicacion.Location = new System.Drawing.Point(0, 61);
            this.mlbl_explicacion.Name = "mlbl_explicacion";
            this.mlbl_explicacion.Size = new System.Drawing.Size(93, 20);
            this.mlbl_explicacion.TabIndex = 6;
            this.mlbl_explicacion.Text = "metroLabel1";
            // 
            // mbtn_salir
            // 
            this.mbtn_salir.Location = new System.Drawing.Point(650, 727);
            this.mbtn_salir.Name = "mbtn_salir";
            this.mbtn_salir.Size = new System.Drawing.Size(146, 39);
            this.mbtn_salir.TabIndex = 1;
            this.mbtn_salir.Text = "salir";
            this.mbtn_salir.UseSelectable = true;
            this.mbtn_salir.Click += new System.EventHandler(this.mbtn_salir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(718, 123);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 81);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(75, 283);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(407, 108);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // mlbl_buscarTip
            // 
            this.mlbl_buscarTip.AutoSize = true;
            this.mlbl_buscarTip.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlbl_buscarTip.Location = new System.Drawing.Point(75, 394);
            this.mlbl_buscarTip.Name = "mlbl_buscarTip";
            this.mlbl_buscarTip.Size = new System.Drawing.Size(109, 20);
            this.mlbl_buscarTip.TabIndex = 4;
            this.mlbl_buscarTip.Text = "mlbl_buscarTip";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(66, 599);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(578, 167);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // Ayuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 789);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.mlbl_buscarTip);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mbtn_salir);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ayuda";
            this.Text = "Ayuda";
            this.Load += new System.EventHandler(this.Ayuda_Load);
            this.MouseEnter += new System.EventHandler(this.mouseOver);
            this.MouseLeave += new System.EventHandler(this.Ayuda_MouseLeave);
            this.MouseHover += new System.EventHandler(this.Ayuda_MouseHover);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Ayuda_MouseMove);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroButton mbtn_salir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MetroFramework.Controls.MetroLabel mlbl_buscarTip;
        private MetroFramework.Controls.MetroLabel mlbl_explicacion;
        private MetroFramework.Controls.MetroLabel mlbl_bienvenida;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}