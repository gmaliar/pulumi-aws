# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import pulumi
import pulumi.runtime
from .. import utilities

class Parameter(pulumi.CustomResource):
    """
    Provides an SSM Parameter resource.
    """
    def __init__(__self__, __name__, __opts__=None, allowed_pattern=None, arn=None, description=None, key_id=None, name=None, overwrite=None, tags=None, type=None, value=None):
        """Create a Parameter resource with the given unique name, props, and options."""
        if not __name__:
            raise TypeError('Missing resource name argument (for URN creation)')
        if not isinstance(__name__, basestring):
            raise TypeError('Expected resource name to be a string')
        if __opts__ and not isinstance(__opts__, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')

        __props__ = dict()

        if allowed_pattern and not isinstance(allowed_pattern, basestring):
            raise TypeError('Expected property allowed_pattern to be a basestring')
        __self__.allowed_pattern = allowed_pattern
        """
        A regular expression used to validate the parameter value.
        """
        __props__['allowedPattern'] = allowed_pattern

        if arn and not isinstance(arn, basestring):
            raise TypeError('Expected property arn to be a basestring')
        __self__.arn = arn
        """
        The ARN of the parameter.
        """
        __props__['arn'] = arn

        if description and not isinstance(description, basestring):
            raise TypeError('Expected property description to be a basestring')
        __self__.description = description
        """
        The description of the parameter.
        """
        __props__['description'] = description

        if key_id and not isinstance(key_id, basestring):
            raise TypeError('Expected property key_id to be a basestring')
        __self__.key_id = key_id
        """
        The KMS key id or arn for encrypting a SecureString.
        """
        __props__['keyId'] = key_id

        if name and not isinstance(name, basestring):
            raise TypeError('Expected property name to be a basestring')
        __self__.name = name
        """
        The name of the parameter.
        """
        __props__['name'] = name

        if overwrite and not isinstance(overwrite, bool):
            raise TypeError('Expected property overwrite to be a bool')
        __self__.overwrite = overwrite
        """
        Overwrite an existing parameter. If not specified, will default to `false` if the resource has not been created by terraform to avoid overwrite of existing resource and will default to `true` otherwise (terraform lifecycle rules should then be used to manage the update behavior).
        """
        __props__['overwrite'] = overwrite

        if tags and not isinstance(tags, dict):
            raise TypeError('Expected property tags to be a dict')
        __self__.tags = tags
        """
        A mapping of tags to assign to the object.
        """
        __props__['tags'] = tags

        if not type:
            raise TypeError('Missing required property type')
        elif not isinstance(type, basestring):
            raise TypeError('Expected property type to be a basestring')
        __self__.type = type
        """
        The type of the parameter. Valid types are `String`, `StringList` and `SecureString`.
        """
        __props__['type'] = type

        if not value:
            raise TypeError('Missing required property value')
        elif not isinstance(value, basestring):
            raise TypeError('Expected property value to be a basestring')
        __self__.value = value
        """
        The value of the parameter.
        """
        __props__['value'] = value

        super(Parameter, __self__).__init__(
            'aws:ssm/parameter:Parameter',
            __name__,
            __props__,
            __opts__)

    def set_outputs(self, outs):
        if 'allowedPattern' in outs:
            self.allowed_pattern = outs['allowedPattern']
        if 'arn' in outs:
            self.arn = outs['arn']
        if 'description' in outs:
            self.description = outs['description']
        if 'keyId' in outs:
            self.key_id = outs['keyId']
        if 'name' in outs:
            self.name = outs['name']
        if 'overwrite' in outs:
            self.overwrite = outs['overwrite']
        if 'tags' in outs:
            self.tags = outs['tags']
        if 'type' in outs:
            self.type = outs['type']
        if 'value' in outs:
            self.value = outs['value']
