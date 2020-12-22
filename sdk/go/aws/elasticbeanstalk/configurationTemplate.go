// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package elasticbeanstalk

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Provides an Elastic Beanstalk Configuration Template, which are associated with
// a specific application and are used to deploy different versions of the
// application with the same configuration settings.
//
// ## Example Usage
//
// ```go
// package main
//
// import (
// 	"github.com/pulumi/pulumi-aws/sdk/v3/go/aws/elasticbeanstalk"
// 	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
// )
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		tftest, err := elasticbeanstalk.NewApplication(ctx, "tftest", &elasticbeanstalk.ApplicationArgs{
// 			Description: pulumi.String("tf-test-desc"),
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		_, err = elasticbeanstalk.NewConfigurationTemplate(ctx, "tfTemplate", &elasticbeanstalk.ConfigurationTemplateArgs{
// 			Application:       tftest.Name,
// 			SolutionStackName: pulumi.String("64bit Amazon Linux 2015.09 v2.0.8 running Go 1.4"),
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
// ## Option Settings
//
// The `setting` field supports the following format:
//
// * `namespace` - unique namespace identifying the option's associated AWS resource
// * `name` - name of the configuration option
// * `value` - value for the configuration option
// * `resource` - (Optional) resource name for [scheduled action](https://docs.aws.amazon.com/elasticbeanstalk/latest/dg/command-options-general.html#command-options-general-autoscalingscheduledaction)
type ConfigurationTemplate struct {
	pulumi.CustomResourceState

	// name of the application to associate with this configuration template
	Application pulumi.StringOutput `pulumi:"application"`
	// Short description of the Template
	Description pulumi.StringPtrOutput `pulumi:"description"`
	// The ID of the environment used with this configuration template
	EnvironmentId pulumi.StringPtrOutput `pulumi:"environmentId"`
	// A unique name for this Template.
	Name pulumi.StringOutput `pulumi:"name"`
	// Option settings to configure the new Environment. These
	// override specific values that are set as defaults. The format is detailed
	// below in Option Settings
	Settings ConfigurationTemplateSettingArrayOutput `pulumi:"settings"`
	// A solution stack to base your Template
	// off of. Example stacks can be found in the [Amazon API documentation](https://docs.aws.amazon.com/elasticbeanstalk/latest/dg/concepts.platforms.html)
	SolutionStackName pulumi.StringPtrOutput `pulumi:"solutionStackName"`
}

// NewConfigurationTemplate registers a new resource with the given unique name, arguments, and options.
func NewConfigurationTemplate(ctx *pulumi.Context,
	name string, args *ConfigurationTemplateArgs, opts ...pulumi.ResourceOption) (*ConfigurationTemplate, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Application == nil {
		return nil, errors.New("invalid value for required argument 'Application'")
	}
	var resource ConfigurationTemplate
	err := ctx.RegisterResource("aws:elasticbeanstalk/configurationTemplate:ConfigurationTemplate", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetConfigurationTemplate gets an existing ConfigurationTemplate resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetConfigurationTemplate(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ConfigurationTemplateState, opts ...pulumi.ResourceOption) (*ConfigurationTemplate, error) {
	var resource ConfigurationTemplate
	err := ctx.ReadResource("aws:elasticbeanstalk/configurationTemplate:ConfigurationTemplate", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ConfigurationTemplate resources.
type configurationTemplateState struct {
	// name of the application to associate with this configuration template
	Application *string `pulumi:"application"`
	// Short description of the Template
	Description *string `pulumi:"description"`
	// The ID of the environment used with this configuration template
	EnvironmentId *string `pulumi:"environmentId"`
	// A unique name for this Template.
	Name *string `pulumi:"name"`
	// Option settings to configure the new Environment. These
	// override specific values that are set as defaults. The format is detailed
	// below in Option Settings
	Settings []ConfigurationTemplateSetting `pulumi:"settings"`
	// A solution stack to base your Template
	// off of. Example stacks can be found in the [Amazon API documentation](https://docs.aws.amazon.com/elasticbeanstalk/latest/dg/concepts.platforms.html)
	SolutionStackName *string `pulumi:"solutionStackName"`
}

type ConfigurationTemplateState struct {
	// name of the application to associate with this configuration template
	Application pulumi.StringPtrInput
	// Short description of the Template
	Description pulumi.StringPtrInput
	// The ID of the environment used with this configuration template
	EnvironmentId pulumi.StringPtrInput
	// A unique name for this Template.
	Name pulumi.StringPtrInput
	// Option settings to configure the new Environment. These
	// override specific values that are set as defaults. The format is detailed
	// below in Option Settings
	Settings ConfigurationTemplateSettingArrayInput
	// A solution stack to base your Template
	// off of. Example stacks can be found in the [Amazon API documentation](https://docs.aws.amazon.com/elasticbeanstalk/latest/dg/concepts.platforms.html)
	SolutionStackName pulumi.StringPtrInput
}

func (ConfigurationTemplateState) ElementType() reflect.Type {
	return reflect.TypeOf((*configurationTemplateState)(nil)).Elem()
}

type configurationTemplateArgs struct {
	// name of the application to associate with this configuration template
	Application string `pulumi:"application"`
	// Short description of the Template
	Description *string `pulumi:"description"`
	// The ID of the environment used with this configuration template
	EnvironmentId *string `pulumi:"environmentId"`
	// A unique name for this Template.
	Name *string `pulumi:"name"`
	// Option settings to configure the new Environment. These
	// override specific values that are set as defaults. The format is detailed
	// below in Option Settings
	Settings []ConfigurationTemplateSetting `pulumi:"settings"`
	// A solution stack to base your Template
	// off of. Example stacks can be found in the [Amazon API documentation](https://docs.aws.amazon.com/elasticbeanstalk/latest/dg/concepts.platforms.html)
	SolutionStackName *string `pulumi:"solutionStackName"`
}

// The set of arguments for constructing a ConfigurationTemplate resource.
type ConfigurationTemplateArgs struct {
	// name of the application to associate with this configuration template
	Application pulumi.StringInput
	// Short description of the Template
	Description pulumi.StringPtrInput
	// The ID of the environment used with this configuration template
	EnvironmentId pulumi.StringPtrInput
	// A unique name for this Template.
	Name pulumi.StringPtrInput
	// Option settings to configure the new Environment. These
	// override specific values that are set as defaults. The format is detailed
	// below in Option Settings
	Settings ConfigurationTemplateSettingArrayInput
	// A solution stack to base your Template
	// off of. Example stacks can be found in the [Amazon API documentation](https://docs.aws.amazon.com/elasticbeanstalk/latest/dg/concepts.platforms.html)
	SolutionStackName pulumi.StringPtrInput
}

func (ConfigurationTemplateArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*configurationTemplateArgs)(nil)).Elem()
}

type ConfigurationTemplateInput interface {
	pulumi.Input

	ToConfigurationTemplateOutput() ConfigurationTemplateOutput
	ToConfigurationTemplateOutputWithContext(ctx context.Context) ConfigurationTemplateOutput
}

func (ConfigurationTemplate) ElementType() reflect.Type {
	return reflect.TypeOf((*ConfigurationTemplate)(nil)).Elem()
}

func (i ConfigurationTemplate) ToConfigurationTemplateOutput() ConfigurationTemplateOutput {
	return i.ToConfigurationTemplateOutputWithContext(context.Background())
}

func (i ConfigurationTemplate) ToConfigurationTemplateOutputWithContext(ctx context.Context) ConfigurationTemplateOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ConfigurationTemplateOutput)
}

type ConfigurationTemplateOutput struct {
	*pulumi.OutputState
}

func (ConfigurationTemplateOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*ConfigurationTemplateOutput)(nil)).Elem()
}

func (o ConfigurationTemplateOutput) ToConfigurationTemplateOutput() ConfigurationTemplateOutput {
	return o
}

func (o ConfigurationTemplateOutput) ToConfigurationTemplateOutputWithContext(ctx context.Context) ConfigurationTemplateOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(ConfigurationTemplateOutput{})
}
