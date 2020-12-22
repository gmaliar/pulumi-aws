// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

// Export members:
export * from "./database";
export * from "./namedQuery";
export * from "./workgroup";

// Import resources to register:
import { Database } from "./database";
import { NamedQuery } from "./namedQuery";
import { Workgroup } from "./workgroup";

const _module = {
    version: utilities.getVersion(),
    construct: (name: string, type: string, urn: string): pulumi.Resource => {
        switch (type) {
            case "aws:athena/database:Database":
                return new Database(name, <any>undefined, { urn })
            case "aws:athena/namedQuery:NamedQuery":
                return new NamedQuery(name, <any>undefined, { urn })
            case "aws:athena/workgroup:Workgroup":
                return new Workgroup(name, <any>undefined, { urn })
            default:
                throw new Error(`unknown resource type ${type}`);
        }
    },
};
pulumi.runtime.registerResourceModule("aws", "athena/database", _module)
pulumi.runtime.registerResourceModule("aws", "athena/namedQuery", _module)
pulumi.runtime.registerResourceModule("aws", "athena/workgroup", _module)
