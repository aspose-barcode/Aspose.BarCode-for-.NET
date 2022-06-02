//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET

namespace Aspose.BarCode.Examples.CSharp.ComplexBarcodes
{
    internal class ComplexBarcodesReadBase
    {
        protected const string _ComplexBarcodesPath = "ComplexBarcodes";

        protected static string GetSwissQRFolder()
        {
            return BarcodePathUtils.GetDataDir_Folders(_ComplexBarcodesPath, "SwissQR");
        }
        protected static string GetMailmarkFolder()
        {
            return BarcodePathUtils.GetDataDir_Folders(_ComplexBarcodesPath, "Mailmark");
        }
    }
}