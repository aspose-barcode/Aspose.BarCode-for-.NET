//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    abstract class StoreBarcodeOutputBase
    {
		protected static string GetFolder()
        {
            return BarcodePathUtils.GetDataDir_Data_Output("BarcodeOutput");
        }
    }
}