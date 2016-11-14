using System.IO;
using System;
using System.Diagnostics;
using System.Drawing;
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
    class ReadBarcodeSpecificRegionOfImage
    {
        public static void Run()
        {
            try
            {
                // The path to the documents directory.
                string dataDir = RunExamples.GetDataDir_ManageAndOptimizeBarcodeRecognition();

                // Create an instance of BarCodeReader class and specify an area to look for the barcode
                BarCodeReader reader = new BarCodeReader(new Bitmap(dataDir + "ReadBarcodefromSpecificRegionofImage.png"), new Rectangle(0, 0, 100, 50), DecodeType.Pdf417);

                // Read all barcodes in the provided area
                while (reader.Read() == true)
                {
                    // Display the codetext and symbology type of the barcode found
                    Console.WriteLine("Codetext: " + reader.GetCodeText() + " Symbology: " + reader.GetCodeType());
                }
                // close the reader
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose BarCode License. You can purchase full license or get 30 day temporary license from http://wwww.aspose.com/purchase/default.aspx.");
            }
        }
    }
}
