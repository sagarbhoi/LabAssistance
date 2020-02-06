﻿using Autofac;
using Autofac.Integration.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VGEC.Models;

namespace VGEC.App_Start
{
    public class ContainerConfig
    {
        internal static void Register()
        {
            var builer = new ContainerBuilder();
           builer.RegisterControllers(typeof(MvcApplication).Assembly);
            builer.RegisterType<VgecDbContext>().InstancePerRequest();
            var container = builer.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}