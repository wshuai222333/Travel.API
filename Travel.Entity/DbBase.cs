using Travel.DDD.IRepositories;
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
        //protected readonly CgtLogContext cgtLogContext;
        //public readonly IExtensionRepository<ApiNotifyLog> apiNotifyLog;
        //public readonly IExtensionRepository<Tranfer_Logs> tranfer_logs;

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
            //cgtLogContext = new CgtLogContext();

            //apiNotifyLog = new CgtLogEfRepository<CGT.Entity.CgtLogModel.ApiNotifyLog>(cgtLogContext);
            //tranfer_logs = new CgtLogEfRepository<Tranfer_Logs>(cgtLogContext);

            #endregion
        }
    }
}
