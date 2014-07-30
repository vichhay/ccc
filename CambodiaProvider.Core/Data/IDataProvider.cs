using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CambodiaProvider.Core.Data
{
    public interface IDataProvider
    {
        /// <summary>
        /// A value indicating whether this data provider supports stored procedures
        /// </summary>
        bool StoredProceduresSupported { get; }

        /// <summary>
        /// Gets a support database parameter object (used by stored procedures)
        /// </summary>
        /// <returns>Parameter</returns>
        DbParameter GetParameter();

        /// <summary>
        /// Gets the db provider invariant name (e.g. <c>System.Data.SqlClient</c>)
        /// </summary>
        string ProviderInvariantName { get; }
    }
}
