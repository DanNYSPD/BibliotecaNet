using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lin.nyspd.core.Controls {
    public class TexBoxUtils {
        public static void RemoveAllWhiteSpaces(TextBox textBox) {
            textBox.Text.Trim();
        }
        


    }
    public class TextBoxV :TextBox {
        public delegate bool validateControl(Control control);
        public validateControl validator;
        public void Validate(validateControl valid) {
            this.validator = valid;
        }
        public bool IsValid() {
            return false;
        }
    }
}
