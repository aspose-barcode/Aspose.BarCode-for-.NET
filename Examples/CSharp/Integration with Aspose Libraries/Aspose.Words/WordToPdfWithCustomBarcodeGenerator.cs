//Copyright(c) 2001-2026 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using Aspose.BarCode.Utils;

namespace Aspose.BarCode.Examples.CSharp.Integration
{
    internal class WordToPdfWithCustomBarcodeGenerator: WordIntegrationBase
    {
		public static void Run()
        {
            string path = GetWriteFolder();
            Console.WriteLine("WordToPdfWithCustomBarcodeGenerator:");

            Aspose.Words.Document wordDoc = new Aspose.Words.Document();
            Aspose.Words.DocumentBuilder wordBuilder = new Aspose.Words.DocumentBuilder(wordDoc);
            //set up CustomBarcodeGenerator
            wordDoc.FieldOptions.BarcodeGenerator = new CustomBarcodeGenerator();

            wordBuilder.Write("Header\n");
            wordBuilder.InsertField("DISPLAYBARCODE “Aspose.Barcode” QR \\q 3");
            wordBuilder.Write("\nFooter.");

            wordDoc.Save($"{path}WordToPdfWithCustomBarcodeGenerator.docx", Aspose.Words.SaveFormat.Docx);

            Aspose.Words.Saving.PdfSaveOptions pso = new Aspose.Words.Saving.PdfSaveOptions();
            pso.Compliance = Aspose.Words.Saving.PdfCompliance.Pdf17;

            wordDoc.Save($"{path}WordToPdfWithCustomBarcodeGenerator.pdf", pso);
        }
    }
}