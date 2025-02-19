﻿using Core.DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ITranslatorDal : IEntityRepository<Translator>
    {
        List<Translator> SearchFilter(string Empsearch);
    }
}
