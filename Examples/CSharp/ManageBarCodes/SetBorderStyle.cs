using Aspose.BarCode;
using Aspose.BarCode.Generation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp.ManageBarCodes
{
    class SetBorderStyle
    {
        public static void Run()
        {
            //ExStart:SetBorderStyle
            // For complete examples and data files, please go to https://github.com/aspose-barcode/Aspose.BarCode-for-.NET

            // Instantiate barcode object and Set border style to solid
            BarcodeGenerator generator = new BarcodeGenerator(EncodeTypes.Code93Standard);
            generator.Parameters.Border.DashStyle = BorderDashStyle.Solid;
            //ExEnd:SetBorderStyle
        }
    }
}
