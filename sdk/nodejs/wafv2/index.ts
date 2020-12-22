// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

// Export members:
export * from "./getIpSet";
export * from "./getRegexPatternSet";
export * from "./getRuleGroup";
export * from "./getWebAcl";
export * from "./ipSet";
export * from "./regexPatternSet";
export * from "./ruleGroup";
export * from "./webAcl";
export * from "./webAclAssociation";
export * from "./webAclLoggingConfiguration";

// Import resources to register:
import { IpSet } from "./ipSet";
import { RegexPatternSet } from "./regexPatternSet";
import { RuleGroup } from "./ruleGroup";
import { WebAcl } from "./webAcl";
import { WebAclAssociation } from "./webAclAssociation";
import { WebAclLoggingConfiguration } from "./webAclLoggingConfiguration";

const _module = {
    version: utilities.getVersion(),
    construct: (name: string, type: string, urn: string): pulumi.Resource => {
        switch (type) {
            case "aws:wafv2/ipSet:IpSet":
                return new IpSet(name, <any>undefined, { urn })
            case "aws:wafv2/regexPatternSet:RegexPatternSet":
                return new RegexPatternSet(name, <any>undefined, { urn })
            case "aws:wafv2/ruleGroup:RuleGroup":
                return new RuleGroup(name, <any>undefined, { urn })
            case "aws:wafv2/webAcl:WebAcl":
                return new WebAcl(name, <any>undefined, { urn })
            case "aws:wafv2/webAclAssociation:WebAclAssociation":
                return new WebAclAssociation(name, <any>undefined, { urn })
            case "aws:wafv2/webAclLoggingConfiguration:WebAclLoggingConfiguration":
                return new WebAclLoggingConfiguration(name, <any>undefined, { urn })
            default:
                throw new Error(`unknown resource type ${type}`);
        }
    },
};
pulumi.runtime.registerResourceModule("aws", "wafv2/ipSet", _module)
pulumi.runtime.registerResourceModule("aws", "wafv2/regexPatternSet", _module)
pulumi.runtime.registerResourceModule("aws", "wafv2/ruleGroup", _module)
pulumi.runtime.registerResourceModule("aws", "wafv2/webAcl", _module)
pulumi.runtime.registerResourceModule("aws", "wafv2/webAclAssociation", _module)
pulumi.runtime.registerResourceModule("aws", "wafv2/webAclLoggingConfiguration", _module)
