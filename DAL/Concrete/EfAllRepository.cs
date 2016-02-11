using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOL;

namespace DAL.Concrete
{
    public abstract class EfAllRepository
    {
        protected InternetProviderContext db = new InternetProviderContext();
    }
}
