using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Concrete;
using EntitiyLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class CategoryManager
    {
        Repository<Category> repocategory=new Repository<Category>();
        public List<Category> GetAll()
        {
            return repocategory.List();
        }
    }
}
