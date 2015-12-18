using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Aspose.BarCode;
using Telerik.Sitefinity.Pages.Model;
using Telerik.Sitefinity.Modules.Pages;
using Telerik.Sitefinity;
using Telerik.Sitefinity.Web;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using Telerik.Sitefinity.Ecommerce.Catalog.Model;
using Telerik.Sitefinity.Modules.Ecommerce.Catalog;
using System.Data;
using Telerik.Sitefinity.GenericContent.Model;


namespace Aspose.SiteFinity.BarcodeGenerator
{    
    public partial class Generator : System.Web.UI.UserControl
    {
        // Defaults        
        private string mySymbology = "Codabar";
        private int myWidth = 200;
        private int myHeight = 200;
        private bool myAutoHeight = true;        

        public string CodeSymbology
        {
            get { return mySymbology; }
            set { mySymbology = value; }
        }
        
        public int Height
        {
            get { return myHeight;  }
            set { myHeight = value; }
        }


        public int Width
        {
            get { return myWidth; }
            set { myWidth = value; }
        }

        public bool AutoHeight
        {
            get { return myAutoHeight; }
            set { myAutoHeight = value; }
        }

        private void loadProducts()
        {
            CatalogManager catalogManager = CatalogManager.GetManager();

            List<Product> products = catalogManager.GetProducts().Where(u => u.Status == ContentLifecycleStatus.Live).ToList();



            DataTable output = new DataTable("ASA");
            output.Columns.Add("ProductTitle");
            output.Columns.Add("DisplayPrice");
            output.Columns.Add("ThumbURL");
            output.Columns.Add("ProductBarcode");



            foreach (Product product in products)
            {
                // Current Page URL
                string product_info = product.Title + "," + product.DisplayPriceFormatted + "," + product.AutoGenerateUniqueUrl;
                string barcode_url = "";

                BarCodeBuilder bb = new BarCodeBuilder();
                bb.CodeText = product_info;
                bb.SymbologyType = (Symbology)Enum.Parse(typeof(Symbology), mySymbology);

                if (Height <= 0)
                    Height = 100;

                if (Width <= 0)
                    Width = 100;

                bb.ImageWidth = Width;
                bb.ImageHeight = Height;
                if (AutoHeight)
                    bb.AutoSize = true;
                bb.CodeLocation = CodeLocation.None;

                // Check for license and apply if exists
                string licenseFile = Server.MapPath("~/App_Data/Aspose.Total.lic");
                if (File.Exists(licenseFile))
                {
                    License license = new License();
                    license.SetLicense(licenseFile);
                }

                using (MD5 md5Hash = MD5.Create())
                {

                    string hashData = product_info + mySymbology + myWidth.ToString() + myHeight.ToString() + myAutoHeight.ToString();
                    string filename_hash = GetMd5Hash(md5Hash, hashData);
                    string fileName = filename_hash + ".png";

                    if (!File.Exists(Server.MapPath("~/Aspose_Data/" + fileName)))
                    {
                        bb.Save(Server.MapPath(@"~/Aspose_Data/" + fileName), BarCodeImageFormat.Png);
                    }

                    barcode_url = "~/Aspose_Data/" + fileName;

                }

                DataRow dr;
                dr = output.NewRow();
                dr["ProductTitle"] = product.Title;
                dr["DisplayPrice"] = product.DisplayPriceFormatted;
                dr["ThumbURL"] = product.ThumbnailUrl;
                dr["ProductBarcode"] = barcode_url;
                output.Rows.Add(dr);
            }

            SitefinityProductsGridView.DataSource = output;
            SitefinityProductsGridView.DataBind(); 
        }
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                loadProducts();                       
        }        

        string GetMd5Hash(MD5 md5Hash, string input)
        {

            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }

        // Verify a hash against a string.
        bool VerifyMd5Hash(MD5 md5Hash, string input, string hash)
        {
            // Hash the input.
            string hashOfInput = GetMd5Hash(md5Hash, input);

            // Create a StringComparer an compare the hashes.
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;

            if (0 == comparer.Compare(hashOfInput, hash))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        protected void SitefinityProductsGridView_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            SitefinityProductsGridView.PageIndex = e.NewPageIndex;
            loadProducts();
        }        
    }
}