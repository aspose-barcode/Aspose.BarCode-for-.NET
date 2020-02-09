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

namespace Aspose.BarCode.Examples.CSharp.RecognitionExamples
{
    class BarCodeRecognitionFilters
    {
        public static string dataDir = RunExamples.GetDataDir_Recognition();

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
                //set high performance mode
                reader.QualitySettings = QualitySettings.HighPerformance;
                while (reader.Read())
                    Console.WriteLine("BarCode CodeText: " + reader.GetCodeText());
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
                while (reader.Read())
                    Console.WriteLine("BarCode CodeText: " + reader.GetCodeText());
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
                while (reader.Read())
                    Console.WriteLine("BarCode CodeText: " + reader.GetCodeText());
            }
            //ExEnd: QualitySettingWithManualOptionsHighPerformance
        }

        public static void ImproveDetectionByInverting()
        {
            //ExStart: ImproveDetectionByInverting
            using (BarCodeReader reader = new BarCodeReader(dataDir + "Scan.jpg", DecodeType.DataMatrix))
            {
                reader.QualitySettings.AllowInvertImage = true;
                
                while (reader.Read())
                    Console.WriteLine("BarCode CodeText: " + reader.GetCodeText());
            }
            //ExEnd: ImproveDetectionByInverting
        }
    }
}
