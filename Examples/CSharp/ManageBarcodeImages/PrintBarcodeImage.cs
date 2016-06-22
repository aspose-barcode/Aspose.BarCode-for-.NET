using System.IO;
using Aspose.BarCode;
using System;
using System.Drawing.Printing;

namespace Aspose.BarCode.Examples.CSharp.ManageBarCodeImages
{
    class PrintBarcodeImage
    {
        public static void Run()
        {
            //ExStart:PrintBarcodeImage
            // Get the default Printer Name
            PrinterSettings settings = new PrinterSettings();

            string printerName = settings.PrinterName;

            // Create instance of BarCodeBuilder, specify codetext and symbology in the constructor
            BarCodeBuilder builder = new BarCodeBuilder("12345678", Symbology.Code128);

            // Set printer name
            builder.PrinterName = printerName;

            builder.Print();
            //ExEnd:PrintBarcodeImage
        }
    }
}
