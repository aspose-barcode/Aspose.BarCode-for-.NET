using System.IO;
using Aspose.BarCode;
using System;

namespace Aspose.BarCode.Examples.CSharp.ManageBarCodes
{
    class SetQREncodeMode
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ManageBarCodes();

            // Create instance of BarCodeBuilder, specify codetext and symbology in the constructor
            BarCodeBuilder builder = new BarCodeBuilder("test123", Symbology.QR);

            // Set QR encode mode
            builder.QREncodeMode = QREncodeMode.Auto;

            // Save the file to disk  
            builder.Save(dataDir + "QR-Encode-mode_out.jpg");
        }
    }
}
