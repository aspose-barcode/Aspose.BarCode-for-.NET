//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.BarCode. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.BarCode;

namespace CustomizeCode128Barcodes
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

            // Create Code12 barcode in mixed mode (Code128 A and B)
            Code128CodeBuilder code12Builder = new Code128CodeBuilder(Code128CodeSet.A);

            string codeText = code12Builder.Append("1234").SwitchTo(Code128CodeSet.B).Append("5678").ToString();

            BarCodeBuilder builder = new BarCodeBuilder(codeText, Symbology.Code128);

            // Save the image to disk in PNG format
            builder.Save(dataDir + "test.png");

        }
    }
}