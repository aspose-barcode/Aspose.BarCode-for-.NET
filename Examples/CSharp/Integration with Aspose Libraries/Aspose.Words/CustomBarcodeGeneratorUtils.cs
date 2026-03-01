//Copyright(c) 2001-2026 Aspose Pty Ltd.All rights reserved
using System;
using System.IO;
using Aspose.Words.Fields;
using Aspose.BarCode.Generation;

#if NETSTANDARD2_0_OR_GREATER || NETCOREAPP2_1_OR_GREATER
using Aspose.Drawing;
using Aspose.Drawing.Imaging;
#else
using System.Drawing;
using System.Drawing.Imaging;
#endif

namespace Aspose.BarCode.Utils
{
    internal class CustomBarcodeGeneratorUtils
    {
        public static double TwipsToPixels(string heightInTwips, double defVal)
        {
            return TwipsToPixels(heightInTwips, 96, defVal);
        }

        public static double TwipsToPixels(string heightInTwips, double resolution, double defVal)
        {
            try
            {
                int lVal = int.Parse(heightInTwips);
                return (lVal / 1440.0) * resolution;
            }
            catch
            {
                return defVal;
            }
        }

        public static float GetRotationAngle(string rotationAngle, float defVal)
        {
            switch (rotationAngle)
            {
                case "0":
                    return 0;
                case "1":
                    return 270;
                case "2":
                    return 180;
                case "3":
                    return 90;
                default:
                    return defVal;
            }
        }

        public static QRErrorLevel GetQRCorrectionLevel(string errorCorrectionLevel, QRErrorLevel def)
        {
            switch (errorCorrectionLevel)
            {
                case "0":
                    return QRErrorLevel.LevelL;
                case "1":
                    return QRErrorLevel.LevelM;
                case "2":
                    return QRErrorLevel.LevelQ;
                case "3":
                    return QRErrorLevel.LevelH;
                default:
                    return def;
            }
        }

        public static SymbologyEncodeType GetBarcodeEncodeType(string encodeTypeFromWord)
        {
            //https://support.microsoft.com/en-au/office/field-codes-displaybarcode-6d81eade-762d-4b44-ae81-f9d3d9e07be3
            switch (encodeTypeFromWord)
            {
                case "QR":
                    return EncodeTypes.QR;
                case "CODE128":
                    return EncodeTypes.Code128;
                case "CODE39":
                    return EncodeTypes.Code39;
                case "JPPOST":
                    return EncodeTypes.RM4SCC;
                case "EAN8":
                case "JAN8":
                    return EncodeTypes.EAN8;
                case "EAN13":
                case "JAN13":
                    return EncodeTypes.EAN13;
                case "UPCA":
                    return EncodeTypes.UPCA;
                case "UPCE":
                    return EncodeTypes.UPCE;
                case "CASE":
                case "ITF14":
                    return EncodeTypes.ITF14;
                case "NW7":
                    return EncodeTypes.Codabar;
                default:
                    return EncodeTypes.None;
            }
        }
        
        public static Color ConvertColor(string inputColor, Color defVal)
        {
            if (string.IsNullOrEmpty(inputColor)) return defVal;
            try
            {
                int color = Convert.ToInt32(inputColor, 16);
                //return Color.FromArgb((color >> 16) & 0xFF, (color >> 8) & 0xFF, color & 0xFF);
                return Color.FromArgb(color & 0xFF, (color >> 8) & 0xFF, (color >> 16) & 0xFF);
            }
            catch
            {
                return defVal;
            }
        }
        
        public static double ScaleFactor(string scaleFactor, double defVal)
        {
            try
            {
                int scale = int.Parse(scaleFactor);
                return scale / 100.0;
            }
            catch
            {
                return defVal;
            }
        }

        public static void SetPosCodeStyle(BarcodeGenerator gen, string posCodeStyle, string barcodeValue)
        {
            switch (posCodeStyle)
            {
                //STD default and without changes
                case "SUP2":
                    gen.CodeText = barcodeValue.Substring(0, barcodeValue.Length - 2);
                    gen.Parameters.Barcode.Supplement.SupplementData = barcodeValue.Substring(barcodeValue.Length - 2, 2);
                    break;
                case "SUP5":
                    gen.CodeText = barcodeValue.Substring(0, barcodeValue.Length - 5);
                    gen.Parameters.Barcode.Supplement.SupplementData = barcodeValue.Substring(barcodeValue.Length - 5, 5);
                    break;
                case "CASE":
                    gen.Parameters.Border.Visible = true;
                    gen.Parameters.Border.Color = gen.Parameters.Barcode.BarColor;
                    gen.Parameters.Border.DashStyle = BorderDashStyle.Solid;
                    gen.Parameters.Border.Width.Pixels = gen.Parameters.Barcode.XDimension.Pixels * 5;
                    break;
            }
        }

        public const double DefaultQRXDimensionInPixels = 4.0;
        public const double Default1DXDimensionInPixels = 1.0;
        public static Bitmap DrawErrorImage(Exception error)
        {
            Bitmap bmp = new Bitmap(100, 100);

            using (Graphics grf = Graphics.FromImage(bmp))
#if NETSTANDARD2_0_OR_GREATER || NETCOREAPP2_1_OR_GREATER
                grf.DrawString(error.Message, new Aspose.Drawing.Font("Microsoft Sans Serif", 8f, FontStyle.Regular), Brushes.Red, new Rectangle(0,0, bmp.Width, bmp.Height));
#else
                grf.DrawString(error.Message, new System.Drawing.Font("Microsoft Sans Serif", 8f, FontStyle.Regular), Brushes.Red, new Rectangle(0,0, bmp.Width, bmp.Height));
#endif
            return bmp;
        }
        public static Stream ConvertImageToStream(Bitmap bmp)
        {
            MemoryStream ms = new MemoryStream();
            bmp.Save(ms, ImageFormat.Png);
            ms.Position = 0;
            return ms;
        }
    }

    internal class CustomBarcodeGenerator : IBarcodeGenerator
    {
        public Stream GetBarcodeImage(Aspose.Words.Fields.BarcodeParameters parameters)
        {
            try
            {
                BarcodeGenerator gen = new BarcodeGenerator(CustomBarcodeGeneratorUtils.GetBarcodeEncodeType(parameters.BarcodeType), parameters.BarcodeValue);

                //color
                gen.Parameters.Barcode.BarColor = CustomBarcodeGeneratorUtils.ConvertColor(parameters.ForegroundColor, gen.Parameters.Barcode.BarColor);
                gen.Parameters.BackColor = CustomBarcodeGeneratorUtils.ConvertColor(parameters.BackgroundColor, gen.Parameters.BackColor);

                //display or hide text
                if (!parameters.DisplayText)
                    gen.Parameters.Barcode.CodeTextParameters.Location = CodeLocation.None;
                else
                    gen.Parameters.Barcode.CodeTextParameters.Location = CodeLocation.Below;

                //QR Code error correction level
                gen.Parameters.Barcode.QR.ErrorLevel = QRErrorLevel.LevelH;
                if (!string.IsNullOrEmpty(parameters.ErrorCorrectionLevel))
                    gen.Parameters.Barcode.QR.ErrorLevel = CustomBarcodeGeneratorUtils.GetQRCorrectionLevel(parameters.ErrorCorrectionLevel, gen.Parameters.Barcode.QR.QrErrorLevel);

                //rotation angle
                if (!string.IsNullOrEmpty(parameters.SymbolRotation))
                    gen.Parameters.RotationAngle = CustomBarcodeGeneratorUtils.GetRotationAngle(parameters.SymbolRotation, gen.Parameters.RotationAngle);

                //scaling factor
                double scalingFactor = 1;
                if (!string.IsNullOrEmpty(parameters.ScalingFactor))
                    scalingFactor = CustomBarcodeGeneratorUtils.ScaleFactor(parameters.ScalingFactor, scalingFactor);

                //size
                if (gen.BarcodeType == EncodeTypes.QR)
                    gen.Parameters.Barcode.XDimension.Pixels = (float)Math.Max(1.0, Math.Round(CustomBarcodeGeneratorUtils.DefaultQRXDimensionInPixels * scalingFactor));
                else
                    gen.Parameters.Barcode.XDimension.Pixels = (float)Math.Max(1.0, Math.Round(CustomBarcodeGeneratorUtils.Default1DXDimensionInPixels * scalingFactor));

                //height
                if (!string.IsNullOrEmpty(parameters.SymbolHeight))
                    gen.Parameters.Barcode.BarHeight.Pixels = (float)Math.Max(5.0, Math.Round(CustomBarcodeGeneratorUtils.TwipsToPixels(parameters.SymbolHeight, gen.Parameters.Barcode.BarHeight.Pixels) * scalingFactor));

                //Style of a Point-of-Sale barcode
                if (!string.IsNullOrEmpty(parameters.PosCodeStyle))
                    CustomBarcodeGeneratorUtils.SetPosCodeStyle(gen, parameters.PosCodeStyle, parameters.BarcodeValue);

                return CustomBarcodeGeneratorUtils.ConvertImageToStream(gen.GenerateBarCodeImage());
            }
            catch (Exception e)
            {
                return CustomBarcodeGeneratorUtils.ConvertImageToStream(CustomBarcodeGeneratorUtils.DrawErrorImage(e));
            }
        }

        public Stream GetOldBarcodeImage(Aspose.Words.Fields.BarcodeParameters parameters)
        {
            throw new NotImplementedException();
        }
    }
}
