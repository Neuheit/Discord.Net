using System;
using System.Collections.Generic;
using Model = Discord.API.MembershipScreenField;

namespace Discord.Rest
{
    public class RestMembershipScreenField : IMembershipScreenField
    {
        public string FieldType { get; private set; }

        public string Label { get; private set; }

        public IReadOnlyCollection<string> Values { get; private set; }

        public bool Required { get; private set; }

        public RestMembershipScreenField(string type, string label, string[] values, bool required)
        {
            FieldType = type;
            Label = label;
            Values = values;
            Required = required;
        }

        internal static RestMembershipScreenField Create(Model model)
        {
            return new RestMembershipScreenField(model.FieldType, model.Label, model.Values.IsSpecified ? model.Values.Value : Array.Empty<string>(), model.Required);
        }
    }
}
