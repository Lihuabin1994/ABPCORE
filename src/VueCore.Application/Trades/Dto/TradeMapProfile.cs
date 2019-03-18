using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace VueCore.Trades.Dto
{
   public class TradeMapProfile :Profile
    {
        public TradeMapProfile()
        {
            CreateMap<TradeDto, Trade>();
            CreateMap<CreateTradeDto, Trade>();
        }
    }
}
