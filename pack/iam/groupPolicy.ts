// *** WARNING: this file was generated by the Lumi Terraform Bridge (TFGEN) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as lumi from "@lumi/lumi";
import * as lumirt from "@lumi/lumirt";

export class GroupPolicy extends lumi.NamedResource implements GroupPolicyArgs {
    public readonly group: string;
    public readonly name: string;
    public readonly namePrefix?: string;
    public readonly policy: string;

    public static get(id: lumi.ID): GroupPolicy {
        return <any>undefined; // functionality provided by the runtime
    }

    public static query(q: any): GroupPolicy[] {
        return <any>undefined; // functionality provided by the runtime
    }

    constructor(urnName: string, args: GroupPolicyArgs) {
        super(urnName);
        if (lumirt.defaultIfComputed(args.group, "") === undefined) {
            throw new Error("Property argument 'group' is required, but was missing");
        }
        this.group = <any>args.group;
        this.name = <any>args.name;
        this.namePrefix = <any>args.namePrefix;
        if (lumirt.defaultIfComputed(args.policy, "") === undefined) {
            throw new Error("Property argument 'policy' is required, but was missing");
        }
        this.policy = <any>args.policy;
    }
}

export interface GroupPolicyArgs {
    readonly group: string;
    readonly name?: string;
    readonly namePrefix?: string;
    readonly policy: string;
}
