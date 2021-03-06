using Beef.Data.Database;
using System.Data.Common;

namespace CFS.Assesment.Online.Business.Data
{
    /// <summary>
    /// Represents the <b>CFS.Assesment.Online</b> database.
    /// </summary>
    public class OnlineDb : DatabaseBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OnlineDb"/> class.
        /// </summary>
        /// <param name="connectionString">The connection string.</param>
        /// <param name="provider">The optional data provider.</param>
        public OnlineDb(string connectionString, DbProviderFactory? provider = null) : base(connectionString, provider, new SqlRetryDatabaseInvoker()) { }

        /// <summary>
        /// Set the SQL Session Context when the connection is opened.
        /// </summary>
        /// <param name="dbConnection">The <see cref="DbConnection"/>.</param>
        public override void OnConnectionOpen(DbConnection dbConnection) => SetSqlSessionContext(dbConnection);
    }
}