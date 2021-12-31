using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using Business.Abstracts;
using Business.Concretes;
using Core.Utilities.Security.Jwt;
using DataAccess.Abstracts;
using DataAccess.Concretes;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<MusicianManager>().As<IMusicianService>();
            builder.RegisterType<EfMusicianDal>().As<IMusicianDal>();

            builder.RegisterType<GroupManager>().As<IGroupService>();
            builder.RegisterType<EfGroupDal>().As<IGroupDal>();

            builder.RegisterType<SongManager>().As<ISongService>();
            builder.RegisterType<EfSongDal>().As<ISongDal>();
            
            builder.RegisterType<InstrumentManager>().As<IInstrumentService>();
            builder.RegisterType<EfInstrumentDal>().As<IInstrumentDal>();

            builder.RegisterType<UserManager>().As<IUserService>();
            builder.RegisterType<EfUserDal>().As<IUserDal>();

            builder.RegisterType<AuthManager>().As<IAuthService>();
            builder.RegisterType<JwtHelper>().As<ITokenHelper>();

        }
    }
}
