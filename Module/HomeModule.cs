using Nancy;
using System.Collections.Generic;

namespace AddressBook
{
	public class HomeModule : NancyModule
	{
		public HomeModule()
		{
			Get["/contact/new"] = _ =>
			{
				return View["index.cshtml"];
			};
		}
	}
}
