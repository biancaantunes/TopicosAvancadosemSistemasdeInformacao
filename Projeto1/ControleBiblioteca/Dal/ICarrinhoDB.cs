using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public interface ICarrinhoDB
    {
        bool Insert(Carrinho carrinho);
        bool Update(Carrinho carrinho, int id);
        bool Delete(int id);
        Carrinho SelectById(int id);
        List<Carrinho> GetAll();
    }
}
