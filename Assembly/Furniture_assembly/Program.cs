using Furniture_assembly_BusinessLogic.BusinessLogics;
using Furniture_assembly_BusinessLogic.Interfaces;
using Furniture_assembly_DatabaseImplement.Implements;
using System;
using System.Windows.Forms;
using Unity;
using Unity.Lifetime;

namespace Furniture_assembly
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var container = BuildUnityContainer();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(container.Resolve<FormMain>());
        }
        private static IUnityContainer BuildUnityContainer()
        {
            var currentContainer = new UnityContainer();

            currentContainer.RegisterType<IComponentStorage, ComponentStorage>(new HierarchicalLifetimeManager());

            currentContainer.RegisterType<IOrderStorage, OrderStorage>(new HierarchicalLifetimeManager());

            currentContainer.RegisterType<IFurnitureStorage, FurnitureStorage>(new HierarchicalLifetimeManager());

            currentContainer.RegisterType<IStoreHouseStorage, StoreHouseStorage>(new HierarchicalLifetimeManager());

            currentContainer.RegisterType<ComponentLogic>(new HierarchicalLifetimeManager());

            currentContainer.RegisterType<OrderLogic>(new HierarchicalLifetimeManager());

            currentContainer.RegisterType<FurnitureLogic>(new HierarchicalLifetimeManager());

            currentContainer.RegisterType<ReportLogic>(new HierarchicalLifetimeManager());

            currentContainer.RegisterType<StoreHouseLogic>(new HierarchicalLifetimeManager());

            return currentContainer;
        }
    }
}
