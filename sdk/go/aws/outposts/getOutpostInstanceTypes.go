// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package outposts

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Information about Outposts Instance Types.
//
// ## Example Usage
//
// ```go
// package main
//
// import (
// 	"github.com/pulumi/pulumi-aws/sdk/v3/go/aws/outposts"
// 	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
// )
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		_, err := outposts.GetOutpostInstanceTypes(ctx, &outposts.GetOutpostInstanceTypesArgs{
// 			Arn: data.Aws_outposts_outpost.Example.Arn,
// 		}, nil)
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
func GetOutpostInstanceTypes(ctx *pulumi.Context, args *GetOutpostInstanceTypesArgs, opts ...pulumi.InvokeOption) (*GetOutpostInstanceTypesResult, error) {
	var rv GetOutpostInstanceTypesResult
	err := ctx.Invoke("aws:outposts/getOutpostInstanceTypes:getOutpostInstanceTypes", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getOutpostInstanceTypes.
type GetOutpostInstanceTypesArgs struct {
	// Outpost Amazon Resource Name (ARN).
	Arn string `pulumi:"arn"`
}

// A collection of values returned by getOutpostInstanceTypes.
type GetOutpostInstanceTypesResult struct {
	Arn string `pulumi:"arn"`
	// The provider-assigned unique ID for this managed resource.
	Id string `pulumi:"id"`
	// Set of instance types.
	InstanceTypes []string `pulumi:"instanceTypes"`
}
