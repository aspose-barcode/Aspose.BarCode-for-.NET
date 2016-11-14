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
    class ReadMultipleBarcodeRegions
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ManageAndOptimizeBarcodeRecognition();
          
            // Initialize the Bitmap object            
            Bitmap bitmap = new Bitmap(dataDir + "Region.png");

            Rectangle[] areas = new Rectangle[3];
            areas[0] = new Rectangle(50, 50, 300, 300);
            areas[1] = new Rectangle(400, 40, 350, 350);
            areas[2] = new Rectangle(40, 500, 700, 150);

            // Initialize the BarCodeReader object and load bitmap object       
            using (BarCodeReader reader = new BarCodeReader(bitmap, areas, DecodeType.Code39Standard))
            {
                while (reader.Read())
                {
                    Console.WriteLine(reader.GetCodeType() + ": " + reader.GetCodeText());
                }
            }
        }
    }
}

