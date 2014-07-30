using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CambodiaProvider.Core.Extension
{
    public interface IMergedData
    {
        bool MergedDataIgnore { get; set; }
        Dictionary<string, object> MergedDataValues { get; }
    }
}
