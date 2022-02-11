﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IUnitOfWork : IDisposable
    {
        IUserDal Users { get; }
        ICategoryDal Categories { get; }
        IColorDal Colors { get; }
        IOfferConfirmDal OfferConfirms { get; }
        IProductBrandDal ProductBrands { get; }
        IUsageStatusDal UsageStatuses { get; }
        Task CommitAsync();
        void Commit();
    }
}

