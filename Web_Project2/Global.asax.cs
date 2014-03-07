﻿using Parse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Web_Project2
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        //Change Id and key when needed
        protected const string PARSEAPPID = "MXtZWjQd43oVRapHHfQ213Kls6EavtWpNrKez1lr";
        protected const string PARSEDOTNETKEY = "Ew5iZztAoPxCh9PATc3PDmexEuBmIdY6BHYn5YTj";

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            //Initialize Parse.com 
            ParseClient.Initialize(PARSEAPPID, PARSEDOTNETKEY);
        }
    }
}