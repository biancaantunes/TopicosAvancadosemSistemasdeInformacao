using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Cliente
    {
        #region Propriedades

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set; }
        public string Pais { get; set; }
        public string Cep { get; set; }
        public string NumerodoCartao { get; set; }
        public string DatadeValidade { get; set; }
        public string CodigodeSeguranca { get; set; }

        public const string INSERT = "INSERT INTO TB_CLIENTE (Nome, Telefone, Endereco, Cidade, Pais, Cep, NumerodoCartao, DatadeValidade, CodigodeSeguranca) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}')";
        public const string GETALL = "SELECT id, Nome, Telefone, Endereco, Cidade, Pais, Cep, NumerodoCartao, DatadeValidade, CodigodeSeguranca FROM TB_CLIENTE";

        #endregion

    }
}
