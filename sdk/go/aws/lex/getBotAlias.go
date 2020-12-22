// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package lex

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Provides details about a specific Amazon Lex Bot Alias.
//
// ## Example Usage
//
// ```go
// package main
//
// import (
// 	"github.com/pulumi/pulumi-aws/sdk/v3/go/aws/lex"
// 	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
// )
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		_, err := lex.LookupBotAlias(ctx, &lex.LookupBotAliasArgs{
// 			BotName: "OrderFlowers",
// 			Name:    "OrderFlowersProd",
// 		}, nil)
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
func LookupBotAlias(ctx *pulumi.Context, args *LookupBotAliasArgs, opts ...pulumi.InvokeOption) (*LookupBotAliasResult, error) {
	var rv LookupBotAliasResult
	err := ctx.Invoke("aws:lex/getBotAlias:getBotAlias", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getBotAlias.
type LookupBotAliasArgs struct {
	// The name of the bot.
	BotName string `pulumi:"botName"`
	// The name of the bot alias. The name is case sensitive.
	Name string `pulumi:"name"`
}

// A collection of values returned by getBotAlias.
type LookupBotAliasResult struct {
	// The ARN of the bot alias.
	Arn string `pulumi:"arn"`
	// The name of the bot.
	BotName string `pulumi:"botName"`
	// The version of the bot that the alias points to.
	BotVersion string `pulumi:"botVersion"`
	// Checksum of the bot alias.
	Checksum string `pulumi:"checksum"`
	// The date that the bot alias was created.
	CreatedDate string `pulumi:"createdDate"`
	// A description of the alias.
	Description string `pulumi:"description"`
	// The provider-assigned unique ID for this managed resource.
	Id string `pulumi:"id"`
	// The date that the bot alias was updated. When you create a resource, the creation date and the last updated date are the same.
	LastUpdatedDate string `pulumi:"lastUpdatedDate"`
	// The name of the alias. The name is not case sensitive.
	Name string `pulumi:"name"`
}
