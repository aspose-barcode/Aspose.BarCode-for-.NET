using Aspose.BarCode.Generation;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Aspose.BarCode.Examples.CSharp.TechnicalArticles
{
    class SaveBarCodeToMemoryStream
    {
        public static void Run()
        {
            // ExStart:SaveBarCodeToMemoryStream
            // For complete examples and data files, please go to https://github.com/aspose-barcode/Aspose.BarCode-for-.NET

            // Instantiate linear barcode object, Set the Code text and symbology type for the barcode
            BarcodeGenerator generator = new BarcodeGenerator(EncodeTypes.Code128, "1234567");

            // Creating memory stream and Saving barcode image to memory stream
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            generator.Save(ms, BarCodeImageFormat.Bmp);
            // ExEnd:SaveBarCodeToMemoryStream
            Console.WriteLine(Environment.NewLine + "Save BarCode To MemoryStream Finished.");
        }

    }
}
