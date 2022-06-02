//Copyright(c) 2001-2022 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET

namespace Aspose.BarCode.Examples.CSharp.BarcodeRecognition
{
    internal class ReadDecodingExamples
    {
		public static void Run()
        {
            //// =====================================================
            //// =====================================================
            ////  BarcodeRecognition: DecodingSettings 
            //// =====================================================
            //// =====================================================
            ReadChecksumCode11.Run();
            ReadChecksumCode39.Run();
            ReadDetectEncoding.Run();
            ReadWithStripFNC.Run();

            ReadAustraliaPostNTable.Run();
            ReadAustraliaPostCTable.Run();
            ReadAustraliaPostOther.Run();
            ReadAustraliaPostCTableIgnoreEnding.Run();
            ReadAustraliaPostCustomerInformationDecoder.Run();
        }
    }
}