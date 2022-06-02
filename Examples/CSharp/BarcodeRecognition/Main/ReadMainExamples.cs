//Copyright(c) 2001-2022 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET

namespace Aspose.BarCode.Examples.CSharp.BarcodeRecognition
{
    internal class ReadMainExamples
    {
		public static void Run()
        {
            //// =====================================================
            //// =====================================================
            ////  BarcodeRecognition: Main
            //// =====================================================
            //// =====================================================
            ReadSimpleExample.Run();
            ReadFoundBarCodes.Run();
            ReadFromFile.Run();
            ReadSetBarCodeImageFromFile.Run();
            ReadFromBitmap.Run();
            ReadFromStream.Run();
            ReadDecodeTypeList.Run();
            ReadMultyDecodeType.Run();
            ReadTypes2D.Run();
            ReadRegion.Run();
            ReadSetBarCodeRegion.Run();
            ReadMultipleRegions.Run();
            ReadWithTimeout.Run();
        }
    }
}