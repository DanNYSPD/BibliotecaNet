using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaNET4.Utils {
    using BibliotecaNET4.Modelo;
    public class QueryBuilder {
        /// <summary>
        /// Crea el query(queryCommand) para la busqueda de libros
        /// </summary>
        /// <param name="worksheetName"></param>
        /// <param name="entrada"></param>
        /// <param name="searchBy"></param>
        /// <returns></returns>
        public string ChooseQuery(string worksheetName, string entrada, string searchBy) {
            //string queryCommand = "Select * from [" + worksheetName + "$] WHERE  Titulo='El lubro de la vida'";

            string queryCommand = string.Empty;
            string select = " CLAVE,TITULO,AUTOR,EDITORIAL ";
            if (searchBy == Library.SearchCriteria.ByTitle) {
                string titulo = entrada;
                return queryCommand = "Select " + select + " from [" + worksheetName + "$] WHERE  Titulo LIKE '%" + titulo + "%'";
            } else if (searchBy == Library.SearchCriteria.ByAuthor) {
                string autor = entrada;
                //return queryCommand = "Select * from [" + worksheetName + "$] WHERE  Autor='" + autor + "'";
                return queryCommand = "Select " + select + "  from [" + worksheetName + "$] WHERE  Autor LIKE '%" + autor + "%'";
            }
            return null;
        }
    }
}
