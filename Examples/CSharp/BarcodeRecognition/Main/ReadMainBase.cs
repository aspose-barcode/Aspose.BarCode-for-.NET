//Copyright(c) 2001-2022 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET

namespace Aspose.BarCode.Examples.CSharp.BarcodeRecognition
{
    internal class ReadMainBase
    {
        protected const string _RecognitionPath = "Recognition";
        protected static string GetReadFolder()
        {
            return BarcodePathUtils.GetDataDir_Folders(_RecognitionPath, "Main");
        }
    }
}