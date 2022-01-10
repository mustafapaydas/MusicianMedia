using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstracts;
using Business.Concretes;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using Core.Utilities.Security.Jwt;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using DataAccess.Concretes.EntityFramework;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<MusicianManager>().As<IMusicianService>().SingleInstance();
            builder.RegisterType<EfMusicianDal>().As<IMusicianDal>().SingleInstance();

            builder.RegisterType<SingerManager>().As<ISingerService>().SingleInstance();
            builder.RegisterType<EfSingerDal>().As<ISingerDal>().SingleInstance();


            builder.RegisterType<MusicKindManager>().As<IMusicKindService>().SingleInstance();
            builder.RegisterType<EfMusicKindDal>().As<IMusicKindDal>().SingleInstance();

            builder.RegisterType<SongManager>().As<ISongService>().SingleInstance();
            builder.RegisterType<EfSongDal>().As<ISongDal>().SingleInstance();

            builder.RegisterType<GroupManager>().As<IGroupService>().SingleInstance();
            builder.RegisterType<EfGroupDal>().As<IGroupDal>().SingleInstance();

            builder.RegisterType<SongManager>().As<ISongService>().SingleInstance();
            builder.RegisterType<EfSongDal>().As<ISongDal>().SingleInstance();
            
            builder.RegisterType<InstrumentManager>().As<IInstrumentService>().SingleInstance();
            builder.RegisterType<EfInstrumentDal>().As<IInstrumentDal>().SingleInstance();

            builder.RegisterType<UserManager>().As<IUserService>();
            builder.RegisterType<EfUserDal>().As<IUserDal>();

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
