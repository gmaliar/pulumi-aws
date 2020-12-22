// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Ec2.Inputs
{

    public sealed class FleetSpotOptionsMaintenanceStrategiesCapacityRebalanceArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The replacement strategy to use. Only available for fleets of `type` set to `maintain`. Valid values: `launch`.
        /// </summary>
        [Input("replacementStrategy")]
        public Input<string>? ReplacementStrategy { get; set; }

        public FleetSpotOptionsMaintenanceStrategiesCapacityRebalanceArgs()
        {
        }
    }
}
