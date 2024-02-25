using SienuoModel;
using SqlSugar;
using System.Configuration;

namespace SientuoDLL
{
    public static class SqlSugarUtil
    {
        public static SqlSugarClient SqlSugarClient
        {
            get
            {
                return new SqlSugarClient(new ConnectionConfig()
                {
                    //DbType = SetDBType(ConfigurationManager.AppSettings["DBType"]), //配置数据库类型
                    //ConnectionString = ConfigurationManager.AppSettings["ConnectionString"],  //数据库连接字符串
                    DbType = DbType.SqlServer,
                    ConnectionString= "data source=.;initial catalog=Test;user id=sa;password=sa123066;MultipleActiveResultSets=True;App=EntityFramework",
                    IsAutoCloseConnection = true,//设置为true无需使用using或者Close操作，自动关闭连接，不需要手动关闭数据链接
                    InitKeyType = InitKeyType.SystemTable//默认SystemTable, 字段信息读取, 如：该属性是不是主键，是不是标识列等等信息
                });
            }
        }
        public static DbType SetDBType(string dbType)
        {
            string sql = ConfigurationManager.AppSettings["DBType"];
            DbType DBType;
            switch (dbType.ToLower())
            {
                case "sqlserver":
                    DBType = DbType.SqlServer;
                    break;
                case "sqlite":
                    DBType = DbType.Sqlite;
                    break;
                case "mysql":
                    DBType = DbType.MySql;
                    break;
                default:
                    DBType = DbType.MySql;
                    break;
            }
            return DBType;
        }

    }
}
