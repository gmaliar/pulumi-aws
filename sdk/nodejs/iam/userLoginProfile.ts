// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";
import * as rxjs from "rxjs";
import * as operators from "rxjs/operators";

/**
 * Provides one-time creation of a IAM user login profile, and uses PGP to
 * encrypt the password for safe transport to the user. PGP keys can be
 * obtained from Keybase.
 * 
 * ## Example Usage
 * 
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as aws from "@pulumi/aws";
 * 
 * const user = new aws.iam.User("u", {
 *     forceDestroy: true,
 *     name: "auser",
 *     path: "/",
 * });
 * const userLoginProfile = new aws.iam.UserLoginProfile("u", {
 *     pgpKey: "keybase:some_person_that_exists",
 *     user: user.name,
 * });
 * 
 * export const password = userLoginProfile.encryptedPassword;
 * ```
 */
export class UserLoginProfile extends pulumi.CustomResource {
    /**
     * Get an existing UserLoginProfile resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: UserLoginProfileState, opts?: pulumi.CustomResourceOptions): UserLoginProfile {
        return new UserLoginProfile(name, <any>state, { ...opts, id: id });
    }

    public static list(ctx: pulumi.query.ListContext, args?: pulumi.query.ListArgs): rxjs.Observable<UserLoginProfileResult> {
        return ctx.list({...args, type: 'aws:iam/userLoginProfile:UserLoginProfile'});
    }

    /**
     * The encrypted password, base64 encoded.
     */
    public /*out*/ readonly encryptedPassword: pulumi.Output<string>;
    /**
     * The fingerprint of the PGP key used to encrypt
     * the password
     */
    public /*out*/ readonly keyFingerprint: pulumi.Output<string>;
    /**
     * The length of the generated
     * password.
     */
    public readonly passwordLength: pulumi.Output<number | undefined>;
    /**
     * Whether the
     * user should be forced to reset the generated password on first login.
     */
    public readonly passwordResetRequired: pulumi.Output<boolean | undefined>;
    /**
     * Either a base-64 encoded PGP public key, or a
     * keybase username in the form `keybase:username`.
     */
    public readonly pgpKey: pulumi.Output<string>;
    /**
     * The IAM user's name.
     */
    public readonly user: pulumi.Output<string>;

    /**
     * Create a UserLoginProfile resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: UserLoginProfileArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: UserLoginProfileArgs | UserLoginProfileState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state: UserLoginProfileState = argsOrState as UserLoginProfileState | undefined;
            inputs["encryptedPassword"] = state ? state.encryptedPassword : undefined;
            inputs["keyFingerprint"] = state ? state.keyFingerprint : undefined;
            inputs["passwordLength"] = state ? state.passwordLength : undefined;
            inputs["passwordResetRequired"] = state ? state.passwordResetRequired : undefined;
            inputs["pgpKey"] = state ? state.pgpKey : undefined;
            inputs["user"] = state ? state.user : undefined;
        } else {
            const args = argsOrState as UserLoginProfileArgs | undefined;
            if (!args || args.pgpKey === undefined) {
                throw new Error("Missing required property 'pgpKey'");
            }
            if (!args || args.user === undefined) {
                throw new Error("Missing required property 'user'");
            }
            inputs["passwordLength"] = args ? args.passwordLength : undefined;
            inputs["passwordResetRequired"] = args ? args.passwordResetRequired : undefined;
            inputs["pgpKey"] = args ? args.pgpKey : undefined;
            inputs["user"] = args ? args.user : undefined;
            inputs["encryptedPassword"] = undefined /*out*/;
            inputs["keyFingerprint"] = undefined /*out*/;
        }
        super("aws:iam/userLoginProfile:UserLoginProfile", name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering UserLoginProfile resources.
 */
export interface UserLoginProfileState {
    /**
     * The encrypted password, base64 encoded.
     */
    readonly encryptedPassword?: pulumi.Input<string>;
    /**
     * The fingerprint of the PGP key used to encrypt
     * the password
     */
    readonly keyFingerprint?: pulumi.Input<string>;
    /**
     * The length of the generated
     * password.
     */
    readonly passwordLength?: pulumi.Input<number>;
    /**
     * Whether the
     * user should be forced to reset the generated password on first login.
     */
    readonly passwordResetRequired?: pulumi.Input<boolean>;
    /**
     * Either a base-64 encoded PGP public key, or a
     * keybase username in the form `keybase:username`.
     */
    readonly pgpKey?: pulumi.Input<string>;
    /**
     * The IAM user's name.
     */
    readonly user?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a UserLoginProfile resource.
 */
export interface UserLoginProfileArgs {
    /**
     * The length of the generated
     * password.
     */
    readonly passwordLength?: pulumi.Input<number>;
    /**
     * Whether the
     * user should be forced to reset the generated password on first login.
     */
    readonly passwordResetRequired?: pulumi.Input<boolean>;
    /**
     * Either a base-64 encoded PGP public key, or a
     * keybase username in the form `keybase:username`.
     */
    readonly pgpKey: pulumi.Input<string>;
    /**
     * The IAM user's name.
     */
    readonly user: pulumi.Input<string>;
}

/**
 * The live UserLoginProfile resource.
 */
export interface UserLoginProfileResult {
    /**
     * The encrypted password, base64 encoded.
     */
    readonly encryptedPassword: string;
    /**
     * The fingerprint of the PGP key used to encrypt
     * the password
     */
    readonly keyFingerprint: string;
    /**
     * The length of the generated
     * password.
     */
    readonly passwordLength?: number;
    /**
     * Whether the
     * user should be forced to reset the generated password on first login.
     */
    readonly passwordResetRequired?: boolean;
    /**
     * Either a base-64 encoded PGP public key, or a
     * keybase username in the form `keybase:username`.
     */
    readonly pgpKey: string;
    /**
     * The IAM user's name.
     */
    readonly user: string;
}
