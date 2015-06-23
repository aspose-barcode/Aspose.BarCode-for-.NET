//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2015 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.BarCode. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.BarCode;
using System;
using Aspose.BarCodeRecognition;

namespace CSharp.BarCode_Recognition
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
