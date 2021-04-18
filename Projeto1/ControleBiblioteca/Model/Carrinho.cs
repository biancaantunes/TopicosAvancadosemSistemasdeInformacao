using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Carrinho
    {
        #region Propriedades

        public int Id { get; set; }
        public string Id_cliente { get; set; }
        public string Nome { get; set; }
        public string Id_livro { get; set; }
        public string Titulo { get; set; }

        public const string INSERT = "INSERT INTO TB_CARRINHO (Id_cliente, Nome, Id_livro, Titulo) VALUES ('{0}', '{1}', '{2}', '{3}')";
        public const string GETALL = "SELECT id, Id_cliente, Nome, Id_livro, Titulo FROM TB_CARRINHO";


        #endregion
    }
}
