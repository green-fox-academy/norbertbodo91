using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedditBackend.Services
{
    public interface ICrudRepository<T>
    {
        void Create(T item);
        List<T> Read();
        void Update();
        void Delete(int id);
        void UpVote(int id);
        void DownVote(int id);
    }
}
