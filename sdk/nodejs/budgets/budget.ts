// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";
import * as rxjs from "rxjs";
import * as operators from "rxjs/operators";

/**
 * Provides a budgets budget resource. Budgets use the cost visualisation provided by Cost Explorer to show you the status of your budgets, to provide forecasts of your estimated costs, and to track your AWS usage, including your free tier usage.
 * 
 * ## Example Usage
 * 
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as aws from "@pulumi/aws";
 * 
 * const ec2 = new aws.budgets.Budget("ec2", {
 *     budgetType: "COST",
 *     costFilters: {
 *         Service: "Amazon Elastic Compute Cloud - Compute",
 *     },
 *     limitAmount: "1200",
 *     limitUnit: "USD",
 *     name: "budget-ec2-monthly",
 *     timePeriodEnd: "2087-06-15_00:00",
 *     timePeriodStart: "2017-07-01_00:00",
 *     timeUnit: "MONTHLY",
 * });
 * ```
 * 
 * Create a budget for *$100*.
 * 
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as aws from "@pulumi/aws";
 * 
 * const cost = new aws.budgets.Budget("cost", {
 *     // ...
 *     budgetType: "COST",
 *     limitAmount: "100",
 *     limitUnit: "USD",
 * });
 * ```
 * 
 * Create a budget for s3 with a limit of *3 GB* of storage.
 * 
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as aws from "@pulumi/aws";
 * 
 * const s3 = new aws.budgets.Budget("s3", {
 *     // ...
 *     budgetType: "USAGE",
 *     limitAmount: "3",
 *     limitUnit: "GB",
 * });
 * ```
 */
export class Budget extends pulumi.CustomResource {
    /**
     * Get an existing Budget resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: BudgetState, opts?: pulumi.CustomResourceOptions): Budget {
        return new Budget(name, <any>state, { ...opts, id: id });
    }

    public static list(ctx: pulumi.query.ListContext, args?: pulumi.query.ListArgs): rxjs.Observable<BudgetResult> {
        return ctx.list({...args, type: 'aws:budgets/budget:Budget'});
    }

    /**
     * The ID of the target account for budget. Will use current user's account_id by default if omitted.
     */
    public readonly accountId: pulumi.Output<string>;
    /**
     * Whether this budget tracks monetary cost or usage.
     */
    public readonly budgetType: pulumi.Output<string>;
    /**
     * Map of CostFilters key/value pairs to apply to the budget.
     */
    public readonly costFilters: pulumi.Output<{[key: string]: any}>;
    /**
     * Object containing CostTypes The types of cost included in a budget, such as tax and subscriptions..
     */
    public readonly costTypes: pulumi.Output<{ includeCredit?: boolean, includeDiscount?: boolean, includeOtherSubscription?: boolean, includeRecurring?: boolean, includeRefund?: boolean, includeSubscription?: boolean, includeSupport?: boolean, includeTax?: boolean, includeUpfront?: boolean, useAmortized?: boolean, useBlended?: boolean }>;
    /**
     * The amount of cost or usage being measured for a budget.
     */
    public readonly limitAmount: pulumi.Output<string>;
    /**
     * The unit of measurement used for the budget forecast, actual spend, or budget threshold, such as dollars or GB. See [Spend](http://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/data-type-spend.html) documentation.
     */
    public readonly limitUnit: pulumi.Output<string>;
    /**
     * The name of a budget. Unique within accounts.
     */
    public readonly name: pulumi.Output<string>;
    /**
     * The prefix of the name of a budget. Unique within accounts.
     */
    public readonly namePrefix: pulumi.Output<string>;
    /**
     * The end of the time period covered by the budget. There are no restrictions on the end date. Format: `2017-01-01_12:00`.
     */
    public readonly timePeriodEnd: pulumi.Output<string | undefined>;
    /**
     * The start of the time period covered by the budget. The start date must come before the end date. Format: `2017-01-01_12:00`.
     */
    public readonly timePeriodStart: pulumi.Output<string>;
    /**
     * The length of time until a budget resets the actual and forecasted spend. Valid values: `MONTHLY`, `QUARTERLY`, `ANNUALLY`.
     */
    public readonly timeUnit: pulumi.Output<string>;

    /**
     * Create a Budget resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: BudgetArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: BudgetArgs | BudgetState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state: BudgetState = argsOrState as BudgetState | undefined;
            inputs["accountId"] = state ? state.accountId : undefined;
            inputs["budgetType"] = state ? state.budgetType : undefined;
            inputs["costFilters"] = state ? state.costFilters : undefined;
            inputs["costTypes"] = state ? state.costTypes : undefined;
            inputs["limitAmount"] = state ? state.limitAmount : undefined;
            inputs["limitUnit"] = state ? state.limitUnit : undefined;
            inputs["name"] = state ? state.name : undefined;
            inputs["namePrefix"] = state ? state.namePrefix : undefined;
            inputs["timePeriodEnd"] = state ? state.timePeriodEnd : undefined;
            inputs["timePeriodStart"] = state ? state.timePeriodStart : undefined;
            inputs["timeUnit"] = state ? state.timeUnit : undefined;
        } else {
            const args = argsOrState as BudgetArgs | undefined;
            if (!args || args.budgetType === undefined) {
                throw new Error("Missing required property 'budgetType'");
            }
            if (!args || args.limitAmount === undefined) {
                throw new Error("Missing required property 'limitAmount'");
            }
            if (!args || args.limitUnit === undefined) {
                throw new Error("Missing required property 'limitUnit'");
            }
            if (!args || args.timePeriodStart === undefined) {
                throw new Error("Missing required property 'timePeriodStart'");
            }
            if (!args || args.timeUnit === undefined) {
                throw new Error("Missing required property 'timeUnit'");
            }
            inputs["accountId"] = args ? args.accountId : undefined;
            inputs["budgetType"] = args ? args.budgetType : undefined;
            inputs["costFilters"] = args ? args.costFilters : undefined;
            inputs["costTypes"] = args ? args.costTypes : undefined;
            inputs["limitAmount"] = args ? args.limitAmount : undefined;
            inputs["limitUnit"] = args ? args.limitUnit : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["namePrefix"] = args ? args.namePrefix : undefined;
            inputs["timePeriodEnd"] = args ? args.timePeriodEnd : undefined;
            inputs["timePeriodStart"] = args ? args.timePeriodStart : undefined;
            inputs["timeUnit"] = args ? args.timeUnit : undefined;
        }
        super("aws:budgets/budget:Budget", name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering Budget resources.
 */
export interface BudgetState {
    /**
     * The ID of the target account for budget. Will use current user's account_id by default if omitted.
     */
    readonly accountId?: pulumi.Input<string>;
    /**
     * Whether this budget tracks monetary cost or usage.
     */
    readonly budgetType?: pulumi.Input<string>;
    /**
     * Map of CostFilters key/value pairs to apply to the budget.
     */
    readonly costFilters?: pulumi.Input<{[key: string]: any}>;
    /**
     * Object containing CostTypes The types of cost included in a budget, such as tax and subscriptions..
     */
    readonly costTypes?: pulumi.Input<{ includeCredit?: pulumi.Input<boolean>, includeDiscount?: pulumi.Input<boolean>, includeOtherSubscription?: pulumi.Input<boolean>, includeRecurring?: pulumi.Input<boolean>, includeRefund?: pulumi.Input<boolean>, includeSubscription?: pulumi.Input<boolean>, includeSupport?: pulumi.Input<boolean>, includeTax?: pulumi.Input<boolean>, includeUpfront?: pulumi.Input<boolean>, useAmortized?: pulumi.Input<boolean>, useBlended?: pulumi.Input<boolean> }>;
    /**
     * The amount of cost or usage being measured for a budget.
     */
    readonly limitAmount?: pulumi.Input<string>;
    /**
     * The unit of measurement used for the budget forecast, actual spend, or budget threshold, such as dollars or GB. See [Spend](http://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/data-type-spend.html) documentation.
     */
    readonly limitUnit?: pulumi.Input<string>;
    /**
     * The name of a budget. Unique within accounts.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * The prefix of the name of a budget. Unique within accounts.
     */
    readonly namePrefix?: pulumi.Input<string>;
    /**
     * The end of the time period covered by the budget. There are no restrictions on the end date. Format: `2017-01-01_12:00`.
     */
    readonly timePeriodEnd?: pulumi.Input<string>;
    /**
     * The start of the time period covered by the budget. The start date must come before the end date. Format: `2017-01-01_12:00`.
     */
    readonly timePeriodStart?: pulumi.Input<string>;
    /**
     * The length of time until a budget resets the actual and forecasted spend. Valid values: `MONTHLY`, `QUARTERLY`, `ANNUALLY`.
     */
    readonly timeUnit?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a Budget resource.
 */
export interface BudgetArgs {
    /**
     * The ID of the target account for budget. Will use current user's account_id by default if omitted.
     */
    readonly accountId?: pulumi.Input<string>;
    /**
     * Whether this budget tracks monetary cost or usage.
     */
    readonly budgetType: pulumi.Input<string>;
    /**
     * Map of CostFilters key/value pairs to apply to the budget.
     */
    readonly costFilters?: pulumi.Input<{[key: string]: any}>;
    /**
     * Object containing CostTypes The types of cost included in a budget, such as tax and subscriptions..
     */
    readonly costTypes?: pulumi.Input<{ includeCredit?: pulumi.Input<boolean>, includeDiscount?: pulumi.Input<boolean>, includeOtherSubscription?: pulumi.Input<boolean>, includeRecurring?: pulumi.Input<boolean>, includeRefund?: pulumi.Input<boolean>, includeSubscription?: pulumi.Input<boolean>, includeSupport?: pulumi.Input<boolean>, includeTax?: pulumi.Input<boolean>, includeUpfront?: pulumi.Input<boolean>, useAmortized?: pulumi.Input<boolean>, useBlended?: pulumi.Input<boolean> }>;
    /**
     * The amount of cost or usage being measured for a budget.
     */
    readonly limitAmount: pulumi.Input<string>;
    /**
     * The unit of measurement used for the budget forecast, actual spend, or budget threshold, such as dollars or GB. See [Spend](http://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/data-type-spend.html) documentation.
     */
    readonly limitUnit: pulumi.Input<string>;
    /**
     * The name of a budget. Unique within accounts.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * The prefix of the name of a budget. Unique within accounts.
     */
    readonly namePrefix?: pulumi.Input<string>;
    /**
     * The end of the time period covered by the budget. There are no restrictions on the end date. Format: `2017-01-01_12:00`.
     */
    readonly timePeriodEnd?: pulumi.Input<string>;
    /**
     * The start of the time period covered by the budget. The start date must come before the end date. Format: `2017-01-01_12:00`.
     */
    readonly timePeriodStart: pulumi.Input<string>;
    /**
     * The length of time until a budget resets the actual and forecasted spend. Valid values: `MONTHLY`, `QUARTERLY`, `ANNUALLY`.
     */
    readonly timeUnit: pulumi.Input<string>;
}

/**
 * The live Budget resource.
 */
export interface BudgetResult {
    /**
     * The ID of the target account for budget. Will use current user's account_id by default if omitted.
     */
    readonly accountId: string;
    /**
     * Whether this budget tracks monetary cost or usage.
     */
    readonly budgetType: string;
    /**
     * Map of CostFilters key/value pairs to apply to the budget.
     */
    readonly costFilters: {[key: string]: any};
    /**
     * Object containing CostTypes The types of cost included in a budget, such as tax and subscriptions..
     */
    readonly costTypes: { includeCredit?: boolean, includeDiscount?: boolean, includeOtherSubscription?: boolean, includeRecurring?: boolean, includeRefund?: boolean, includeSubscription?: boolean, includeSupport?: boolean, includeTax?: boolean, includeUpfront?: boolean, useAmortized?: boolean, useBlended?: boolean };
    /**
     * The amount of cost or usage being measured for a budget.
     */
    readonly limitAmount: string;
    /**
     * The unit of measurement used for the budget forecast, actual spend, or budget threshold, such as dollars or GB. See [Spend](http://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/data-type-spend.html) documentation.
     */
    readonly limitUnit: string;
    /**
     * The name of a budget. Unique within accounts.
     */
    readonly name: string;
    /**
     * The prefix of the name of a budget. Unique within accounts.
     */
    readonly namePrefix: string;
    /**
     * The end of the time period covered by the budget. There are no restrictions on the end date. Format: `2017-01-01_12:00`.
     */
    readonly timePeriodEnd?: string;
    /**
     * The start of the time period covered by the budget. The start date must come before the end date. Format: `2017-01-01_12:00`.
     */
    readonly timePeriodStart: string;
    /**
     * The length of time until a budget resets the actual and forecasted spend. Valid values: `MONTHLY`, `QUARTERLY`, `ANNUALLY`.
     */
    readonly timeUnit: string;
}
