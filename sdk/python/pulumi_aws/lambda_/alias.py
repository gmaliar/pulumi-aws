# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import pulumi
import pulumi.runtime
from .. import utilities

class Alias(pulumi.CustomResource):
    """
    Creates a Lambda function alias. Creates an alias that points to the specified Lambda function version.
    
    For information about Lambda and how to use it, see [What is AWS Lambda?][1]
    For information about function aliases, see [CreateAlias][2] and [AliasRoutingConfiguration][3] in the API docs.
    """
    def __init__(__self__, __name__, __opts__=None, description=None, function_name=None, function_version=None, name=None, routing_config=None):
        """Create a Alias resource with the given unique name, props, and options."""
        if not __name__:
            raise TypeError('Missing resource name argument (for URN creation)')
        if not isinstance(__name__, basestring):
            raise TypeError('Expected resource name to be a string')
        if __opts__ and not isinstance(__opts__, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')

        __props__ = dict()

        if description and not isinstance(description, basestring):
            raise TypeError('Expected property description to be a basestring')
        __self__.description = description
        """
        Description of the alias.
        """
        __props__['description'] = description

        if not function_name:
            raise TypeError('Missing required property function_name')
        elif not isinstance(function_name, basestring):
            raise TypeError('Expected property function_name to be a basestring')
        __self__.function_name = function_name
        """
        The function ARN of the Lambda function for which you want to create an alias.
        """
        __props__['functionName'] = function_name

        if not function_version:
            raise TypeError('Missing required property function_version')
        elif not isinstance(function_version, basestring):
            raise TypeError('Expected property function_version to be a basestring')
        __self__.function_version = function_version
        """
        Lambda function version for which you are creating the alias. Pattern: `(\$LATEST|[0-9]+)`.
        """
        __props__['functionVersion'] = function_version

        if name and not isinstance(name, basestring):
            raise TypeError('Expected property name to be a basestring')
        __self__.name = name
        """
        Name for the alias you are creating. Pattern: `(?!^[0-9]+$)([a-zA-Z0-9-_]+)`
        """
        __props__['name'] = name

        if routing_config and not isinstance(routing_config, dict):
            raise TypeError('Expected property routing_config to be a dict')
        __self__.routing_config = routing_config
        """
        The Lambda alias' route configuration settings. Fields documented below
        """
        __props__['routingConfig'] = routing_config

        __self__.arn = pulumi.runtime.UNKNOWN
        """
        The Amazon Resource Name (ARN) identifying your Lambda function alias.
        """

        super(Alias, __self__).__init__(
            'aws:lambda/alias:Alias',
            __name__,
            __props__,
            __opts__)

    def set_outputs(self, outs):
        if 'arn' in outs:
            self.arn = outs['arn']
        if 'description' in outs:
            self.description = outs['description']
        if 'functionName' in outs:
            self.function_name = outs['functionName']
        if 'functionVersion' in outs:
            self.function_version = outs['functionVersion']
        if 'name' in outs:
            self.name = outs['name']
        if 'routingConfig' in outs:
            self.routing_config = outs['routingConfig']
