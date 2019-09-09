﻿// Copyright (c) Microsoft.  All Rights Reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Linq;
using System.Text;

namespace Microsoft.CodeAnalysis.Sarif
{
    public partial class Notification
    {
        public bool ShouldSerializeLocations() { return this.Locations.HasAtLeastOneNonDefaultValue(Location.ValueComparer); }

#if DEBUG
        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.Append(this.Locations?[0].PhysicalLocation?.ArtifactLocation?.Uri);
            sb.Append(" : " + this.Descriptor.Id);
            sb.Append(" : " + this.AssociatedRule?.Id);
            sb.Append(" : " + this.Level);

            if (!string.IsNullOrEmpty(this.Message.Text))
            {
                sb.Append(" : " + this.Message.Text);
            }
            else
            {
                sb.Append(" : {");
                foreach (string argument in this.Message.Arguments)
                {
                    sb.Append(argument + ",");
                }
                sb.Length = sb.Length - 1;
                sb.Append("}");

            }

            return sb.ToString();
        }
#endif

    }
}
