// *** WARNING: this file was generated by the Lumi Terraform Bridge (TFGEN) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as lumi from "@lumi/lumi";
import * as lumirt from "@lumi/lumirt";

export class Record extends lumi.NamedResource implements RecordArgs {
    public readonly alias?: { evaluateTargetHealth: boolean, name: string, zoneId: string }[];
    public readonly failoverRoutingPolicy?: { type: string }[];
    public /*out*/ readonly fqdn: string;
    public readonly geolocationRoutingPolicy?: { continent?: string, country?: string, subdivision?: string }[];
    public readonly healthCheckId?: string;
    public readonly latencyRoutingPolicy?: { region: string }[];
    public readonly name: string;
    public readonly records?: string[];
    public readonly setIdentifier?: string;
    public readonly ttl?: number;
    public readonly type: string;
    public readonly weightedRoutingPolicy?: { weight: number }[];
    public readonly zoneId: string;

    public static get(id: lumi.ID): Record {
        return <any>undefined; // functionality provided by the runtime
    }

    public static query(q: any): Record[] {
        return <any>undefined; // functionality provided by the runtime
    }

    constructor(urnName: string, args: RecordArgs) {
        super(urnName);
        this.alias = <any>args.alias;
        this.failoverRoutingPolicy = <any>args.failoverRoutingPolicy;
        this.geolocationRoutingPolicy = <any>args.geolocationRoutingPolicy;
        this.healthCheckId = <any>args.healthCheckId;
        this.latencyRoutingPolicy = <any>args.latencyRoutingPolicy;
        this.name = <any>args.name;
        this.records = <any>args.records;
        this.setIdentifier = <any>args.setIdentifier;
        this.ttl = <any>args.ttl;
        if (lumirt.defaultIfComputed(args.type, "") === undefined) {
            throw new Error("Property argument 'type' is required, but was missing");
        }
        this.type = <any>args.type;
        this.weightedRoutingPolicy = <any>args.weightedRoutingPolicy;
        if (lumirt.defaultIfComputed(args.zoneId, "") === undefined) {
            throw new Error("Property argument 'zoneId' is required, but was missing");
        }
        this.zoneId = <any>args.zoneId;
    }
}

export interface RecordArgs {
    readonly alias?: { evaluateTargetHealth: boolean, name: string, zoneId: string }[];
    readonly failoverRoutingPolicy?: { type: string }[];
    readonly geolocationRoutingPolicy?: { continent?: string, country?: string, subdivision?: string }[];
    readonly healthCheckId?: string;
    readonly latencyRoutingPolicy?: { region: string }[];
    readonly name?: string;
    readonly records?: string[];
    readonly setIdentifier?: string;
    readonly ttl?: number;
    readonly type: string;
    readonly weightedRoutingPolicy?: { weight: number }[];
    readonly zoneId: string;
}
