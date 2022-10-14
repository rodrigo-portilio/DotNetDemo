using System.ComponentModel.DataAnnotations;

namespace DotNetDemo.WebAPI.ViewModels;

public class ProductCategory
{
    public Guid Id { get; set; } = Guid.Empty;

    [Required(ErrorMessage = "The {0} is required")]
    public string Name { get; set; }
}

public class ProductViewModel
{
    public Guid Id { get; set; } = Guid.Empty;

    [Required(ErrorMessage = "The {0} is required")]
    public string Name { get; set; }

    [Required(ErrorMessage = "The {0} is required")]
    public string Description { get; set; }

    [Required(ErrorMessage = "The {0} is required")]
    public Guid CategoryId { get; set; }
}