using System.Collections.Generic;

namespace ChubbRestaurantChain.Reports.Models
{
    public class SupplierOrderDetails
    {
        public string MenuItem { get; set; }
        public List<RestaurantPortion> RestaurantPortions { get; set; }
        public string KeyIngredientToOrderForNextMonth { get; set; }
        public int Quantity { get; set; }
    }
}
