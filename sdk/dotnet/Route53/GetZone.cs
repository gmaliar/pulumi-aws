// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Route53
{
    public static class GetZone
    {
        /// <summary>
        /// `aws.route53.Zone` provides details about a specific Route 53 Hosted Zone.
        /// 
        /// This data source allows to find a Hosted Zone ID given Hosted Zone name and certain search criteria.
        /// 
        /// {{% examples %}}
        /// ## Example Usage
        /// {{% example %}}
        /// 
        /// The following example shows how to get a Hosted Zone from its name and from this data how to create a Record Set.
        /// 
        /// 
        /// ```csharp
        /// using Pulumi;
        /// using Aws = Pulumi.Aws;
        /// 
        /// class MyStack : Stack
        /// {
        ///     public MyStack()
        ///     {
        ///         var selected = Output.Create(Aws.Route53.GetZone.InvokeAsync(new Aws.Route53.GetZoneArgs
        ///         {
        ///             Name = "test.com.",
        ///             PrivateZone = true,
        ///         }));
        ///         var www = new Aws.Route53.Record("www", new Aws.Route53.RecordArgs
        ///         {
        ///             ZoneId = selected.Apply(selected =&gt; selected.ZoneId),
        ///             Name = selected.Apply(selected =&gt; $"www.{selected.Name}"),
        ///             Type = "A",
        ///             Ttl = 300,
        ///             Records = 
        ///             {
        ///                 "10.0.0.1",
        ///             },
        ///         });
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetZoneResult> InvokeAsync(GetZoneArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetZoneResult>("aws:route53/getZone:getZone", args ?? new GetZoneArgs(), options.WithVersion());
    }


    public sealed class GetZoneArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The Hosted Zone name of the desired Hosted Zone.
        /// </summary>
        [Input("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Used with `name` field to get a private Hosted Zone.
        /// </summary>
        [Input("privateZone")]
        public bool? PrivateZone { get; set; }

        /// <summary>
        /// The number of Record Set in the Hosted Zone.
        /// </summary>
        [Input("resourceRecordSetCount")]
        public int? ResourceRecordSetCount { get; set; }

        [Input("tags")]
        private Dictionary<string, string>? _tags;

        /// <summary>
        /// Used with `name` field. A map of tags, each pair of which must exactly match a pair on the desired Hosted Zone.
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get => _tags ?? (_tags = new Dictionary<string, string>());
            set => _tags = value;
        }

        /// <summary>
        /// Used with `name` field to get a private Hosted Zone associated with the vpc_id (in this case, private_zone is not mandatory).
        /// </summary>
        [Input("vpcId")]
        public string? VpcId { get; set; }

        /// <summary>
        /// The Hosted Zone id of the desired Hosted Zone.
        /// </summary>
        [Input("zoneId")]
        public string? ZoneId { get; set; }

        public GetZoneArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetZoneResult
    {
        /// <summary>
        /// Caller Reference of the Hosted Zone.
        /// </summary>
        public readonly string CallerReference;
        /// <summary>
        /// The comment field of the Hosted Zone.
        /// </summary>
        public readonly string Comment;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// The description provided by the service that created the Hosted Zone (e.g. `arn:aws:servicediscovery:us-east-1:1234567890:namespace/ns-xxxxxxxxxxxxxxxx`).
        /// </summary>
        public readonly string LinkedServiceDescription;
        /// <summary>
        /// The service that created the Hosted Zone (e.g. `servicediscovery.amazonaws.com`).
        /// </summary>
        public readonly string LinkedServicePrincipal;
        public readonly string Name;
        /// <summary>
        /// The list of DNS name servers for the Hosted Zone.
        /// </summary>
        public readonly ImmutableArray<string> NameServers;
        public readonly bool? PrivateZone;
        /// <summary>
        /// The number of Record Set in the Hosted Zone.
        /// </summary>
        public readonly int ResourceRecordSetCount;
        public readonly ImmutableDictionary<string, string> Tags;
        public readonly string VpcId;
        public readonly string ZoneId;

        [OutputConstructor]
        private GetZoneResult(
            string callerReference,

            string comment,

            string id,

            string linkedServiceDescription,

            string linkedServicePrincipal,

            string name,

            ImmutableArray<string> nameServers,

            bool? privateZone,

            int resourceRecordSetCount,

            ImmutableDictionary<string, string> tags,

            string vpcId,

            string zoneId)
        {
            CallerReference = callerReference;
            Comment = comment;
            Id = id;
            LinkedServiceDescription = linkedServiceDescription;
            LinkedServicePrincipal = linkedServicePrincipal;
            Name = name;
            NameServers = nameServers;
            PrivateZone = privateZone;
            ResourceRecordSetCount = resourceRecordSetCount;
            Tags = tags;
            VpcId = vpcId;
            ZoneId = zoneId;
        }
    }
}
