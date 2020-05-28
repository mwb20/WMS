﻿using Coldairarrow.Entity.PB;
using Coldairarrow.IBusiness.DTO;
using Coldairarrow.Util;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Coldairarrow.Business.PB
{
    public partial interface IPB_LocationBusiness
    {
        Task<List<PB_Location>> GetQueryData(SelectQueryDTO search, string storId);
    }
}