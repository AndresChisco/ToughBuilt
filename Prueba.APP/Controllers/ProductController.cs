using AutoMapper;
using Prueba.APP.Models.ViewModels;
using Prueba.BLL.Interfaces;
using Prueba.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Prueba.APP.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductBL _productBL;
        private readonly IMapper _mapper;

        public ProductController(IProductBL productBL, IMapper mapper)
        {
            _productBL = productBL;
            _mapper = mapper;
        }
        // GET: Product
        public async Task<ActionResult> Index()
        {
            IEnumerable<Product> products = await _productBL.GetListAsync();
            IEnumerable<ProductViewModel> productsVM = _mapper.Map<IEnumerable<ProductViewModel>>(products);
            return View(productsVM);
        }

        [HttpPost]
        public async Task<JsonResult> ProductList()
        {
            IEnumerable<ProductViewModel> productsVM = (IEnumerable<ProductViewModel>)await Index();
            return Json(new { data = productsVM });
        }
    }
}