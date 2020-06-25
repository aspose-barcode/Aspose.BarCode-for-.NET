using Aspose.Barcode.Live.Demos.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aspose.Barcode.Live.Demos.UI.Controllers
{
	public class HomeController : BaseController
	{
	
		public override string Product => (string)RouteData.Values["productname"];
		

		

		public ActionResult Default()
		{
			ViewBag.PageTitle = "On Premise, Cloud &amp; App Based Solutions for Barcode Processing";
			ViewBag.MetaDescription = "Build barcode generation &amp; processing applications via On Premise APIs or Cloud-based SDKs. Use cross-platform apps for Barcode generation or recognition.";
			var model = new LandingPageModel(this);

			return View(model);
		}
	}
}
