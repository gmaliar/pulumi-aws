// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.LB
{
    /// <summary>
    /// Provides a Load Balancer Listener resource.
    /// 
    /// &gt; **Note:** `aws.alb.Listener` is known as `aws.lb.Listener`. The functionality is identical.
    /// 
    /// ## Example Usage
    /// ### Forward Action
    /// 
    /// ```csharp
    /// using Pulumi;
    /// using Aws = Pulumi.Aws;
    /// 
    /// class MyStack : Stack
    /// {
    ///     public MyStack()
    ///     {
    ///         var frontEndLoadBalancer = new Aws.LB.LoadBalancer("frontEndLoadBalancer", new Aws.LB.LoadBalancerArgs
    ///         {
    ///         });
    ///         // ...
    ///         var frontEndTargetGroup = new Aws.LB.TargetGroup("frontEndTargetGroup", new Aws.LB.TargetGroupArgs
    ///         {
    ///         });
    ///         // ...
    ///         var frontEndListener = new Aws.LB.Listener("frontEndListener", new Aws.LB.ListenerArgs
    ///         {
    ///             LoadBalancerArn = frontEndLoadBalancer.Arn,
    ///             Port = 443,
    ///             Protocol = "HTTPS",
    ///             SslPolicy = "ELBSecurityPolicy-2016-08",
    ///             CertificateArn = "arn:aws:iam::187416307283:server-certificate/test_cert_rab3wuqwgja25ct3n4jdj2tzu4",
    ///             DefaultActions = 
    ///             {
    ///                 new Aws.LB.Inputs.ListenerDefaultActionArgs
    ///                 {
    ///                     Type = "forward",
    ///                     TargetGroupArn = frontEndTargetGroup.Arn,
    ///                 },
    ///             },
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// ### Redirect Action
    /// 
    /// ```csharp
    /// using Pulumi;
    /// using Aws = Pulumi.Aws;
    /// 
    /// class MyStack : Stack
    /// {
    ///     public MyStack()
    ///     {
    ///         var frontEndLoadBalancer = new Aws.LB.LoadBalancer("frontEndLoadBalancer", new Aws.LB.LoadBalancerArgs
    ///         {
    ///         });
    ///         // ...
    ///         var frontEndListener = new Aws.LB.Listener("frontEndListener", new Aws.LB.ListenerArgs
    ///         {
    ///             LoadBalancerArn = frontEndLoadBalancer.Arn,
    ///             Port = 80,
    ///             Protocol = "HTTP",
    ///             DefaultActions = 
    ///             {
    ///                 new Aws.LB.Inputs.ListenerDefaultActionArgs
    ///                 {
    ///                     Type = "redirect",
    ///                     Redirect = new Aws.LB.Inputs.ListenerDefaultActionRedirectArgs
    ///                     {
    ///                         Port = "443",
    ///                         Protocol = "HTTPS",
    ///                         StatusCode = "HTTP_301",
    ///                     },
    ///                 },
    ///             },
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// ### Fixed-response Action
    /// 
    /// ```csharp
    /// using Pulumi;
    /// using Aws = Pulumi.Aws;
    /// 
    /// class MyStack : Stack
    /// {
    ///     public MyStack()
    ///     {
    ///         var frontEndLoadBalancer = new Aws.LB.LoadBalancer("frontEndLoadBalancer", new Aws.LB.LoadBalancerArgs
    ///         {
    ///         });
    ///         // ...
    ///         var frontEndListener = new Aws.LB.Listener("frontEndListener", new Aws.LB.ListenerArgs
    ///         {
    ///             LoadBalancerArn = frontEndLoadBalancer.Arn,
    ///             Port = 80,
    ///             Protocol = "HTTP",
    ///             DefaultActions = 
    ///             {
    ///                 new Aws.LB.Inputs.ListenerDefaultActionArgs
    ///                 {
    ///                     Type = "fixed-response",
    ///                     FixedResponse = new Aws.LB.Inputs.ListenerDefaultActionFixedResponseArgs
    ///                     {
    ///                         ContentType = "text/plain",
    ///                         MessageBody = "Fixed response content",
    ///                         StatusCode = "200",
    ///                     },
    ///                 },
    ///             },
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// ### Authenticate-cognito Action
    /// 
    /// ```csharp
    /// using Pulumi;
    /// using Aws = Pulumi.Aws;
    /// 
    /// class MyStack : Stack
    /// {
    ///     public MyStack()
    ///     {
    ///         var frontEndLoadBalancer = new Aws.LB.LoadBalancer("frontEndLoadBalancer", new Aws.LB.LoadBalancerArgs
    ///         {
    ///         });
    ///         // ...
    ///         var frontEndTargetGroup = new Aws.LB.TargetGroup("frontEndTargetGroup", new Aws.LB.TargetGroupArgs
    ///         {
    ///         });
    ///         // ...
    ///         var pool = new Aws.Cognito.UserPool("pool", new Aws.Cognito.UserPoolArgs
    ///         {
    ///         });
    ///         // ...
    ///         var client = new Aws.Cognito.UserPoolClient("client", new Aws.Cognito.UserPoolClientArgs
    ///         {
    ///         });
    ///         // ...
    ///         var domain = new Aws.Cognito.UserPoolDomain("domain", new Aws.Cognito.UserPoolDomainArgs
    ///         {
    ///         });
    ///         // ...
    ///         var frontEndListener = new Aws.LB.Listener("frontEndListener", new Aws.LB.ListenerArgs
    ///         {
    ///             LoadBalancerArn = frontEndLoadBalancer.Arn,
    ///             Port = 80,
    ///             Protocol = "HTTP",
    ///             DefaultActions = 
    ///             {
    ///                 new Aws.LB.Inputs.ListenerDefaultActionArgs
    ///                 {
    ///                     Type = "authenticate-cognito",
    ///                     AuthenticateCognito = new Aws.LB.Inputs.ListenerDefaultActionAuthenticateCognitoArgs
    ///                     {
    ///                         UserPoolArn = pool.Arn,
    ///                         UserPoolClientId = client.Id,
    ///                         UserPoolDomain = domain.Domain,
    ///                     },
    ///                 },
    ///                 new Aws.LB.Inputs.ListenerDefaultActionArgs
    ///                 {
    ///                     Type = "forward",
    ///                     TargetGroupArn = frontEndTargetGroup.Arn,
    ///                 },
    ///             },
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// ### Authenticate-oidc Action
    /// 
    /// ```csharp
    /// using Pulumi;
    /// using Aws = Pulumi.Aws;
    /// 
    /// class MyStack : Stack
    /// {
    ///     public MyStack()
    ///     {
    ///         var frontEndLoadBalancer = new Aws.LB.LoadBalancer("frontEndLoadBalancer", new Aws.LB.LoadBalancerArgs
    ///         {
    ///         });
    ///         // ...
    ///         var frontEndTargetGroup = new Aws.LB.TargetGroup("frontEndTargetGroup", new Aws.LB.TargetGroupArgs
    ///         {
    ///         });
    ///         // ...
    ///         var frontEndListener = new Aws.LB.Listener("frontEndListener", new Aws.LB.ListenerArgs
    ///         {
    ///             LoadBalancerArn = frontEndLoadBalancer.Arn,
    ///             Port = 80,
    ///             Protocol = "HTTP",
    ///             DefaultActions = 
    ///             {
    ///                 new Aws.LB.Inputs.ListenerDefaultActionArgs
    ///                 {
    ///                     Type = "authenticate-oidc",
    ///                     AuthenticateOidc = new Aws.LB.Inputs.ListenerDefaultActionAuthenticateOidcArgs
    ///                     {
    ///                         AuthorizationEndpoint = "https://example.com/authorization_endpoint",
    ///                         ClientId = "client_id",
    ///                         ClientSecret = "client_secret",
    ///                         Issuer = "https://example.com",
    ///                         TokenEndpoint = "https://example.com/token_endpoint",
    ///                         UserInfoEndpoint = "https://example.com/user_info_endpoint",
    ///                     },
    ///                 },
    ///                 new Aws.LB.Inputs.ListenerDefaultActionArgs
    ///                 {
    ///                     Type = "forward",
    ///                     TargetGroupArn = frontEndTargetGroup.Arn,
    ///                 },
    ///             },
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// ### Gateway Load Balancer Listener
    /// 
    /// ```csharp
    /// using Pulumi;
    /// using Aws = Pulumi.Aws;
    /// 
    /// class MyStack : Stack
    /// {
    ///     public MyStack()
    ///     {
    ///         var exampleLoadBalancer = new Aws.LB.LoadBalancer("exampleLoadBalancer", new Aws.LB.LoadBalancerArgs
    ///         {
    ///             LoadBalancerType = "gateway",
    ///             SubnetMappings = 
    ///             {
    ///                 new Aws.LB.Inputs.LoadBalancerSubnetMappingArgs
    ///                 {
    ///                     SubnetId = aws_subnet.Example.Id,
    ///                 },
    ///             },
    ///         });
    ///         var exampleTargetGroup = new Aws.LB.TargetGroup("exampleTargetGroup", new Aws.LB.TargetGroupArgs
    ///         {
    ///             Port = 6081,
    ///             Protocol = "GENEVE",
    ///             VpcId = aws_vpc.Example.Id,
    ///             HealthCheck = new Aws.LB.Inputs.TargetGroupHealthCheckArgs
    ///             {
    ///                 Port = "80",
    ///                 Protocol = "HTTP",
    ///             },
    ///         });
    ///         var exampleListener = new Aws.LB.Listener("exampleListener", new Aws.LB.ListenerArgs
    ///         {
    ///             LoadBalancerArn = exampleLoadBalancer.Id,
    ///             DefaultActions = 
    ///             {
    ///                 new Aws.LB.Inputs.ListenerDefaultActionArgs
    ///                 {
    ///                     TargetGroupArn = exampleTargetGroup.Id,
    ///                     Type = "forward",
    ///                 },
    ///             },
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// 
    /// ## Import
    /// 
    /// Listeners can be imported using their ARN, e.g.
    /// 
    /// ```sh
    ///  $ pulumi import aws:lb/listener:Listener front_end arn:aws:elasticloadbalancing:us-west-2:187416307283:listener/app/front-end-alb/8e4497da625e2d8a/9ab28ade35828f96
    /// ```
    /// </summary>
    public partial class Listener : Pulumi.CustomResource
    {
        /// <summary>
        /// The Amazon Resource Name (ARN) of the target group.
        /// </summary>
        [Output("arn")]
        public Output<string> Arn { get; private set; } = null!;

        /// <summary>
        /// The ARN of the default SSL server certificate. Exactly one certificate is required if the protocol is HTTPS. For adding additional SSL certificates, see the `aws.lb.ListenerCertificate` resource.
        /// </summary>
        [Output("certificateArn")]
        public Output<string?> CertificateArn { get; private set; } = null!;

        /// <summary>
        /// An Action block. Action blocks are documented below.
        /// </summary>
        [Output("defaultActions")]
        public Output<ImmutableArray<Outputs.ListenerDefaultAction>> DefaultActions { get; private set; } = null!;

        /// <summary>
        /// The ARN of the load balancer.
        /// </summary>
        [Output("loadBalancerArn")]
        public Output<string> LoadBalancerArn { get; private set; } = null!;

        /// <summary>
        /// The port on which the load balancer is listening. Not valid for Gateway Load Balancers.
        /// </summary>
        [Output("port")]
        public Output<int?> Port { get; private set; } = null!;

        /// <summary>
        /// The protocol for connections from clients to the load balancer. For Application Load Balancers, valid values are `HTTP` and `HTTPS`, with a default of `HTTP`. For Network Load Balancers, valid values are `TCP`, `TLS`, `UDP`, and `TCP_UDP`. Not valid to use `UDP` or `TCP_UDP` if dual-stack mode is enabled. Not valid for Gateway Load Balancers.
        /// </summary>
        [Output("protocol")]
        public Output<string> Protocol { get; private set; } = null!;

        /// <summary>
        /// The name of the SSL Policy for the listener. Required if `protocol` is `HTTPS` or `TLS`.
        /// </summary>
        [Output("sslPolicy")]
        public Output<string> SslPolicy { get; private set; } = null!;


        /// <summary>
        /// Create a Listener resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Listener(string name, ListenerArgs args, CustomResourceOptions? options = null)
            : base("aws:lb/listener:Listener", name, args ?? new ListenerArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Listener(string name, Input<string> id, ListenerState? state = null, CustomResourceOptions? options = null)
            : base("aws:lb/listener:Listener", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "aws:elasticloadbalancingv2/listener:Listener"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing Listener resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Listener Get(string name, Input<string> id, ListenerState? state = null, CustomResourceOptions? options = null)
        {
            return new Listener(name, id, state, options);
        }
    }

    public sealed class ListenerArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The ARN of the default SSL server certificate. Exactly one certificate is required if the protocol is HTTPS. For adding additional SSL certificates, see the `aws.lb.ListenerCertificate` resource.
        /// </summary>
        [Input("certificateArn")]
        public Input<string>? CertificateArn { get; set; }

        [Input("defaultActions", required: true)]
        private InputList<Inputs.ListenerDefaultActionArgs>? _defaultActions;

        /// <summary>
        /// An Action block. Action blocks are documented below.
        /// </summary>
        public InputList<Inputs.ListenerDefaultActionArgs> DefaultActions
        {
            get => _defaultActions ?? (_defaultActions = new InputList<Inputs.ListenerDefaultActionArgs>());
            set => _defaultActions = value;
        }

        /// <summary>
        /// The ARN of the load balancer.
        /// </summary>
        [Input("loadBalancerArn", required: true)]
        public Input<string> LoadBalancerArn { get; set; } = null!;

        /// <summary>
        /// The port on which the load balancer is listening. Not valid for Gateway Load Balancers.
        /// </summary>
        [Input("port")]
        public Input<int>? Port { get; set; }

        /// <summary>
        /// The protocol for connections from clients to the load balancer. For Application Load Balancers, valid values are `HTTP` and `HTTPS`, with a default of `HTTP`. For Network Load Balancers, valid values are `TCP`, `TLS`, `UDP`, and `TCP_UDP`. Not valid to use `UDP` or `TCP_UDP` if dual-stack mode is enabled. Not valid for Gateway Load Balancers.
        /// </summary>
        [Input("protocol")]
        public Input<string>? Protocol { get; set; }

        /// <summary>
        /// The name of the SSL Policy for the listener. Required if `protocol` is `HTTPS` or `TLS`.
        /// </summary>
        [Input("sslPolicy")]
        public Input<string>? SslPolicy { get; set; }

        public ListenerArgs()
        {
        }
    }

    public sealed class ListenerState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The Amazon Resource Name (ARN) of the target group.
        /// </summary>
        [Input("arn")]
        public Input<string>? Arn { get; set; }

        /// <summary>
        /// The ARN of the default SSL server certificate. Exactly one certificate is required if the protocol is HTTPS. For adding additional SSL certificates, see the `aws.lb.ListenerCertificate` resource.
        /// </summary>
        [Input("certificateArn")]
        public Input<string>? CertificateArn { get; set; }

        [Input("defaultActions")]
        private InputList<Inputs.ListenerDefaultActionGetArgs>? _defaultActions;

        /// <summary>
        /// An Action block. Action blocks are documented below.
        /// </summary>
        public InputList<Inputs.ListenerDefaultActionGetArgs> DefaultActions
        {
            get => _defaultActions ?? (_defaultActions = new InputList<Inputs.ListenerDefaultActionGetArgs>());
            set => _defaultActions = value;
        }

        /// <summary>
        /// The ARN of the load balancer.
        /// </summary>
        [Input("loadBalancerArn")]
        public Input<string>? LoadBalancerArn { get; set; }

        /// <summary>
        /// The port on which the load balancer is listening. Not valid for Gateway Load Balancers.
        /// </summary>
        [Input("port")]
        public Input<int>? Port { get; set; }

        /// <summary>
        /// The protocol for connections from clients to the load balancer. For Application Load Balancers, valid values are `HTTP` and `HTTPS`, with a default of `HTTP`. For Network Load Balancers, valid values are `TCP`, `TLS`, `UDP`, and `TCP_UDP`. Not valid to use `UDP` or `TCP_UDP` if dual-stack mode is enabled. Not valid for Gateway Load Balancers.
        /// </summary>
        [Input("protocol")]
        public Input<string>? Protocol { get; set; }

        /// <summary>
        /// The name of the SSL Policy for the listener. Required if `protocol` is `HTTPS` or `TLS`.
        /// </summary>
        [Input("sslPolicy")]
        public Input<string>? SslPolicy { get; set; }

        public ListenerState()
        {
        }
    }
}
