using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ViewComponentLibrary.ViewComponents
{
    [ViewComponent(Name = "ViewComponentLibrary.Simple")]
    public class SimpleViewComponent : ViewComponent
    {

        public IViewComponentResult Invoke(int number)
        {
            return View(number + 1);
        }
    }
}
