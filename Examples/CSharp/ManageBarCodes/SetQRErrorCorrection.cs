using System.IO;
using Aspose.BarCode;
using System;

namespace Aspose.BarCode.Examples.CSharp.ManageBarCodes
{
    class SetQRErrorCorrection
    {
        public static void Run()
        {

            //ExStart:SetQRErrorCorrection
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ManageBarCodes();

            // Create instance of BarCodeBuilder, specify codetext and symbology in the constructor
            BarCodeBuilder builder = new BarCodeBuilder();

            // Set SymbologyType         
            builder.SymbologyType = Symbology.QR;

            // Set QRErrorLevel     
            builder.QRErrorLevel = QRErrorLevel.LevelH;

            // Set CodeText     
            builder.CodeText = "1234567890";

            // Save the file to disk
            builder.Save(dataDir + "QR-error-correction.jpg", BarCodeImageFormat.Jpeg);
            //ExStart:SetQRErrorCorrection
        }
    }
}
