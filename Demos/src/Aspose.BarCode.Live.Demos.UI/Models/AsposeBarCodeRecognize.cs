using System;
using System.IO;
using System.Web.Http;
using System.Threading.Tasks;
using Aspose.BarCode.BarCodeRecognition;
using System.Text;
using System.Collections;
using System.Linq;

namespace Aspose.Barcode.Live.Demos.UI.Models
{
	///<Summary>
	/// AsposeBarCodeRecognize class to perform barcode recognization
	///</Summary>
	public class AsposeBarCodeRecognize : AsposeBarCodeBase
	{
		///<Summary>
		/// BarCodeRecognizeActionDelegate
		///</Summary>
		protected delegate void BarCodeRecognizeActionDelegate(string inFilePath, string barcodeType);

        private string barCodeText = "";
		///<Summary>
		/// Process
		///</Summary>
		protected BarCodeResponse Process(string barcodeType, string fileName, string folderName,  string methodName,  BarCodeRecognizeActionDelegate action)
        {
            string sourceFolder = Config.Configuration.WorkingDirectory + folderName;
			string tempFile = fileName;
			fileName = sourceFolder + "/" + fileName;

            string statusValue = "OK";
            int statusCodeValue = 200;

            try
            {
                action(fileName, barcodeType);

                Directory.Delete(sourceFolder, true);

               

                if (string.IsNullOrEmpty(barCodeText)) {
                    statusCodeValue = 500;
                    statusValue = "BarCode was not recognized.";
                }

            }
            catch (Exception ex)
            {
                statusCodeValue = 500;
                statusValue = "500 " + ex.Message;
                
            }

            return new BarCodeResponse
            {
                BarCodeFileorText = barCodeText,
                Status = statusValue,
                StatusCode = statusCodeValue,
            };
        }
        private BarCodeResponse ProcessTask(string barcodeType, string fileName, string folderName,  string methodName, BarCodeRecognizeActionDelegate action)
        {
            License.SetAsposeBarCodeLicense();
            return  Process(barcodeType, fileName, folderName,  methodName, action);
        }

        private static BaseDecodeType[] getBarCodeType(string barcodetype)
        {
			var types = DecodeType.AllSupportedTypes.GetSingleTypes().Where(w => w.TypeName.ToLower().Trim().Contains(barcodetype.ToLower().Trim())).Select(s => s).ToArray();
            if (types == null || types.Length <= 0)
                return new BaseDecodeType[] { DecodeType.None };
            else
                return types;
        }
		///<Summary>
		/// ReadBarCode method to read barcode
		///</Summary>
		
        public BarCodeResponse ReadBarCode(string encodetype, string fileName, string folderName, int quality)
        {
            return  ProcessTask(encodetype, fileName, folderName,  "ReadBarCode", delegate (string inFilePath, string barcodeType)

            {
                // Initialize the BarCodeReader 
                BarCodeReader reader = encodetype.ToLower().Equals("none") ? new BarCodeReader(inFilePath):
										new BarCodeReader(inFilePath, getBarCodeType(encodetype));

	            switch (quality)
	            {
		            case 1:
			            reader.QualitySettings = QualitySettings.HighPerformance;
			            break;
		            case 2:
			            reader.QualitySettings = QualitySettings.NormalQuality;
			            break;
		            case 3:
			            reader.QualitySettings = QualitySettings.HighQuality;
			            break;
				}

	            var res = reader.ReadBarCodes();
	            foreach (var barcode in res)
	            {
                    barCodeText += barcode.CodeTypeName + ": " + barcode.CodeText + Environment.NewLine;
                }
            });
        }



    }
}
