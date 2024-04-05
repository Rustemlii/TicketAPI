using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IBase<Send,T,Bring>where T : class
    {
        List<Bring> GetAll();
        Bring GetbyId(int id);
        Bring Insert(Send dto);
        void Update(Send dto);
        void Delete(int id);
    }
}
