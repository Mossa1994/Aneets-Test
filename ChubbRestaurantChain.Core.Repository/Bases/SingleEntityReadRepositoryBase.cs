using ChubbRestaurantChain.Core.Entities.Interfaces;
using ChubbRestaurantChain.Core.Repository.Intefaces;
using System.Collections.Generic;
using System.Linq;

namespace ChubbRestaurantChain.Core.Repository.Bases
{
    public abstract class SingleEntityReadRepositoryBase<T> : ISingleEntityReadRepository<T> where T : ISingleEntity
    {
        public SingleEntityReadRepositoryBase(IEnumerable<T> repository)
        {
            Repository = repository;
        }

        internal readonly IEnumerable<T> Repository = new List<T>();

        public IEnumerable<T> Get()
        {
            return Repository;
        }

        public T GetById(int Id)
        {
            return Repository.Single(x => x.Id == Id);
        }
    }
}
