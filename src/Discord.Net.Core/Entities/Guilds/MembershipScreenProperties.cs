using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discord
{
    public class MembershipScreenProperties
    {
        public Optional<bool> Enabled { get; set; }

        public Optional<IEnumerable<IMembershipScreenField>> FormFields { get; set; }

        public Optional<string> Description { get; set; }
    }
}
