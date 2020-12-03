// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package route53

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Provides a Route53 record resource.
//
// ## Example Usage
// ### Weighted routing policy
// Other routing policies are configured similarly. See [AWS Route53 Developer Guide](https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/routing-policy.html) for details.
//
// ```go
// package main
//
// import (
// 	"github.com/pulumi/pulumi-aws/sdk/v3/go/aws/route53"
// 	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
// )
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		_, err := route53.NewRecord(ctx, "www_dev", &route53.RecordArgs{
// 			ZoneId: pulumi.Any(aws_route53_zone.Primary.Zone_id),
// 			Name:   pulumi.String("www"),
// 			Type:   pulumi.String("CNAME"),
// 			Ttl:    pulumi.Int(5),
// 			WeightedRoutingPolicies: route53.RecordWeightedRoutingPolicyArray{
// 				&route53.RecordWeightedRoutingPolicyArgs{
// 					Weight: pulumi.Int(10),
// 				},
// 			},
// 			SetIdentifier: pulumi.String("dev"),
// 			Records: pulumi.StringArray{
// 				pulumi.String("dev.example.com"),
// 			},
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		_, err = route53.NewRecord(ctx, "www_live", &route53.RecordArgs{
// 			ZoneId: pulumi.Any(aws_route53_zone.Primary.Zone_id),
// 			Name:   pulumi.String("www"),
// 			Type:   pulumi.String("CNAME"),
// 			Ttl:    pulumi.Int(5),
// 			WeightedRoutingPolicies: route53.RecordWeightedRoutingPolicyArray{
// 				&route53.RecordWeightedRoutingPolicyArgs{
// 					Weight: pulumi.Int(90),
// 				},
// 			},
// 			SetIdentifier: pulumi.String("live"),
// 			Records: pulumi.StringArray{
// 				pulumi.String("live.example.com"),
// 			},
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
// ### Alias record
// See [related part of AWS Route53 Developer Guide](https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/resource-record-sets-choosing-alias-non-alias.html)
// to understand differences between alias and non-alias records.
//
// TTL for all alias records is [60 seconds](https://aws.amazon.com/route53/faqs/#dns_failover_do_i_need_to_adjust),
// you cannot change this, therefore `ttl` has to be omitted in alias records.
//
// ```go
// package main
//
// import (
// 	"github.com/pulumi/pulumi-aws/sdk/v3/go/aws/elb"
// 	"github.com/pulumi/pulumi-aws/sdk/v3/go/aws/route53"
// 	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
// )
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		main, err := elb.NewLoadBalancer(ctx, "main", &elb.LoadBalancerArgs{
// 			AvailabilityZones: pulumi.StringArray{
// 				pulumi.String("us-east-1c"),
// 			},
// 			Listeners: elb.LoadBalancerListenerArray{
// 				&elb.LoadBalancerListenerArgs{
// 					InstancePort:     pulumi.Int(80),
// 					InstanceProtocol: pulumi.String("http"),
// 					LbPort:           pulumi.Int(80),
// 					LbProtocol:       pulumi.String("http"),
// 				},
// 			},
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		_, err = route53.NewRecord(ctx, "www", &route53.RecordArgs{
// 			ZoneId: pulumi.Any(aws_route53_zone.Primary.Zone_id),
// 			Name:   pulumi.String("example.com"),
// 			Type:   pulumi.String("A"),
// 			Aliases: route53.RecordAliasArray{
// 				&route53.RecordAliasArgs{
// 					Name:                 main.DnsName,
// 					ZoneId:               main.ZoneId,
// 					EvaluateTargetHealth: pulumi.Bool(true),
// 				},
// 			},
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
// ### NS and SOA Record Management
//
// When creating Route 53 zones, the `NS` and `SOA` records for the zone are automatically created. Enabling the `allowOverwrite` argument will allow managing these records in a single deployment without the requirement for `import`.
//
// ```go
// package main
//
// import (
// 	"github.com/pulumi/pulumi-aws/sdk/v3/go/aws/route53"
// 	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
// )
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		exampleZone, err := route53.NewZone(ctx, "exampleZone", nil)
// 		if err != nil {
// 			return err
// 		}
// 		_, err = route53.NewRecord(ctx, "exampleRecord", &route53.RecordArgs{
// 			AllowOverwrite: pulumi.Bool(true),
// 			Name:           pulumi.String("test.example.com"),
// 			Ttl:            pulumi.Int(30),
// 			Type:           pulumi.String("NS"),
// 			ZoneId:         exampleZone.ZoneId,
// 			Records: pulumi.StringArray{
// 				exampleZone.NameServers.ApplyT(func(nameServers []string) (string, error) {
// 					return nameServers[0], nil
// 				}).(pulumi.StringOutput),
// 				exampleZone.NameServers.ApplyT(func(nameServers []string) (string, error) {
// 					return nameServers[1], nil
// 				}).(pulumi.StringOutput),
// 				exampleZone.NameServers.ApplyT(func(nameServers []string) (string, error) {
// 					return nameServers[2], nil
// 				}).(pulumi.StringOutput),
// 				exampleZone.NameServers.ApplyT(func(nameServers []string) (string, error) {
// 					return nameServers[3], nil
// 				}).(pulumi.StringOutput),
// 			},
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
//
// ## Import
//
// Route53 Records can be imported using ID of the record, which is the zone identifier, record name, and record type, separated by underscores (`_`). e.g.
//
// ```sh
//  $ pulumi import aws:route53/record:Record myrecord Z4KAPRWWNC7JR_dev.example.com_NS
// ```
//
//  If the record also contains a delegated set identifier, it can be appended
//
// ```sh
//  $ pulumi import aws:route53/record:Record myrecord Z4KAPRWWNC7JR_dev.example.com_NS_dev
// ```
type Record struct {
	pulumi.CustomResourceState

	// An alias block. Conflicts with `ttl` & `records`.
	// Alias record documented below.
	Aliases RecordAliasArrayOutput `pulumi:"aliases"`
	// Allow creation of this record to overwrite an existing record, if any. This does not affect the ability to update the record using this provider and does not prevent other resources within this provider or manual Route 53 changes outside this provider from overwriting this record. `false` by default. This configuration is not recommended for most environments.
	AllowOverwrite pulumi.BoolOutput `pulumi:"allowOverwrite"`
	// A block indicating the routing behavior when associated health check fails. Conflicts with any other routing policy. Documented below.
	FailoverRoutingPolicies RecordFailoverRoutingPolicyArrayOutput `pulumi:"failoverRoutingPolicies"`
	// [FQDN](https://en.wikipedia.org/wiki/Fully_qualified_domain_name) built using the zone domain and `name`.
	Fqdn pulumi.StringOutput `pulumi:"fqdn"`
	// A block indicating a routing policy based on the geolocation of the requestor. Conflicts with any other routing policy. Documented below.
	GeolocationRoutingPolicies RecordGeolocationRoutingPolicyArrayOutput `pulumi:"geolocationRoutingPolicies"`
	// The health check the record should be associated with.
	HealthCheckId pulumi.StringPtrOutput `pulumi:"healthCheckId"`
	// A block indicating a routing policy based on the latency between the requestor and an AWS region. Conflicts with any other routing policy. Documented below.
	LatencyRoutingPolicies RecordLatencyRoutingPolicyArrayOutput `pulumi:"latencyRoutingPolicies"`
	// Set to `true` to indicate a multivalue answer routing policy. Conflicts with any other routing policy.
	MultivalueAnswerRoutingPolicy pulumi.BoolPtrOutput `pulumi:"multivalueAnswerRoutingPolicy"`
	// DNS domain name for a CloudFront distribution, S3 bucket, ELB, or another resource record set in this hosted zone.
	Name pulumi.StringOutput `pulumi:"name"`
	// A string list of records. To specify a single record value longer than 255 characters such as a TXT record for DKIM, add `\"\"` inside the configuration string (e.g. `"first255characters\"\"morecharacters"`).
	Records pulumi.StringArrayOutput `pulumi:"records"`
	// Unique identifier to differentiate records with routing policies from one another. Required if using `failover`, `geolocation`, `latency`, or `weighted` routing policies documented below.
	SetIdentifier pulumi.StringPtrOutput `pulumi:"setIdentifier"`
	// The TTL of the record.
	Ttl pulumi.IntPtrOutput `pulumi:"ttl"`
	// `PRIMARY` or `SECONDARY`. A `PRIMARY` record will be served if its healthcheck is passing, otherwise the `SECONDARY` will be served. See http://docs.aws.amazon.com/Route53/latest/DeveloperGuide/dns-failover-configuring-options.html#dns-failover-failover-rrsets
	Type pulumi.StringOutput `pulumi:"type"`
	// A block indicating a weighted routing policy. Conflicts with any other routing policy. Documented below.
	WeightedRoutingPolicies RecordWeightedRoutingPolicyArrayOutput `pulumi:"weightedRoutingPolicies"`
	// Hosted zone ID for a CloudFront distribution, S3 bucket, ELB, or Route 53 hosted zone. See `resource_elb.zone_id` for example.
	ZoneId pulumi.StringOutput `pulumi:"zoneId"`
}

// NewRecord registers a new resource with the given unique name, arguments, and options.
func NewRecord(ctx *pulumi.Context,
	name string, args *RecordArgs, opts ...pulumi.ResourceOption) (*Record, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Name == nil {
		return nil, errors.New("invalid value for required argument 'Name'")
	}
	if args.Type == nil {
		return nil, errors.New("invalid value for required argument 'Type'")
	}
	if args.ZoneId == nil {
		return nil, errors.New("invalid value for required argument 'ZoneId'")
	}
	var resource Record
	err := ctx.RegisterResource("aws:route53/record:Record", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetRecord gets an existing Record resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetRecord(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *RecordState, opts ...pulumi.ResourceOption) (*Record, error) {
	var resource Record
	err := ctx.ReadResource("aws:route53/record:Record", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Record resources.
type recordState struct {
	// An alias block. Conflicts with `ttl` & `records`.
	// Alias record documented below.
	Aliases []RecordAlias `pulumi:"aliases"`
	// Allow creation of this record to overwrite an existing record, if any. This does not affect the ability to update the record using this provider and does not prevent other resources within this provider or manual Route 53 changes outside this provider from overwriting this record. `false` by default. This configuration is not recommended for most environments.
	AllowOverwrite *bool `pulumi:"allowOverwrite"`
	// A block indicating the routing behavior when associated health check fails. Conflicts with any other routing policy. Documented below.
	FailoverRoutingPolicies []RecordFailoverRoutingPolicy `pulumi:"failoverRoutingPolicies"`
	// [FQDN](https://en.wikipedia.org/wiki/Fully_qualified_domain_name) built using the zone domain and `name`.
	Fqdn *string `pulumi:"fqdn"`
	// A block indicating a routing policy based on the geolocation of the requestor. Conflicts with any other routing policy. Documented below.
	GeolocationRoutingPolicies []RecordGeolocationRoutingPolicy `pulumi:"geolocationRoutingPolicies"`
	// The health check the record should be associated with.
	HealthCheckId *string `pulumi:"healthCheckId"`
	// A block indicating a routing policy based on the latency between the requestor and an AWS region. Conflicts with any other routing policy. Documented below.
	LatencyRoutingPolicies []RecordLatencyRoutingPolicy `pulumi:"latencyRoutingPolicies"`
	// Set to `true` to indicate a multivalue answer routing policy. Conflicts with any other routing policy.
	MultivalueAnswerRoutingPolicy *bool `pulumi:"multivalueAnswerRoutingPolicy"`
	// DNS domain name for a CloudFront distribution, S3 bucket, ELB, or another resource record set in this hosted zone.
	Name *string `pulumi:"name"`
	// A string list of records. To specify a single record value longer than 255 characters such as a TXT record for DKIM, add `\"\"` inside the configuration string (e.g. `"first255characters\"\"morecharacters"`).
	Records []string `pulumi:"records"`
	// Unique identifier to differentiate records with routing policies from one another. Required if using `failover`, `geolocation`, `latency`, or `weighted` routing policies documented below.
	SetIdentifier *string `pulumi:"setIdentifier"`
	// The TTL of the record.
	Ttl *int `pulumi:"ttl"`
	// `PRIMARY` or `SECONDARY`. A `PRIMARY` record will be served if its healthcheck is passing, otherwise the `SECONDARY` will be served. See http://docs.aws.amazon.com/Route53/latest/DeveloperGuide/dns-failover-configuring-options.html#dns-failover-failover-rrsets
	Type *string `pulumi:"type"`
	// A block indicating a weighted routing policy. Conflicts with any other routing policy. Documented below.
	WeightedRoutingPolicies []RecordWeightedRoutingPolicy `pulumi:"weightedRoutingPolicies"`
	// Hosted zone ID for a CloudFront distribution, S3 bucket, ELB, or Route 53 hosted zone. See `resource_elb.zone_id` for example.
	ZoneId *string `pulumi:"zoneId"`
}

type RecordState struct {
	// An alias block. Conflicts with `ttl` & `records`.
	// Alias record documented below.
	Aliases RecordAliasArrayInput
	// Allow creation of this record to overwrite an existing record, if any. This does not affect the ability to update the record using this provider and does not prevent other resources within this provider or manual Route 53 changes outside this provider from overwriting this record. `false` by default. This configuration is not recommended for most environments.
	AllowOverwrite pulumi.BoolPtrInput
	// A block indicating the routing behavior when associated health check fails. Conflicts with any other routing policy. Documented below.
	FailoverRoutingPolicies RecordFailoverRoutingPolicyArrayInput
	// [FQDN](https://en.wikipedia.org/wiki/Fully_qualified_domain_name) built using the zone domain and `name`.
	Fqdn pulumi.StringPtrInput
	// A block indicating a routing policy based on the geolocation of the requestor. Conflicts with any other routing policy. Documented below.
	GeolocationRoutingPolicies RecordGeolocationRoutingPolicyArrayInput
	// The health check the record should be associated with.
	HealthCheckId pulumi.StringPtrInput
	// A block indicating a routing policy based on the latency between the requestor and an AWS region. Conflicts with any other routing policy. Documented below.
	LatencyRoutingPolicies RecordLatencyRoutingPolicyArrayInput
	// Set to `true` to indicate a multivalue answer routing policy. Conflicts with any other routing policy.
	MultivalueAnswerRoutingPolicy pulumi.BoolPtrInput
	// DNS domain name for a CloudFront distribution, S3 bucket, ELB, or another resource record set in this hosted zone.
	Name pulumi.StringPtrInput
	// A string list of records. To specify a single record value longer than 255 characters such as a TXT record for DKIM, add `\"\"` inside the configuration string (e.g. `"first255characters\"\"morecharacters"`).
	Records pulumi.StringArrayInput
	// Unique identifier to differentiate records with routing policies from one another. Required if using `failover`, `geolocation`, `latency`, or `weighted` routing policies documented below.
	SetIdentifier pulumi.StringPtrInput
	// The TTL of the record.
	Ttl pulumi.IntPtrInput
	// `PRIMARY` or `SECONDARY`. A `PRIMARY` record will be served if its healthcheck is passing, otherwise the `SECONDARY` will be served. See http://docs.aws.amazon.com/Route53/latest/DeveloperGuide/dns-failover-configuring-options.html#dns-failover-failover-rrsets
	Type pulumi.StringPtrInput
	// A block indicating a weighted routing policy. Conflicts with any other routing policy. Documented below.
	WeightedRoutingPolicies RecordWeightedRoutingPolicyArrayInput
	// Hosted zone ID for a CloudFront distribution, S3 bucket, ELB, or Route 53 hosted zone. See `resource_elb.zone_id` for example.
	ZoneId pulumi.StringPtrInput
}

func (RecordState) ElementType() reflect.Type {
	return reflect.TypeOf((*recordState)(nil)).Elem()
}

type recordArgs struct {
	// An alias block. Conflicts with `ttl` & `records`.
	// Alias record documented below.
	Aliases []RecordAlias `pulumi:"aliases"`
	// Allow creation of this record to overwrite an existing record, if any. This does not affect the ability to update the record using this provider and does not prevent other resources within this provider or manual Route 53 changes outside this provider from overwriting this record. `false` by default. This configuration is not recommended for most environments.
	AllowOverwrite *bool `pulumi:"allowOverwrite"`
	// A block indicating the routing behavior when associated health check fails. Conflicts with any other routing policy. Documented below.
	FailoverRoutingPolicies []RecordFailoverRoutingPolicy `pulumi:"failoverRoutingPolicies"`
	// A block indicating a routing policy based on the geolocation of the requestor. Conflicts with any other routing policy. Documented below.
	GeolocationRoutingPolicies []RecordGeolocationRoutingPolicy `pulumi:"geolocationRoutingPolicies"`
	// The health check the record should be associated with.
	HealthCheckId *string `pulumi:"healthCheckId"`
	// A block indicating a routing policy based on the latency between the requestor and an AWS region. Conflicts with any other routing policy. Documented below.
	LatencyRoutingPolicies []RecordLatencyRoutingPolicy `pulumi:"latencyRoutingPolicies"`
	// Set to `true` to indicate a multivalue answer routing policy. Conflicts with any other routing policy.
	MultivalueAnswerRoutingPolicy *bool `pulumi:"multivalueAnswerRoutingPolicy"`
	// DNS domain name for a CloudFront distribution, S3 bucket, ELB, or another resource record set in this hosted zone.
	Name string `pulumi:"name"`
	// A string list of records. To specify a single record value longer than 255 characters such as a TXT record for DKIM, add `\"\"` inside the configuration string (e.g. `"first255characters\"\"morecharacters"`).
	Records []string `pulumi:"records"`
	// Unique identifier to differentiate records with routing policies from one another. Required if using `failover`, `geolocation`, `latency`, or `weighted` routing policies documented below.
	SetIdentifier *string `pulumi:"setIdentifier"`
	// The TTL of the record.
	Ttl *int `pulumi:"ttl"`
	// `PRIMARY` or `SECONDARY`. A `PRIMARY` record will be served if its healthcheck is passing, otherwise the `SECONDARY` will be served. See http://docs.aws.amazon.com/Route53/latest/DeveloperGuide/dns-failover-configuring-options.html#dns-failover-failover-rrsets
	Type string `pulumi:"type"`
	// A block indicating a weighted routing policy. Conflicts with any other routing policy. Documented below.
	WeightedRoutingPolicies []RecordWeightedRoutingPolicy `pulumi:"weightedRoutingPolicies"`
	// Hosted zone ID for a CloudFront distribution, S3 bucket, ELB, or Route 53 hosted zone. See `resource_elb.zone_id` for example.
	ZoneId string `pulumi:"zoneId"`
}

// The set of arguments for constructing a Record resource.
type RecordArgs struct {
	// An alias block. Conflicts with `ttl` & `records`.
	// Alias record documented below.
	Aliases RecordAliasArrayInput
	// Allow creation of this record to overwrite an existing record, if any. This does not affect the ability to update the record using this provider and does not prevent other resources within this provider or manual Route 53 changes outside this provider from overwriting this record. `false` by default. This configuration is not recommended for most environments.
	AllowOverwrite pulumi.BoolPtrInput
	// A block indicating the routing behavior when associated health check fails. Conflicts with any other routing policy. Documented below.
	FailoverRoutingPolicies RecordFailoverRoutingPolicyArrayInput
	// A block indicating a routing policy based on the geolocation of the requestor. Conflicts with any other routing policy. Documented below.
	GeolocationRoutingPolicies RecordGeolocationRoutingPolicyArrayInput
	// The health check the record should be associated with.
	HealthCheckId pulumi.StringPtrInput
	// A block indicating a routing policy based on the latency between the requestor and an AWS region. Conflicts with any other routing policy. Documented below.
	LatencyRoutingPolicies RecordLatencyRoutingPolicyArrayInput
	// Set to `true` to indicate a multivalue answer routing policy. Conflicts with any other routing policy.
	MultivalueAnswerRoutingPolicy pulumi.BoolPtrInput
	// DNS domain name for a CloudFront distribution, S3 bucket, ELB, or another resource record set in this hosted zone.
	Name pulumi.StringInput
	// A string list of records. To specify a single record value longer than 255 characters such as a TXT record for DKIM, add `\"\"` inside the configuration string (e.g. `"first255characters\"\"morecharacters"`).
	Records pulumi.StringArrayInput
	// Unique identifier to differentiate records with routing policies from one another. Required if using `failover`, `geolocation`, `latency`, or `weighted` routing policies documented below.
	SetIdentifier pulumi.StringPtrInput
	// The TTL of the record.
	Ttl pulumi.IntPtrInput
	// `PRIMARY` or `SECONDARY`. A `PRIMARY` record will be served if its healthcheck is passing, otherwise the `SECONDARY` will be served. See http://docs.aws.amazon.com/Route53/latest/DeveloperGuide/dns-failover-configuring-options.html#dns-failover-failover-rrsets
	Type pulumi.StringInput
	// A block indicating a weighted routing policy. Conflicts with any other routing policy. Documented below.
	WeightedRoutingPolicies RecordWeightedRoutingPolicyArrayInput
	// Hosted zone ID for a CloudFront distribution, S3 bucket, ELB, or Route 53 hosted zone. See `resource_elb.zone_id` for example.
	ZoneId pulumi.StringInput
}

func (RecordArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*recordArgs)(nil)).Elem()
}

type RecordInput interface {
	pulumi.Input

	ToRecordOutput() RecordOutput
	ToRecordOutputWithContext(ctx context.Context) RecordOutput
}

func (Record) ElementType() reflect.Type {
	return reflect.TypeOf((*Record)(nil)).Elem()
}

func (i Record) ToRecordOutput() RecordOutput {
	return i.ToRecordOutputWithContext(context.Background())
}

func (i Record) ToRecordOutputWithContext(ctx context.Context) RecordOutput {
	return pulumi.ToOutputWithContext(ctx, i).(RecordOutput)
}

type RecordOutput struct {
	*pulumi.OutputState
}

func (RecordOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*RecordOutput)(nil)).Elem()
}

func (o RecordOutput) ToRecordOutput() RecordOutput {
	return o
}

func (o RecordOutput) ToRecordOutputWithContext(ctx context.Context) RecordOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(RecordOutput{})
}
