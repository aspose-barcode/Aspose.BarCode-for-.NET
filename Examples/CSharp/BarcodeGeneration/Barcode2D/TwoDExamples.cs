//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class TwoDExamples
    {
		public static void Run()
        {
            //// =====================================================
            //// =====================================================
            ////  Barcode Generation: QR code
            //// =====================================================
            //// =====================================================
            QREncodeTypeExample.Run();
            QRVersionExample.Run();

            QrEncodeModeAuto.Run();
            QrEncodeModeBytes.Run();
            QrEncodeModeUtfBOM.Run();
            QrEncodeModeECIEncoding.Run();
            QrEncodeModeExtendedCodetext.Run();

            QrErrorLevel.Run();
            QrStructuredAppend.Run();
            QrAspectRatio.Run();

            //// =====================================================
            //// =====================================================
            ////  Barcode Generation: PDF417
            //// =====================================================
            //// =====================================================
            Pdf417Basic.Run();
            MicroPdf417Basic.Run();
            CompactPdf417Basic.Run();
            Pdf417ECIEncoding.Run();
            Pdf417Compaction.Run();
            Pdf417CodeTextEncoding.Run();
            Pdf417RowColumns.Run();
            MicroPdf417RowColumns.Run();
            Pdf417AspectRatio.Run();
            Pdf417ErrorLevelExample.Run();
            MacroPdf417Permanent.Run();
            MacroPdf417Optional.Run();
            MacroPdf417ECIEncoding.Run();
            Pdf417ReaderInitialization.Run();
            Pdf417Code128Emulation.Run();
            Pdf417BytesEncoding.Run();

            //// =====================================================
            //// =====================================================
            ////  Barcode Generation: Aztec
            //// =====================================================
            //// =====================================================
            AztecSymbolModeExample.Run();
            AztecBytesEncoding.Run();
            AztecCodeTextEncoding.Run();
            AztecErrorLevelExample.Run();
            AztecAspectRatio.Run();

            //// =====================================================
            //// =====================================================
            ////  Barcode Generation: DataMatrix
            //// =====================================================
            //// =====================================================
            DatamatrixEcc000140.Run();
            DatamatrixEcc200.Run();
            DatamatrixEncodeModeAuto.Run();
            DatamatrixEncodeModeFullBytes.Run();
            DatamatrixEncodeModeCustom.Run();
            DatamatrixEncodeModeC40.Run();
            DatamatrixExtendedCodetext.Run();
            DatamatrixRowsColumnsEcc200.Run();
            DatamatrixMacro.Run();
            DatamatrixAspectRatio.Run();

            //// =====================================================
            //// =====================================================
            ////  Barcode Generation: Maxicode
            //// =====================================================
            //// =====================================================
            MaxiCodeEncodeMode2.Run();
            MaxiCodeEncodeMode4.Run();
            MaxiCodeAspectRatio.Run();
        }
    }
}