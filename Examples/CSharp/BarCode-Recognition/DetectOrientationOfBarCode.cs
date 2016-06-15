using System.IO;
using Aspose.BarCode;
using System;
using Aspose.BarCodeRecognition;

namespace Aspose.BarCode.Examples.CSharp.BarCode.Recognition
{
    class DetectOrientationOfBarCode
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_BarCodeRecognition();
            string dst = dataDir + "Code39.png";

            // Instantiate BarCodeReader object
            BarCodeReader reader = new BarCodeReader(dst, BarCodeReadType.Code39Standard);

            try
            {
                // read Code39 bar code
                while (reader.Read())
                {
                    // detect bar code orientation
                    System.Console.Write(Environment.NewLine + "Rotaion Angle: " + reader.GetAngle());
                }
                reader.Close();
            }

            catch (Exception exp)
            {

                System.Console.Write(exp.Message);
            }

            Console.WriteLine(Environment.NewLine + "Barcode recognized from " + dst);
        }
    }
}
