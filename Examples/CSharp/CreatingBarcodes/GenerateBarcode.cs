using Aspose.BarCode;
using Aspose.BarCode.Examples.CSharp;
using Aspose.BarCode.Generation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp.GenerateBarcode
{
    public class GenerateBarcode
    {
        public static string dataDir = RunExamples.GetDataDir_CreateAndManage2DBarCodes();

        public static void Run()
        {
            GenerateBarcodeWithRestrictedBarcodeSize();

            GenerateBarcodeWithoutRestrictedBarcodeSize();

            GetGeneratedBarcodeSize();

            UnitBasedBarcodeGenerateion();

            GettingDefaultCodeTextForGeneratedBarcode();
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
    }
}
