using DataAccessLayer.Concrete;
using EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AuthorManager
    {
        Repository<Author> repoauthor = new Repository<Author>();


        //Yazar Listesini Getirme
        public List<Author> GetAll()
        {
            return repoauthor.List();

        }
        //Yazar Ekleme
        public int AddAuthorBl(Author p)
        {
            //Yazar Ekleme Kontrolü
            if (p.AuthorName == "" || p.AuthorAbout == "" || p.AuthorTitle == "" || p.AuthorMail == "" || p.AuthorPassword == "" || p.PhoneNumber == "")
            {
                return -1;
            }
            
                return repoauthor.Insert(p);
            
        }


        //Yazarı Düzenleme sayfasına taşıma
        public Author FindAuthor(int id)
        {
            return repoauthor.Find(x => x.AuthorId == id);
        }

        public int EditAuthor(Author p)
        {
           Author author = repoauthor.Find(x => x.AuthorId == p.AuthorId);
            author.AuthorName = p.AuthorName;
            author.AuthorAbout = p.AuthorAbout;
            author.AuthorTitle = p.AuthorTitle;
            author.AuthorMail = p.AuthorMail;
            author.AuthorPassword = p.AuthorPassword;
            author.PhoneNumber = p.PhoneNumber;
            author.AuthorImage = p.AuthorImage;
            author.AboutShort = p.AboutShort;
            return repoauthor.Update(author);
        }
    }
}
