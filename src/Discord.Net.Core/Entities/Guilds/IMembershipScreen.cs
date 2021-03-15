using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discord
{
    public interface IMembershipScreen
    {
        /// <summary>
        ///     Gets when this screen's fields were last updated.
        /// </summary>
        /// <returns>
        ///     A <see cref="DateTimeOffset"/> containing a date and time of day when the fields were last updated.
        /// </returns>
        DateTimeOffset Version { get; }

        IReadOnlyCollection<IMembershipScreenField> FormFields { get; }

        string Description { get; }
    }
}
