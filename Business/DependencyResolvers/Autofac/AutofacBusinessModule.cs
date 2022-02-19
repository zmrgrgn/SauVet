using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
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
            builder.RegisterType<HekimManager>().As<IHekimService>().SingleInstance();
            builder.RegisterType<EfHekimDal>().As<IHekimDal>().SingleInstance();
            builder.RegisterType<MamaManager>().As<IMamaService>().SingleInstance();
            builder.RegisterType<EfMamaDal>().As<IMamaDal>().SingleInstance();
            builder.RegisterType<VatandasBilgiManager>().As<IVatandasBilgiService>().SingleInstance();
            builder.RegisterType<EfVatandasBilgiDal>().As<IVatandasBilgiDal>().SingleInstance();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();

        }
    }
}
