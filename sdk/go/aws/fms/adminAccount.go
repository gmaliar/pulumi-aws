// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package fms

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Provides a resource to associate/disassociate an AWS Firewall Manager administrator account. This operation must be performed in the `us-east-1` region.
//
// ## Example Usage
//
// ```go
// package main
//
// import (
// 	"github.com/pulumi/pulumi-aws/sdk/v3/go/aws/fms"
// 	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
// )
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		_, err := fms.NewAdminAccount(ctx, "example", nil)
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
// Firewall Manager administrator account association can be imported using the account ID, e.g.
//
// ```sh
//  $ pulumi import aws:fms/adminAccount:AdminAccount example 123456789012
// ```
type AdminAccount struct {
	pulumi.CustomResourceState

	// The AWS account ID to associate with AWS Firewall Manager as the AWS Firewall Manager administrator account. This can be an AWS Organizations master account or a member account. Defaults to the current account. Must be configured to perform drift detection.
	AccountId pulumi.StringOutput `pulumi:"accountId"`
}

// NewAdminAccount registers a new resource with the given unique name, arguments, and options.
func NewAdminAccount(ctx *pulumi.Context,
	name string, args *AdminAccountArgs, opts ...pulumi.ResourceOption) (*AdminAccount, error) {
	if args == nil {
		args = &AdminAccountArgs{}
	}

	var resource AdminAccount
	err := ctx.RegisterResource("aws:fms/adminAccount:AdminAccount", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetAdminAccount gets an existing AdminAccount resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetAdminAccount(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *AdminAccountState, opts ...pulumi.ResourceOption) (*AdminAccount, error) {
	var resource AdminAccount
	err := ctx.ReadResource("aws:fms/adminAccount:AdminAccount", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering AdminAccount resources.
type adminAccountState struct {
	// The AWS account ID to associate with AWS Firewall Manager as the AWS Firewall Manager administrator account. This can be an AWS Organizations master account or a member account. Defaults to the current account. Must be configured to perform drift detection.
	AccountId *string `pulumi:"accountId"`
}

type AdminAccountState struct {
	// The AWS account ID to associate with AWS Firewall Manager as the AWS Firewall Manager administrator account. This can be an AWS Organizations master account or a member account. Defaults to the current account. Must be configured to perform drift detection.
	AccountId pulumi.StringPtrInput
}

func (AdminAccountState) ElementType() reflect.Type {
	return reflect.TypeOf((*adminAccountState)(nil)).Elem()
}

type adminAccountArgs struct {
	// The AWS account ID to associate with AWS Firewall Manager as the AWS Firewall Manager administrator account. This can be an AWS Organizations master account or a member account. Defaults to the current account. Must be configured to perform drift detection.
	AccountId *string `pulumi:"accountId"`
}

// The set of arguments for constructing a AdminAccount resource.
type AdminAccountArgs struct {
	// The AWS account ID to associate with AWS Firewall Manager as the AWS Firewall Manager administrator account. This can be an AWS Organizations master account or a member account. Defaults to the current account. Must be configured to perform drift detection.
	AccountId pulumi.StringPtrInput
}

func (AdminAccountArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*adminAccountArgs)(nil)).Elem()
}

type AdminAccountInput interface {
	pulumi.Input

	ToAdminAccountOutput() AdminAccountOutput
	ToAdminAccountOutputWithContext(ctx context.Context) AdminAccountOutput
}

func (AdminAccount) ElementType() reflect.Type {
	return reflect.TypeOf((*AdminAccount)(nil)).Elem()
}

func (i AdminAccount) ToAdminAccountOutput() AdminAccountOutput {
	return i.ToAdminAccountOutputWithContext(context.Background())
}

func (i AdminAccount) ToAdminAccountOutputWithContext(ctx context.Context) AdminAccountOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AdminAccountOutput)
}

type AdminAccountOutput struct {
	*pulumi.OutputState
}

func (AdminAccountOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*AdminAccountOutput)(nil)).Elem()
}

func (o AdminAccountOutput) ToAdminAccountOutput() AdminAccountOutput {
	return o
}

func (o AdminAccountOutput) ToAdminAccountOutputWithContext(ctx context.Context) AdminAccountOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(AdminAccountOutput{})
}
