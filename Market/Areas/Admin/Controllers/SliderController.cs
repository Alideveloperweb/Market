using Market.Core.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Market.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SliderController : Controller
    {
        #region Constractor

        private readonly ISliderService _sliderService;

        public SliderController(ISliderService sliderService)
        {
            _sliderService= sliderService;
        }

        #endregion
        public IActionResult Index()
        {
            return View();
        }
    }
}
