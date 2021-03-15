using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discord
{
    public interface IMembershipScreenField
    {
        string FieldType { get; }

        string Label { get; }

        IReadOnlyCollection<string> Values { get; }

        bool Required { get; }
    }
}
