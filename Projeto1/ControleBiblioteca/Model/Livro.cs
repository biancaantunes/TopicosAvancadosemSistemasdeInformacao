using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Livro
    {
        #region Propriedades

        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Editora { get; set; }
        public string DatadeLancamento { get; set; }
        public string Preco { get; set; }

        public const string INSERT = "INSERT INTO TB_LIVRO (Titulo, Autor, Editora, DatadeLancamento, Preco) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')";
        public const string GETALL = "SELECT id, Titulo, Autor, Editora, DatadeLancamento, Preco FROM TB_LIVRO";

        #endregion
    }
}
