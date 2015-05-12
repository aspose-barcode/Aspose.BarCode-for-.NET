//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.BarCode. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.BarCode;
using Aspose.BarCodeRecognition;
using System;

namespace DetectOrientationOfBarCode
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");

            // Instantiate BarCodeReader object
            BarCodeReader reader = new BarCodeReader(dataDir + "barcode.jpg", BarCodeReadType.Code128);

            try
            {
                // read Code128 bar code
                while (reader.Read())
                {
                    // detect bar code orientation
                    System.Console.Write("Rotaion Angle: " + reader.GetAngle());
                }
                reader.Close();
            }

            catch (Exception exp)
            {

                System.Console.Write(exp.Message);
            }
        }
    }
}