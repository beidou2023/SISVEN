using SISVEN_DAO._Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISVEN_DAO._Interface
{
    public interface IBase<T> //variable generica
    {
        int Insert(T t);
        int Delete(T t);
        int Update(T t);
        DataTable Select();
    }
}
