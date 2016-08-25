﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;

namespace Microsoft.CodeAnalysis.Sarif.Cli.Rules
{
    public class DoNotUseFriendlyNameAsRuleId : SarifValidationSkimmerBase
    {
        public override string FullDescription => RuleResources.SV0001_DoNotUseFriendlyNameAsRuleIdDescription;

        /// <summary>
        /// SV0001
        /// </summary>
        public override string Id => RuleId.DoNotUseFriendlyNameAsRuleId;

        protected override IEnumerable<string> FormatIds
        {
            get
            {
                return new string[]
                {
                    nameof(RuleResources.SV0001_DefaultFormatId)
                };
            }
        }

        protected override void Analyze(Rule rule, string rulePointer)
        {
            if (rule.Id != null
                && rule.Name != null 
                && rule.Id.Equals(rule.Name, StringComparison.OrdinalIgnoreCase))
            {
                LogResult(
                    ResultLevel.Warning,
                    rulePointer,
                    nameof(RuleResources.SV0001_DefaultFormatId),
                    rule.Id);
            }
        }
    }
}
