namespace Aspose.Barcode.Live.Demos.UI.Models
{
	/// <summary>
	/// Prepares Extension and HowTo sections
	/// Changes Title and TitleSub in ViewModel
	/// </summary>
	public class ExtensionInfoModel
	{
		public ViewModel Parent;

		/// <summary>
		/// File extension without dot received by "fileformat" value in RouteData (e.g. docx)
		/// </summary>
		public string Extension { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public string URL { get; set; }

		public string AppName => Parent.AppName;

		

		public ExtensionInfoModel(ViewModel parent, string extension)
		{
			Parent = parent;
			Extension = extension;
			if (Extension.Equals("excel"))
			{
				Extension = "xlsx";
			}
			else if (Extension.Equals("extract"))
			{
				Extension = "pdf";
			}

			

			
		}
	}
}
