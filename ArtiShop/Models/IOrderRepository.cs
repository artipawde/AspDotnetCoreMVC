﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtiShop.Models
{
    public interface IOrderRepository
    {
        void CreateOrder(Order order);
    //    void CreatePieGiftOrder(PieGiftOrder pieGiftOrder);
    }
}
