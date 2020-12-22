// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package rds

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Information about an RDS engine version.
//
// ## Example Usage
//
// ```go
// package main
//
// import (
// 	"github.com/pulumi/pulumi-aws/sdk/v3/go/aws/rds"
// 	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
// )
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		_, err := rds.GetEngineVersion(ctx, &rds.GetEngineVersionArgs{
// 			Engine: "mysql",
// 			PreferredVersions: []string{
// 				"5.7.42",
// 				"5.7.19",
// 				"5.7.17",
// 			},
// 		}, nil)
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
func GetEngineVersion(ctx *pulumi.Context, args *GetEngineVersionArgs, opts ...pulumi.InvokeOption) (*GetEngineVersionResult, error) {
	var rv GetEngineVersionResult
	err := ctx.Invoke("aws:rds/getEngineVersion:getEngineVersion", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getEngineVersion.
type GetEngineVersionArgs struct {
	// DB engine. Engine values include `aurora`, `aurora-mysql`, `aurora-postgresql`, `docdb`, `mariadb`, `mysql`, `neptune`, `oracle-ee`, `oracle-se`, `oracle-se1`, `oracle-se2`, `postgres`, `sqlserver-ee`, `sqlserver-ex`, `sqlserver-se`, and `sqlserver-web`.
	Engine string `pulumi:"engine"`
	// The name of a specific DB parameter group family. Examples of parameter group families are `mysql8.0`, `mariadb10.4`, and `postgres12`.
	ParameterGroupFamily *string `pulumi:"parameterGroupFamily"`
	// Ordered list of preferred engine versions. The first match in this list will be returned. If no preferred matches are found and the original search returned more than one result, an error is returned. If both the `version` and `preferredVersions` arguments are not configured, the data source will return the default version for the engine.
	PreferredVersions []string `pulumi:"preferredVersions"`
	// Version of the DB engine. For example, `5.7.22`, `10.1.34`, and `12.3`. If both the `version` and `preferredVersions` arguments are not configured, the data source will return the default version for the engine.
	Version *string `pulumi:"version"`
}

// A collection of values returned by getEngineVersion.
type GetEngineVersionResult struct {
	// The default character set for new instances of this engine version.
	DefaultCharacterSet string `pulumi:"defaultCharacterSet"`
	Engine              string `pulumi:"engine"`
	// The description of the database engine.
	EngineDescription string `pulumi:"engineDescription"`
	// Set of log types that the database engine has available for export to CloudWatch Logs.
	ExportableLogTypes []string `pulumi:"exportableLogTypes"`
	// The provider-assigned unique ID for this managed resource.
	Id                   string   `pulumi:"id"`
	ParameterGroupFamily string   `pulumi:"parameterGroupFamily"`
	PreferredVersions    []string `pulumi:"preferredVersions"`
	// The status of the DB engine version, either available or deprecated.
	Status string `pulumi:"status"`
	// Set of the character sets supported by this engine.
	SupportedCharacterSets []string `pulumi:"supportedCharacterSets"`
	// Set of features supported by the DB engine.
	SupportedFeatureNames []string `pulumi:"supportedFeatureNames"`
	// Set of the supported DB engine modes.
	SupportedModes []string `pulumi:"supportedModes"`
	// Set of the time zones supported by this engine.
	SupportedTimezones []string `pulumi:"supportedTimezones"`
	// Indicates whether you can use Aurora global databases with a specific DB engine version.
	SupportsGlobalDatabases bool `pulumi:"supportsGlobalDatabases"`
	// Indicates whether the engine version supports exporting the log types specified by `exportableLogTypes` to CloudWatch Logs.
	SupportsLogExportsToCloudwatch bool `pulumi:"supportsLogExportsToCloudwatch"`
	// Indicates whether you can use Aurora parallel query with a specific DB engine version.
	SupportsParallelQuery bool `pulumi:"supportsParallelQuery"`
	// Indicates whether the database engine version supports read replicas.
	SupportsReadReplica bool `pulumi:"supportsReadReplica"`
	// Set of engine versions that this database engine version can be upgraded to.
	ValidUpgradeTargets []string `pulumi:"validUpgradeTargets"`
	Version             string   `pulumi:"version"`
	// The description of the database engine version.
	VersionDescription string `pulumi:"versionDescription"`
}
