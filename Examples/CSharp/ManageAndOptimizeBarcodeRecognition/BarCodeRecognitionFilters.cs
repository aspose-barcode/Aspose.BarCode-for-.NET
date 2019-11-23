using System;
using System.Collections.Generic;
using System.Drawing;
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
    class BarCodeRecognitionFilters
    {
        public static string dataDir = RunExamples.GetDataDir_ManageAndOptimizeBarcodeRecognition();

        public static void Run()
        {
            QualitySetting();

            QualitySettingWithManualOptionsNormalQuality();

            QualitySettingWithManualOptionsHighPerformance();

            ImproveDetectionByInverting();
        }

        public static void QualitySetting()
        {
            //ExStart: QualitySetting
            using (BarCodeReader reader = new BarCodeReader(dataDir + "Scan.jpg"))
            {
                //set high quality mode with low speed recognition 
                reader.QualitySettings = QualitySettings.HighQuality;
                foreach (BarCodeResult result in reader.ReadBarCodes())
                    Console.WriteLine("BarCode CodeText: " + result.CodeText);
            }
            //ExEnd: QualitySetting
        }

        public static void QualitySettingWithManualOptionsNormalQuality()
        {
            //ExStart: QualitySettingWithManualOptionsNormalQuality
            using (BarCodeReader reader = new BarCodeReader(dataDir + "Scan.jpg"))
            {
                //default mode is NormalQuality
                //set separate options
                reader.QualitySettings.AllowMedianSmoothing = true;
                reader.QualitySettings.MedianSmoothingWindowSize = 5;
                foreach (BarCodeResult result in reader.ReadBarCodes())
                    Console.WriteLine("BarCode CodeText: " + result.CodeText);
            }
            //ExEnd: QualitySettingWithManualOptionsNormalQuality
        }

        public static void QualitySettingWithManualOptionsHighPerformance()
        {
            //ExStart: QualitySettingWithManualOptionsHighPerformance
            using (BarCodeReader reader = new BarCodeReader(dataDir + "Scan.jpg"))
            {
                //set high performance mode
                reader.QualitySettings = QualitySettings.HighPerformance;
                //set separate options
                reader.QualitySettings.AllowMedianSmoothing = true;
                reader.QualitySettings.MedianSmoothingWindowSize = 5;
                foreach (BarCodeResult result in reader.ReadBarCodes())
                    Console.WriteLine("BarCode CodeText: " + result.CodeText);
            }
            //ExEnd: QualitySettingWithManualOptionsHighPerformance
        }

        public static void ImproveDetectionByInverting()
        {
            //ExStart: ImproveDetectionByInverting
            using (BarCodeReader reader = new BarCodeReader(dataDir + "Scan.jpg", DecodeType.DataMatrix))
            {
                reader.QualitySettings.AllowInvertImage = true;

                foreach (BarCodeResult result in reader.ReadBarCodes())
                    Console.WriteLine("BarCode CodeText: " + result.CodeText);
            }
            //ExEnd: ImproveDetectionByInverting
        }
    }
}
