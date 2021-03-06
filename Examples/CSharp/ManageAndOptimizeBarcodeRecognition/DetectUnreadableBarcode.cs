﻿using System;
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
    class DetectUnreadableBarcode
    {
        public static void Run()
        {
            // ExStart:DetectUnreadableBarcode
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ManageAndOptimizeBarcodeRecognition();
            
            using (BarCodeReader reader = new BarCodeReader(dataDir + "code39.png", DecodeType.Code39Standard))
            {
                //set max barcodes mode, which tries to find all possible barcodes, even incorrect. 
                //The slowest recognition mode
                reader.QualitySettings = QualitySettings.MaxBarCodes;
                foreach (BarCodeResult result in reader.ReadBarCodes())
                {
                    Console.WriteLine("BarCode CodeText: " + result.CodeText);
                    Console.WriteLine("BarCode Type: " + result.CodeType);
                }
            }
            // ExEnd:DetectUnreadableBarcode
        }
    }
}