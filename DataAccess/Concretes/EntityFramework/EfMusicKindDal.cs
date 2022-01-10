﻿using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess.Concretes;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfMusicKindDal:EfEntityRepositoryBase<MusicKind,MusicContext>,IMusicKindDal
    {
    }
}
