﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.F2FPay.AliPay.Domain
{
    public class AlipayTradeRefundDTO : AlipayDTO
    {
        
        public string trade_no { get; set; }

        public string out_trade_no { get; set; }

        public string refund_amount { get; set; }

        public string out_request_no { get; set; }

        public string refund_reason { get; set; }


    }
}
