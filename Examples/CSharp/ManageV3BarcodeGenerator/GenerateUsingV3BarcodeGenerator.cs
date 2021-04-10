using Aspose.BarCode.Examples.CSharp;
using Aspose.BarCode.Generation;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace CSharp.ManageV3BarcodeGenerator
{
    public class GenerateUsingV3BarcodeGenerator
    {
        public static string dataDir = RunExamples.GetDataDir_ManageV3BarcodeGenerator();

        public static void Run()
        {
            //  GenerateBarcode();
            //  GenerateBarcodeWithCodeText();
            //  GettingDefaultTextForGeneratedBarcode();
            //  SettingBarcodeHeight();
            //  SettingBarcodeProperties();
            //  SettingBarcodeBorder();
            //  GenerateBarcodeWithAutoSizeInterpolation();
            //  GenerateBarcodeWithCaptionAbove();
            GenerateBarcodeWithCaptionBelow();
        }

        public static void GenerateBarcode()
        {
            //ExStart: GenerateBarcode
            using (var generator = new Aspose.BarCode.Generation.BarcodeGenerator(EncodeTypes.ITF14))
            {
                generator.Save(dataDir + "GenerateBarcode_out.png");
            }
            //ExEnd: GenerateBarcode
        }

        public static void GenerateBarcodeWithCodeText()
        {
            //ExStart: GenerateBarcodeWithCodeText
            using (var generator = new Aspose.BarCode.Generation.BarcodeGenerator(EncodeTypes.ITF14, "1234567890"))
            {
                generator.Save(dataDir + "GenerateBarcodeWithCodeText_out.png");
            }
            //ExEnd: GenerateBarcodeWithCodeText
        }

        public static void GettingDefaultTextForGeneratedBarcode()
        {
            //ExStart: GettingDefaultTextForGeneratedBarcode
            using (var generator = new Aspose.BarCode.Generation.BarcodeGenerator(EncodeTypes.ITF14))
            {
                string codetext = generator.CodeText;
                Console.WriteLine(codetext);
            }
            //ExEnd: GettingDefaultTextForGeneratedBarcode
        }

        public static void SettingBarcodeHeight()
        {
            //ExStart: SettingBarcodeHeight
            using (var generator = new Aspose.BarCode.Generation.BarcodeGenerator(EncodeTypes.ITF14))
            {
                generator.CodeText = "123456789";
                generator.Parameters.Barcode.BarHeight.Pixels = 500;
                generator.Save(dataDir + "SettingBarcodeHeight_out.png");
            }
            //ExEnd: SettingBarcodeHeight
        }

        public static void SettingBarcodeProperties()
        {
            //ExStart: SettingBarcodeProperties
            using (var gen = new Aspose.BarCode.Generation.BarcodeGenerator(EncodeTypes.ITF14))
            {
                gen.CodeText = "123456789";
                gen.Parameters.BackColor = Color.DarkBlue;
                gen.Parameters.Barcode.XDimension.Pixels = 5;
                gen.Parameters.Barcode.BarHeight.Pixels = 200;
                gen.Parameters.Barcode.Padding.Top.Pixels = 70;
                gen.Parameters.Barcode.Padding.Bottom.Pixels = 70;
                gen.Parameters.Barcode.Padding.Left.Pixels = 70;
                gen.Parameters.Barcode.Padding.Right.Pixels = 70;
                gen.Save(dataDir + "SettingBarcodeProperties_out.png");
            }
            //ExEnd: SettingBarcodeProperties
        }

        public static void SettingBarcodeBorder()
        {
            //ExStart: SettingBarcodeBorder
            using (var gen = new Aspose.BarCode.Generation.BarcodeGenerator(EncodeTypes.ITF14))
            {
                gen.CodeText = "123456789";
                gen.Parameters.Border.Width.Pixels = 50;
                gen.Parameters.Border.Color = Color.Red;
                gen.Parameters.Border.Visible = true;
                gen.Parameters.Border.DashStyle = BorderDashStyle.Solid;
                gen.Save(dataDir + "SettingBarcodeBorder_out.png");
            }
            //ExEnd: SettingBarcodeBorder
        }

        public static void GenerateBarcodeWithAutoSizeInterpolation()
        {
            //ExStart: GenerateBarcodeWithAutoSizeInterpolation
            using (var gen = new Aspose.BarCode.Generation.BarcodeGenerator(EncodeTypes.ITF14))
            {
                gen.CodeText = "123456789";
                gen.Parameters.AutoSizeMode = AutoSizeMode.Interpolation;
                gen.Parameters.ImageWidth.Pixels = 500;
                gen.Parameters.ImageHeight.Pixels = 200;
                gen.Save(dataDir + "GenerateBarcodeWithAutoSizeInterpolation_out.png");
            }
            //ExEnd: GenerateBarcodeWithAutoSizeInterpolation
        }

        public static void GenerateBarcodeWithCaptionAbove()
        {
            //ExStart: GenerateBarcodeWithCaptionAbove
            using (var gen = new Aspose.BarCode.Generation.BarcodeGenerator(EncodeTypes.ITF14))
            {
                gen.CodeText = "123456789";
                gen.Parameters.CaptionAbove.Padding.Top.Pixels = 70;
                gen.Parameters.CaptionAbove.Padding.Bottom.Pixels = 70;
                gen.Parameters.CaptionAbove.Padding.Left.Pixels = 50;
                gen.Parameters.CaptionAbove.Padding.Right.Pixels = 50;
                gen.Parameters.CaptionAbove.Text = "Caption Above";
                gen.Parameters.CaptionAbove.TextColor = Color.Red;
                gen.Parameters.CaptionAbove.Font.Size.Pixels = 28;
                gen.Parameters.CaptionAbove.Visible = true;
                gen.Parameters.CaptionAbove.Alignment = TextAlignment.Center;
                gen.Save(dataDir + "GenerateBarcodeWithCaptionAbove_out.png");
            }
            //ExEnd: GenerateBarcodeWithCaptionAbove
        }

        public static void GenerateBarcodeWithCaptionBelow()
        {
            //ExStart: GenerateBarcodeWithCaptionBelow
            using (var gen = new Aspose.BarCode.Generation.BarcodeGenerator(EncodeTypes.ITF14))
            {
                gen.CodeText = "123456789";
                gen.Parameters.CaptionBelow.Padding.Top.Pixels = 70;
                gen.Parameters.CaptionBelow.Padding.Bottom.Pixels = 70;
                gen.Parameters.CaptionBelow.Padding.Left.Pixels = 50;
                gen.Parameters.CaptionBelow.Padding.Right.Pixels = 50;
                gen.Parameters.CaptionBelow.Text = "Caption Below";
                gen.Parameters.CaptionBelow.TextColor = Color.Red;
                gen.Parameters.CaptionBelow.Font.Size.Pixels = 28;
                gen.Parameters.CaptionBelow.Visible = true;
                gen.Parameters.CaptionBelow.Alignment = TextAlignment.Center;
                gen.Save(dataDir + "GenerateBarcodeWithCaptionBelow_out.png");
            }
            //ExEnd: GenerateBarcodeWithCaptionBelow
        }
    }
}
