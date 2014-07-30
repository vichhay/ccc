﻿using System;
using System.Threading;

namespace CambodiaProvider.Core.Extension
{

    public sealed class UpgradeableReadLockDisposable : IDisposable
    {
        private readonly ReaderWriterLockSlim _rwLock;

        public UpgradeableReadLockDisposable(ReaderWriterLockSlim rwLock)
        {
            this._rwLock = rwLock;
        }

        void IDisposable.Dispose()
        {
            this._rwLock.ExitUpgradeableReadLock();
        }


    }

}
