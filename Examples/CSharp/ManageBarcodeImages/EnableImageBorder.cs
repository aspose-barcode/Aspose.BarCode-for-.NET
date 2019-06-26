using Aspose.BarCode.Examples.CSharp;
using Aspose.BarCode.Generation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.BarCode.Examples.CSharp.ManageBarCodeImages
{
    class EnableImageBorder
    {
        public static void Run()
        {
            // ExStart:EnableImageBorder 
            // For complete examples and data files, please go to https://github.com/aspose-barcode/Aspose.BarCode-for-.NET

            // Instantiate barcode object and Enable border to be shown in the barcode
            BarcodeGenerator generator = new BarcodeGenerator(EncodeTypes.Code93Standard);
            generator.Parameters.Border.Visible = true;
            // ExEnd:EnableImageBorder 
        }
    }
}
