using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Abstract;
using DataAccessLayer.Repositories;

namespace DataAccessLayer.EntityFramework
{
    public class EfContactRepository : GenericRepository<Contact>, IContactDal
    {
    }
}
