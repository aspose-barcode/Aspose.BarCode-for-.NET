//Copyright(c) 2001-2022 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET

namespace Aspose.BarCode.Examples.CSharp.BarcodeRecognition
{
    internal class ReadMultiThreadingExamples
    {
		public static void Run()
        {
            //cold run
            InitMTColdRun.Run();

            //// =====================================================
            //// =====================================================
            ////  BarcodeRecognition: ProcessorSettings
            //// =====================================================
            //// =====================================================
            ReadMTSingleCore.Run();
            ReadMTRestrictedCores.Run();
            ReadMTAllCores.Run();
        }
    }
}