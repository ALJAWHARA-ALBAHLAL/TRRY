using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TRRY.Models.Repositories
{
    public interface IShopRepositpry<TEntinty>
    {
        IList<TEntinty> List();      // List from any object type   .. order .. customer
        TEntinty Find(int id);
        void Add(TEntinty entinty);
        void Delete(int id);
        void Update(TEntinty entinty, int id);

    }
}
