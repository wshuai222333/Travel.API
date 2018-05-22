using System;
using System.Collections.Generic;
using System.Text;

namespace Travel.Api.DTO.BackTicket.Request
{
    /// <summary>
    /// 放款回调请求实体
    /// </summary>
    public class BackTicketRequest: RequestBaseModel {
        /// <summary>
        /// 订单号
        /// </summary>
        public string OrderId { get; set; }
        /// <summary>
        /// 放款状态
        /// </summary>
        public string BackStatus { get; set; }
        /// <summary>
        /// 放款时间
        /// </summary>
        public DateTime BackTime { get; set; }
        /// <summary>
        /// 放款失败原因
        /// </summary>
        public string BackMessage { get; set; }
    }
}
