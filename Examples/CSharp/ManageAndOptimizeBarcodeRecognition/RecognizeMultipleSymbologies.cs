using System.IO;
using System;
using System.Diagnostics;
using System.Drawing.Imaging;
using Aspose.BarCode.BarCodeRecognition;
using Aspose.BarCode;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
when the project is build. Please check https:// ocs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http:// ww.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http:// ww.aspose.com/community/forums/default.aspx
*/

namespace Aspose.BarCode.Examples.CSharp.ManageAndOptimizeBarCodeRecognition
{
    class RecognizeMultipleSymbologies
    {
        public static void Run()
        {
            try
            {
                //ExStart:RecognizeMultipleSymbologies
                // The path to the documents directory.
                string dataDir = RunExamples.GetDataDir_ManageAndOptimizeBarcodeRecognition();

                // Initialize the BarCodeReader 
                BarCodeReader reader = new BarCodeReader(dataDir + "RecognizingMultipleSymbologies.png", BarCodeReadType.Code39Standard | BarCodeReadType.Pdf417);

                // Call Read() method in a loop
                while (reader.Read())
                {
                    // Display the codetext and symbology type
                    Console.WriteLine("Codetext: " + reader.GetCodeText());
                    Console.WriteLine("Symbology type: " + reader.GetCodeType());
                }
                reader.Close();
                //ExEnd:RecognizeMultipleSymbologies 
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose BarCode License. You can purchase full license or get 30 day temporary license from http:// Www.aspose.com/purchase/default.aspx.");
            }
        }
    }
}
