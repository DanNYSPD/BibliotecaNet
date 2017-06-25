using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliotecaNET4.Modelo {
    public partial class Persona {
        private void metodoA() {
        }
       private string Nombre { get; set; }
    }
    public partial class Persona {
        public void metodoB() {
            metodoA();
            Nombre="";
        }
    }
    public partial class Persona {
        private void metodoC() {
            metodoA();
            metodoB();
            
        }
    }
}
