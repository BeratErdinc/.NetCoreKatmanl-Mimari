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
    public class PortfolioManager : IPortfolioServices
    {
        IPortfolio portfolio;

        public PortfolioManager(IPortfolio portfolio)
        {
            this.portfolio = portfolio;
        }

       
        public void TAdd(Portfolio t)
        {
            portfolio.Insert(t);
        }

        public void TDelete(Portfolio t)
        {
            portfolio.Delete(t);
        }

        public Portfolio TGetById(int id)
        {
           return portfolio.GetById(id);
        }

        public List<Portfolio> TGetList()
        {
            return portfolio.GetList();
        }

        public List<Portfolio> TGetListbyFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Portfolio t)
        {
            portfolio.Update(t);
        }
    }
}
