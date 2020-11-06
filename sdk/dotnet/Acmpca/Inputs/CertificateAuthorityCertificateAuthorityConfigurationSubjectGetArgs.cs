// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Acmpca.Inputs
{

    public sealed class CertificateAuthorityCertificateAuthorityConfigurationSubjectGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Fully qualified domain name (FQDN) associated with the certificate subject. Must be less than or equal to 64 characters in length.
        /// </summary>
        [Input("commonName")]
        public Input<string>? CommonName { get; set; }

        /// <summary>
        /// Two digit code that specifies the country in which the certificate subject located. Must be less than or equal to 2 characters in length.
        /// </summary>
        [Input("country")]
        public Input<string>? Country { get; set; }

        /// <summary>
        /// Disambiguating information for the certificate subject. Must be less than or equal to 64 characters in length.
        /// </summary>
        [Input("distinguishedNameQualifier")]
        public Input<string>? DistinguishedNameQualifier { get; set; }

        /// <summary>
        /// Typically a qualifier appended to the name of an individual. Examples include Jr. for junior, Sr. for senior, and III for third. Must be less than or equal to 3 characters in length.
        /// </summary>
        [Input("generationQualifier")]
        public Input<string>? GenerationQualifier { get; set; }

        /// <summary>
        /// First name. Must be less than or equal to 16 characters in length.
        /// </summary>
        [Input("givenName")]
        public Input<string>? GivenName { get; set; }

        /// <summary>
        /// Concatenation that typically contains the first letter of the `given_name`, the first letter of the middle name if one exists, and the first letter of the `surname`. Must be less than or equal to 5 characters in length.
        /// </summary>
        [Input("initials")]
        public Input<string>? Initials { get; set; }

        /// <summary>
        /// The locality (such as a city or town) in which the certificate subject is located. Must be less than or equal to 128 characters in length.
        /// </summary>
        [Input("locality")]
        public Input<string>? Locality { get; set; }

        /// <summary>
        /// Legal name of the organization with which the certificate subject is affiliated. Must be less than or equal to 64 characters in length.
        /// </summary>
        [Input("organization")]
        public Input<string>? Organization { get; set; }

        /// <summary>
        /// A subdivision or unit of the organization (such as sales or finance) with which the certificate subject is affiliated. Must be less than or equal to 64 characters in length.
        /// </summary>
        [Input("organizationalUnit")]
        public Input<string>? OrganizationalUnit { get; set; }

        /// <summary>
        /// Typically a shortened version of a longer `given_name`. For example, Jonathan is often shortened to John. Elizabeth is often shortened to Beth, Liz, or Eliza. Must be less than or equal to 128 characters in length.
        /// </summary>
        [Input("pseudonym")]
        public Input<string>? Pseudonym { get; set; }

        /// <summary>
        /// State in which the subject of the certificate is located. Must be less than or equal to 128 characters in length.
        /// </summary>
        [Input("state")]
        public Input<string>? State { get; set; }

        /// <summary>
        /// Family name. In the US and the UK for example, the surname of an individual is ordered last. In Asian cultures the surname is typically ordered first. Must be less than or equal to 40 characters in length.
        /// </summary>
        [Input("surname")]
        public Input<string>? Surname { get; set; }

        /// <summary>
        /// A title such as Mr. or Ms. which is pre-pended to the name to refer formally to the certificate subject. Must be less than or equal to 64 characters in length.
        /// </summary>
        [Input("title")]
        public Input<string>? Title { get; set; }

        public CertificateAuthorityCertificateAuthorityConfigurationSubjectGetArgs()
        {
        }
    }
}
