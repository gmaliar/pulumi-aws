// *** WARNING: this file was generated by the Lumi Terraform Bridge (TFGEN) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as lumi from "@lumi/lumi";
import * as lumirt from "@lumi/lumirt";

export class Project extends lumi.NamedResource implements ProjectArgs {
    public /*out*/ readonly arn: string;
    public readonly name: string;

    public static get(id: lumi.ID): Project {
        return <any>undefined; // functionality provided by the runtime
    }

    public static query(q: any): Project[] {
        return <any>undefined; // functionality provided by the runtime
    }

    constructor(urnName: string, args: ProjectArgs) {
        super(urnName);
        this.name = <any>args.name;
    }
}

export interface ProjectArgs {
    readonly name?: string;
}
