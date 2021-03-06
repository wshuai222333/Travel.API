﻿using System;
using System.Collections.Generic;

namespace Travel.Entity.CGTModels
{
    public partial class TicketScannedLog
    {
        public int Id { get; set; }
        public string OrderId { get; set; }
        public string TicketNo { get; set; }
        public int? TicketType { get; set; }
        public string MerchantCode { get; set; }
        public string MerchantName { get; set; }
        public string BackUserName { get; set; }
        public string BackMerchantCode { get; set; }
        public DateTime? BackTime { get; set; }
        public int? RechargeStatus { get; set; }
        public int? IsSuspend { get; set; }
        public DateTime? DepartureTime { get; set; }
        public string FlightNo { get; set; }
        public string PassengerName { get; set; }
        public DateTime? CreateTime { get; set; }
        public Guid? TableId { get; set; }
    }
}
