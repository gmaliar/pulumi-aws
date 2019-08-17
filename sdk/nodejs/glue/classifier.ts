// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Provides a Glue Classifier resource.
 * 
 * > **NOTE:** It is only valid to create one type of classifier (grok, JSON, or XML). Changing classifier types will recreate the classifier.
 * 
 * ## Example Usage
 * 
 * ### Grok Classifier
 * 
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as aws from "@pulumi/aws";
 * 
 * const example = new aws.glue.Classifier("example", {
 *     grokClassifier: {
 *         classification: "example",
 *         grokPattern: "example",
 *     },
 * });
 * ```
 * 
 * ### JSON Classifier
 * 
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as aws from "@pulumi/aws";
 * 
 * const example = new aws.glue.Classifier("example", {
 *     jsonClassifier: {
 *         jsonPath: "example",
 *     },
 * });
 * ```
 * 
 * ### XML Classifier
 * 
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as aws from "@pulumi/aws";
 * 
 * const example = new aws.glue.Classifier("example", {
 *     xmlClassifier: {
 *         classification: "example",
 *         rowTag: "example",
 *     },
 * });
 * ```
 *
 * > This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/r/glue_classifier.html.markdown.
 */
export class Classifier extends pulumi.CustomResource {
    /**
     * Get an existing Classifier resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: ClassifierState, opts?: pulumi.CustomResourceOptions): Classifier {
        return new Classifier(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'aws:glue/classifier:Classifier';

    /**
     * Returns true if the given object is an instance of Classifier.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Classifier {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Classifier.__pulumiType;
    }

    /**
     * A classifier that uses grok patterns. Defined below.
     */
    public readonly grokClassifier!: pulumi.Output<outputs.glue.ClassifierGrokClassifier | undefined>;
    /**
     * A classifier for JSON content. Defined below.
     */
    public readonly jsonClassifier!: pulumi.Output<outputs.glue.ClassifierJsonClassifier | undefined>;
    /**
     * The name of the classifier.
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * A classifier for XML content. Defined below.
     */
    public readonly xmlClassifier!: pulumi.Output<outputs.glue.ClassifierXmlClassifier | undefined>;

    /**
     * Create a Classifier resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args?: ClassifierArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: ClassifierArgs | ClassifierState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state = argsOrState as ClassifierState | undefined;
            inputs["grokClassifier"] = state ? state.grokClassifier : undefined;
            inputs["jsonClassifier"] = state ? state.jsonClassifier : undefined;
            inputs["name"] = state ? state.name : undefined;
            inputs["xmlClassifier"] = state ? state.xmlClassifier : undefined;
        } else {
            const args = argsOrState as ClassifierArgs | undefined;
            inputs["grokClassifier"] = args ? args.grokClassifier : undefined;
            inputs["jsonClassifier"] = args ? args.jsonClassifier : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["xmlClassifier"] = args ? args.xmlClassifier : undefined;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(Classifier.__pulumiType, name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering Classifier resources.
 */
export interface ClassifierState {
    /**
     * A classifier that uses grok patterns. Defined below.
     */
    readonly grokClassifier?: pulumi.Input<inputs.glue.ClassifierGrokClassifier>;
    /**
     * A classifier for JSON content. Defined below.
     */
    readonly jsonClassifier?: pulumi.Input<inputs.glue.ClassifierJsonClassifier>;
    /**
     * The name of the classifier.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * A classifier for XML content. Defined below.
     */
    readonly xmlClassifier?: pulumi.Input<inputs.glue.ClassifierXmlClassifier>;
}

/**
 * The set of arguments for constructing a Classifier resource.
 */
export interface ClassifierArgs {
    /**
     * A classifier that uses grok patterns. Defined below.
     */
    readonly grokClassifier?: pulumi.Input<inputs.glue.ClassifierGrokClassifier>;
    /**
     * A classifier for JSON content. Defined below.
     */
    readonly jsonClassifier?: pulumi.Input<inputs.glue.ClassifierJsonClassifier>;
    /**
     * The name of the classifier.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * A classifier for XML content. Defined below.
     */
    readonly xmlClassifier?: pulumi.Input<inputs.glue.ClassifierXmlClassifier>;
}
