using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;


namespace VueCore.Trades
{
    public class Trade : Entity<int>
    {

        [Required]
        [StringLength(20)]
        public string AccountNo { get; set; }

        [Required]
        [StringLength(50)]
        public string ProductCode { get; set; }

        [Required]
        [StringLength(5)]
        public string SecType { get; set; }

        [Required]
        [StringLength(4)]
        public string MMY { get; set; }
     
        [StringLength(1)]
        public string PutCall { get; set; }

        public  decimal? StrikePx { get; set; }

        [StringLength(50)]
        public string TradeID { get; set; }

        [StringLength(50)]
        public string OrderID { get; set; }

        public int TradeVenue { get; set; }

        [StringLength(1)]
        public string Side { get; set; }

        public int Qty { get; set; }

        [StringLength(10)]
        public string EventType { get; set; }

        public DateTime TradeDate { get; set; }

        public decimal TradePrice { get; set; }

        [StringLength(10)]
        public string Ccy { get; set; }

        public DateTime BizDate { get; set; }

        public DateTime InsertDate { get; set; }

        [StringLength(10)]
        public  string Exchange { get; set; }

        [StringLength(50)]
        public string ClearingMember { get; set; }

        [StringLength(5)]
        public string AccountType { get; set; }

        public int ContractSize { get; set; }

        [StringLength(1)]
        public string AllocateFlag { get; set; }

        [StringLength(50)]
        public string BizUnit { get; set; }

        [StringLength(50)]
        public string MarketID { get; set; }

        [StringLength(50)]
        public string GroupID { get; set; }
    }
}
