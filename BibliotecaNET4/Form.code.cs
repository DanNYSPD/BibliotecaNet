using BibliotecaNET4.vista;
using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using BibliotecaNET4.Services;
using BibliotecaNET4.Utils;
namespace BibliotecaNET4 {
    public partial class Form1 {
       
        /// <summary>
        /// usamos esta interfaz para mostrar notificaciones a la pantalla sin tener que depender de un elementos especifico
        /// </summary>
        IDisplayService idisplayService;
        public static String[] arr = { "ACERVO GENERAL", "NOVELAS", "INFANTIL", "CONSULTA", "HISTORIA ORIZABA", "LIBROS D BIBLIOTECARIO", "BRAILLE", "TESIS", "BRAILE-INFANTIL" };
        
        public void mostrarDatosDesdeExcel() {

            string filepath = txb_filepath.Text;
            string worksheetName = cmb_category.Text;
            if (!ExistFile(filepath)) {
                idisplayService.Show("Error!! Archivo no encontrado, selecciona uno nuevo por favor");
                return;
            }

            if (worksheetName == string.Empty) {
                idisplayService.Show("Error hoja no seleccionada, el excel debe coincidir con: " + worksheetName);
                return;
            }
            if (cmb_opciones.SelectedItem.ToString().Trim() == string.Empty || mtxt_entrada.Text.Trim() == string.Empty) {
                idisplayService.Show("Escribe por favor un autor o titulo");
                return;
            }

            string stringconn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + filepath + ";Mode=Read;Extended Properties=\"Excel 8.0;HDR=Yes;\";";
            
            OleDbConnection connection = new OleDbConnection(stringconn);

            string queryCommand = new QueryBuilder().ChooseQuery(worksheetName, (mtxt_entrada.Text.ToString()).ToUpper(), cmb_opciones.SelectedItem.ToString());
            if (queryCommand != null) {
                pictureB_loadingSearching.Visible = true;
                OleDbDataAdapter da = new OleDbDataAdapter(queryCommand, connection);
                DataTable dt = new DataTable(); //representa una tabla de datos en memoria
                try {
                    da.Fill(dt);//fill agrega las filas al datable pasado para que ambos coincidan
                    if (dt.Rows.Count > 0) {                        
                        Console.Out.WriteLine(dt.Columns[0]);
                    } else {
                        idisplayService.Show("no se encontro ninguna coincidencia");
                    }
                    dataGridView1.DataSource = dt; //establecemos los adatos
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    //  Console.Out.WriteLine(dataGridView1.AutoSizeColumnsMode.ToString());
                } catch (OleDbException e) {
#if DEBUG
                    Console.Out.WriteLine("-----");
                    Console.Out.WriteLine(e.Message);
                    Console.Out.WriteLine(queryCommand);
#endif

                }
            }
            pictureB_loadingSearching.Hide();
        }//method end

        public void closeAplication() {
            if (MetroFramework.MetroMessageBox.Show(this, "¿Esta seguro de cerrar la aplicacion ?",
                "Ventana de Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                safeCloseAplication();
        }
        private Boolean SelectExcelFile() {
            string path =string.Empty;
            OpenFileDialog opnFileDialog = new OpenFileDialog();
            if (opnFileDialog.ShowDialog() == DialogResult.OK) {
                path = opnFileDialog.FileName;
                //guarda el path
                if (ExistFile(path)) {
                    SaveExcelPath(path);
                    txb_filepath.Text = path;
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// Salva la ruta del archivo excel en la propiedades de la aplicacion
        /// </summary>
        /// <param name="path"></param>
        private void SaveExcelPath(String path) {
            Properties.Settings.Default.FILEPATH = path;
            Properties.Settings.Default.Save();
            Console.Out.WriteLine("ipendialog" + Properties.Settings.Default.FILEPATH + " path" + path);
        }
        /// <summary>
        /// Verify if exists the file 
        /// </summary>
        /// <returns></returns>
        private Boolean isRetrievedFile() {
            if (Properties.Settings.Default.FILEPATH != string.Empty) {
                if (ExistFile(Properties.Settings.Default.FILEPATH)) {//comprbamos que exista el archivo 
                    txb_filepath.Text = Properties.Settings.Default.FILEPATH;
                    Console.Out.WriteLine("enbtri" + Properties.Settings.Default.FILEPATH);
                    return true;
                } else {
                    Console.Out.WriteLine("no existe" + Properties.Settings.Default.FILEPATH);
                    return false;
                }
            }
            return false;
        }
        public Boolean ExistFile(string path) {
           return System.IO.File.Exists(path);
        }
        public void CreateOrshowHelp() {
            if (ayuda == null) {
                ayuda = new Ayuda();
                ayuda.Show();
                //puede no ser nulo y aun asi ya haber sido cerrado, entonces verificasomos con dispose
            } else if (ayuda.IsDisposed == false && ayuda.Visible == false) {
                ayuda.Visible = true;
            } else if (ayuda.IsDisposed) {//sino esta disponible
                ayuda = null;
                ayuda = new Ayuda();
                ayuda.Show();
            }
        }
    }
}
