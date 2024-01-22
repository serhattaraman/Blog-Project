﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Concrete;
using EntitiyLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class SubscribeMailManager
    {
        private Repository<SubscribeMail> reposubscribemail = new Repository<SubscribeMail>();
        public int BLAdd(SubscribeMail p)
        {
            if (p.Mail.Length<=10 || p.Mail.Length>=50)
            {
                return -1;
            }

            return reposubscribemail.Insert(p);
        }
    }
}
