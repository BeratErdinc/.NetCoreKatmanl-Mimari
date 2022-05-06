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
    public class MessageManager : IMessageServices
    {
        IMessage _message;


         public MessageManager(IMessage message)
        {
            _message = message;
        }
      
        public void TAdd(Message t)
        {
            _message.Insert(t);
        }   

        public void TDelete(Message t)
        {
          _message.Delete(t);
        }

        public Message TGetById(int id)
        {
            return _message.GetById(id);
        }

        public List<Message> TGetList()
        {
            return _message.GetList();
        }

        public List<Message> TGetListbyFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Message t)
        {
            _message.Update(t); 
        }
    }
}
