using System;
using Aspose.BarCode.BarCodeRecognition;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.BarCode.Examples.CSharp.ManageAndOptimizeBarCodeRecognition
{
    class ScanBarCodePicture
    {
        public static void Run()
        {
            // ExStart:ScanBarCodePicture
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ManageAndOptimizeBarcodeRecognition();

            try
            {
                // Read file from directory with DecodeType.EAN13
                BarCodeReader reader = new BarCodeReader(dataDir + "Scan.jpg", DecodeType.EAN13);
                while (reader.Read())
                {
                    // Read symbology type and code text
                    Console.WriteLine("Symbology Type: " + reader.GetCodeType());
                    Console.WriteLine("CodeText: " + reader.GetCodeText());
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose BarCode License. You can purchase full license or get 30 day temporary license from https://www.aspose.com/purchase/default.aspx.");
            }
            // ExEnd:ScanBarCodePicture

        }
    }
}
