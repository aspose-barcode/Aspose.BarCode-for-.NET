using System.IO;
using System;
using System.Diagnostics;
using System.Drawing;
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
    class ReadMultipleMacroPdf417Barcodes
    {
        public static void Run()
        {

            try
            {
                //ExStart:ReadMultipleMacroPdf417Barcodes               

                // The path to the documents directory.
                string dataDir = RunExamples.GetDataDir_ManageAndOptimizeBarcodeRecognition();
                // Create array for storing multiple bar codes file names
                string[] files = new string[] { "Barcodefrom.png", "Barcode2.png" };

                // Iiterate through the bar code image files
                for (int i = 0; i < files.Length; ++i)
                {
                    // Create instance of BarCodeReader class and set symbology
                    using (BarCodeReader reader = new BarCodeReader(dataDir + files[i], DecodeType.MacroPdf417))
                    {

                        if (reader.Read())
                        {
                            // Get code text
                            Console.WriteLine("File Name: " + files[i] + " Code Text: " + reader.GetCodeText());
                            // Get file id
                            Console.WriteLine("FileID: " + reader.GetMacroPdf417FileID());
                            // Get segment id
                            Console.WriteLine("SegmentID: " + reader.GetMacroPdf417SegmentID());
                            // Get segment count
                            Console.WriteLine("Segment Count: " + reader.GetMacroPdf417SegmentsCount());
                        }
                        Console.WriteLine();
                    }
                }
                //ExEnd:ReadMultipleMacroPdf417Barcodes 


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose BarCode License. You can purchase full license or get 30 day temporary license from http:// Www.aspose.com/purchase/default.aspx.");
            }

        }
    }
}

