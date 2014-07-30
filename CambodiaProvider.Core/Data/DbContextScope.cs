using CambodiaProvider.Core.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CambodiaProvider.Core.Data
{
    public class DbContextScope : IDisposable
    {

        private readonly bool _autoDetectChangesEnabled;
        private readonly bool _proxyCreationEnabled;
        private readonly bool _validateOnSaveEnabled;
        private readonly IDbContext _ctx;

        public DbContextScope(IDbContext cxt = null, bool? autoDetectChangesEnabled = null, bool? proxyCreationEnabled = null, bool? validateOnSaveEnabled = null)
        {
            _ctx = cxt ?? EngineContext.Current.Resolve<IDbContext>();
            _autoDetectChangesEnabled = _ctx.AutoDetectChangesEnabled;
            _proxyCreationEnabled = _ctx.ProxyCreationEnabled;
            _validateOnSaveEnabled = _ctx.ValidateOnSaveEnabled;

            if (autoDetectChangesEnabled.HasValue)
                _ctx.AutoDetectChangesEnabled = autoDetectChangesEnabled.Value;

            if (proxyCreationEnabled.HasValue)
                _ctx.ProxyCreationEnabled = proxyCreationEnabled.Value;

            if (validateOnSaveEnabled.HasValue)
                _ctx.ValidateOnSaveEnabled = validateOnSaveEnabled.Value;
        }

        public int Commit()
        {
            return _ctx.SaveChanges();
        }

        public void Dispose()
        {
            _ctx.AutoDetectChangesEnabled = _autoDetectChangesEnabled;
            _ctx.ProxyCreationEnabled = _proxyCreationEnabled;
            _ctx.ValidateOnSaveEnabled = _validateOnSaveEnabled;
        }

    }
}
