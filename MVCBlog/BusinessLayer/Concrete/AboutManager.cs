using DataAccessLayer.Concrete;
using EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AboutManager
    { 
        Repository<About> repoabout = new Repository<About>();

        public List<About> GetAll()
        {
            return repoabout.List();

        }
        public int UpdateAboutBm(About p)
        {
          About about = repoabout.Find(x => x.AboutId == p.AboutId);
            about.AboutConcat1 = p.AboutConcat1;
            about.AboutConcat2 = p.AboutConcat2;
            about.AboutImage1 = p.AboutImage1;
            about.AboutImage2 = p.AboutImage2;
            about.AboutId = p.AboutId;

            return repoabout.Update(about);
        }
    }
}
