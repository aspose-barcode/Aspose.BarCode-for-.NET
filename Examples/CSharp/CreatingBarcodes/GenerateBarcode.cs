using Aspose.BarCode;
using Aspose.BarCode.Examples.CSharp;
using Aspose.BarCode.Generation;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace CSharp.GenerateBarcode
{
    public class GenerateBarcode
    {
        public static string dataDir = RunExamples.GetDataDir_CreateAndManage2DBarCodes();

        public static void Run()
        {
            //GenerateBarcodeWithRestrictedBarcodeSize();

            //GenerateBarcodeWithoutRestrictedBarcodeSize();

            //GetGeneratedBarcodeSize();

            //UnitBasedBarcodeGenerateion();

            //GettingDefaultCodeTextForGeneratedBarcode();

            //ImplementUpcaGs1DatabarCouponForNewBarcode();

            //ImplementUpcaGs1DatabarCouponWithAutoSizeModeInterpolation();

            //ImplementInterpolationAutoSizemode();

            //GenerateCode16KBarCode();

            //ImplementMaxiCodeForBarcode();

            //ImplementDotCodeForBarcode();

            //GS1DatamatrixBarcodeWithWrappingText();

            GenarateBarcodeWithRotationAndDpi();
        }

        public static void GenerateBarcodeWithRestrictedBarcodeSize()
        {
            //ExStart: GenerateBarcodeWithRestrictedBarcodeSize
            //If you have restricted requirements of barcode size, then you can set AutoSizeMode = Nearest 
            //and required barcode size. Barcode generator will calculate all other parameters like 
            //xDimension, AspectRatio, etc to fit barcode into desired size.
            using (BarCodeGenerator generator = new BarCodeGenerator(EncodeTypes.QR, "Aspose.BarCode sample"))
            {
                generator.AutoSizeMode = AutoSizeMode.Nearest;
                generator.BarCodeWidth.Pixels = 200;
                generator.BarCodeHeight.Pixels = 200;
                generator.Save(dataDir + "GenerateBarcodeWithRestrictedBarcodeSize_out.png");
            }
            //ExEnd: GenerateBarcodeWithRestrictedBarcodeSize
        }

        public static void GenerateBarcodeWithoutRestrictedBarcodeSize()
        {
            //ExStart: GenerateBarcodeWithoutRestrictedBarcodeSize
            // if you  don't have required size, you can use AutoSizeMode = None and set all generator parameters by yourself
            using (BarCodeGenerator generator = new BarCodeGenerator(EncodeTypes.QR, "Aspose.BarCode sample"))
            {
                generator.XDimension.Pixels = 3;
                generator.Margins.Left.Pixels = 20;
                generator.Margins.Right.Pixels = 20;
                generator.Save(dataDir + "GenerateBarcodeWithoutRestrictedBarcodeSize_out.png");
            }
            //ExEnd: GenerateBarcodeWithoutRestrictedBarcodeSize
        }

        public static void GetGeneratedBarcodeSize()
        {
            //ExStart: GetGeneratedBarcodeSize
            using (BarCodeGenerator generator = new BarCodeGenerator(EncodeTypes.QR, "Aspose.BarCode sample"))
            {
                generator.XDimension.Pixels = 3;
                generator.D2.AspectRatio = 1.5f;
                generator.RecalculateValues();
                Console.WriteLine("Width = " + generator.BarCodeWidth.Pixels);
                Console.WriteLine("Height = " + generator.BarCodeWidth.Pixels);
            }
            //ExEnd: GetGeneratedBarcodeSize
        }

        public static void UnitBasedBarcodeGenerateion()
        {
            //ExStart: UnitBasedBarcodeGenerateion
            using (BarCodeGenerator generator = new BarCodeGenerator(EncodeTypes.QR, "Aspose.BarCode sample"))
            {
                generator.AutoSizeMode = AutoSizeMode.Nearest;
                generator.BarCodeWidth.Millimeters = 20;
                generator.BarCodeHeight.Millimeters = 20;
                generator.Save(dataDir + "for_display_out.png");

                generator.Resolution = 300;
                generator.Save(dataDir + "for_printer_out.png");
            }
            //ExEnd: UnitBasedBarcodeGenerateion
        }

        public static void GroupingPropertiesByBarcodeType()
        {
            //ExStart: GroupingPropertiesByBarcodeType
            using (BarCodeGenerator generator = new BarCodeGenerator(EncodeTypes.QR))
            {
                generator.QR.Version = QRVersion.Version18;
                generator.QR.ErrorLevel = QRErrorLevel.LevelM;
                generator.Save(dataDir + "qr_out.png");
            }
            //ExEnd: GroupingPropertiesByBarcodeType
        }

        public static void GettingDefaultCodeTextForGeneratedBarcode()
        {
            //ExStart: GettingDefaultCodeTextForGeneratedBarcode
            using (BarCodeGenerator generator = new BarCodeGenerator(EncodeTypes.AustralianPosteParcel))
            {
                string codetext = generator.CodeText; //99712345678901234567890103456
            }

            using (BarCodeGenerator generator = new BarCodeGenerator(EncodeTypes.EAN13))
            {
                string codetext = generator.CodeText; //590123412345
            }
            //ExEnd: GettingDefaultCodeTextForGeneratedBarcode
        }

        public static void ImplementUpcaGs1DatabarCouponForNewBarcode()
        {
            //ExStart: ImplementUpcaGs1DatabarCouponForNewBarcode
            using (BarCodeGenerator generator = new BarCodeGenerator(EncodeTypes.UpcaGs1DatabarCoupon))
            {
                generator.Save(dataDir + "UpcaGs1DatabarCoupon.png");
            }
            //ExEnd: ImplementUpcaGs1DatabarCouponForNewBarcode
        }

        public static void ImplementUpcaGs1DatabarCouponWithAutoSizeModeInterpolation()
        {
            //ExStart: ImplementUpcaGs1DatabarCouponWithAutoSizeModeInterpolation
            using (BarCodeGenerator generator = new BarCodeGenerator(EncodeTypes.UpcaGs1Code128Coupon))
            {
                generator.CodeText = "514141100906(01)88898765432109";

                generator.AutoSizeMode = AutoSizeMode.Interpolation;
                generator.BarCodeWidth.Pixels = 500;
                generator.BarCodeHeight.Pixels = 200;

                generator.Save(dataDir + "UpcaGs1Code128Coupon_Interpolation_500x200.png");
            }
            //ExEnd: ImplementUpcaGs1DatabarCouponWithAutoSizeModeInterpolation
        }

        public static void ImplementInterpolationAutoSizemode()
        {
            //ExStart: ImplementInterpolationAutoSizemode
            using (BarCodeGenerator generator = new BarCodeGenerator(EncodeTypes.DataMatrix))
            {
                generator.AutoSizeMode = AutoSizeMode.Interpolation;
                generator.BarCodeWidth.Millimeters = 50;
                generator.BarCodeHeight.Inches = 1.3f;

                Bitmap barcode = generator.GenerateBarCodeImage();
                barcode.Save(dataDir + "DataMatrix.png");
            }
            //ExEnd: ImplementInterpolationAutoSizemode
        }

        public static void GenerateCode16KBarCode()
        {
            //ExStart: GenerateCode16KBarCode
            using (BarCodeGenerator generator = new BarCodeGenerator(EncodeTypes.Code16K))
            {
                generator.AutoSizeMode = AutoSizeMode.Nearest;
                generator.BarCodeWidth.Pixels = 100;
                generator.CodeTextStyle.Location = CodeLocation.None;
                generator.Save(dataDir + "Code16K_Nearest.png");
            }
            //ExEnd: GenerateCode16KBarCode
        }

        public static void ImplementMaxiCodeForBarcode()
        {
            //ExStart: ImplementMaxiCodeForBarcode
            using (BarCodeGenerator generator = new BarCodeGenerator(EncodeTypes.MaxiCode))
            {
                generator.MaxiCodeEncodeMode = 5;
                Bitmap barcode = generator.GenerateBarCodeImage();
                barcode.Save(dataDir + "MaxiCode.png");
            }
            //ExEnd: ImplementMaxiCodeForBarcode
        }

        public static void ImplementDotCodeForBarcode()
        {
            //ExStart: ImplementDotCodeForBarcode
            using (BarCodeGenerator generator = new BarCodeGenerator(EncodeTypes.DotCode))
            {
                generator.DotCodeMask = 2;
                Bitmap barcode = generator.GenerateBarCodeImage();
                barcode.Save(dataDir + "DotCode.png");
            }
            //ExEnd: ImplementDotCodeForBarcode
        }

        public static void GS1DatamatrixBarcodeWithWrappingText()
        {
            //ExStart: GS1DatamatrixBarcodeWithWrappingText
            string CODICE = "(90)0843110730<<<<452287005001T8";
            string displayedText = "(90)0843" + Environment.NewLine +
                                    "110730<<<<" + Environment.NewLine +
                                    "452287" + Environment.NewLine +
                                    "005001T8" + Environment.NewLine;

            using (BarCodeGenerator generator = new BarCodeGenerator(EncodeTypes.GS1DataMatrix))
            {
                generator.CodeText = CODICE;
                generator.CodeTextStyle.Location = CodeLocation.Right;
                generator.D2.DisplayText = displayedText;

                Bitmap barcode = generator.GenerateBarCodeImage();
                barcode.Save(dataDir + "Display2DText.png");
            }
            //ExEnd: GS1DatamatrixBarcodeWithWrappingText
        }

        public static void GenarateBarcodeWithRotationAndDpi()
        {
            //ExStart: GenarateBarcodeWithRotationAndDpi
            using (BarCodeGenerator generator = new BarCodeGenerator(EncodeTypes.Code128))
            {
                generator.Resolution = 144;
                generator.RotationAngle = 90;
                generator.Save(dataDir + "rotated_dpi144.png");
            }
            //ExEnd: GenarateBarcodeWithRotationAndDpi
        }
    }
}
