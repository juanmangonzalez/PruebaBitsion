using LayerBus;
using LayerBus.Implementaciones;
using LayerBus.Interfaces;
using LayerDataAccess;
using LayerDataAccess.Implementaciones;
using LayerDataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Unity;
using Unity.AspNet.Mvc;

namespace BitsionPrueba.App_Start
{
    public class UnityConfig
    {
        public static IUnityContainer Initialize()
        {
            var container = BuildUnityContainer();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
            return container;
        }
        private static IUnityContainer BuildUnityContainer()
        {
            var container = new UnityContainer();

            // register all your components with the container here  
            //This is the important line to edit  
            container.RegisterType<IPlayListBus, PlayListBus>();
            container.RegisterType<IUserBus, UserBus>();
            container.RegisterType<IPlayListDBRepository, PlayListDBRepository>();
            container.RegisterType<IUserDBRepository, UserDBRepository>();
            container.RegisterType<IContext, Context>();
            RegisterTypes(container);
            return container;
        }
        public static void RegisterTypes(IUnityContainer container)
        {

        }
    }
}