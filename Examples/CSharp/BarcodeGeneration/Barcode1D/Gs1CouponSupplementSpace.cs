//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class Gs1CouponSupplementSpace : OneDBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("Gs1CouponSupplementSpace:");

            BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.UpcaGs1DatabarCoupon, "123456789012(8110)ASPOSE");
            gen.Parameters.Barcode.XDimension.Pixels = 2;
            //set coupon supplement space 30 pixels
            gen.Parameters.Barcode.Coupon.SupplementSpace.Pixels = 30;
            gen.Save($"{path}Gs1CouponSpace30Pixels.png", BarCodeImageFormat.Png);
            //set coupon supplement space 50 pixels
            gen.Parameters.Barcode.Coupon.SupplementSpace.Pixels = 50;
            gen.Save($"{path}Gs1CouponSpace50Pixels.png", BarCodeImageFormat.Png);
        }
    }
}