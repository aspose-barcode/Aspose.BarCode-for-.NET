using Aspose.BarCode.Generation;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;

namespace Aspose.BarCode.Examples.CSharp.TechnicalArticles
{
    class BarcodeWithDatabase
    {
        public static void Run()
        {
			// ExStart:BarcodeWithDatabase
			// For complete examples and data files, please go to https://github.com/aspose-barcode/Aspose.BarCode-for-.NET

			// The path to the documents directory.
			string dataDir = RunExamples.GetDataDir_TechnicalArticles();

            // Instantiate linear barcode object, Set the Code text and symbology type for the barcode
            BarcodeGenerator generator = new BarcodeGenerator(EncodeTypes.Code128);
            generator.CodeText = "1234567";

            //Save and Retrieve Barcode Information
            StoreInDB(generator);
            BarcodeGenerator barcode = RetrieveFromDB();

            // Save the retrievd Barcode in JPEG format
            barcode.Save(dataDir + "barcode_out.jpg", BarCodeImageFormat.Jpeg);

            // Save and Retrieve Barcode Image
            StoreImageInDB(generator);
            Image image = RetrieveImageFromDB();

			// Save the retrieved Barcode image in JPEG format
			image.Save(dataDir + "BarcodeFromDB_out.jpg", ImageFormat.Jpeg);
			// ExEnd:BarcodeWithDatabase
			Console.WriteLine(Environment.NewLine + "Save and Retrieve using Database Finished.");
        }

		// ExStart:StoreInDB
		private static void StoreInDB(BarcodeGenerator generator)
		{
			string connectionString = "server=localhost;database=test_db;uid=sa;pwd=123;";

			string Codetext = generator.CodeText;
			string Symbology = generator.BarcodeType.ToString();

			// Create the SQL connection.
			SqlConnection mConnection = new SqlConnection(connectionString);
            mConnection.Open();

			// Create the SQL command.
			string commandString = "INSERT INTO barcodes (CodeText,Symbology) VALUES('" + Codetext + "','" + Symbology + "')";
			SqlCommand command = new SqlCommand(commandString, mConnection);

			// Execute the command.
			command.ExecuteNonQuery();

			// Close the connection.
            mConnection.Close();
		}
		// ExEnd:StoreInDB

		// ExStart:RetrieveFromDB
		private static BarcodeGenerator RetrieveFromDB()
		{
			BarcodeGenerator barcode = null;
			string connectionString = "server=localhost;database=test_db;uid=sa;pwd=123;";

			// Create the SQL connection.
			SqlConnection mConnection = new SqlConnection(connectionString);
			mConnection.Open();

			// Create the SQL command.
			string commandString = "SELECT * FROM barcodes";
			SqlCommand command = new SqlCommand(commandString, mConnection);

			// Create the data adapter.
			SqlDataAdapter adapter = new SqlDataAdapter(command);

			// Fill the results from the database into a DataTable.
			DataTable dataTable = new DataTable();
			adapter.Fill(dataTable);

			string SymbologyType = dataTable.Rows[0]["Symbology"].ToString();
			bool isValid = EncodeTypes.Parse(SymbologyType, out BaseEncodeType encodeType);
			if(isValid)
            {
				barcode = new BarcodeGenerator(encodeType);
				barcode.CodeText = dataTable.Rows[0]["CodeText"].ToString();
			}

			// Close the connection.
			mConnection.Close();

			return barcode;
		}
		// ExEnd:RetrieveFromDB

		// ExStart:StoreImageInDB
		private static void StoreImageInDB(BarcodeGenerator barcode)
        {
			string connectionString = "server=localhost;database=test_db;uid=sa;pwd=123;";

			MemoryStream ms = new MemoryStream();
			barcode.Save(ms, BarCodeImageFormat.Bmp);
			ms.Seek(0, SeekOrigin.Begin);
			byte[] imgBytes = ms.ToArray();

			// Create the SQL connection
			SqlConnection mConnection = new SqlConnection(connectionString);
			mConnection.Open();
			
			// Create the SQL command.
			string commandString = "INSERT INTO barcodeImages(CodeText,barcodeImage) VALUES(@codetext, @BarcodeImage)";
			SqlCommand command = new SqlCommand(commandString, mConnection);
			command.Parameters.AddWithValue("codetext", barcode.CodeText);
			command.Parameters.AddWithValue("BarcodeImage", imgBytes);

			// Execute the command.
			command.ExecuteNonQuery();
			mConnection.Close();
		}
		// ExEnd:StoreImageInDB

		// ExStart:RetrieveImageFromDB
		private static Image RetrieveImageFromDB()
        {
			string connectionString = "server=localhost;database=test_db;uid=sa;pwd=123;";

			// Create the SQL connection.
			SqlConnection mConnection = new SqlConnection(connectionString);
			mConnection.Open();

			// Create the SQL command.
			string commandString = "SELECT * FROM barcodeImages";
			SqlCommand command = new SqlCommand(commandString, mConnection);

			// Create the data adapter.
			SqlDataAdapter adapter = new SqlDataAdapter(command);

			// Fill the results from the database into a DataTable.
			DataTable dataTable = new DataTable();
			adapter.Fill(dataTable);

			MemoryStream ms = new MemoryStream((byte[])dataTable.Rows[0]["barcodeImage"]);
			Image image = Image.FromStream(ms, true);

			mConnection.Close();

			return image;
		}
		// ExEnd:RetrieveImageFromDB
	}
}
