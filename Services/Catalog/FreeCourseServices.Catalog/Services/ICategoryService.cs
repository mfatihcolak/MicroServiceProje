using FreeCourseServices.Catalog.Dtos;
using FreeCourseServices.Catalog.Model;
using FreeCourseShared.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FreeCourseServices.Catalog.Services
{
    public interface ICategoryService
    {
        Task<Response<List<CategoryDto>>> GetAllAsync();

        Task<Response<CategoryDto>> CreateAsync(Category category);

        Task<Response<CategoryDto>> GetById(string id);
    }
}
