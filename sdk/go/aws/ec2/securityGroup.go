// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package ec2

import (
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// Provides a security group resource.
// 
// ~> **NOTE on Security Groups and Security Group Rules:** Terraform currently
// provides both a standalone Security Group Rule resource (a single `ingress` or
// `egress` rule), and a Security Group resource with `ingress` and `egress` rules
// defined in-line. At this time you cannot use a Security Group with in-line rules
// in conjunction with any Security Group Rule resources. Doing so will cause
// a conflict of rule settings and will overwrite rules.
type SecurityGroup struct {
	s *pulumi.ResourceState
}

// NewSecurityGroup registers a new resource with the given unique name, arguments, and options.
func NewSecurityGroup(ctx *pulumi.Context,
	name string, args *SecurityGroupArgs, opts ...pulumi.ResourceOpt) (*SecurityGroup, error) {
	inputs := make(map[string]interface{})
	inputs["description"] = "Managed by Pulumi"
	if args == nil {
		inputs["egress"] = nil
		inputs["ingress"] = nil
		inputs["name"] = nil
		inputs["namePrefix"] = nil
		inputs["revokeRulesOnDelete"] = nil
		inputs["tags"] = nil
		inputs["vpcId"] = nil
	} else {
		inputs["description"] = args.Description
		inputs["egress"] = args.Egress
		inputs["ingress"] = args.Ingress
		inputs["name"] = args.Name
		inputs["namePrefix"] = args.NamePrefix
		inputs["revokeRulesOnDelete"] = args.RevokeRulesOnDelete
		inputs["tags"] = args.Tags
		inputs["vpcId"] = args.VpcId
	}
	inputs["arn"] = nil
	inputs["ownerId"] = nil
	s, err := ctx.RegisterResource("aws:ec2/securityGroup:SecurityGroup", name, true, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &SecurityGroup{s: s}, nil
}

// GetSecurityGroup gets an existing SecurityGroup resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetSecurityGroup(ctx *pulumi.Context,
	name string, id pulumi.ID, state *SecurityGroupState, opts ...pulumi.ResourceOpt) (*SecurityGroup, error) {
	inputs := make(map[string]interface{})
	if state != nil {
		inputs["arn"] = state.Arn
		inputs["description"] = state.Description
		inputs["egress"] = state.Egress
		inputs["ingress"] = state.Ingress
		inputs["name"] = state.Name
		inputs["namePrefix"] = state.NamePrefix
		inputs["ownerId"] = state.OwnerId
		inputs["revokeRulesOnDelete"] = state.RevokeRulesOnDelete
		inputs["tags"] = state.Tags
		inputs["vpcId"] = state.VpcId
	}
	s, err := ctx.ReadResource("aws:ec2/securityGroup:SecurityGroup", name, id, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &SecurityGroup{s: s}, nil
}

// URN is this resource's unique name assigned by Pulumi.
func (r *SecurityGroup) URN() *pulumi.URNOutput {
	return r.s.URN
}

// ID is this resource's unique identifier assigned by its provider.
func (r *SecurityGroup) ID() *pulumi.IDOutput {
	return r.s.ID
}

// The ARN of the security group
func (r *SecurityGroup) Arn() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["arn"])
}

// The security group description. Defaults to
// "Managed by Terraform". Cannot be "". __NOTE__: This field maps to the AWS
// `GroupDescription` attribute, for which there is no Update API. If you'd like
// to classify your security groups in a way that can be updated, use `tags`.
func (r *SecurityGroup) Description() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["description"])
}

// Can be specified multiple times for each
// egress rule. Each egress block supports fields documented below.
func (r *SecurityGroup) Egress() *pulumi.ArrayOutput {
	return (*pulumi.ArrayOutput)(r.s.State["egress"])
}

// Can be specified multiple times for each
// ingress rule. Each ingress block supports fields documented below.
func (r *SecurityGroup) Ingress() *pulumi.ArrayOutput {
	return (*pulumi.ArrayOutput)(r.s.State["ingress"])
}

// The name of the security group. If omitted, Terraform will
// assign a random, unique name
func (r *SecurityGroup) Name() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["name"])
}

// Creates a unique name beginning with the specified
// prefix. Conflicts with `name`.
func (r *SecurityGroup) NamePrefix() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["namePrefix"])
}

// The owner ID.
func (r *SecurityGroup) OwnerId() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["ownerId"])
}

// Instruct Terraform to revoke all of the
// Security Groups attached ingress and egress rules before deleting the rule
// itself. This is normally not needed, however certain AWS services such as
// Elastic Map Reduce may automatically add required rules to security groups used
// with the service, and those rules may contain a cyclic dependency that prevent
// the security groups from being destroyed without removing the dependency first.
// Default `false`
func (r *SecurityGroup) RevokeRulesOnDelete() *pulumi.BoolOutput {
	return (*pulumi.BoolOutput)(r.s.State["revokeRulesOnDelete"])
}

// A mapping of tags to assign to the resource.
func (r *SecurityGroup) Tags() *pulumi.MapOutput {
	return (*pulumi.MapOutput)(r.s.State["tags"])
}

// The VPC ID.
func (r *SecurityGroup) VpcId() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["vpcId"])
}

// Input properties used for looking up and filtering SecurityGroup resources.
type SecurityGroupState struct {
	// The ARN of the security group
	Arn interface{}
	// The security group description. Defaults to
	// "Managed by Terraform". Cannot be "". __NOTE__: This field maps to the AWS
	// `GroupDescription` attribute, for which there is no Update API. If you'd like
	// to classify your security groups in a way that can be updated, use `tags`.
	Description interface{}
	// Can be specified multiple times for each
	// egress rule. Each egress block supports fields documented below.
	Egress interface{}
	// Can be specified multiple times for each
	// ingress rule. Each ingress block supports fields documented below.
	Ingress interface{}
	// The name of the security group. If omitted, Terraform will
	// assign a random, unique name
	Name interface{}
	// Creates a unique name beginning with the specified
	// prefix. Conflicts with `name`.
	NamePrefix interface{}
	// The owner ID.
	OwnerId interface{}
	// Instruct Terraform to revoke all of the
	// Security Groups attached ingress and egress rules before deleting the rule
	// itself. This is normally not needed, however certain AWS services such as
	// Elastic Map Reduce may automatically add required rules to security groups used
	// with the service, and those rules may contain a cyclic dependency that prevent
	// the security groups from being destroyed without removing the dependency first.
	// Default `false`
	RevokeRulesOnDelete interface{}
	// A mapping of tags to assign to the resource.
	Tags interface{}
	// The VPC ID.
	VpcId interface{}
}

// The set of arguments for constructing a SecurityGroup resource.
type SecurityGroupArgs struct {
	// The security group description. Defaults to
	// "Managed by Terraform". Cannot be "". __NOTE__: This field maps to the AWS
	// `GroupDescription` attribute, for which there is no Update API. If you'd like
	// to classify your security groups in a way that can be updated, use `tags`.
	Description interface{}
	// Can be specified multiple times for each
	// egress rule. Each egress block supports fields documented below.
	Egress interface{}
	// Can be specified multiple times for each
	// ingress rule. Each ingress block supports fields documented below.
	Ingress interface{}
	// The name of the security group. If omitted, Terraform will
	// assign a random, unique name
	Name interface{}
	// Creates a unique name beginning with the specified
	// prefix. Conflicts with `name`.
	NamePrefix interface{}
	// Instruct Terraform to revoke all of the
	// Security Groups attached ingress and egress rules before deleting the rule
	// itself. This is normally not needed, however certain AWS services such as
	// Elastic Map Reduce may automatically add required rules to security groups used
	// with the service, and those rules may contain a cyclic dependency that prevent
	// the security groups from being destroyed without removing the dependency first.
	// Default `false`
	RevokeRulesOnDelete interface{}
	// A mapping of tags to assign to the resource.
	Tags interface{}
	// The VPC ID.
	VpcId interface{}
}
