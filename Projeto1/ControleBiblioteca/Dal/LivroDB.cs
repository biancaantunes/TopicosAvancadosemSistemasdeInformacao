using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class LivroDB : ILivroDB
    {
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Livro> GetAll()
        {
            string sql = Livro.GETALL;
            List<Livro> lst;

            using (var connection = new DB())
            {
                lst = TransformSQLReaderToList(connection.ExecQueryReturn(sql));
            }
            return lst;
        }

        private List<Livro> TransformSQLReaderToList(SqlDataReader returnData)
        {
            var lst = new List<Livro>();

            while (returnData.Read())
            {
                var item = new Livro()
                {
                    Id = int.Parse(returnData["id"].ToString()),
                    Titulo = returnData["Titulo"].ToString(),
                    Autor = returnData["Autor"].ToString(),
                    Editora = returnData["Editora"].ToString(),
                    DatadeLancamento = returnData["DatadeLancamento"].ToString(),
                    Preco = returnData["Preco"].ToString()
                };
                lst.Add(item);
            }
            return lst;
        }

        public bool Insert(Livro livro)
        {
            bool status = false;
            string sql = string.Format(Livro.INSERT, livro.Titulo, livro.Autor, livro.Editora, livro.DatadeLancamento, livro.Preco);

            using (var connection = new DB())
            {
                status = connection.ExecQuery(sql);
            }
            return status;
        }

        public Livro SelectById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Livro livro, int id)
        {
            throw new NotImplementedException();
        }
    }
}
