using DataAccessLayer.Concrete;
using EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ConcatMAnager
    {
        Repository<Concat> repoconcat = new Repository<Concat>();

        public int BlConcatAdd(Concat c)
        {
            if (c.Mail == "" || c.Message == "" || c.Subject == "" || c.Name == "" || c.SurName=="" || c.Mail.Length<=10 || c.Subject.Length<=3 )
            {
                return -1;
            }
            
            return repoconcat.Insert(c);
        }



    }
}
