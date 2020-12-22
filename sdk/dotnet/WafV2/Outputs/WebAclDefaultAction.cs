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
    public sealed class WebAclDefaultAction
    {
        /// <summary>
        /// Specifies that AWS WAF should allow requests by default.
        /// </summary>
        public readonly Outputs.WebAclDefaultActionAllow? Allow;
        /// <summary>
        /// Specifies that AWS WAF should block requests by default.
        /// </summary>
        public readonly Outputs.WebAclDefaultActionBlock? Block;

        [OutputConstructor]
        private WebAclDefaultAction(
            Outputs.WebAclDefaultActionAllow? allow,

            Outputs.WebAclDefaultActionBlock? block)
        {
            Allow = allow;
            Block = block;
        }
    }
}
