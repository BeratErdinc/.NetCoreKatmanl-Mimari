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
    public class FeatureManager :IGenericService<Feature>
    {
        IFeature _feature;


        public FeatureManager(IFeature feature)
        {
            _feature = feature;
        }


        public List<Feature> TGetList()
        {
            return _feature.GetList();
        }

        public void TAdd(Feature t)
        {
            _feature.Insert(t);
        }

        public void TDelete(Feature t)
        {
            _feature.Delete(t);
        }

        public Feature TGetById(int id)
        {
            return _feature.GetById(id);
        }

        public void TUpdate(Feature t)
        {
            _feature.Update(t);
        }

        public List<Feature> TGetListbyFilter()
        {
            throw new NotImplementedException();
        }
    }
}
