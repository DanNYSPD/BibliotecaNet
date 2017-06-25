namespace BibliotecaNET4
{
    //este arhivo de la clase Form1 se usa para generar la vista, el otro para los eventos
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cmb_opciones = new System.Windows.Forms.ComboBox();
            this.txb_filepath = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_openExcel = new System.Windows.Forms.Button();
            this.lbl_TituloAutor = new System.Windows.Forms.Label();
            this.lbl_selecionBusqueda = new System.Windows.Forms.Label();
            this.groupb_selectExcel = new System.Windows.Forms.GroupBox();
            this.lbl_search = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsddBtn_Menu = new System.Windows.Forms.ToolStripDropDownButton();
            this.escogerArchivoExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmitem_Acercade = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmitem_ayuda = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupB_search = new System.Windows.Forms.GroupBox();
            this.pictureB_loadingSearching = new System.Windows.Forms.PictureBox();
            this.mbtn_buscar = new MetroFramework.Controls.MetroButton();
            this.mtxt_entrada = new MetroFramework.Controls.MetroTextBox();
            this.cmb_category = new System.Windows.Forms.ComboBox();
            this.lbl_selectcategory = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupB_category = new System.Windows.Forms.GroupBox();
            this.mclb_category = new System.Windows.Forms.CheckedListBox();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.mbtn_salir = new MetroFramework.Controls.MetroButton();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.mlbl_Tip = new MetroFramework.Controls.MetroLabel();
            this.lbl_tip = new System.Windows.Forms.Label();
            this.mchb_category = new MetroFramework.Controls.MetroCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupb_selectExcel.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupB_search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureB_loadingSearching)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupB_category.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_opciones
            // 
            this.cmb_opciones.FormattingEnabled = true;
            this.cmb_opciones.Location = new System.Drawing.Point(225, 32);
            this.cmb_opciones.Name = "cmb_opciones";
            this.cmb_opciones.Size = new System.Drawing.Size(224, 24);
            this.cmb_opciones.TabIndex = 3;
            this.cmb_opciones.SelectedIndexChanged += new System.EventHandler(this.cmb_opciones_SelectedIndexChanged);
            // 
            // txb_filepath
            // 
            this.txb_filepath.Location = new System.Drawing.Point(20, 113);
            this.txb_filepath.Name = "txb_filepath";
            this.txb_filepath.Size = new System.Drawing.Size(701, 22);
            this.txb_filepath.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 477);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1018, 241);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_openExcel
            // 
            this.btn_openExcel.Location = new System.Drawing.Point(24, 35);
            this.btn_openExcel.Name = "btn_openExcel";
            this.btn_openExcel.Size = new System.Drawing.Size(75, 23);
            this.btn_openExcel.TabIndex = 6;
            this.btn_openExcel.Text = "Abrir Excel";
            this.btn_openExcel.UseVisualStyleBackColor = true;
            this.btn_openExcel.Click += new System.EventHandler(this.btn_openExcel_Click);
            // 
            // lbl_TituloAutor
            // 
            this.lbl_TituloAutor.AutoSize = true;
            this.lbl_TituloAutor.Location = new System.Drawing.Point(6, 72);
            this.lbl_TituloAutor.Name = "lbl_TituloAutor";
            this.lbl_TituloAutor.Size = new System.Drawing.Size(139, 17);
            this.lbl_TituloAutor.TabIndex = 9;
            this.lbl_TituloAutor.Text = "Escribe Autor o titulo";
            this.lbl_TituloAutor.Click += new System.EventHandler(this.lbl_TituloAutor_Click);
            // 
            // lbl_selecionBusqueda
            // 
            this.lbl_selecionBusqueda.AutoSize = true;
            this.lbl_selecionBusqueda.Location = new System.Drawing.Point(6, 35);
            this.lbl_selecionBusqueda.Name = "lbl_selecionBusqueda";
            this.lbl_selecionBusqueda.Size = new System.Drawing.Size(184, 17);
            this.lbl_selecionBusqueda.TabIndex = 10;
            this.lbl_selecionBusqueda.Text = "Escoge el tipo de busqueda";
            // 
            // groupb_selectExcel
            // 
            this.groupb_selectExcel.Controls.Add(this.btn_openExcel);
            this.groupb_selectExcel.Location = new System.Drawing.Point(21, 30);
            this.groupb_selectExcel.Name = "groupb_selectExcel";
            this.groupb_selectExcel.Size = new System.Drawing.Size(331, 77);
            this.groupb_selectExcel.TabIndex = 11;
            this.groupb_selectExcel.TabStop = false;
            this.groupb_selectExcel.Text = "Selecciona el archivo Excel";
            this.groupb_selectExcel.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lbl_search
            // 
            this.lbl_search.AutoSize = true;
            this.lbl_search.Location = new System.Drawing.Point(6, 127);
            this.lbl_search.Name = "lbl_search";
            this.lbl_search.Size = new System.Drawing.Size(287, 17);
            this.lbl_search.TabIndex = 12;
            this.lbl_search.Text = "[Presiona Enter, da clic la lupa, o en buscar]";
            this.lbl_search.Click += new System.EventHandler(this.lbl_search_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsddBtn_Menu});
            this.toolStrip1.Location = new System.Drawing.Point(20, 60);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1025, 27);
            this.toolStrip1.TabIndex = 13;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // tsddBtn_Menu
            // 
            this.tsddBtn_Menu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsddBtn_Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.escogerArchivoExcelToolStripMenuItem,
            this.tsmitem_Acercade,
            this.tsmitem_ayuda,
            this.salirToolStripMenuItem});
            this.tsddBtn_Menu.Image = ((System.Drawing.Image)(resources.GetObject("tsddBtn_Menu.Image")));
            this.tsddBtn_Menu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsddBtn_Menu.Name = "tsddBtn_Menu";
            this.tsddBtn_Menu.Size = new System.Drawing.Size(73, 24);
            this.tsddBtn_Menu.Text = "Archivo";
            // 
            // escogerArchivoExcelToolStripMenuItem
            // 
            this.escogerArchivoExcelToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("escogerArchivoExcelToolStripMenuItem.Image")));
            this.escogerArchivoExcelToolStripMenuItem.Name = "escogerArchivoExcelToolStripMenuItem";
            this.escogerArchivoExcelToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.escogerArchivoExcelToolStripMenuItem.Text = "Escoger Archivo Excel";
            this.escogerArchivoExcelToolStripMenuItem.Click += new System.EventHandler(this.escogerArchivoExcelToolStripMenuItem_Click);
            // 
            // tsmitem_Acercade
            // 
            this.tsmitem_Acercade.Image = ((System.Drawing.Image)(resources.GetObject("tsmitem_Acercade.Image")));
            this.tsmitem_Acercade.Name = "tsmitem_Acercade";
            this.tsmitem_Acercade.Size = new System.Drawing.Size(228, 26);
            this.tsmitem_Acercade.Text = "Acerca de...";
            this.tsmitem_Acercade.Click += new System.EventHandler(this.tsmitem_Acercade_Click);
            // 
            // tsmitem_ayuda
            // 
            this.tsmitem_ayuda.Image = ((System.Drawing.Image)(resources.GetObject("tsmitem_ayuda.Image")));
            this.tsmitem_ayuda.Name = "tsmitem_ayuda";
            this.tsmitem_ayuda.Size = new System.Drawing.Size(228, 26);
            this.tsmitem_ayuda.Text = "Ayuda";
            this.tsmitem_ayuda.Click += new System.EventHandler(this.tsmitem_ayuda_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("salirToolStripMenuItem.Image")));
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // groupB_search
            // 
            this.groupB_search.Controls.Add(this.pictureB_loadingSearching);
            this.groupB_search.Controls.Add(this.mbtn_buscar);
            this.groupB_search.Controls.Add(this.mtxt_entrada);
            this.groupB_search.Controls.Add(this.lbl_selecionBusqueda);
            this.groupB_search.Controls.Add(this.cmb_opciones);
            this.groupB_search.Controls.Add(this.lbl_TituloAutor);
            this.groupB_search.Controls.Add(this.lbl_search);
            this.groupB_search.Location = new System.Drawing.Point(21, 151);
            this.groupB_search.Name = "groupB_search";
            this.helpProvider1.SetShowHelp(this.groupB_search, true);
            this.groupB_search.Size = new System.Drawing.Size(561, 170);
            this.groupB_search.TabIndex = 15;
            this.groupB_search.TabStop = false;
            this.groupB_search.Text = "Busqueda";
            // 
            // pictureB_loadingSearching
            // 
            this.pictureB_loadingSearching.Image = ((System.Drawing.Image)(resources.GetObject("pictureB_loadingSearching.Image")));
            this.pictureB_loadingSearching.Location = new System.Drawing.Point(455, 92);
            this.pictureB_loadingSearching.Name = "pictureB_loadingSearching";
            this.pictureB_loadingSearching.Size = new System.Drawing.Size(100, 72);
            this.pictureB_loadingSearching.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureB_loadingSearching.TabIndex = 22;
            this.pictureB_loadingSearching.TabStop = false;
            // 
            // mbtn_buscar
            // 
            this.mbtn_buscar.Location = new System.Drawing.Point(331, 115);
            this.mbtn_buscar.Name = "mbtn_buscar";
            this.mbtn_buscar.Size = new System.Drawing.Size(118, 38);
            this.mbtn_buscar.TabIndex = 22;
            this.mbtn_buscar.Text = "buscar";
            this.mbtn_buscar.UseSelectable = true;
            this.mbtn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // mtxt_entrada
            // 
            this.mtxt_entrada.BackColor = System.Drawing.Color.White;
            this.mtxt_entrada.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.mtxt_entrada.CustomButton.BackColor = System.Drawing.Color.DimGray;
            this.mtxt_entrada.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.mtxt_entrada.CustomButton.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.mtxt_entrada.CustomButton.Location = new System.Drawing.Point(196, 2);
            this.mtxt_entrada.CustomButton.Name = "";
            this.mtxt_entrada.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.mtxt_entrada.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxt_entrada.CustomButton.TabIndex = 1;
            this.mtxt_entrada.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxt_entrada.CustomButton.UseSelectable = true;
            this.mtxt_entrada.CustomButton.UseVisualStyleBackColor = false;
            this.mtxt_entrada.DisplayIcon = true;
            this.mtxt_entrada.Icon = ((System.Drawing.Image)(resources.GetObject("mtxt_entrada.Icon")));
            this.mtxt_entrada.Lines = new string[0];
            this.mtxt_entrada.Location = new System.Drawing.Point(225, 64);
            this.mtxt_entrada.MaxLength = 32767;
            this.mtxt_entrada.Name = "mtxt_entrada";
            this.mtxt_entrada.PasswordChar = '\0';
            this.mtxt_entrada.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxt_entrada.SelectedText = "";
            this.mtxt_entrada.SelectionLength = 0;
            this.mtxt_entrada.SelectionStart = 0;
            this.mtxt_entrada.ShowButton = true;
            this.mtxt_entrada.ShowClearButton = true;
            this.mtxt_entrada.Size = new System.Drawing.Size(224, 30);
            this.mtxt_entrada.TabIndex = 13;
            this.mtxt_entrada.UseSelectable = true;
            this.mtxt_entrada.WaterMark = "Buscar";
            this.mtxt_entrada.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxt_entrada.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.mtxt_entrada.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_entrada_KeyDown);
            // 
            // cmb_category
            // 
            this.cmb_category.FormattingEnabled = true;
            this.cmb_category.Location = new System.Drawing.Point(733, 151);
            this.cmb_category.Name = "cmb_category";
            this.cmb_category.Size = new System.Drawing.Size(267, 24);
            this.cmb_category.TabIndex = 16;
            // 
            // lbl_selectcategory
            // 
            this.lbl_selectcategory.AutoSize = true;
            this.lbl_selectcategory.Location = new System.Drawing.Point(15, 26);
            this.lbl_selectcategory.Name = "lbl_selectcategory";
            this.lbl_selectcategory.Size = new System.Drawing.Size(154, 17);
            this.lbl_selectcategory.TabIndex = 17;
            this.lbl_selectcategory.Text = "Escoge una categoria :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(602, 197);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 60);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // groupB_category
            // 
            this.groupB_category.Controls.Add(this.mclb_category);
            this.groupB_category.Controls.Add(this.lbl_selectcategory);
            this.groupB_category.Location = new System.Drawing.Point(714, 197);
            this.groupB_category.Name = "groupB_category";
            this.groupB_category.Size = new System.Drawing.Size(335, 274);
            this.groupB_category.TabIndex = 19;
            this.groupB_category.TabStop = false;
            this.groupB_category.Text = "Categoria";
            // 
            // mclb_category
            // 
            this.mclb_category.FormattingEnabled = true;
            this.mclb_category.Location = new System.Drawing.Point(18, 46);
            this.mclb_category.Name = "mclb_category";
            this.mclb_category.Size = new System.Drawing.Size(309, 208);
            this.mclb_category.TabIndex = 22;
            // 
            // mbtn_salir
            // 
            this.mbtn_salir.Location = new System.Drawing.Point(923, 724);
            this.mbtn_salir.Name = "mbtn_salir";
            this.mbtn_salir.Size = new System.Drawing.Size(118, 38);
            this.mbtn_salir.TabIndex = 20;
            this.mbtn_salir.Text = "Salir";
            this.mbtn_salir.UseSelectable = true;
            this.mbtn_salir.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            // 
            // mlbl_Tip
            // 
            this.mlbl_Tip.AutoSize = true;
            this.mlbl_Tip.Location = new System.Drawing.Point(45, 742);
            this.mlbl_Tip.Name = "mlbl_Tip";
            this.mlbl_Tip.Size = new System.Drawing.Size(60, 20);
            this.mlbl_Tip.TabIndex = 21;
            this.mlbl_Tip.Text = "mlbl_Tip";
            // 
            // lbl_tip
            // 
            this.lbl_tip.AutoSize = true;
            this.lbl_tip.Location = new System.Drawing.Point(543, 137);
            this.lbl_tip.Name = "lbl_tip";
            this.lbl_tip.Size = new System.Drawing.Size(123, 17);
            this.lbl_tip.TabIndex = 14;
            this.lbl_tip.Text = "No es necesario ..";
            // 
            // mchb_category
            // 
            this.mchb_category.AutoSize = true;
            this.mchb_category.Location = new System.Drawing.Point(36, 55);
            this.mchb_category.Name = "mchb_category";
            this.mchb_category.Size = new System.Drawing.Size(121, 17);
            this.mchb_category.TabIndex = 22;
            this.mchb_category.Text = "metroCheckBox1";
            this.mchb_category.UseSelectable = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 833);
            this.Controls.Add(this.mlbl_Tip);
            this.Controls.Add(this.cmb_category);
            this.Controls.Add(this.mbtn_salir);
            this.Controls.Add(this.groupB_category);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupB_search);
            this.Controls.Add(this.txb_filepath);
            this.Controls.Add(this.lbl_tip);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupb_selectExcel);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Biblioteca de Orizaba";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupb_selectExcel.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupB_search.ResumeLayout(false);
            this.groupB_search.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureB_loadingSearching)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupB_category.ResumeLayout(false);
            this.groupB_category.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmb_opciones;
        private System.Windows.Forms.TextBox txb_filepath;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_openExcel;
        private System.Windows.Forms.Label lbl_TituloAutor;
        private System.Windows.Forms.Label lbl_selecionBusqueda;
        private System.Windows.Forms.GroupBox groupb_selectExcel;
        private System.Windows.Forms.Label lbl_search;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton tsddBtn_Menu;
        private System.Windows.Forms.ToolStripMenuItem escogerArchivoExcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmitem_Acercade;
        private System.Windows.Forms.GroupBox groupB_search;
        private System.Windows.Forms.ComboBox cmb_category;
        private System.Windows.Forms.Label lbl_selectcategory;
        private System.Windows.Forms.ToolStripMenuItem tsmitem_ayuda;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupB_category;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private MetroFramework.Controls.MetroButton mbtn_salir;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroLabel mlbl_Tip;
        private System.Windows.Forms.Label lbl_tip;
        private MetroFramework.Controls.MetroTextBox mtxt_entrada;
        private MetroFramework.Controls.MetroButton mbtn_buscar;
        private System.Windows.Forms.PictureBox pictureB_loadingSearching;
        private MetroFramework.Controls.MetroCheckBox mchb_category;
        private System.Windows.Forms.CheckedListBox mclb_category;
    }
}

