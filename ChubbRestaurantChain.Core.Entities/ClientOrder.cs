using ChubbRestaurantChain.Core.Entities.Interfaces;
using System;

namespace ChubbRestaurantChain.Core.Entities
{
    public class ClientOrder : ISingleEntity
    {
        public int Id { get; set; }
        public int RestuarantId { get; set; }
        public int MenuItemId { get; set; }
        public DateTime OrderDateTime { get; set; }
        public int NumOfPortions { get; set; }
    }
}
