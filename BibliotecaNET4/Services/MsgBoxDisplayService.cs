using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaNET4.Services {
    public class MsgBoxDisplayService : IDisplayService {

        public void Show(string msj) {
            MessageBox.Show(msj);
            //View view
        }
        public void Show(string msj, string caption) {
            MessageBox.Show(msj, caption);
            //View view
        }
    }
}
