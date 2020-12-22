// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.WafV2.Outputs
{

    [OutputType]
    public sealed class RuleGroupRuleStatementNotStatementStatementAndStatementStatementSizeConstraintStatement
    {
        /// <summary>
        /// The operator to use to compare the request part to the size setting. Valid values include: `EQ`, `NE`, `LE`, `LT`, `GE`, or `GT`.
        /// </summary>
        public readonly string ComparisonOperator;
        /// <summary>
        /// The part of a web request that you want AWS WAF to inspect. See Field to Match below for details.
        /// </summary>
        public readonly Outputs.RuleGroupRuleStatementNotStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatch? FieldToMatch;
        /// <summary>
        /// The size, in bytes, to compare to the request part, after any transformations. Valid values are integers between 0 and 21474836480, inclusive.
        /// </summary>
        public readonly int Size;
        /// <summary>
        /// Text transformations eliminate some of the unusual formatting that attackers use in web requests in an effort to bypass detection. See Text Transformation below for details.
        /// </summary>
        public readonly ImmutableArray<Outputs.RuleGroupRuleStatementNotStatementStatementAndStatementStatementSizeConstraintStatementTextTransformation> TextTransformations;

        [OutputConstructor]
        private RuleGroupRuleStatementNotStatementStatementAndStatementStatementSizeConstraintStatement(
            string comparisonOperator,

            Outputs.RuleGroupRuleStatementNotStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatch? fieldToMatch,

            int size,

            ImmutableArray<Outputs.RuleGroupRuleStatementNotStatementStatementAndStatementStatementSizeConstraintStatementTextTransformation> textTransformations)
        {
            ComparisonOperator = comparisonOperator;
            FieldToMatch = fieldToMatch;
            Size = size;
            TextTransformations = textTransformations;
        }
    }
}
