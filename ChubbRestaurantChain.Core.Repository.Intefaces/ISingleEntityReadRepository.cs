using ChubbRestaurantChain.Core.Entities.Interfaces;
using System.Collections.Generic;

namespace ChubbRestaurantChain.Core.Repository.Intefaces
{
    public interface ISingleEntityReadRepository<T> where T : ISingleEntity
    {
        IEnumerable<T> Get();
        T GetById(int Id);
    }
}
