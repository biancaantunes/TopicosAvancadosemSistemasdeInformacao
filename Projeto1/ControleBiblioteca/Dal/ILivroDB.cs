using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public interface ILivroDB
    {
        bool Insert(Livro livro);
        bool Update(Livro livro, int id);
        bool Delete(int id);
        Livro SelectById(int id);
        List<Livro> GetAll();
    }
}
