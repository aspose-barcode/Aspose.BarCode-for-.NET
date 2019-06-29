using System;
using System.Drawing;
using System.IO;
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
    class BarcodeReaderSetBarcodeImage
    {
        public static string dataDir = RunExamples.GetDataDir_ManageAndOptimizeBarcodeRecognition();

        public static void Run()
        {
            ReadBarCodeFromStream();

            ReadBarCodeFromSpecificRegion();

            ReadBarCodeFromMultipleRegions();
        }

        public static void ReadBarCodeFromStream()
        {
            try
            {
                //ExStart: ReadBarCodeFromStream
                using (FileStream lStream = new FileStream(dataDir + "Scan.jpg", FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    using (BarCodeReader reader = new BarCodeReader())
                    {
                        reader.SetBarCodeImage(lStream);
                        while (reader.Read())
                            Console.WriteLine("BarCode CodeText: " + reader.GetCodeText());
                    }
                }
                //ExEnd: ReadBarCodeFromStream
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void ReadBarCodeFromSpecificRegion()
        {
            try
            {
                //ExStart: ReadBarCodeFromSpecificRegion
                using (Bitmap lBitmap = new Bitmap(dataDir + "Scan.jpg"))
                {
                    using (BarCodeReader reader = new BarCodeReader())
                    {
                        reader.SetBarCodeImage(lBitmap, new Rectangle(0, 0, lBitmap.Width, lBitmap.Height));
                        while (reader.Read())
                            Console.WriteLine("BarCode CodeText: " + reader.GetCodeText());
                    }
                }
                //ExEnd: ReadBarCodeFromSpecificRegion
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void ReadBarCodeFromMultipleRegions()
        {
            try
            {
                //ExStart: ReadBarCodeFromMultipleRegions
                using (Bitmap lBitmap = new Bitmap(dataDir + "Scan.jpg"))
                {
                    using (BarCodeReader reader = new BarCodeReader())
                    {
                        reader.SetBarCodeImage(lBitmap, new Rectangle[] { new Rectangle(0, 0, lBitmap.Width, lBitmap.Height) });
                        while (reader.Read())
                            Console.WriteLine("BarCode CodeText: " + reader.GetCodeText());
                    }
                }
                //ExEnd: ReadBarCodeFromMultipleRegions
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
