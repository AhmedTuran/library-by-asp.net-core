using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace library.Models.repositories
{
    public class AuthorRepository : BookStorRepository<author>
    {
        List<author> authors;
        public AuthorRepository()
        {
            authors = new List<author> { 
            new author{id=1,fullNames="osama kamal"},
            new author{id=1,fullNames="issa munir"},
            new author{id=1,fullNames="mohammed akif"}
            
            
            };
        }
        
        
        public void Add(author entity)
        {
            authors.Add(entity);
        }

        public void Delete(int id)
        {
            var author = fined(id);
            authors.Remove(author);
                }

        internal static object list()
        {
            throw new NotImplementedException();
        }

        public author fined(int id)
        {
            var author = authors.SingleOrDefault(b => b.id == id);
            return author;
        }

        IList<author> BookStorRepository<author>.list()
        {
            return authors;
        }

        public void Update(int id, author newAuthor)
        {
            var author = fined(id);
            author.id=newAuthor.id;
            author.fullNames=newAuthor.fullNames;
            
            
        }
    }
}
