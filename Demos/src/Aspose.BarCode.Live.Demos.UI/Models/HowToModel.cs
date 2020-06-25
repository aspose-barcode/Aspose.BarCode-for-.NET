using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Aspose.Barcode.Live.Demos.UI.Controllers;

namespace Aspose.Barcode.Live.Demos.UI.Models
{
  public class HowToModel
  {
    public string Title { get; set; }
    public List<HowToItem> List { get; set; }
    
    public ViewModel Parent;
		public Dictionary<string, string> Resources => Parent.Resources;
    public string AppName => Parent.AppName;
		/// <summary>
		/// Returns Word, OpenOffice, RTF or Text
		/// </summary>
		/// <param name="extension"></param>
		/// <param name="defaultValue"></param>
		/// <returns></returns>
		
		public HowToModel(ViewModel parent)
    {
      Parent = parent;
      var extension = Parent.Extension?.ToUpper();
      var extension2 = Parent.Extension2?.ToUpper();
      if (string.IsNullOrEmpty(extension) || Parent.IsCanonical)
        extension = Resources["Document"];
	  else if ("acroform".Equals(extension, StringComparison.InvariantCultureIgnoreCase))
      {
	      extension = "PDF Xfa";
	      extension2 = "PDF Acroform";
      }
      else if ("extract".Equals(extension, StringComparison.InvariantCultureIgnoreCase))
      {
        extension = "PDF";
      }
      else if ("md".Equals(extension, StringComparison.InvariantCultureIgnoreCase) && "htmlConversion".Equals(parent.ProductAppName))
      {
		extension = "Markdown";
      }
      else if (!string.IsNullOrEmpty(extension2) &&
               (extension2.Equals("pdfa1a", StringComparison.InvariantCultureIgnoreCase) ||
                extension2.Equals("pdfa1b", StringComparison.InvariantCultureIgnoreCase) ||
                extension2.Equals("pdfa2a", StringComparison.InvariantCultureIgnoreCase) ||
                extension2.Equals("pdfa3a", StringComparison.InvariantCultureIgnoreCase)))
      {
	      extension2 = Parent.DesktopAppNameByExtension(extension2);
      }
      if (string.IsNullOrEmpty(extension2))
        extension2 = extension;
      
      List = new List<HowToItem>();
      var title = Resources.ContainsKey($"{Parent.Product}Howto{AppName}Title")
        ? Resources[$"{Parent.Product}Howto{AppName}Title"]
        : Resources[$"Howto{AppName}Title"];
      var titleEnd = title.EndsWith("file.") ? extension : Parent.PageProductTitle + " " + AppName;
      var k = title.IndexOf("using") - 1;
      if (k > 0)
        title = title.Substring(0, k);
      if (string.IsNullOrEmpty(Parent.Extension2))
        Title = string.Format(title, extension, titleEnd);
      else
        switch (Parent.AppName)
        {
	      case "Conversion":
	      case "Merger":
            k = title.IndexOf("files") - 1;
            if (k > 0)
              title = title.Substring(0, k);
            Title = string.Format(title, $"{extension} to {extension2}", titleEnd);
            break;
          case "Comparison":
            Title = string.Format(title, $"{extension} with {extension2}", titleEnd);
            break;
		  case "Parser":
            Title = string.Format(title, $"{extension}");
            break;
        }

      var hwName = "HowtoName" + Parent.AppName + "Feature";
      var hwUrlPath = "HowtoUrlPath" + Parent.AppName + "Feature";
      var hwImageUrl = "HowtoImageUrl" + Parent.AppName + "Feature";
      var hw = "Howto" + Parent.AppName + "Feature";
      var i = 1;
      while (Resources.ContainsKey(hw + i))
      {
	      var item = new HowToItem();
		  if (Resources.ContainsKey(hwName + i))
			item.Name = string.Format(Resources[hwName + i], extension, extension2);
		  if (Resources.ContainsKey(hwUrlPath + i))
			  item.UrlPath = string.Format(Resources[hwUrlPath + i], extension, extension2);
		  if (Resources.ContainsKey(hwImageUrl + i))
			  item.ImageUrl = string.Format(Resources[hwImageUrl + i], Parent.Product.ToLower(), extension, extension2);
	      item.Text = string.Format(Resources[hw + i], extension, extension2);
          List.Add(item);
        i++;
      }
    }
  }
  public class HowToItem
  {
	  public string Name { get; set; }
	  public string Text { get; set; }
	  public string ImageUrl { get; set; }
	  public string UrlPath { get; set; }
  }
}
