// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../types";
import * as utilities from "../utilities";

/**
 * Retrieve information about an EKS Cluster.
 */
export function getCluster(args: GetClusterArgs, opts?: pulumi.InvokeOptions): Promise<GetClusterResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("aws:eks/getCluster:getCluster", {
        "name": args.name,
        "tags": args.tags,
    }, opts);
}

/**
 * A collection of arguments for invoking getCluster.
 */
export interface GetClusterArgs {
    /**
     * The name of the cluster
     */
    readonly name: string;
    /**
     * Key-value map of resource tags.
     */
    readonly tags?: {[key: string]: string};
}

/**
 * A collection of values returned by getCluster.
 */
export interface GetClusterResult {
    /**
     * The Amazon Resource Name (ARN) of the cluster.
     */
    readonly arn: string;
    /**
     * Nested attribute containing `certificate-authority-data` for your cluster.
     */
    readonly certificateAuthority: outputs.eks.GetClusterCertificateAuthority;
    /**
     * The Unix epoch time stamp in seconds for when the cluster was created.
     */
    readonly createdAt: string;
    /**
     * The enabled control plane logs.
     */
    readonly enabledClusterLogTypes: string[];
    /**
     * The endpoint for your Kubernetes API server.
     */
    readonly endpoint: string;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    /**
     * Nested attribute containing identity provider information for your cluster. Only available on Kubernetes version 1.13 and 1.14 clusters created or upgraded on or after September 3, 2019. For an example using this information to enable IAM Roles for Service Accounts, see the `aws.eks.Cluster` resource documentation.
     */
    readonly identities: outputs.eks.GetClusterIdentity[];
    /**
     * Nested list containing Kubernetes Network Configuration.
     */
    readonly kubernetesNetworkConfigs: outputs.eks.GetClusterKubernetesNetworkConfig[];
    readonly name: string;
    /**
     * The platform version for the cluster.
     */
    readonly platformVersion: string;
    /**
     * The Amazon Resource Name (ARN) of the IAM role that provides permissions for the Kubernetes control plane to make calls to AWS API operations on your behalf.
     */
    readonly roleArn: string;
    /**
     * The status of the EKS cluster. One of `CREATING`, `ACTIVE`, `DELETING`, `FAILED`.
     */
    readonly status: string;
    /**
     * Key-value map of resource tags.
     */
    readonly tags: {[key: string]: string};
    /**
     * The Kubernetes server version for the cluster.
     */
    readonly version: string;
    /**
     * Nested list containing VPC configuration for the cluster.
     */
    readonly vpcConfig: outputs.eks.GetClusterVpcConfig;
}
