using Aspose.BarCode;
using Aspose.BarCode.Examples.CSharp;
using Aspose.BarCode.Generation;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Aspose.BarCode.Examples.CSharp.CreateAndManageTwoDBarcodes
{
    public class GenerateCustomBarcodes
    {
        public static string dataDir = RunExamples.GetDataDir_CreateAndManage2DBarCodes();

        public static void Run()
        {
            GenerateBarcodeWithRestrictedBarcodeSize();

            GenerateBarcodeWithoutRestrictedBarcodeSize();

            GetGeneratedBarcodeSize();

            UnitBasedBarcodeGenerateion();

            GettingDefaultCodeTextForGeneratedBarcode();

            ImplementUpcaGs1DatabarCouponForNewBarcode();

            ImplementUpcaGs1DatabarCouponWithAutoSizeModeInterpolation();

            ImplementInterpolationAutoSizemode();

            GenerateCode16KBarCode();

            ImplementMaxiCodeForBarcode();

            ImplementDotCodeForBarcode();

            GS1DatamatrixBarcodeWithWrappingText();

            GenarateBarcodeWithRotationAndDpi();
        }

        public static void GenerateBarcodeWithRestrictedBarcodeSize()
        {
            //ExStart: GenerateBarcodeWithRestrictedBarcodeSize
            //If you have restricted requirements of barcode size, then you can set AutoSizeMode = Nearest 
            //and required barcode size. Barcode generator will calculate all other parameters like 
            //xDimension, AspectRatio, etc to fit barcode into desired size.
            using (BarcodeGenerator  generator = new BarcodeGenerator (EncodeTypes.QR, "Aspose.BarCode sample"))
            {
                generator.Parameters.Barcode.AutoSizeMode = AutoSizeMode.Nearest;
                generator.Parameters.Barcode.BarCodeWidth.Pixels = 200;
                generator.Parameters.Barcode.BarCodeHeight.Pixels = 200;
                generator.Save(dataDir + "GenerateBarcodeWithRestrictedBarcodeSize_out.png");
            }
            //ExEnd: GenerateBarcodeWithRestrictedBarcodeSize
            Console.WriteLine(Environment.NewLine + "Barcode saved at " + dataDir + "GenerateBarcodeWithRestrictedBarcodeSize_out.png");
        }

        public static void GenerateBarcodeWithoutRestrictedBarcodeSize()
        {
            //ExStart: GenerateBarcodeWithoutRestrictedBarcodeSize
            // if you  don't have required size, you can use AutoSizeMode = None and set all generator parameters by yourself
            using (BarcodeGenerator  generator = new BarcodeGenerator (EncodeTypes.QR, "Aspose.BarCode sample"))
            {
                generator.Parameters.Barcode.XDimension.Pixels = 3;
                generator.Parameters.Barcode.Padding.Left.Pixels = 20;
                generator.Parameters.Barcode.Padding.Right.Pixels = 20;
                generator.Save(dataDir + "GenerateBarcodeWithoutRestrictedBarcodeSize_out.png");
            }
            //ExEnd: GenerateBarcodeWithoutRestrictedBarcodeSize
            Console.WriteLine(Environment.NewLine + "Barcode saved at " + dataDir + "GenerateBarcodeWithoutRestrictedBarcodeSize_out.png");
        }

        public static void GetGeneratedBarcodeSize()
        {
            //ExStart: GetGeneratedBarcodeSize
            using (BarcodeGenerator  generator = new BarcodeGenerator (EncodeTypes.QR, "Aspose.BarCode sample"))
            {
                generator.Parameters.Barcode.XDimension.Pixels = 3;
                generator.Parameters.Barcode.QR.AspectRatio = 1.5f;
                //generator.RecalculateValues();
                Console.WriteLine("Width = " + generator.Parameters.Barcode.BarCodeWidth.Pixels);
                Console.WriteLine("Height = " + generator.Parameters.Barcode.BarCodeWidth.Pixels);
            }
            //ExEnd: GetGeneratedBarcodeSize
        }

        public static void UnitBasedBarcodeGenerateion()
        {
            //ExStart: UnitBasedBarcodeGenerateion
            using (BarcodeGenerator  generator = new BarcodeGenerator (EncodeTypes.QR, "Aspose.BarCode sample"))
            {
                generator.Parameters.Barcode.AutoSizeMode = AutoSizeMode.Nearest;
                generator.Parameters.Barcode.BarCodeWidth.Millimeters = 20;
                generator.Parameters.Barcode.BarCodeHeight.Millimeters = 20;
                generator.Save(dataDir + "for_display_out.png");

                generator.Parameters.Resolution = 300;
                generator.Save(dataDir + "for_printer_out.png");
            }
            //ExEnd: UnitBasedBarcodeGenerateion
            Console.WriteLine(Environment.NewLine + "Barcode saved at " + dataDir + "for_printer_out.png");
        }

        public static void GroupingPropertiesByBarcodeType()
        {
            //ExStart: GroupingPropertiesByBarcodeType
            using (BarcodeGenerator  generator = new BarcodeGenerator (EncodeTypes.QR))
            {
                generator.Parameters.Barcode.QR.QrVersion = QRVersion.Version18;
                generator.Parameters.Barcode.QR.QrErrorLevel = QRErrorLevel.LevelM;
                generator.Save(dataDir + "qr_out.png");
            }
            //ExEnd: GroupingPropertiesByBarcodeType
            Console.WriteLine(Environment.NewLine + "Barcode saved at " + dataDir + "qr_out.png");
        }

        public static void GettingDefaultCodeTextForGeneratedBarcode()
        {
            //ExStart: GettingDefaultCodeTextForGeneratedBarcode
            using (BarcodeGenerator  generator = new BarcodeGenerator (EncodeTypes.AustralianPosteParcel))
            {
                string codetext = generator.CodeText; //99712345678901234567890103456
            }

            using (BarcodeGenerator  generator = new BarcodeGenerator (EncodeTypes.EAN13))
            {
                string codetext = generator.CodeText; //590123412345
            }
            //ExEnd: GettingDefaultCodeTextForGeneratedBarcode
        }

        public static void ImplementUpcaGs1DatabarCouponForNewBarcode()
        {
            //ExStart: ImplementUpcaGs1DatabarCouponForNewBarcode
            using (BarcodeGenerator  generator = new BarcodeGenerator (EncodeTypes.UpcaGs1DatabarCoupon))
            {
                generator.Save(dataDir + "UpcaGs1DatabarCoupon.png");
            }
            //ExEnd: ImplementUpcaGs1DatabarCouponForNewBarcode
            Console.WriteLine(Environment.NewLine + "Barcode saved at " + dataDir + "UpcaGs1DatabarCoupon.png");
        }

        public static void ImplementUpcaGs1DatabarCouponWithAutoSizeModeInterpolation()
        {
            //ExStart: ImplementUpcaGs1DatabarCouponWithAutoSizeModeInterpolation
            using (BarcodeGenerator  generator = new BarcodeGenerator (EncodeTypes.UpcaGs1Code128Coupon))
            {
                generator.CodeText = "514141100906(01)88898765432109";

                generator.Parameters.Barcode.AutoSizeMode = AutoSizeMode.Interpolation;
                generator.Parameters.Barcode.BarCodeWidth.Pixels = 500;
                generator.Parameters.Barcode.BarCodeHeight.Pixels = 200;

                generator.Save(dataDir + "UpcaGs1Code128Coupon_Interpolation_500x200.png");
            }
            //ExEnd: ImplementUpcaGs1DatabarCouponWithAutoSizeModeInterpolation
            Console.WriteLine(Environment.NewLine + "Barcode saved at " + dataDir + "UpcaGs1Code128Coupon_Interpolation_500x200.png");
        }

        public static void ImplementInterpolationAutoSizemode()
        {
            //ExStart: ImplementInterpolationAutoSizemode
            using (BarcodeGenerator  generator = new BarcodeGenerator (EncodeTypes.DataMatrix))
            {
                generator.Parameters.Barcode.AutoSizeMode = AutoSizeMode.Interpolation;
                generator.Parameters.Barcode.BarCodeWidth.Millimeters = 50;
                generator.Parameters.Barcode.BarCodeHeight.Inches = 1.3f;

                Bitmap barcode = generator.GenerateBarCodeImage();
                barcode.Save(dataDir + "DataMatrix.png");
            }
            //ExEnd: ImplementInterpolationAutoSizemode
            Console.WriteLine(Environment.NewLine + "Barcode saved at " + dataDir + "DataMatrix.png");
        }

        public static void GenerateCode16KBarCode()
        {
            //ExStart: GenerateCode16KBarCode
            using (BarcodeGenerator  generator = new BarcodeGenerator (EncodeTypes.Code16K))
            {
                generator.Parameters.Barcode.AutoSizeMode = AutoSizeMode.Nearest;
                generator.Parameters.Barcode.BarCodeWidth.Pixels = 100;
                generator.Parameters.Barcode.CodeTextParameters.Location = CodeLocation.None;
                generator.Save(dataDir + "Code16K_Nearest.png");
            }
            //ExEnd: GenerateCode16KBarCode
            Console.WriteLine(Environment.NewLine + "Barcode saved at " + dataDir + "Code16K_Nearest.png");
        }

        public static void ImplementMaxiCodeForBarcode()
        {
            //ExStart: ImplementMaxiCodeForBarcode
            using (BarcodeGenerator  generator = new BarcodeGenerator (EncodeTypes.MaxiCode))
            {
                generator.Parameters.Barcode.MaxiCode.MaxiCodeEncodeMode = 5;
                Bitmap barcode = generator.GenerateBarCodeImage();
                barcode.Save(dataDir + "MaxiCode.png");
            }
            //ExEnd: ImplementMaxiCodeForBarcode
            Console.WriteLine(Environment.NewLine + "Barcode saved at " + dataDir + "MaxiCode.png");
        }

        public static void ImplementDotCodeForBarcode()
        {
            //ExStart: ImplementDotCodeForBarcode
            using (BarcodeGenerator  generator = new BarcodeGenerator (EncodeTypes.DotCode))
            {
                generator.Parameters.Barcode.DotCode.DotCodeMask = 2;
                Bitmap barcode = generator.GenerateBarCodeImage();
                barcode.Save(dataDir + "DotCode.png");
            }
            //ExEnd: ImplementDotCodeForBarcode
            Console.WriteLine(Environment.NewLine + "Barcode saved at " + dataDir + "DotCode.png");
        }

        public static void GS1DatamatrixBarcodeWithWrappingText()
        {
            //ExStart: GS1DatamatrixBarcodeWithWrappingText
            string CODICE = "(90)0843110730<<<<452287005001T8";
            string displayedText = "(90)0843" + Environment.NewLine +
                                    "110730<<<<" + Environment.NewLine +
                                    "452287" + Environment.NewLine +
                                    "005001T8" + Environment.NewLine;

            using (BarcodeGenerator  generator = new BarcodeGenerator (EncodeTypes.GS1DataMatrix))
            {
                generator.CodeText = CODICE;
                generator.Parameters.Barcode.CodeTextParameters.Location = CodeLocation.Above;
                generator.Parameters.Barcode.CodeTextParameters.TwoDDisplayText = displayedText;

                Bitmap barcode = generator.GenerateBarCodeImage();
                barcode.Save(dataDir + "Display2DText.png");
            }
            //ExEnd: GS1DatamatrixBarcodeWithWrappingText
            Console.WriteLine(Environment.NewLine + "Barcode saved at " + dataDir + "Display2DText.png");
        }

        public static void GenarateBarcodeWithRotationAndDpi()
        {
            //ExStart: GenarateBarcodeWithRotationAndDpi
            using (BarcodeGenerator  generator = new BarcodeGenerator (EncodeTypes.Code128))
            {
                generator.Parameters.Resolution = 144;
                generator.Parameters.RotationAngle = 90;
                generator.Save(dataDir + "rotated_dpi144.png");
            }
            //ExEnd: GenarateBarcodeWithRotationAndDpi
            Console.WriteLine(Environment.NewLine + "Barcode saved at " + dataDir + "rotated_dpi144.png");
        }
    }
}
