using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaNET4.Services {
public interface IDisplayService {
        void Show(string msj);
        void Show(string text, string caption);
    }

    /// <summary>
    /// interface para mostrar en un elemento View
    /// </summary>

    public interface IViewDisplayService :IDisplayService{
        //void setView(View view); 
    }
}
