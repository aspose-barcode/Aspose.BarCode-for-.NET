using Aspose.BarCode.Generation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.BarCode.Examples.CSharp.ManageBarCodes
{
    class BorderWidth
    {
        public static void Run()
        {
            // ExStart:BorderWidth 
            // For complete examples and data files, please go to https://github.com/aspose-barcode/Aspose.BarCode-for-.NET

            // Instantiate barcode object and Set border width
            BarcodeGenerator generator = new BarcodeGenerator(EncodeTypes.Code93Standard);
            generator.Parameters.Border.Width.Millimeters = 0.5f;
            // ExEnd:BorderWidth 
        }
    }
}
