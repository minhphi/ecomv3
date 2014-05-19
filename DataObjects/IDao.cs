using System.Collections.Generic;

namespace DataObjects
{
    public interface IDao<TDomain>
    {
        IList<TDomain> FindAll();
        TDomain FindById(int id);
        IList<TDomain> FindBy(int[] ids);
        //List<CmsPage> FindBy(Func<CmsPage, bool> func);

        TDomain Insert(TDomain obj);
        IList<TDomain> Insert(List<TDomain> objs);

        TDomain Update(TDomain obj);
        List<TDomain> Update(List<TDomain> objs);

        void Delete(int id);
        void Delete(TDomain obj);
        void Delete(List<TDomain> obj);
        void Delete(int[] ids);
    }
}
