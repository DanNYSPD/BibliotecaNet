using BibliotecaNET4.vista;
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using BibliotecaNET4.Services;
using BibliotecaNET4.Modelo;
//este arhivo de la clase Form1 se usa para controlar los eventos,
// se recomienda este archivo de la clase para trabajar y dejar el otro solo para la generacion de vistas
namespace BibliotecaNET4 {

    //particial, el cual permite definir la defincion de la misma clase en MAS DE 1 archivos (form1.designes.cs y form1.cs) en el mismo espcaio
    //de nombres
    //con clase: otraClase ,heredamos de de la clase despues de los : , es decir
    // Form1 hereda de Form
    public partial class Form1 : MetroFramework.Forms.MetroForm {
        private const int CP_NOCLOSE_BUTTON = 0x200;
        private Ayuda ayuda = null;

        public Form1(IDisplayService idisplayService) {
            InitializeComponent(); //esta en el otro archivo de la clase
            //llamada a metodo propio
            this.set_elements();
            this.StyleManager = this.metroStyleManager1;
            pictureB_loadingSearching.Visible = false;
            this.idisplayService = idisplayService;
            //this.StyleManager = msmMain;
        }

        protected override CreateParams CreateParams {//desabilitamos el boton close
            get {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }

        public void hideHelp() {
            if (ayuda != null) {
                if (ayuda.IsMouseOver != true)
                    ayuda.Visible = false;
            }
        }

        public void pictureBox1_DragEnter(object sender, DragEventArgs e) {
        }

        public void set_elements() {
            cmb_opciones.Items.Add(Library.SearchCriteria.ByTitle); //0
            cmb_opciones.Items.Add(Library.SearchCriteria.ByAuthor);//1
            cmb_opciones.SelectedIndex = 0;

            cmb_category.Items.AddRange(arr);
            cmb_category.SelectedIndex = 0;
            //mchb_category.It
            mclb_category.Items.AddRange(arr);



            //para que no alteren:
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToAddRows = false;
            //verificamos que la la variable/ruta exista:
            groupb_selectExcel.Visible = !isRetrievedFile();

            txb_filepath.Enabled = false;
            string tip = "[No es necesario escribir perfectamente el titulo del libro," +
                 "\n la busqueda se hace por coincidencias, ejemplo: si escribes estrella," +
                "\n te apareceran todos los titulos que incluyan la palabra sin importar el orden] ";
            lbl_tip.Text = tip;
            lbl_tip.Hide();
            mlbl_Tip.Text = tip;
            toolStrip1.BackColor = Color.FromArgb(13, 183, 255);
            //
            //le asginanms un conrrolador de vento manualmente

            mtxt_entrada.CustomButton.Click += new EventHandler(this.btn_buscar_Click);

            //debe regtrarse manualmente
            cmb_category.SelectedIndexChanged += cmb_category_SelectedIndexChanged;
            mclb_category.SelectedIndexChanged += mclb_category_SelectedIndexChanged;
        }

        public void pictureBox1_DragLeave(object sender, EventArgs e) {
            Console.Out.WriteLine("salio");
            //      hideHelp();
        }
        private void btn_buscar_Click(object sender, EventArgs e) {
            // this.Focus();
            mostrarDatosDesdeExcel();



        }

        private void btn_openExcel_Click(object sender, EventArgs e) {
            groupb_selectExcel.Visible = !SelectExcelFile();
        }



        private void cmb_opciones_SelectedIndexChanged(object sender, EventArgs e) {
            string text = "";
            switch (cmb_opciones.SelectedIndex) {
                case 0:
                    text = "Escribe el titulo ";
                    break;

                case 1:
                    text = "Escribe el autor ";
                    break;
            }
            lbl_TituloAutor.Text = text;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {
        }

        /// <summary>
        /// abre el archivo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void escogerArchivoExcelToolStripMenuItem_Click(object sender, EventArgs e) {
            groupb_selectExcel.Visible = !SelectExcelFile();
        }

        private void Form1_Click(object sender, EventArgs e) {
        }

        private void Form1_Load(object sender, EventArgs e) {
        }

        private void GreetingBtn_Click(Object sender,
                           EventArgs e) {
            // When the button is clicked,
            Console.WriteLine("buton");
        }

        private void groupBox1_Enter(object sender, EventArgs e) { }

        private void lbl_search_Click(object sender, EventArgs e) { }

        //verificamos si el path fuardado cotniene algo y si existe el archivo para colocarlo
        private void lbl_TituloAutor_Click(object sender, EventArgs e) {
        }
        private void cmb_category_SelectedIndexChanged(object sender, EventArgs e) {
            ChamgeMclbCategory(cmb_category.SelectedIndex);
        }
        private void mclb_category_SelectedIndexChanged(object sender, EventArgs e) {
            //recorremos todos los items
            for (int i = 0; i <= mclb_category.Items.Count - 1; i++) {
                //a todos los item los desmarcamos (nos aseguramos de que soloe exista un checked)
                mclb_category.SetItemCheckState(i, CheckState.Unchecked); 
            }
#if DEBUG
            Console.Out.WriteLine("Selected Index" + mclb_category.SelectedIndex);
#endif

            //solo al ultmi que se acaba de seleccionar le damos el estado de checked que perdio (selectedIndex !=ItemCheckedState)
            ((CheckedListBox)sender).SetItemCheckState(mclb_category.SelectedIndex, CheckState.Checked);
            ChangeCmbCategory(mclb_category.SelectedIndex);
        }
        void ChangeCmbCategory(int index) {
            cmb_category.SelectedIndex = index;
        }
        void ChamgeMclbCategory(int index) {
            mclb_category.SelectedIndex = index;
        }
        private void metroButton1_Click(object sender, EventArgs e) {
            Console.WriteLine("entro");
            closeAplication();
        }

        private void pictureBox1_Click(object sender, EventArgs e) {
            CreateOrshowHelp();
        }

        private void pictureBox1_DragEnter(object sender, EventArgs e) {
            Console.Out.WriteLine("entro");
            CreateOrshowHelp();
        }

        private void safeCloseAplication() {
            if (System.Windows.Forms.Application.MessageLoop)// WinForms app
                System.Windows.Forms.Application.Exit();
            else// Console app
                System.Environment.Exit(1);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e) {
            safeCloseAplication();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e) {
        }

        private void tsmitem_Acercade_Click(object sender, EventArgs e) {
            //AboutBox_AcercaDe about = new AboutBox_AcercaDe();
            //about.Show();
            new Acercade().Show();
        }

        private void tsmitem_ayuda_Click(object sender, EventArgs e) {
            new Ayuda().Show();
        }

        private void txt_entrada_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                //Console.Out.WriteLine("me presiono"+e.KeyCode);
                mostrarDatosDesdeExcel();
            }
        }

        private void txt_entrada_TextChanged(object sender, EventArgs e) { }

        
    }

    //<div>Icons made by <a href="http://www.flaticon.com/authors/madebyoliver" title="Madebyoliver">Madebyoliver</a> from <a href="http://www.flaticon.com" title="Flaticon">www.flaticon.com</a> is licensed by <a href="http://creativecommons.org/licenses/by/3.0/" title="Creative Commons BY 3.0" target="_blank">CC 3.0 BY</a></div>
}