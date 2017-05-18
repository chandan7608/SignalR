using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace PushNotification
{
    public class MvcApplication : System.Web.HttpApplication
    {
        string con = ConfigurationManager.ConnectionStrings["ConStr"].ConnectionString;
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();          
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            //here in Application Start we will start Sql Dependency
            SqlDependency.Start(con);
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            NotificationComponent NC = new NotificationComponent();
            var currentTime = DateTime.Now;           
            NC.RegisterNotification(currentTime);
        }

    }
}
