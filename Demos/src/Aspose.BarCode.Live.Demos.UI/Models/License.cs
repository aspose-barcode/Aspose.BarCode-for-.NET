using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aspose.Barcode.Live.Demos.UI.Models
{
	///<Summary>
	/// License class to set apose products license
	///</Summary>
	public static class License
	{
		private static string _licenseFileName = "Aspose.Total.lic";

		///<Summary>
		/// SetAsposeBarCodeLicense method to Aspose.OMR License
		///</Summary>
		public static void SetAsposeBarCodeLicense()
		{
			try
			{

				Aspose.BarCode.License lic = new Aspose.BarCode.License();
				lic.SetLicense(_licenseFileName);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}	
		
	}
}
