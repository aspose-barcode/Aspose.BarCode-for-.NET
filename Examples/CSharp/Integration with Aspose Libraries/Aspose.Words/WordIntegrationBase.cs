//Copyright(c) 2001-2022 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET

namespace Aspose.BarCode.Examples.CSharp.Integration
{
    internal class WordIntegrationBase
    {
        protected const string _AsposeLibrariesPath = "Aspose";
        protected static string GetReadFolder()
        {
            return BarcodePathUtils.GetDataDir_Folders(_AsposeLibrariesPath, "Word");
        }
        protected static string GetWriteFolder()
        {
            return BarcodePathUtils.GetDataDir_Data_Output(_AsposeLibrariesPath, "Word");
        }
    }
}