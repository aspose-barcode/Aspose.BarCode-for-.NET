using System.IO;
using System;
using System.Diagnostics;
using System.Drawing.Imaging;
using Aspose.BarCode.BarCodeRecognition;
using Aspose.BarCode;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
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
            try
            {
                // The path to the documents directory.
                string dataDir = RunExamples.GetDataDir_ManageAndOptimizeBarcodeRecognition();

                // Create instance of BarCodeBuilder class 
                BarCodeReader reader = new BarCodeReader(dataDir + "SymbologyTypebarcode.png", DecodeType.Code128);
                while (reader.Read())
                {
                    // Display code text
                    Console.WriteLine("CodeText: " + reader.GetCodeText());
                    // Display Symbology Type
                    Console.Write("Symbology Type: " + reader.GetCodeType());
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose BarCode License. You can purchase full license or get 30 day temporary license from http://wwww.aspose.com/purchase/default.aspx.");
            }
        }
    }
}
