using DotNetDemo.WebAPI.ViewModels;

namespace DotNetDemo.WebAPI.Services;

public interface IProductService
{
    public IEnumerable<ProductViewModel> Get();
    public ProductViewModel Add(ProductViewModel vm);
    public ProductViewModel Update(ProductViewModel vm);
    public bool Remove(Guid id);
}

public class ProductService : IProductService
{
    public ProductService()
    {

    }
    
    public IEnumerable<ProductViewModel> Get()
    {
        throw new NotImplementedException();
    }

    public ProductViewModel Add(ProductViewModel vm)
    {
        throw new NotImplementedException();
    }

    public ProductViewModel Update(ProductViewModel vm)
    {
        throw new NotImplementedException();
    }

    public bool Remove(Guid id)
    {
        throw new NotImplementedException();
    }
}