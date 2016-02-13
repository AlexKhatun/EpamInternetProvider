using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Binding;

namespace BLL.DbLogic
{
    public abstract class BaseDb
    {
        protected readonly Repository repository;

        protected BaseDb()
        {
            repository = new Repository();
        }
    }
}
