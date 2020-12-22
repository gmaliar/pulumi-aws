// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

// Export members:
export * from "./codeRepository";
export * from "./endpoint";
export * from "./endpointConfiguration";
export * from "./getPrebuiltEcrImage";
export * from "./model";
export * from "./notebookInstance";
export * from "./notebookInstanceLifecycleConfiguration";

// Import resources to register:
import { CodeRepository } from "./codeRepository";
import { Endpoint } from "./endpoint";
import { EndpointConfiguration } from "./endpointConfiguration";
import { Model } from "./model";
import { NotebookInstance } from "./notebookInstance";
import { NotebookInstanceLifecycleConfiguration } from "./notebookInstanceLifecycleConfiguration";

const _module = {
    version: utilities.getVersion(),
    construct: (name: string, type: string, urn: string): pulumi.Resource => {
        switch (type) {
            case "aws:sagemaker/codeRepository:CodeRepository":
                return new CodeRepository(name, <any>undefined, { urn })
            case "aws:sagemaker/endpoint:Endpoint":
                return new Endpoint(name, <any>undefined, { urn })
            case "aws:sagemaker/endpointConfiguration:EndpointConfiguration":
                return new EndpointConfiguration(name, <any>undefined, { urn })
            case "aws:sagemaker/model:Model":
                return new Model(name, <any>undefined, { urn })
            case "aws:sagemaker/notebookInstance:NotebookInstance":
                return new NotebookInstance(name, <any>undefined, { urn })
            case "aws:sagemaker/notebookInstanceLifecycleConfiguration:NotebookInstanceLifecycleConfiguration":
                return new NotebookInstanceLifecycleConfiguration(name, <any>undefined, { urn })
            default:
                throw new Error(`unknown resource type ${type}`);
        }
    },
};
pulumi.runtime.registerResourceModule("aws", "sagemaker/codeRepository", _module)
pulumi.runtime.registerResourceModule("aws", "sagemaker/endpoint", _module)
pulumi.runtime.registerResourceModule("aws", "sagemaker/endpointConfiguration", _module)
pulumi.runtime.registerResourceModule("aws", "sagemaker/model", _module)
pulumi.runtime.registerResourceModule("aws", "sagemaker/notebookInstance", _module)
pulumi.runtime.registerResourceModule("aws", "sagemaker/notebookInstanceLifecycleConfiguration", _module)
