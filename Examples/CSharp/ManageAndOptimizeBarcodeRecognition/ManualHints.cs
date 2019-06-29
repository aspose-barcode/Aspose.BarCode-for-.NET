using System;
using System.Diagnostics;
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
    class ManualHints
    {
        public static void Run()
        {
            try
            {
                // ExStart:MarkingBarCodeRegionsInImage
                Stopwatch watch = new Stopwatch();
                // The path to the documents directory.
                string dataDir = RunExamples.GetDataDir_ManageAndOptimizeBarcodeRecognition();
                using (BarCodeReader reader = new BarCodeReader(dataDir + "Code128.jpg", DecodeType.Code128))
                {
                    // Start Stopwatch and Set RecognitionMode, ManualHints
                    watch.Start();
                    //reader.RecognitionMode = RecognitionMode.ManualHints;
                    reader.QualitySettings.AllowMedianSmoothing = true;
                    reader.QualitySettings.MedianSmoothingWindowSize = 5;

                    while (reader.Read())
                    {
                        Console.WriteLine(reader.GetCodeType() + ": " + reader.GetCodeText());
                    }

                    // End Stopwatch
                    watch.Stop();
                    Console.WriteLine("Time: " + watch.ElapsedMilliseconds + "ms.");
                }
                // ExEnd:MarkingBarCodeRegionsInImage
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose BarCode License. You can purchase full license or get 30 day temporary license from http://wwww.aspose.com/purchase/default.aspx.");
            }
        }
    }
}