﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vcart.Core.Entities;

namespace vcart.Services.Interfaces
{
    public interface IOrderService : IService<Order>
    {
        Order GetOrderDetailWithItem(string id);
    }
}
