using System.IO;
using Aspose.BarCode;
using System;
using System.Drawing.Printing;
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.ManageBarCodeImages
{
    class PrintBarcodeImage
    {
        public static void Run()
        {
            // Get the default Printer Name
            PrinterSettings settings = new PrinterSettings();
            string printerName = settings.PrinterName;

            // Instantiate barcode object and set CodeText & Barcode Symbology
            BarCodeBuilder barCodeBuilder = new BarCodeBuilder("1234567890", EncodeTypes.Code128);

            // Set printer name
            barCodeBuilder.PrinterName = printerName;
            barCodeBuilder.Print();
        }
    }
}
