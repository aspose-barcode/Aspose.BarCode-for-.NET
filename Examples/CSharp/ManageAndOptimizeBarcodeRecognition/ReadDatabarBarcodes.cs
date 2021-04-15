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
    class ReadDatabarBarcodes
    {
        public static void Run()
        {
            // ExStart:ReadDatabarBarcodes
            try
            {
                // The path to the documents directory.
                string dataDir = RunExamples.GetDataDir_ManageAndOptimizeBarcodeRecognition();

                // Instantiate BarCodeReader object
                using (BarCodeReader reader = new BarCodeReader(dataDir + "Databar.png", DecodeType.DatabarExpanded, DecodeType.DatabarExpandedStacked))
                    // Read Code128 bar code and Detect bar code orientation
                    foreach (BarCodeResult result in reader.ReadBarCodes())
                    {
                        Console.WriteLine("Type: " + result.CodeTypeName);
                        Console.WriteLine("CodeText: " + result.CodeText);
                        Console.WriteLine("Is DataBar has 2D component: " + result.Extended.DataBar.Is2DCompositeComponent.ToString());
                    }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose BarCode License. You can purchase full license or get 30 day temporary license from http://wwww.aspose.com/purchase/default.aspx.");
            }
            // ExEnd:ReadDatabarBarcodes
        }
    }
}