//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.BarCode. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.BarCode;

namespace GenerateBarcodeCustomSize
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");

            // Create directory if it is not already present.
            bool IsExists = System.IO.Directory.Exists(dataDir);
            if (!IsExists)
                System.IO.Directory.CreateDirectory(dataDir);

            //Instantiate barcode object
            BarCodeBuilder builder = new BarCodeBuilder("1234567890", Symbology.Code39Standard);

            // Set auto size false
            builder.AutoSize = false;
            
            // Set height
            builder.ImageHeight = 50;
            
            // Set width
            builder.ImageWidth = 120;
            
            // Save image to disk
            builder.Save(dataDir + "test.png");
            
            
        }
    }
}