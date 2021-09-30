using DataAccessLayer.Abstract;
using DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class EfAboutRepository : GenericRepository<About>, IAboutDal
    {
    }
    
}
