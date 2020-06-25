using System;
using System.Web.Http;
using System.Threading.Tasks;
using Aspose.BarCode.Generation;
using System.Text;
using Aspose.BarCode;
using System.Linq;

namespace Aspose.Barcode.Live.Demos.UI.Models
{
	///<Summary>
	/// AsposeBarCodeGenerate class to generated barcode
	///</Summary>
	public class AsposeBarCodeGenerate : AsposeBarCodeBase
    {
		///<Summary>
		/// BarcodeGenerateActionDelegate
		///</Summary>
		protected delegate void BarcodeGenerateActionDelegate(string outPath, string imagePath, string barcodeType);
		///<Summary>
		/// Process
		///</Summary>
		protected Response Process(string barcodeType, string strValue, string outFileExtension,  string methodName, BarcodeGenerateActionDelegate action)
        {
            string guid = Guid.NewGuid().ToString();

            string outfileName = guid + outFileExtension;
	        string outPath = Config.Configuration.OutputDirectory + outfileName;

	        string imageFileName = Guid.NewGuid() + ".png";
			string imagePath = Config.Configuration.OutputDirectory + imageFileName;

			string statusValue = "OK";
            int statusCodeValue = 200;

            try
            {
                action(outPath, imagePath, barcodeType);            


            }
            catch (Exception ex)
            {
                statusCodeValue = 500;
                statusValue = "500 " + ex.Message;
                outfileName = "";                
            }

            return new Response
            {
	            DownloadFileLink = outfileName,
				FileName = imageFileName,
                Status = statusValue,
                StatusCode = statusCodeValue,
            };
        }


        private Response ProcessTask(string barcodeType, string content, string outFileExtension, string methodName, BarcodeGenerateActionDelegate action)
        {
            License.SetAsposeBarCodeLicense();
            return  Process(barcodeType, content, outFileExtension,  methodName, action);
        }



        private string getExtension(string filetype)
        {
            return "." + filetype.ToLower().Trim();
        }

        private BarCodeImageFormat getImageFormat(string filetype)
        {
            switch (filetype)
            {
                case "PNG":
                    return BarCodeImageFormat.Png;
                case "BMP":
                    return BarCodeImageFormat.Bmp;
                case "GIF":
                    return BarCodeImageFormat.Gif;
                case "JPEG":
                    return BarCodeImageFormat.Jpeg;
                case "TIFF":
                    return BarCodeImageFormat.Tiff;
                case "SVG":
                    return BarCodeImageFormat.Svg;
                case "EMF":
                    return BarCodeImageFormat.Emf;

                default:
                    return BarCodeImageFormat.Png;
            }
        }

		private static BaseEncodeType getBarCodeType(string barcodetype)
        {
            var type = EncodeTypes.AllEncodeTypes.Where(w => w.TypeName.Trim().Equals(barcodetype.Trim())).Select(s=>s).FirstOrDefault();
            if (type == null)
                return EncodeTypes.None;
            else
                return type;
        }
		///<Summary>
		/// GenerateBarCode method to generate barcode
		///</Summary>

        public Response GenerateBarCode(string barcodetype, string content, string filetype, float filesize)
        {
            return  ProcessTask(barcodetype, content, getExtension(filetype),  "GenerateBarCode", delegate (string outPath, string imagePath, string barcodeType)
            {
                var generator = new BarcodeGenerator(getBarCodeType(barcodetype), content);
                generator.Parameters.Barcode.QR.CodeTextEncoding = Encoding.UTF8;
                generator.Parameters.Barcode.XDimension.Millimeters *= filesize;
                generator.Parameters.Barcode.BarHeight.Millimeters *= filesize;
                generator.Parameters.Barcode.AustralianPost.AustralianPostShortBarHeight.Millimeters *= filesize;
                generator.Parameters.Barcode.Postal.PostalShortBarHeight.Millimeters *= filesize;
                generator.Parameters.Barcode.ITF.ItfBorderThickness.Millimeters *= filesize;
	            generator.Save(outPath, getImageFormat(filetype));
				generator.Save(imagePath, BarCodeImageFormat.Png);
            });
        }
    }
}
