﻿using DataAccessLayer.Concrete;
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
        Repository<About> repoblog = new Repository<About>();

        public List<About> GetAll()
        {
            return repoblog.List();

        }
    }
}
