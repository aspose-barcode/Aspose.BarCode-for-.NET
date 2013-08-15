//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.BarCode. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.BarCode;

namespace WorkingWithImageBorders
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

            //Set border style to solid
            bb.BorderDashStyle = Aspose.BarCode.BorderDashStyle.Solid;

            //Set border margins by assigning an instance of MarginsF
            bb.Margins = new Aspose.BarCode.MarginsF(2f, 2f, 2f, 2f);

            //Set border width
            bb.BorderWidth = 0.5f;

            //Enable border to be shown in the barcode
            bb.BorderVisible = true;

            //Save the image to your system
            //and set its image format to Jpeg
            bb.Save(dataDir + "barcode.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);

        }
    }
}