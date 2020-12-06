using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace library.Models.repositories
{
    public interface BookStorRepository<Entity>
    {
        IList<Entity> list();
        Entity fined(int id);
        void Add(Entity entity);
        void Update(int id,Entity entity);
        void Delete(int id);

    }
}
