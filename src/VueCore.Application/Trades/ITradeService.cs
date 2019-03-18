using Abp.Application.Services;
using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using VueCore.Trades.Dto;

namespace VueCore.Trades
{
    public interface ITradeService: IAsyncCrudAppService<TradeDto,int,PageTradeResultRequestDto,CreateTradeDto,TradeDto>
    {
    }
}
