using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class CarrinhoDB : ICarrinhoDB
    {
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Carrinho> GetAll()
        {
            string sql = Carrinho.GETALL;
            List<Carrinho> lst;

            using (var connection = new DB())
            {
                lst = TransformSQLReaderToList(connection.ExecQueryReturn(sql));
            }
            return lst;
        }

        private List<Carrinho> TransformSQLReaderToList(SqlDataReader returnData)
        {
            var lst = new List<Carrinho>();

            while (returnData.Read())
            {
                var item = new Carrinho()
                {
                    Id = int.Parse(returnData["id"].ToString()),
                    Id_cliente = returnData["Id_cliente"].ToString(),
                    Nome = returnData["Nome"].ToString(),
                    Id_livro = returnData["Id_livro"].ToString(),
                    Titulo = returnData["Titulo"].ToString()
                };
                lst.Add(item);
            }
            return lst;
        }

        public bool Insert(Carrinho carrinho)
        {
            bool status = false;
            string sql = string.Format(Carrinho.INSERT, carrinho.Id_cliente, carrinho.Nome, carrinho.Id_livro, carrinho.Titulo);

            using (var connection = new DB())
            {
                status = connection.ExecQuery(sql);
            }
            return status;
        }

        public Carrinho SelectById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Carrinho carrinho, int id)
        {
            throw new NotImplementedException();
        }
    }
}
