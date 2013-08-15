//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.BarCode. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.BarCode;

namespace ColorizeanyPartoftheBarcodeImage
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
            BarCodeBuilder bb = new BarCodeBuilder();

            //Set the Code text for the barcode
            bb.CodeText = "1234567";

            //Set the symbology type to Code128
            bb.SymbologyType = Symbology.Code128;

            //Set background color of the barcode
            bb.BackColor = System.Drawing.Color.Yellow;

            //Set color (fore color) of the barcode
            bb.ForeColor = System.Drawing.Color.Blue;

            //Set border color of the barcode
            bb.BorderColor = System.Drawing.Color.Red;

            //Set color of the code text of the barcode
            bb.CodeTextColor = System.Drawing.Color.Red;

            //Save the image to your system
            //and set its image format to Jpeg
            bb.Save(dataDir + "barcode.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);

        }
    }
}