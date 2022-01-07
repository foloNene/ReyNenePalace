using System.Collections.Generic;

namespace ReyNenePalace.Models
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
