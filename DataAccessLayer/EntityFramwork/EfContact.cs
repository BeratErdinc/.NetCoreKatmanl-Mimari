using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Abstract;
using DataAccessLayer.Respository;
using EntityLayer.Concrete;

namespace DataAccessLayer.EntityFramwork
{
    public class EfContact:GenericRepository<Conteact>,IConteact
    {
    }
}
