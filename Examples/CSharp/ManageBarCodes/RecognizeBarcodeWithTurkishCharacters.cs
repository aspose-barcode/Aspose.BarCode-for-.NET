using System;
using System.Text;
using Aspose.BarCode.BarCodeRecognition;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/
namespace Aspose.BarCode.Examples.CSharp.ManageBarCodes
{
    class RecognizeBarcodeWithTurkishCharacters
    {
        public static void Run()
        {
            try
            {
                // ExStart:RecognizeBarcodeWithTurkishCharacters
                // The path to the documents directory.
                string dataDir = RunExamples.GetDataDir_ManageBarCodes();

                // Load barcode image and Read barcode
                var reader = new BarCodeReader(dataDir + "Turkish.png", DecodeType.Pdf417);
                while (reader.Read())
                {
                    var t = reader.GetCodeBytes();
                    var encodingValue = Encoding.GetEncoding(1254).GetString(t);
                }
                reader.Close();
                // ExEnd:RecognizeBarcodeWithTurkishCharacters
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }
        }
    }
}