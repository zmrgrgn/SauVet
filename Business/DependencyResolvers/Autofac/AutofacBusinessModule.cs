using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using Core.Utilities.Security.JWT;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<HayvanKayitManager>().As<IHayvanKayitService>().SingleInstance();
            builder.RegisterType<EfHayvanKayitDal>().As<IHayvanKayitDal>().SingleInstance();
            builder.RegisterType<HayvanTedaviManager>().As<IHayvanTedaviService>().SingleInstance();
            builder.RegisterType<EfHayvanTedaviDal>().As<IHayvanTedaviDal>().SingleInstance();
            builder.RegisterType<BelediyeBilgiManager>().As<IBelediyeBilgiService>().SingleInstance();
            builder.RegisterType<EfBelediyeBilgiDal>().As<IBelediyeBilgiDal>().SingleInstance();
            builder.RegisterType<HayvanSahiplendirmeManager>().As<IHayvanSahiplendirmeService>().SingleInstance();
            builder.RegisterType<EfHayvanSahiplendirmeDal>().As<IHayvanSahiplendirmeDal>().SingleInstance();
            builder.RegisterType<MamaManager>().As<IMamaService>().SingleInstance();
            builder.RegisterType<EfMamaDal>().As<IMamaDal>().SingleInstance();
            builder.RegisterType<VatandasBilgiManager>().As<IVatandasBilgiService>().SingleInstance();
            builder.RegisterType<EfVatandasBilgiDal>().As<IVatandasBilgiDal>().SingleInstance();
            builder.RegisterType<UserManager>().As<IUserService>();
            builder.RegisterType<EfUserDal>().As<IUserDal>();
            builder.RegisterType<HayvanTurManager>().As<IHayvanTurService>().SingleInstance();
            builder.RegisterType<EfHayvanTurDal>().As<IHayvanTurDal>().SingleInstance();
            builder.RegisterType<KafesNoManager>().As<IKafesNoService>().SingleInstance();
            builder.RegisterType<EfKafesNoDal>().As<IKafesNoDal>().SingleInstance();

            builder.RegisterType<AuthManager>().As<IAuthService>();
            builder.RegisterType<JwtHelper>().As<ITokenHelper>();


            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();

        }
    }
}
