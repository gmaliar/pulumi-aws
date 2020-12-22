// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package eks

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Retrieve information about an EKS Cluster.
func LookupCluster(ctx *pulumi.Context, args *LookupClusterArgs, opts ...pulumi.InvokeOption) (*LookupClusterResult, error) {
	var rv LookupClusterResult
	err := ctx.Invoke("aws:eks/getCluster:getCluster", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getCluster.
type LookupClusterArgs struct {
	// The name of the cluster
	Name string `pulumi:"name"`
	// Key-value map of resource tags.
	Tags map[string]string `pulumi:"tags"`
}

// A collection of values returned by getCluster.
type LookupClusterResult struct {
	// The Amazon Resource Name (ARN) of the cluster.
	Arn string `pulumi:"arn"`
	// Nested attribute containing `certificate-authority-data` for your cluster.
	CertificateAuthority GetClusterCertificateAuthority `pulumi:"certificateAuthority"`
	// The Unix epoch time stamp in seconds for when the cluster was created.
	CreatedAt string `pulumi:"createdAt"`
	// The enabled control plane logs.
	EnabledClusterLogTypes []string `pulumi:"enabledClusterLogTypes"`
	// The endpoint for your Kubernetes API server.
	Endpoint string `pulumi:"endpoint"`
	// The provider-assigned unique ID for this managed resource.
	Id string `pulumi:"id"`
	// Nested attribute containing identity provider information for your cluster. Only available on Kubernetes version 1.13 and 1.14 clusters created or upgraded on or after September 3, 2019. For an example using this information to enable IAM Roles for Service Accounts, see the `eks.Cluster` resource documentation.
	Identities []GetClusterIdentity `pulumi:"identities"`
	// Nested list containing Kubernetes Network Configuration.
	KubernetesNetworkConfigs []GetClusterKubernetesNetworkConfig `pulumi:"kubernetesNetworkConfigs"`
	Name                     string                              `pulumi:"name"`
	// The platform version for the cluster.
	PlatformVersion string `pulumi:"platformVersion"`
	// The Amazon Resource Name (ARN) of the IAM role that provides permissions for the Kubernetes control plane to make calls to AWS API operations on your behalf.
	RoleArn string `pulumi:"roleArn"`
	// The status of the EKS cluster. One of `CREATING`, `ACTIVE`, `DELETING`, `FAILED`.
	Status string `pulumi:"status"`
	// Key-value map of resource tags.
	Tags map[string]string `pulumi:"tags"`
	// The Kubernetes server version for the cluster.
	Version string `pulumi:"version"`
	// Nested list containing VPC configuration for the cluster.
	VpcConfig GetClusterVpcConfig `pulumi:"vpcConfig"`
}
