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
    public sealed class WebAclRuleStatementAndStatementStatementNotStatementStatementOrStatementStatement
    {
        /// <summary>
        /// A rule statement that defines a string match search for AWS WAF to apply to web requests. See Byte Match Statement below for details.
        /// </summary>
        public readonly Outputs.WebAclRuleStatementAndStatementStatementNotStatementStatementOrStatementStatementByteMatchStatement? ByteMatchStatement;
        /// <summary>
        /// A rule statement used to identify web requests based on country of origin. See GEO Match Statement below for details.
        /// </summary>
        public readonly Outputs.WebAclRuleStatementAndStatementStatementNotStatementStatementOrStatementStatementGeoMatchStatement? GeoMatchStatement;
        /// <summary>
        /// A rule statement used to detect web requests coming from particular IP addresses or address ranges. See IP Set Reference Statement below for details.
        /// </summary>
        public readonly Outputs.WebAclRuleStatementAndStatementStatementNotStatementStatementOrStatementStatementIpSetReferenceStatement? IpSetReferenceStatement;
        /// <summary>
        /// A rule statement used to search web request components for matches with regular expressions. See Regex Pattern Set Reference Statement below for details.
        /// </summary>
        public readonly Outputs.WebAclRuleStatementAndStatementStatementNotStatementStatementOrStatementStatementRegexPatternSetReferenceStatement? RegexPatternSetReferenceStatement;
        /// <summary>
        /// A rule statement that compares a number of bytes against the size of a request component, using a comparison operator, such as greater than (&gt;) or less than (&lt;). See Size Constraint Statement below for more details.
        /// </summary>
        public readonly Outputs.WebAclRuleStatementAndStatementStatementNotStatementStatementOrStatementStatementSizeConstraintStatement? SizeConstraintStatement;
        /// <summary>
        /// An SQL injection match condition identifies the part of web requests, such as the URI or the query string, that you want AWS WAF to inspect. See SQL Injection Match Statement below for details.
        /// </summary>
        public readonly Outputs.WebAclRuleStatementAndStatementStatementNotStatementStatementOrStatementStatementSqliMatchStatement? SqliMatchStatement;
        /// <summary>
        /// A rule statement that defines a cross-site scripting (XSS) match search for AWS WAF to apply to web requests. See XSS Match Statement below for details.
        /// </summary>
        public readonly Outputs.WebAclRuleStatementAndStatementStatementNotStatementStatementOrStatementStatementXssMatchStatement? XssMatchStatement;

        [OutputConstructor]
        private WebAclRuleStatementAndStatementStatementNotStatementStatementOrStatementStatement(
            Outputs.WebAclRuleStatementAndStatementStatementNotStatementStatementOrStatementStatementByteMatchStatement? byteMatchStatement,

            Outputs.WebAclRuleStatementAndStatementStatementNotStatementStatementOrStatementStatementGeoMatchStatement? geoMatchStatement,

            Outputs.WebAclRuleStatementAndStatementStatementNotStatementStatementOrStatementStatementIpSetReferenceStatement? ipSetReferenceStatement,

            Outputs.WebAclRuleStatementAndStatementStatementNotStatementStatementOrStatementStatementRegexPatternSetReferenceStatement? regexPatternSetReferenceStatement,

            Outputs.WebAclRuleStatementAndStatementStatementNotStatementStatementOrStatementStatementSizeConstraintStatement? sizeConstraintStatement,

            Outputs.WebAclRuleStatementAndStatementStatementNotStatementStatementOrStatementStatementSqliMatchStatement? sqliMatchStatement,

            Outputs.WebAclRuleStatementAndStatementStatementNotStatementStatementOrStatementStatementXssMatchStatement? xssMatchStatement)
        {
            ByteMatchStatement = byteMatchStatement;
            GeoMatchStatement = geoMatchStatement;
            IpSetReferenceStatement = ipSetReferenceStatement;
            RegexPatternSetReferenceStatement = regexPatternSetReferenceStatement;
            SizeConstraintStatement = sizeConstraintStatement;
            SqliMatchStatement = sqliMatchStatement;
            XssMatchStatement = xssMatchStatement;
        }
    }
}
