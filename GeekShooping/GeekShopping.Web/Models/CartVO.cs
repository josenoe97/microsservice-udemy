using System.Collections.Generic;

namespace GeekShopping.Web.Models
{
    public class CartVO
    {
        public CartHeaderViewModel CartHeader { get; set; }
        public IEnumerable<CartDetailViewModel> CartDetails { get; set; }
    }
}
