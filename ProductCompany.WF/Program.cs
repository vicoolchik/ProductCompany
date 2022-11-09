using AutoMapper;
using ProductCompany.BusinessLogic.Concrete;
using ProductCompany.BusinessLogic.Interfaces;
using ProductCompany.DAL.Concrete;
using ProductCompany.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;

namespace ProductCompany.WF
{
    static class Program
    {
        public static UnityContainer Container;
        //public static AppDataManager 
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ConfigureUnity();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            LoginForm lf = Container.Resolve<LoginForm>();

            if (lf.ShowDialog() == DialogResult.OK)
            {
                Application.Run(Container.Resolve<UserForm>());
            }
            else
            {
                Application.Exit();
            }
            //Application.Run(new UserForm());
        }

        private static void ConfigureUnity()
        {
            MapperConfiguration config = new MapperConfiguration(
                cfg =>
                {
                    cfg.AddMaps(typeof(ProductDal).Assembly);
                }
                );
            Container = new UnityContainer();
            Container.RegisterInstance<IMapper>(config.CreateMapper());
            Container.RegisterType<IProductDal, ProductDal>()
                .RegisterType<ICategoryDal, CategoryDal>()
                .RegisterType<ISupplierDal, SupplierDal>()
                .RegisterType<IUserDal, UserDal>()
                .RegisterType<IProductCompanyManager, ProductCompanyManager>()
                .RegisterType<IAuthManager, AuthManager>();
        }
    }
}
