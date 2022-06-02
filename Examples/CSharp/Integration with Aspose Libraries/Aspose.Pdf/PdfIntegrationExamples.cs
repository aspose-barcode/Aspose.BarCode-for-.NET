//Copyright(c) 2001-2022 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET

namespace Aspose.BarCode.Examples.CSharp.Integration
{
    internal class PdfIntegrationExamples
    {
		public static void Run()
        {
            //// =====================================================
            //// =====================================================
            ////  Integration with Aspose Components: Aspose.PDF
            //// =====================================================
            //// =====================================================            
            AddBarcodeToPDFDocumentDirectly.Run();
            AddBarcodeToPDFDocumentWithFacades.Run();
            AddBarcodeToPDFDocumentWithOperators.Run();
            RecognizeBarcodesFromPDFDocumentWithPdfConverter.Run();
            RecognizeBarcodesFromPDFDocumentWithPngDevice.Run();
            RecognizeBarcodesFromPDFDocumentWithPageDirectRendering.Run();
            RecognizeBarcodesFromPDFDocumentFromExtractedImages.Run();
        }
    }
}