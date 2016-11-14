using System.IO;
using Aspose.BarCode;
using System;
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.ManageBarCodes
{
    class SetQRErrorCorrection
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ManageBarCodes();

            // Create instance of BarCodeBuilder, specify codetext and symbology in the constructor
            BarCodeBuilder builder = new BarCodeBuilder("1234567890", EncodeTypes.QR);

            // Set QRErrorLevel     
            builder.QRErrorLevel = QRErrorLevel.LevelH;

            // Save the file to disk
            builder.Save(dataDir + "QR-error-correction_out.jpg", BarCodeImageFormat.Jpeg);
        }
    }
}
