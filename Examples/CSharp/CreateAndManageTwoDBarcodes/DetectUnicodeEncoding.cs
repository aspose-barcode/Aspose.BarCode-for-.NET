using System.IO;
using System;
using System.Text;
using Aspose.BarCode.BarCodeRecognition;
using Aspose.BarCode;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
when the project is build. Please check https:// ocs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http:// ww.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http:// ww.aspose.com/community/forums/default.aspx
*/

namespace Aspose.BarCode.Examples.CSharp.CreateAndManageTwoDBarcodes
{
    class DetectUnicodeEncoding
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_CreateAndManage2DBarCodes();

            try
            {
                MemoryStream memoryStream = new MemoryStream();
                // Instantiate barcode object
                using (BarCodeBuilder barCodeBuilder = new BarCodeBuilder())
                {
                    // Set CodeText 
                    barCodeBuilder.CodeText = "Слово";

                    // Set Barcode Symbology
                    barCodeBuilder.SymbologyType = Symbology.QR;

                    // Set Text Encoding
                    barCodeBuilder.CodeTextEncoding = Encoding.UTF8;

                    // Save the Barcode image
                    barCodeBuilder.Save(dataDir + "" + memoryStream + "_out.png", BarCodeImageFormat.Png);
                }

                string fileName = dataDir + "" + memoryStream + "_out.png";

                using (BarCodeReader reader = new BarCodeReader(fileName, DecodeType.QR))
                {
                    reader.SetDetectEncoding(false);
                    if (reader.Read())
                        Console.WriteLine(reader.GetCodeText(Encoding.UTF8)); //"Слово"
                }

            }
            catch (Exception)
            {

            }
        }
    }
}
