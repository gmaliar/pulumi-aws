// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Organizations
{
    /// <summary>
    /// ## Import
    /// 
    /// The AWS organization can be imported by using the `id`, e.g.
    /// 
    /// ```sh
    ///  $ pulumi import aws:organizations/organization:Organization my_org o-1234567
    /// ```
    /// </summary>
    public partial class Organization : Pulumi.CustomResource
    {
        /// <summary>
        /// List of organization accounts including the master account. For a list excluding the master account, see the `non_master_accounts` attribute. All elements have these attributes:
        /// </summary>
        [Output("accounts")]
        public Output<ImmutableArray<Outputs.OrganizationAccount>> Accounts { get; private set; } = null!;

        /// <summary>
        /// ARN of the root
        /// </summary>
        [Output("arn")]
        public Output<string> Arn { get; private set; } = null!;

        /// <summary>
        /// List of AWS service principal names for which you want to enable integration with your organization. This is typically in the form of a URL, such as service-abbreviation.amazonaws.com. Organization must have `feature_set` set to `ALL`. For additional information, see the [AWS Organizations User Guide](https://docs.aws.amazon.com/organizations/latest/userguide/orgs_integrate_services.html).
        /// </summary>
        [Output("awsServiceAccessPrincipals")]
        public Output<ImmutableArray<string>> AwsServiceAccessPrincipals { get; private set; } = null!;

        /// <summary>
        /// List of Organizations policy types to enable in the Organization Root. Organization must have `feature_set` set to `ALL`. For additional information about valid policy types (e.g. `BACKUP_POLICY`, `SERVICE_CONTROL_POLICY`, and `TAG_POLICY`), see the [AWS Organizations API Reference](https://docs.aws.amazon.com/organizations/latest/APIReference/API_EnablePolicyType.html).
        /// </summary>
        [Output("enabledPolicyTypes")]
        public Output<ImmutableArray<string>> EnabledPolicyTypes { get; private set; } = null!;

        /// <summary>
        /// Specify "ALL" (default) or "CONSOLIDATED_BILLING".
        /// </summary>
        [Output("featureSet")]
        public Output<string?> FeatureSet { get; private set; } = null!;

        /// <summary>
        /// ARN of the master account
        /// </summary>
        [Output("masterAccountArn")]
        public Output<string> MasterAccountArn { get; private set; } = null!;

        /// <summary>
        /// Email address of the master account
        /// </summary>
        [Output("masterAccountEmail")]
        public Output<string> MasterAccountEmail { get; private set; } = null!;

        /// <summary>
        /// Identifier of the master account
        /// </summary>
        [Output("masterAccountId")]
        public Output<string> MasterAccountId { get; private set; } = null!;

        /// <summary>
        /// List of organization accounts excluding the master account. For a list including the master account, see the `accounts` attribute. All elements have these attributes:
        /// </summary>
        [Output("nonMasterAccounts")]
        public Output<ImmutableArray<Outputs.OrganizationNonMasterAccount>> NonMasterAccounts { get; private set; } = null!;

        /// <summary>
        /// List of organization roots. All elements have these attributes:
        /// </summary>
        [Output("roots")]
        public Output<ImmutableArray<Outputs.OrganizationRoot>> Roots { get; private set; } = null!;


        /// <summary>
        /// Create a Organization resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Organization(string name, OrganizationArgs? args = null, CustomResourceOptions? options = null)
            : base("aws:organizations/organization:Organization", name, args ?? new OrganizationArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Organization(string name, Input<string> id, OrganizationState? state = null, CustomResourceOptions? options = null)
            : base("aws:organizations/organization:Organization", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing Organization resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Organization Get(string name, Input<string> id, OrganizationState? state = null, CustomResourceOptions? options = null)
        {
            return new Organization(name, id, state, options);
        }
    }

    public sealed class OrganizationArgs : Pulumi.ResourceArgs
    {
        [Input("awsServiceAccessPrincipals")]
        private InputList<string>? _awsServiceAccessPrincipals;

        /// <summary>
        /// List of AWS service principal names for which you want to enable integration with your organization. This is typically in the form of a URL, such as service-abbreviation.amazonaws.com. Organization must have `feature_set` set to `ALL`. For additional information, see the [AWS Organizations User Guide](https://docs.aws.amazon.com/organizations/latest/userguide/orgs_integrate_services.html).
        /// </summary>
        public InputList<string> AwsServiceAccessPrincipals
        {
            get => _awsServiceAccessPrincipals ?? (_awsServiceAccessPrincipals = new InputList<string>());
            set => _awsServiceAccessPrincipals = value;
        }

        [Input("enabledPolicyTypes")]
        private InputList<string>? _enabledPolicyTypes;

        /// <summary>
        /// List of Organizations policy types to enable in the Organization Root. Organization must have `feature_set` set to `ALL`. For additional information about valid policy types (e.g. `BACKUP_POLICY`, `SERVICE_CONTROL_POLICY`, and `TAG_POLICY`), see the [AWS Organizations API Reference](https://docs.aws.amazon.com/organizations/latest/APIReference/API_EnablePolicyType.html).
        /// </summary>
        public InputList<string> EnabledPolicyTypes
        {
            get => _enabledPolicyTypes ?? (_enabledPolicyTypes = new InputList<string>());
            set => _enabledPolicyTypes = value;
        }

        /// <summary>
        /// Specify "ALL" (default) or "CONSOLIDATED_BILLING".
        /// </summary>
        [Input("featureSet")]
        public Input<string>? FeatureSet { get; set; }

        public OrganizationArgs()
        {
        }
    }

    public sealed class OrganizationState : Pulumi.ResourceArgs
    {
        [Input("accounts")]
        private InputList<Inputs.OrganizationAccountGetArgs>? _accounts;

        /// <summary>
        /// List of organization accounts including the master account. For a list excluding the master account, see the `non_master_accounts` attribute. All elements have these attributes:
        /// </summary>
        public InputList<Inputs.OrganizationAccountGetArgs> Accounts
        {
            get => _accounts ?? (_accounts = new InputList<Inputs.OrganizationAccountGetArgs>());
            set => _accounts = value;
        }

        /// <summary>
        /// ARN of the root
        /// </summary>
        [Input("arn")]
        public Input<string>? Arn { get; set; }

        [Input("awsServiceAccessPrincipals")]
        private InputList<string>? _awsServiceAccessPrincipals;

        /// <summary>
        /// List of AWS service principal names for which you want to enable integration with your organization. This is typically in the form of a URL, such as service-abbreviation.amazonaws.com. Organization must have `feature_set` set to `ALL`. For additional information, see the [AWS Organizations User Guide](https://docs.aws.amazon.com/organizations/latest/userguide/orgs_integrate_services.html).
        /// </summary>
        public InputList<string> AwsServiceAccessPrincipals
        {
            get => _awsServiceAccessPrincipals ?? (_awsServiceAccessPrincipals = new InputList<string>());
            set => _awsServiceAccessPrincipals = value;
        }

        [Input("enabledPolicyTypes")]
        private InputList<string>? _enabledPolicyTypes;

        /// <summary>
        /// List of Organizations policy types to enable in the Organization Root. Organization must have `feature_set` set to `ALL`. For additional information about valid policy types (e.g. `BACKUP_POLICY`, `SERVICE_CONTROL_POLICY`, and `TAG_POLICY`), see the [AWS Organizations API Reference](https://docs.aws.amazon.com/organizations/latest/APIReference/API_EnablePolicyType.html).
        /// </summary>
        public InputList<string> EnabledPolicyTypes
        {
            get => _enabledPolicyTypes ?? (_enabledPolicyTypes = new InputList<string>());
            set => _enabledPolicyTypes = value;
        }

        /// <summary>
        /// Specify "ALL" (default) or "CONSOLIDATED_BILLING".
        /// </summary>
        [Input("featureSet")]
        public Input<string>? FeatureSet { get; set; }

        /// <summary>
        /// ARN of the master account
        /// </summary>
        [Input("masterAccountArn")]
        public Input<string>? MasterAccountArn { get; set; }

        /// <summary>
        /// Email address of the master account
        /// </summary>
        [Input("masterAccountEmail")]
        public Input<string>? MasterAccountEmail { get; set; }

        /// <summary>
        /// Identifier of the master account
        /// </summary>
        [Input("masterAccountId")]
        public Input<string>? MasterAccountId { get; set; }

        [Input("nonMasterAccounts")]
        private InputList<Inputs.OrganizationNonMasterAccountGetArgs>? _nonMasterAccounts;

        /// <summary>
        /// List of organization accounts excluding the master account. For a list including the master account, see the `accounts` attribute. All elements have these attributes:
        /// </summary>
        public InputList<Inputs.OrganizationNonMasterAccountGetArgs> NonMasterAccounts
        {
            get => _nonMasterAccounts ?? (_nonMasterAccounts = new InputList<Inputs.OrganizationNonMasterAccountGetArgs>());
            set => _nonMasterAccounts = value;
        }

        [Input("roots")]
        private InputList<Inputs.OrganizationRootGetArgs>? _roots;

        /// <summary>
        /// List of organization roots. All elements have these attributes:
        /// </summary>
        public InputList<Inputs.OrganizationRootGetArgs> Roots
        {
            get => _roots ?? (_roots = new InputList<Inputs.OrganizationRootGetArgs>());
            set => _roots = value;
        }

        public OrganizationState()
        {
        }
    }
}
