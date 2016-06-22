using System.IO;
using Aspose.BarCode;
using System;
using Aspose.BarCode.BarCodeRecognition;

namespace Aspose.BarCode.Examples.CSharp.ManageAndOptimizeBarCodeRecognition
{
    class DetectOrientationOfBarCode
    {
        public static void Run()
        {
            //ExStart:DetectOrientationOfBarCode
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ManageAndOptimizeBarcodeRecognition();

            // Instantiate BarCodeReader object
            BarCodeReader reader = new BarCodeReader(dataDir + "rotatedbarcode.jpg", DecodeType.Code128);

            try
            {
                // read Code39 bar code
                while (reader.Read())
                {
                    // detect bar code orientation
                    System.Console.Write(Environment.NewLine + "Rotaion Angle: " + reader.GetAngle());
                }
                reader.Close();
                //ExEnd:DetectOrientationOfBarCode
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose BarCode License. You can purchase full license or get 30 day temporary license from http:// Www.aspose.com/purchase/default.aspx.");
            }

            Console.WriteLine(Environment.NewLine + "Barcode recognized from " + dataDir + "rotatedbarcode.jpg");

        }
    }
}
