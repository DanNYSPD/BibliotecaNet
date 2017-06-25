using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BibliotecaNET4.vista {
    public partial class Ayuda : MetroFramework.Forms.MetroForm {
        
        //con esta variable verificamos que el mouse esta sobre este form
        public bool IsMouseOver = false;
        public Ayuda() {
            
            InitializeComponent();
            String bc = "\"",br="\r";
            mlbl_explicacion.Text =
                   "Para buscar , debera estar seleccionado un archivo Excel(2000-2007)  " +
                br+ "con extension .xls y no " + bc+"xlsx"+bc+", ya que no soporta esa version. "+
                br+"Tambien las cabeceras en el excel deben ser de la forma:"+
                br+"CLAVE,TITULO,AUTOR,EDITORIAL "+
             br+br+"NOTA: el archivo excel debe estar cerrado para un optimo funcionamiento";
            mlbl_buscarTip.Text =
                    "La busqueda esta SECCIONADA en CATEGORIAS, elige la que mas adecuada.Esta" +
                br + "busqueda se puede hacer por titulo o autor y no es necesario escribirlos " +
                br + "completamente, con una parte del nombre es suficiente para mostrar todos los  " +
                br + "libros que contengan el patron (palabra) en su titulo/autor, esta es la forma " +
                br + "recomendada, mientras mas escribas los resultados seran mas especificos, sin embargo," +
                br + "si se trata de un titulo largo no es recomendable, ya que pudiera no hallar coincidencias" +
                br + "por ligeras variaciones en el registro de libros, por ejemplo una coma o espacio de mas, " +
                br + "o faltantes. " +
                br+ "Por ultimo NO ES NECESARIO NI RECOMENDABLE COLOCAR LOS ACENTOS";
        }

        private void panel1_Paint(object sender, PaintEventArgs e) {

        }

        private void Ayuda_MouseMove(object sender, MouseEventArgs e) {
            mouseOver();
        }
        public void mouseOver() {
            this.IsMouseOver = true;
        }
        public void mouseLeave() {
            this.IsMouseOver = false;
        }

        private void mouseOver(object sender, EventArgs e) {
            mouseOver();
        }

        private void Ayuda_MouseHover(object sender, EventArgs e) {
            mouseOver();
        }

        private void Ayuda_MouseLeave(object sender, EventArgs e) {
            mouseLeave();
        }

        private void mbtn_salir_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void Ayuda_Load(object sender, EventArgs e) {

        }
    }
}
