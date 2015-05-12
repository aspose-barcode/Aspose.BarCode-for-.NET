//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.BarCode. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.BarCode;

namespace ControlAppearanceOfCodeText
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
				
            //Instantiate bar code object
            BarCodeBuilder bc = new BarCodeBuilder();

            //Set the Code text for the bar code
            bc.CodeText = "1234567";

            //Align the code text to center
            bc.CodeTextAlignment = System.Drawing.StringAlignment.Center;

            //Set the location of the code text to above the bar code
            bc.CodeLocation = CodeLocation.Above;

            //Set the code text fore color to red
            bc.CodeTextColor = System.Drawing.Color.Red;

            //Increase the space between code text and barcode to 1 point
            bc.CodeTextSpace = 1.0f;

            //Set the symbology type to Code128
            bc.SymbologyType = Symbology.Code128;

            //Save the image to your system and set its image format to Jpeg
            bc.Save(dataDir + "barcode.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
        }
    }
}