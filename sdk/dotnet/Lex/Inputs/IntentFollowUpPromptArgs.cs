// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Lex.Inputs
{

    public sealed class IntentFollowUpPromptArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Prompts for information from the user. Attributes are documented under prompt.
        /// </summary>
        [Input("prompt", required: true)]
        public Input<Inputs.IntentFollowUpPromptPromptArgs> Prompt { get; set; } = null!;

        /// <summary>
        /// If the user answers "no" to the question defined in the prompt field,
        /// Amazon Lex responds with this statement to acknowledge that the intent was canceled. Attributes are
        /// documented below under statement.
        /// </summary>
        [Input("rejectionStatement", required: true)]
        public Input<Inputs.IntentFollowUpPromptRejectionStatementArgs> RejectionStatement { get; set; } = null!;

        public IntentFollowUpPromptArgs()
        {
        }
    }
}