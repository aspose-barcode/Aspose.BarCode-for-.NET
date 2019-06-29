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
    class RecognizeSpecificBarcodeSymbology
    {
        public static void Run()
        {
            // ExStart:RecognizeSpecificBarcodeSymbology
            try
            {
                // The path to the documents directory.
                string dataDir = RunExamples.GetDataDir_ManageAndOptimizeBarcodeRecognition();

                // Create instance of BarCodeReader class 
                BarCodeReader reader = new BarCodeReader(dataDir + "Code128.jpg", DecodeType.Code128);
                while (reader.Read())
                {
                    // Display code text and Symbology Type
                    Console.WriteLine("CodeText: " + reader.GetCodeText());
                    Console.Write("Symbology Type: " + reader.GetCodeType());
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose BarCode License. You can purchase full license or get 30 day temporary license from http://wwww.aspose.com/purchase/default.aspx.");
            }
            // ExEnd:RecognizeSpecificBarcodeSymbology
        }
    }
}
