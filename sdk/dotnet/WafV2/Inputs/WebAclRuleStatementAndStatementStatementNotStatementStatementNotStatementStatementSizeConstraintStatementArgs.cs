// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.WafV2.Inputs
{

    public sealed class WebAclRuleStatementAndStatementStatementNotStatementStatementNotStatementStatementSizeConstraintStatementArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The operator to use to compare the request part to the size setting. Valid values include: `EQ`, `NE`, `LE`, `LT`, `GE`, or `GT`.
        /// </summary>
        [Input("comparisonOperator", required: true)]
        public Input<string> ComparisonOperator { get; set; } = null!;

        /// <summary>
        /// The part of a web request that you want AWS WAF to inspect. See Field to Match below for details.
        /// </summary>
        [Input("fieldToMatch")]
        public Input<Inputs.WebAclRuleStatementAndStatementStatementNotStatementStatementNotStatementStatementSizeConstraintStatementFieldToMatchArgs>? FieldToMatch { get; set; }

        /// <summary>
        /// The size, in bytes, to compare to the request part, after any transformations. Valid values are integers between 0 and 21474836480, inclusive.
        /// </summary>
        [Input("size", required: true)]
        public Input<int> Size { get; set; } = null!;

        [Input("textTransformations", required: true)]
        private InputList<Inputs.WebAclRuleStatementAndStatementStatementNotStatementStatementNotStatementStatementSizeConstraintStatementTextTransformationArgs>? _textTransformations;

        /// <summary>
        /// Text transformations eliminate some of the unusual formatting that attackers use in web requests in an effort to bypass detection. See Text Transformation below for details.
        /// </summary>
        public InputList<Inputs.WebAclRuleStatementAndStatementStatementNotStatementStatementNotStatementStatementSizeConstraintStatementTextTransformationArgs> TextTransformations
        {
            get => _textTransformations ?? (_textTransformations = new InputList<Inputs.WebAclRuleStatementAndStatementStatementNotStatementStatementNotStatementStatementSizeConstraintStatementTextTransformationArgs>());
            set => _textTransformations = value;
        }

        public WebAclRuleStatementAndStatementStatementNotStatementStatementNotStatementStatementSizeConstraintStatementArgs()
        {
        }
    }
}
