﻿using Core.DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IBookPublisherDal : IEntityRepository<BookPublisher>
    {
        List<BookPublisher> SearchFilter(string EmpsearchName);
        List<BookPublisher> GetListWithBookCategories();
        BookPublisher GetByIdWithBookCategories(int id);
    }
}
