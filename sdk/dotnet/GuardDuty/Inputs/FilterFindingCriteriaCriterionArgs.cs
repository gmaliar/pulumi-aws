// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.GuardDuty.Inputs
{

    public sealed class FilterFindingCriteriaCriterionArgs : Pulumi.ResourceArgs
    {
        [Input("equals")]
        private InputList<string>? _equals;

        /// <summary>
        /// List of string values to be evaluated.
        /// </summary>
        public InputList<string> Equals
        {
            get => _equals ?? (_equals = new InputList<string>());
            set => _equals = value;
        }

        /// <summary>
        /// The name of the field to be evaluated. The full list of field names can be found in [AWS documentation](https://docs.aws.amazon.com/guardduty/latest/ug/guardduty_filter-findings.html#filter_criteria).
        /// </summary>
        [Input("field", required: true)]
        public Input<string> Field { get; set; } = null!;

        /// <summary>
        /// A value to be evaluated. Accepts either an integer or a date in [RFC 3339 format](https://tools.ietf.org/html/rfc3339#section-5.8).
        /// </summary>
        [Input("greaterThan")]
        public Input<string>? GreaterThan { get; set; }

        /// <summary>
        /// A value to be evaluated. Accepts either an integer or a date in [RFC 3339 format](https://tools.ietf.org/html/rfc3339#section-5.8).
        /// </summary>
        [Input("greaterThanOrEqual")]
        public Input<string>? GreaterThanOrEqual { get; set; }

        /// <summary>
        /// A value to be evaluated. Accepts either an integer or a date in [RFC 3339 format](https://tools.ietf.org/html/rfc3339#section-5.8).
        /// </summary>
        [Input("lessThan")]
        public Input<string>? LessThan { get; set; }

        /// <summary>
        /// A value to be evaluated. Accepts either an integer or a date in [RFC 3339 format](https://tools.ietf.org/html/rfc3339#section-5.8).
        /// </summary>
        [Input("lessThanOrEqual")]
        public Input<string>? LessThanOrEqual { get; set; }

        [Input("notEquals")]
        private InputList<string>? _notEquals;

        /// <summary>
        /// List of string values to be evaluated.
        /// </summary>
        public InputList<string> NotEquals
        {
            get => _notEquals ?? (_notEquals = new InputList<string>());
            set => _notEquals = value;
        }

        public FilterFindingCriteriaCriterionArgs()
        {
        }
    }
}
