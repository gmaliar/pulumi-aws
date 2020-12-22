// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package imagebuilder

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Provides details about an Image Builder Image Pipeline.
//
// ## Example Usage
//
// ```go
// package main
//
// import (
// 	"github.com/pulumi/pulumi-aws/sdk/v3/go/aws/imagebuilder"
// 	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
// )
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		_, err := imagebuilder.LookupImagePipeline(ctx, &imagebuilder.LookupImagePipelineArgs{
// 			Arn: "arn:aws:imagebuilder:us-west-2:aws:image-pipeline/example",
// 		}, nil)
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
func LookupImagePipeline(ctx *pulumi.Context, args *LookupImagePipelineArgs, opts ...pulumi.InvokeOption) (*LookupImagePipelineResult, error) {
	var rv LookupImagePipelineResult
	err := ctx.Invoke("aws:imagebuilder/getImagePipeline:getImagePipeline", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getImagePipeline.
type LookupImagePipelineArgs struct {
	// Amazon Resource Name (ARN) of the image pipeline.
	Arn string `pulumi:"arn"`
	// Key-value map of resource tags for the image pipeline.
	Tags map[string]string `pulumi:"tags"`
}

// A collection of values returned by getImagePipeline.
type LookupImagePipelineResult struct {
	Arn string `pulumi:"arn"`
	// Date the image pipeline was created.
	DateCreated string `pulumi:"dateCreated"`
	// Date the image pipeline was last run.
	DateLastRun string `pulumi:"dateLastRun"`
	// Date the image pipeline will run next.
	DateNextRun string `pulumi:"dateNextRun"`
	// Date the image pipeline was updated.
	DateUpdated string `pulumi:"dateUpdated"`
	// Description of the image pipeline.
	Description string `pulumi:"description"`
	// Amazon Resource Name (ARN) of the Image Builder Distribution Configuration.
	DistributionConfigurationArn string `pulumi:"distributionConfigurationArn"`
	// Whether additional information about the image being created is collected.
	EnhancedImageMetadataEnabled bool `pulumi:"enhancedImageMetadataEnabled"`
	// The provider-assigned unique ID for this managed resource.
	Id string `pulumi:"id"`
	// Amazon Resource Name (ARN) of the Image Builder Infrastructure Recipe.
	ImageRecipeArn string `pulumi:"imageRecipeArn"`
	// List of an object with image tests configuration.
	ImageTestsConfigurations []GetImagePipelineImageTestsConfiguration `pulumi:"imageTestsConfigurations"`
	// Amazon Resource Name (ARN) of the Image Builder Infrastructure Configuration.
	InfrastructureConfigurationArn string `pulumi:"infrastructureConfigurationArn"`
	// Name of the image pipeline.
	Name string `pulumi:"name"`
	// Platform of the image pipeline.
	Platform string `pulumi:"platform"`
	// List of an object with schedule settings.
	Schedules []GetImagePipelineSchedule `pulumi:"schedules"`
	// Status of the image pipeline.
	Status string `pulumi:"status"`
	// Key-value map of resource tags for the image pipeline.
	Tags map[string]string `pulumi:"tags"`
}
