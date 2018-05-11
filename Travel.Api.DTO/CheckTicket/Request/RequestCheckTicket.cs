using System;

namespace Travel.Api.DTO.CheckTicket.Request {
    public class RequestCheckTicket : RequestBaseModel {
        public string TicketNumber { get; set; }

        public DateTime RequestTime { get; set; }
    }
}
