//Copyright(c) 2001-2022 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET

namespace Aspose.BarCode.Examples.CSharp.Symbologies
{
    internal class SymbologyExamples
    {
		public static void Run()
        {
            //// =====================================================
            //// =====================================================
            //// Symbologies :
            //// =====================================================
            //// =====================================================
            QR_Type.Run();
            MicroQR_Type.Run();
            
            DataMatrix_Type.Run();
            
            AztecFull_Type.Run();
            AztecCompact_Type.Run();
            AztecRune_Type.Run();
            
            PDF417Basic_Type.Run();
            CompactPDF417_Type.Run();
            MacroPDF417_Type.Run();
            MicroPDF417_Type.Run();
            
            Code128_Type.Run();
            Code39_Type.Run();

            DataBarOmniDirectional_Type.Run();
            DataBarOmniDirectionalStacked_Type.Run();
            DataBarTruncated_Type.Run();
            DataBarStacked_Type.Run();
            DataBarLimited_Type.Run();
            DataBarExpanded_Type.Run();
            DataBarExpandedStacked_Type.Run();
        }
    }
}