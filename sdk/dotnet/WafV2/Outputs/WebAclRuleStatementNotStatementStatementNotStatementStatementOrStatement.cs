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
    public sealed class WebAclRuleStatementNotStatementStatementNotStatementStatementOrStatement
    {
        /// <summary>
        /// The statements to combine with `OR` logic. You can use any statements that can be nested. See Statement above for details.
        /// </summary>
        public readonly ImmutableArray<Outputs.WebAclRuleStatementNotStatementStatementNotStatementStatementOrStatementStatement> Statements;

        [OutputConstructor]
        private WebAclRuleStatementNotStatementStatementNotStatementStatementOrStatement(ImmutableArray<Outputs.WebAclRuleStatementNotStatementStatementNotStatementStatementOrStatementStatement> statements)
        {
            Statements = statements;
        }
    }
}
