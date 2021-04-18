using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class ClienteDB : IClienteDB
    {
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Cliente> GetAll()
        {
            string sql = Cliente.GETALL;
            List<Cliente> lst;

            using (var connection = new DB())
            {
                lst = TransformSQLReaderToList(connection.ExecQueryReturn(sql));
            }
            return lst;
        }

        private List<Cliente> TransformSQLReaderToList(SqlDataReader returnData)
        {
            var lst = new List<Cliente>();

            while (returnData.Read())
            {
                var item = new Cliente()
                {
                    Id = int.Parse(returnData["id"].ToString()),
                    Nome = returnData["Nome"].ToString(),
                    Telefone = returnData["Telefone"].ToString()
                    //Endereco = returnData["Endereco"].ToString(),
                    //Cidade = returnData["Cidade"].ToString(),
                    //Pais = returnData["Pais"].ToString(),
                    //Cep = returnData["Cep"].ToString(),
                    //NumerodoCartao = returnData["NumerodoCartao"].ToString(),
                    //DatadeValidade = returnData["DatadeValidade"].ToString(),
                    //CodigodeSeguranca = returnData["CodigodeSeguranca"].ToString()
                };
                lst.Add(item);
            }
            return lst;
        }

        public bool Insert(Cliente cliente)
        {
            bool status = false;
            string sql = string.Format(Cliente.INSERT, cliente.Nome, cliente.Telefone, cliente.Endereco, cliente.Cidade, cliente.Pais, cliente.Cep, cliente.NumerodoCartao, cliente.DatadeValidade, cliente.CodigodeSeguranca);

            using (var connection = new DB())
            {
                status = connection.ExecQuery(sql);
            }
            return status;
        }

        public Cliente SelectById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Cliente cliente, int id)
        {
            throw new NotImplementedException();
        }
    }
}
