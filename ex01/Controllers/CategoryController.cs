using AutoMapper;
using DTO;
using Entytess;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using servies;

namespace project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : Controller
    {
        private readonly ICategoryServices _category;
        private readonly IMapper mapper;
        public CategoryController(ICategoryServices category, IMapper _mapper)
        {
            _category = category;
            mapper = _mapper;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CategoryDto>>> GetAllCategory()
        {





            IEnumerable<Category> categories = await _category.GetAllCategory();
            IEnumerable <CategoryDto> category =mapper.Map<IEnumerable<Category>, IEnumerable<CategoryDto>>(categories);

            return Ok(category);

        }
    }
}