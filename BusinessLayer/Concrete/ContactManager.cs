using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ContactManager : IContactServices
    {
        IConteact _conteact;

        public ContactManager(IConteact conteact)
        {
            _conteact = conteact;
        }

      
        public void TAdd(Conteact t)
        {
            _conteact.Insert(t);
        }

        public void TDelete(Conteact t)
        {
            _conteact.Delete(t);
        }

        public Conteact TGetById(int id)
        {
            return _conteact.GetById(id);
        }

        public List<Conteact> TGetList()
        {
            return _conteact.GetList();
        }

        public List<Conteact> TGetListbyFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Conteact t)
        {_conteact.Update(t);
        }
    }
}
