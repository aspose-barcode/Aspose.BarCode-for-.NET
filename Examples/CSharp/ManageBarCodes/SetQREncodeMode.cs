using System.IO;
using Aspose.BarCode;
using System;
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.ManageBarCodes
{
    class SetQREncodeMode
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ManageBarCodes();

            // Create instance of BarCodeBuilder, specify codetext symbology and encode mode 
            BarCodeBuilder builder = new BarCodeBuilder("test123", EncodeTypes.QR) {QREncodeMode = QREncodeMode.Auto};
            builder.Save(dataDir + "QR-Encode-mode_out.jpg");
        }
    }
}
