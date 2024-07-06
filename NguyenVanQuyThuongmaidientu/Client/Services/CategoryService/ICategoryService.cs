namespace NguyenVanQuyThuongmaidientu.Client.Services.CategoryService
{
    public interface ICategoryService
    {
        Task GetCategories();
        List<Category> Categories { get; set; }
    }
}
