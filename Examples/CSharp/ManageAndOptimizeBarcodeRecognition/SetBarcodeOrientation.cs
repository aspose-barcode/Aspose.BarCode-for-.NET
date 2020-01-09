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
    class SetBarcodeOrientation
    {
        public static void Run()
        {
            try
            {
                // ExStart:SetBarcodeOrientation
                // The path to the documents directory.
                string dataDir = RunExamples.GetDataDir_ManageAndOptimizeBarcodeRecognition();

                // Create an instance of BarCodeReader and set image and symbology type to recognize
                using (BarCodeReader barCodeReader = new BarCodeReader(dataDir + "BarcodeOrientation.png", DecodeType.Code39Standard))
                {
                    // Aspose.BarCode.BarCodeRecognition.RecognitionHints is obsolete: RecognitionHints is depricated
                    // Barcode orientation is detected automatically
                    // barCodeReader.OrientationHints = RecognitionHints.Orientation.Rotate90;

                    // Try to recognize all possible barcodes in the image and Display the codetext
                    foreach (BarCodeResult result in barCodeReader.ReadBarCodes())
                    {
                        Console.WriteLine("Codetext: " + result.CodeText);
                    }
                }
                // ExEnd:SetBarcodeOrientation
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose BarCode License. You can purchase full license or get 30 day temporary license from http://wwww.aspose.com/purchase/default.aspx.");
            }
        }
    }
}