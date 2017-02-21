using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Practice.Models;
using System.Collections.Generic;
using System;

namespace Practice
{
	public class Global : HttpApplication
	{
		protected void Application_Start()
		{
			AreaRegistration.RegisterAllAreas();
			RouteConfig.RegisterRoutes(RouteTable.Routes);
		}
	}
}
