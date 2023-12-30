//Copyright(c) 2001-2023 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using Aspose.BarCode.Generation;
using Aspose.BarCode.BarCodeRecognition;
#if NETSTANDARD2_0_OR_GREATER || NETCOREAPP2_1_OR_GREATER
using Aspose.Drawing;
#else
using System.Drawing;
#endif

namespace Aspose.BarCode.Examples.CSharp.KnowledgeBase
{
    internal class SwissPostAdditionalService: SwissPostParcelBase
    {
        public static void Run()
        {
            string path = GetWriteFolder();
            Console.WriteLine("SwissPostAdditionalService:");
            BarcodeGenerator gen;

            //Additional Service codes are:
            //Personal delivery(RMP) 0322
            //Return receipt (AR) 0327
            //Cash on delivery(currently obsolete) 0340
            //Electronic cash on delivery (BLN) 0341
            //Items for the blind (CEC) 0610
            //Military mail (MIL) 1007
            //Second attempted delivery on the  following Saturday 2512
            //Electronic return receipt(eAR) 0328
            //ID check(ID+RMP) 0470
            //Business reply label(GAS) 0203

            //generate Swiss Post Additional Service barcode
            gen = new BarcodeGenerator(EncodeTypes.SwissPostParcel, "0327");
            gen.Parameters.Barcode.XDimension.Pixels = 2;
            gen.Parameters.Barcode.BarHeight.Pixels = 40;
            gen.Parameters.Barcode.CodeTextParameters.Location = CodeLocation.None;
            gen.Parameters.CaptionAbove.Visible = true;
            gen.Parameters.CaptionAbove.Alignment = TextAlignment.Left;
            gen.Parameters.CaptionAbove.Text = "AR";
            gen.Parameters.CaptionAbove.Font.Size.Pixels = 24;
            gen.Parameters.CaptionAbove.Font.Style = FontStyle.Bold;
            gen.Save($"{path}SwissPostAdditionalServiceAsIs.png", BarCodeImageFormat.Png);
            //read the current barcode value
            foreach (BarCodeResult result in new BarCodeReader(gen.GenerateBarCodeImage(), DecodeType.SwissPostParcel).ReadBarCodes())
                Console.WriteLine($"Barcode type:{result.CodeTypeName}, Barcode Data:{result.CodeText}");

            //generate Swiss Post Additional Service barcode as Code128 symbology
            gen = new BarcodeGenerator(EncodeTypes.Code128, "0327");
            gen.Parameters.Barcode.XDimension.Pixels = 2;
            gen.Parameters.Barcode.BarHeight.Pixels = 40;
            gen.Parameters.Barcode.CodeTextParameters.Location = CodeLocation.None;
            gen.Parameters.CaptionAbove.Visible = true;
            gen.Parameters.CaptionAbove.Alignment = TextAlignment.Left;
            gen.Parameters.CaptionAbove.Text = "AR";
            gen.Parameters.CaptionAbove.Font.Size.Pixels = 24;
            gen.Parameters.CaptionAbove.Font.Style = FontStyle.Bold;
            gen.Save($"{path}SwissPostAdditionalServiceAsCode128.png", BarCodeImageFormat.Png);
            //read the current barcode value
            foreach (BarCodeResult result in new BarCodeReader(gen.GenerateBarCodeImage(), DecodeType.SwissPostParcel).ReadBarCodes())
                Console.WriteLine($"Barcode type:{result.CodeTypeName}, Barcode Data:{result.CodeText}");
        }
	}
}