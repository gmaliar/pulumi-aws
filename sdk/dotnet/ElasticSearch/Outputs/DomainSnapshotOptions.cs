// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.ElasticSearch.Outputs
{

    [OutputType]
    public sealed class DomainSnapshotOptions
    {
        /// <summary>
        /// Hour during which the service takes an automated daily snapshot of the indices in the domain.
        /// </summary>
        public readonly int AutomatedSnapshotStartHour;

        [OutputConstructor]
        private DomainSnapshotOptions(int automatedSnapshotStartHour)
        {
            AutomatedSnapshotStartHour = automatedSnapshotStartHour;
        }
    }
}
