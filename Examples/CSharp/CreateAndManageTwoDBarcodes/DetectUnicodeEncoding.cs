using System;
using System.IO;
using System.Text;
using Aspose.BarCode.BarCodeRecognition;
using Aspose.BarCode.Generation;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.BarCode.Examples.CSharp.CreateAndManageTwoDBarcodes
{
    class DetectUnicodeEncoding
    {
        public static void Run()
        {
            //ExStart:DetectUnicodeEncoding
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_CreateAndManage2DBarCodes();

            try
            {
                MemoryStream memoryStream = new MemoryStream();

                // Instantiate barcode object, Set CodeText, Barcode Symbology and Text Encoding
                using (BarcodeGenerator  generator = new BarcodeGenerator (EncodeTypes.QR, "Слово"))
                {
                    generator.Parameters.Barcode.QR.CodeTextEncoding = Encoding.UTF8;
                    generator.Save(dataDir + "" + memoryStream + "_out.png", BarCodeImageFormat.Png);
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
            {}
            //ExEnd:DetectUnicodeEncoding
        }
    }
}
