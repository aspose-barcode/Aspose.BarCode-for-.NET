using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using Aspose.Barcode.Live.Demos.UI.Config;
using Aspose.Barcode.Live.Demos.UI.Services;
using Aspose.Barcode.Live.Demos.UI.Helpers;
using Aspose.Barcode.Live.Demos.UI.Models;

using Aspose.Barcode.Live.Demos.UI.Resources;

namespace Aspose.Barcode.Live.Demos.UI.Controllers
{
    public class BarcodeController : Controller
    {
	    public ActionResult Generate()
	    {
		    var viewModel = BarcodeGenerateViewModel.Create(HttpContext);
			return View(viewModel);
	    }

	    public ActionResult GenerateWithType(string barcodeType)
	    {
		    if (barcodeType != barcodeType.ToLower())
		    {
			    return RedirectPermanent("/barcode/generate/" + barcodeType.ToLower());
		    }


		    var model = BarcodeGenerateViewModel.Create(HttpContext, barcodeType);
		    if (model == null)
		    {
			    return RedirectPermanent("/barcode/generate");
		    }
		    return View("Generate", model);
	    }

		[HttpPost]
	    public ActionResult GenerateBarcode(string barcodetype, string content, string filetype, string filesize)
	    {
			if (ValidateBarcodeGenerateModel())
			{
				try
				{
					var obj = new
					{
						FileType = filetype,
						FileSize = filesize,
						BarCodeType = barcodetype
					};

					AsposeBarCodeGenerate asposeBarCodeGenerate = new AsposeBarCodeGenerate();

					var response = asposeBarCodeGenerate.GenerateBarCode(barcodetype, content, filetype, float.Parse(filesize)  );

					if ((response != null) && (response.FileName != ""))
					{



						var imgBase64 = Convert.ToBase64String(System.IO.File.ReadAllBytes(Config.Configuration.OutputDirectory + response.FileName));

						string url = Config.Configuration.AsposeBarCodeLiveDemosPath + "common/download?file=" + response.FileName;

						return Json(new { success = true, imgBase64 = imgBase64, url });
					}

					else
					{
						return Json(new { success = false, errorMsg = "Failed to generate barcode" });
					}
				}
				catch (Exception ex)
				{
					return Json(new { success = false, errorMsg = "Failed to generate barcode. Error: " + ex.Message });
				}
			}
		    return Json(new { success = false, errorMsg = "Failed to generate barcode. Invalid codetext." });
		}

	    public ActionResult Recognize()
	    {
		    return View(BarcodeRecognizeViewModel.Create(HttpContext));
	    }

	    public ActionResult RecognizeWithType(string barcodeType)
	    {
		    if (barcodeType != barcodeType.ToLower())
		    {
			    return RedirectPermanent("/barcode/recognize/" + barcodeType.ToLower());
		    }

		    var model = BarcodeRecognizeViewModel.Create(HttpContext, barcodeType);
		    if (model == null)
		    {
			    return RedirectPermanent("/barcode/recognize");
		    }

			return View("Recognize", model);
	    }

		[HttpPost]
	    public JsonResult RecognizeBarcode()
	    {
		    try
		    {
				var files = Request.Files;
				foreach (string fileName in Request.Files)
				{
					HttpPostedFileBase postedFile = Request.Files[fileName];

					if (postedFile != null)
					{
						var isFileUploaded = FileManager.UploadFile(postedFile);

						if ((isFileUploaded != null) && (isFileUploaded.FileName.Trim() != ""))
						{
							AsposeBarCodeRecognize asposeBarCodeRecognize = new AsposeBarCodeRecognize();

							var response = asposeBarCodeRecognize.ReadBarCode(Request.Params["type"],
						isFileUploaded.FileName, isFileUploaded.FolderId, Int32.Parse(Request.Params["quality"]));
							if (response == null)
							{
								return Json(new { success = false, errorMsg = AppStrings.APIResponseTime });
							}
							else if (response.StatusCode != 200)
							{
								return Json(new { success = false, errorMsg = response.Status });
							}

							return Json(new { success = true, foundBarcodes = response.BarCodeFileorText });
						}
					}
				}
			}
		    catch (Exception ex)
		    {
				Console.WriteLine(ex.Message);
			    return Json(new { success = false, errorMsg = AppStrings.APIResponseTime });
		    }
			return Json(new { success = false, errorMsg = AppStrings.APIResponseTime });
	    }

		private bool ValidateBarcodeGenerateModel()
		{
			
			return true;
		}


	}
}
