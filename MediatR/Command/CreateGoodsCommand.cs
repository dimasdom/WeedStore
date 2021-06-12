﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeedStore.Models.Goods;

namespace WeedStore.MediatR.Command
{
    public class CreateGoodsCommand:IRequest<bool>
    {
        public CreateGoodsCommand(GoodsModel goods)
        {
            Goods = goods;
        }

        public GoodsModel Goods { get; set; }
    }
}
