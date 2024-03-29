//Copyright(c) 2001-2024 Aspose Pty Ltd.All rights reserved.
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
            QrVersionExample.Run();
            QrMicroQRVersion.Run();
            QrRectMIcroQRVersion.Run();

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
            CompactPdf417Basic.Run();
            MicroPdf417Basic.Run();
            Pdf417RowColumns.Run();
            MicroPdf417RowColumns.Run();
            Pdf417AspectRatio.Run();
            MicroPdf417AspectRatio.Run();
            Pdf417ECIEncoding.Run();
            Pdf417Compaction.Run();
            Pdf417CodeTextEncoding.Run();
            Pdf417BytesEncoding.Run();
            Pdf417ErrorLevelExample.Run();
            MacroPdf417Main.Run();
            MacroPdf417Optional.Run();
            MacroPdf417ECIEncoding.Run();
            GS1MicroPdf417Mode903To905.Run();
            GS1MicroPdf417Mode906And907.Run();
            GS1MicroPdf417Mode912.Run();
            GS1MicroPdf417Mode914And915.Run();
            Pdf417ReaderInitialization.Run();
            Pdf417IsLinked.Run();
            MicroPdf417IsCode128Emulation.Run();
            MicroPdf417MacroCharacters.Run();

            //// =====================================================
            //// =====================================================
            ////  Barcode Generation: Aztec
            //// =====================================================
            //// =====================================================
            AztecEncodeModeAuto.Run();
            AztecEncodeModeBytes.Run();
            AztecEncodeModeExtendedCodetext.Run();
            AztecErrorLevelExample.Run();
            AztecLayersCount.Run();
            AztecReaderInitialization.Run();
            AztecStructuredAppendMode.Run();
            AztecSymbolModeExample.Run();
            AztecAspectRatio.Run();

            //// =====================================================
            //// =====================================================
            ////  Barcode Generation: DataMatrix
            //// =====================================================
            //// =====================================================
            DataMatrixAspectRatio.Run();
            DataMatrixEcc000140.Run();
            DataMatrixEcc200.Run();
            DataMatrixEncodeModeASCII.Run();
            DataMatrixEncodeModeAuto.Run();
            DataMatrixEncodeModeBytes.Run();
            DataMatrixEncodeModeC40.Run();
            DataMatrixExtendedCodetext.Run();
            DataMatrixMacro.Run();
            DataMatrixReaderProgramming.Run();
            DataMatrixStructuredAppend.Run();
            DataMatrixVersions.Run();

            //// =====================================================
            //// =====================================================
            ////  Barcode Generation: Maxicode
            //// =====================================================
            //// =====================================================
            MaxiCodeAspectRatio.Run();
            MaxiCodeEncodeModeAuto.Run();
            MaxiCodeEncodeModeBytes.Run();
            MaxiCodeEncodeModeExtendedCodetext.Run();
            MaxiCodeMode2.Run();
            MaxiCodeMode4.Run();
            MaxiCodeStructuredAppendMode.Run();

            //// =====================================================
            //// =====================================================
            ////  Barcode Generation: DotCode
            //// =====================================================
            //// =====================================================
            DotCodeRowsColumns.Run();
            DotCodeAspectRatio.Run();
            DotCodeStructuredAppendMode.Run();
            DotCodeEncodeModeAuto.Run();
            DotCodeEncodeModeBytes.Run();
            DotCodeReaderInitialization.Run();
            DotCodeExtendedCodetext.Run();

            //// =====================================================
            //// =====================================================
            ////  Barcode Generation: GS1CompositeBar
            //// =====================================================
            //// =====================================================
            GS1CompositeLinearComponent.Run();
            GS1CompositeTwoDComponent.Run();
            GS1CompositeNotGS1TwoDSupplement.Run();
            GS1CompositeEncodationModes.Run();
        }
    }
}