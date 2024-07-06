using NguyenVanQuyThuongmaidientu.Shared;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace NguyenVanQuyThuongmaidientu.Client.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _http;

        public ProductService(HttpClient http)
        {
            _http = http;
        }

        public List<Product> Products { get; set; } = new List<Product>();

        public event Action? ProductsChanged;

        public async Task<ServiceResponse<Product>> GetProduct(int productId)
        {
            var result = await _http.GetFromJsonAsync<ServiceResponse<Product>>($"api/product/{productId}");
            return result ?? new ServiceResponse<Product> { Data = null, Success = false, Message = "Product not found" };
        }

        public async Task GetProducts(string? categoryUrl = null)
        {
            ServiceResponse<List<Product>>? result;
            if (categoryUrl == null)
            {
                result = await _http.GetFromJsonAsync<ServiceResponse<List<Product>>>("api/product");
            }
            else
            {
                result = await _http.GetFromJsonAsync<ServiceResponse<List<Product>>>($"api/product/category/{categoryUrl}");
            }

            if (result != null && result.Data != null)
            {
                Products = result.Data;
            }

            ProductsChanged?.Invoke();
        }

        public async Task<ServiceResponse<List<Product>>> GetProductsByCategory(string categoryUrl)
        {
            var response = await _http.GetFromJsonAsync<ServiceResponse<List<Product>>>($"api/product/category/{categoryUrl}");
            return response ?? new ServiceResponse<List<Product>> { Data = new List<Product>(), Success = false, Message = "Category not found" };
        }
    }
}
