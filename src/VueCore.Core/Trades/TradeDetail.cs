using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace VueCore.Trades
{
    public class TradeDetail : Entity<int>
    {

        /// <summary>
        /// 等待平掉的Trade ID
        /// </summary>
        public int ClosingID { get; set; }

        /// <summary>
        /// 被平掉的Trade ID
        /// </summary>
        public int ClosedID{ get; set; }

        /// <summary>
        /// 被平掉的交易数
        /// </summary>
        public int Qty { get; set; }

        public decimal? CloseProfit { get; set; }

        [StringLength(1)]
        public string CloseFlag { get; set; }

        public DateTime InsertDate { get; set; }

        public DateTime LastUpadteDate { get; set; }

        [ForeignKey("ClosedID")]
        public Trade Trade { get; set; }

    }
}
