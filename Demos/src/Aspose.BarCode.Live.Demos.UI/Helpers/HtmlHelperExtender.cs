using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;

namespace Aspose.Barcode.Live.Demos.UI.Helpers
{
	public static class HtmlHelperExtender
	{
		public static IHtmlString ToEscapeHtmlJson(this HtmlHelper html, object src)
		{
			return html.Raw(JsonConvert.SerializeObject(src, new JsonSerializerSettings
			{
				StringEscapeHandling = StringEscapeHandling.EscapeHtml
			}));
		}

	}
}
