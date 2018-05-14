﻿using Travel.DDD.IRepositories;
using Travel.Entity.CGTLOGModels;
using Travel.Entity.CGTModels;
using Travel.Entity.EFRepositories;

namespace Travel.Entity {
    /// <summary>
    /// 数据库连接
    /// </summary>
    public class DbBase {
        #region cgt数据库
        protected readonly cgtContext db;


        public readonly IExtensionRepository<InterfaceAccount> interfaceAccount;

        #endregion

        #region 日志
        protected readonly cgt_logContext cgtLogContext;
        public readonly IExtensionRepository<AliCheckTicketLog> aliCheckTicketLog;
       

        #endregion

        /// <summary>
        /// 构造方法
        /// </summary>
        public DbBase() {
            #region cgt数据库
            db = new cgtContext();

           
            interfaceAccount = new CgtEfRepository<InterfaceAccount>(db);

            #endregion
            #region cgt_log日志库
            var cgtLogdb = new cgt_logContext();

            aliCheckTicketLog = new CgtLogEfRepository<AliCheckTicketLog>(cgtLogContext);
           

            #endregion
        }
    }
}
