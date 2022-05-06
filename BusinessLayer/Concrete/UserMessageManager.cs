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
    public class UserMessageManager: IUserMessageServices
    {
        IUserMessage _userMessageDal;

        public UserMessageManager(IUserMessage mess)
        {
            _userMessageDal = mess;
        }

        public List<UserMessage> GetUserMessagesWithUserService()
        {
          return  _userMessageDal.GetUserMessagesWithUser();
        }

        public void TAdd(UserMessage t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(UserMessage t)
        {
            throw new NotImplementedException();
        }

        public UserMessage TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<UserMessage> TGetList()
        {
           return _userMessageDal.GetList();
        }

        public List<UserMessage> TGetListbyFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(UserMessage t)
        {
            throw new NotImplementedException();
        }
    }
}
