using System;
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
    class DetectUnreadableBarcode
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ManageAndOptimizeBarcodeRecognition();

          
            //ExStart:DetectUnreadableBarcode               
            // Initialize the BarCodeReader object
            using (BarCodeReader reader = new BarCodeReader(dataDir + "code39.png", DecodeType.Code39Standard))
            {
                // Set RecognitionMode
                reader.RecognitionMode = RecognitionMode.MaxBarCodes;
                while (reader.Read())
                {
                    Console.WriteLine(reader.GetCodeType() + ": " + reader.GetCodeText());
                    Console.WriteLine("IsDeniable: " + reader.GetIsDeniable());
                }
            }
            //ExEnd:DetectUnreadableBarcode 
        }
    }
}

