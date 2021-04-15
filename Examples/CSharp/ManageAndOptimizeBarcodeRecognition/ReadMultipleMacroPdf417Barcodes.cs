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
    class ReadMultipleMacroPdf417Barcodes
    {
        public static void Run()
        {
            // ExStart:ReadMultipleMacroPdf417Barcodes
            try
            {
                // The path to the documents directory.
                string dataDir = RunExamples.GetDataDir_ManageAndOptimizeBarcodeRecognition();
         
                // Create array for storing multiple bar codes file names
                string[] files = new string[] { "MacroPdf417_0.png", "MacroPdf417_1.png" };

                // Iiterate through the bar code image files
                for (int i = 0; i < files.Length; ++i)
                {
                    // Create instance of BarCodeReader class and set symbology
                    using (BarCodeReader reader = new BarCodeReader(dataDir + files[i], DecodeType.MacroPdf417))
                    {
                        foreach (BarCodeResult result in reader.ReadBarCodes())
                        {
                            // Get code text, file id, segment id and segment count
                            Console.WriteLine("File Name: " + files[i] + " Code Text: " + result.CodeText);
                            Console.WriteLine("File ID: " + result.Extended.Pdf417.MacroPdf417FileID);
                            Console.WriteLine("Segment ID: " + result.Extended.Pdf417.MacroPdf417SegmentID);
                            Console.WriteLine("Segment Count: " + result.Extended.Pdf417.MacroPdf417SegmentsCount);
                            Console.WriteLine("File Size: " + result.Extended.Pdf417.MacroPdf417FileSize);
                            Console.WriteLine("Sender: " + result.Extended.Pdf417.MacroPdf417Sender);
                            Console.WriteLine("Addressee: " + result.Extended.Pdf417.MacroPdf417Addressee);
                            Console.WriteLine("Date: " + result.Extended.Pdf417.MacroPdf417TimeStamp.ToString());
                            Console.WriteLine("Checksum: " + result.Extended.Pdf417.MacroPdf417Checksum);
                        }
                        Console.WriteLine();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose BarCode License. You can purchase full license or get 30 day temporary license from http://wwww.aspose.com/purchase/default.aspx.");
            }
            // ExEnd:ReadMultipleMacroPdf417Barcodes
        }
    }
}