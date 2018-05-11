using System;
using Travel.Api.DTO.CheckTicket.Request;
using TravelCheckTicketForA.Service;

namespace Travel.Api.Service.CheckTicket {
    public class CheckTicketService : ApiBase<RequestCheckTicket> {
        public CheckTicketForAProcessor checkTicketForAProcessor {get; set;}
        /// <summary>
        /// 执行方法
        /// </summary>
        protected override void ExecuteMethod() {
            var checkTicketRequestView = new CheckTicketRequestView() {
                RequestTime = this.Parameter.RequestTime,
                TikcetNo = this.Parameter.TicketNumber
            };
            checkTicketForAProcessor.Init(checkTicketRequestView);
            var execResult = checkTicketForAProcessor.Execute();
            if (execResult.Success) {
                this.Result.Data = execResult.Result;
            } else {
                throw new AggregateException("查询异常！");
            }
        }
    }
}
