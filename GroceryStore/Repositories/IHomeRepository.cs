namespace GroceryStore
{
    public interface IHomeRepository
    {
        Task<IEnumerable<Product>> GetProducts(string sTerm = "", int categoryId = 0);
        Task<IEnumerable<Category>> Categories();
    }
}