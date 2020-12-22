// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Ec2.Inputs
{

    public sealed class FleetSpotOptionsMaintenanceStrategiesGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Nested argument containing the capacity rebalance for your fleet request. Defined below.
        /// </summary>
        [Input("capacityRebalance")]
        public Input<Inputs.FleetSpotOptionsMaintenanceStrategiesCapacityRebalanceGetArgs>? CapacityRebalance { get; set; }

        public FleetSpotOptionsMaintenanceStrategiesGetArgs()
        {
        }
    }
}
