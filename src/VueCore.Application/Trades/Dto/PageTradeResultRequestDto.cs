using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace VueCore.Trades.Dto
{
   public  class PageTradeResultRequestDto : PagedResultRequestDto
    {

        public string AccountNo { get; set; }

      
        public string ProductCode { get; set; }

        public string SecType { get; set; }

        public string MMY { get; set; }

        public string PutCall { get; set; }

        public decimal? StrikePx { get; set; }

        public string TradeID { get; set; }

        public string OrderID { get; set; }

        public int TradeVenue { get; set; }

        public string Side { get; set; }

        public int Qty { get; set; }

        public string EventType { get; set; }

        public DateTime TradeDate { get; set; }

        public decimal TradePrice { get; set; }

        public string Ccy { get; set; }

        public DateTime BizDate { get; set; }

        public DateTime InsertDate { get; set; }

        public string Exchange { get; set; }

        public string ClearingMember { get; set; }

        public string AccountType { get; set; }

        public int ContractSize { get; set; }

        public string AllocateFlag { get; set; }

        public string BizUnit { get; set; }

        public string MarketID { get; set; }

        public string GroupID { get; set; }

        public DateTimeOffset? From { get; set; }//javascript date within timezone
        public DateTimeOffset? To { get; set; }//javascript date within timezone
    }
}
