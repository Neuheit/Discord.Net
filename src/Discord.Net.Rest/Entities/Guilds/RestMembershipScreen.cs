using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord;
using MembershipModel = Discord.API.MembershipScreen;
using FieldModel = Discord.API.MembershipScreenField;

namespace Discord.Rest
{
    public class RestMembershipScreen : IMembershipScreen
    {
        public DateTimeOffset Version { get; private set; }

        public IReadOnlyCollection<IMembershipScreenField> FormFields { get; private set; }

        public string Description { get; private set; }

        internal RestMembershipScreen(DateTimeOffset version, IMembershipScreenField[] fields, string description)
        {
            Version = version;
            FormFields = fields.ToReadOnlyCollection();
            Description = description;
        }

        internal static RestMembershipScreen Create(MembershipModel model)
        {
            RestMembershipScreenField[] fields = new RestMembershipScreenField[model.FormFields.Length];
            for(var i = 0; i < model.FormFields.Length; i++)
            {
                fields[i] = RestMembershipScreenField.Create(model.FormFields[i]);
            }

            return new RestMembershipScreen(model.Version, fields, model.Description);
        }
    }
}
