using Newtonsoft.Json;
using System;
using Travel.Api.DTO.CheckTicket.Request;
using Travel.Entity.CGTLOGModels;
using TravelCheckTicketForA.Service;

namespace Travel.Api.Service.CheckTicket {
    public class CheckTicketService: ApiBase<RequestCheckTicket> {
        
        public CheckTicketForAProcessor checkTicketForAProcessor { get; set; }

        /// <summary>
        /// 执行方法
        /// </summary>
        protected override void ExecuteMethod() {
            var checkTicketRequestView = new CheckTicketRequestView() {
                RequestTime =this.Parameter.RequestTime,
                TikcetNo = this.Parameter.TicketNumber
            };
            checkTicketForAProcessor.Init(checkTicketRequestView);
            var execResult = checkTicketForAProcessor.Execute();

            #region  记录日志
            var _AliCheckTicketLog = new AliCheckTicketLog() {
                CreateTime = DateTime.Now,
                RequestTime = this.Parameter.RequestTime,
                ReturnMessage = execResult.Message,
                ReturnResult = JsonConvert.SerializeObject(execResult.Message),
                ReturnTime = DateTime.Now,
                TikcetNo = this.Parameter.TicketNumber,
                IsSuccess = execResult.Success == false ? 0 : 1
            };
            aliCheckTicketLog.Insert(_AliCheckTicketLog);
            #endregion

            if (execResult.Success) {
                this.Result.Data = execResult.Result;
            } else {
                throw new AggregateException("查询异常！");
            }
        }
    }
}
