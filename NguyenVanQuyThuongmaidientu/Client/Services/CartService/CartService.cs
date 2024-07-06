using NguyenVanQuyThuongmaidientu.Shared;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NguyenVanQuyThuongmaidientu.Client.Services.CartService
{
    public class CartService
    {
        public List<Product> Products { get; set; } = new List<Product>();
        public decimal TotalAmount => Products.Sum(p => p.Price);

        public event Action OnChange = delegate { };

        public void AddToCart(Product product)
        {
            Products.Add(product);
            OnChange?.Invoke();
        }

        public void RemoveFromCart(int productId)
        {
            var product = Products.FirstOrDefault(p => p.Id == productId);
            if (product != null)
            {
                Products.Remove(product);
                OnChange?.Invoke();
            }
        }

        public void ClearCart()
        {
            Products.Clear();
            OnChange?.Invoke();
        }

        public List<Product> GetCartItems()
        {
            return Products;
        }
    }
}
