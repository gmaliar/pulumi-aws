// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Kinesis.Inputs
{

    public sealed class FirehoseDeliveryStreamHttpEndpointConfigurationRequestConfigurationGetArgs : Pulumi.ResourceArgs
    {
        [Input("commonAttributes")]
        private InputList<Inputs.FirehoseDeliveryStreamHttpEndpointConfigurationRequestConfigurationCommonAttributeGetArgs>? _commonAttributes;

        /// <summary>
        /// Describes the metadata sent to the HTTP endpoint destination. More details are given below
        /// </summary>
        public InputList<Inputs.FirehoseDeliveryStreamHttpEndpointConfigurationRequestConfigurationCommonAttributeGetArgs> CommonAttributes
        {
            get => _commonAttributes ?? (_commonAttributes = new InputList<Inputs.FirehoseDeliveryStreamHttpEndpointConfigurationRequestConfigurationCommonAttributeGetArgs>());
            set => _commonAttributes = value;
        }

        /// <summary>
        /// Kinesis Data Firehose uses the content encoding to compress the body of a request before sending the request to the destination. Valid values are `NONE` and `GZIP`.  Default value is `NONE`.
        /// </summary>
        [Input("contentEncoding")]
        public Input<string>? ContentEncoding { get; set; }

        public FirehoseDeliveryStreamHttpEndpointConfigurationRequestConfigurationGetArgs()
        {
        }
    }
}
