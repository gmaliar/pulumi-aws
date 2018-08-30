# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import pulumi
import pulumi.runtime
from .. import utilities

class RdsDbInstance(pulumi.CustomResource):
    """
    Provides an OpsWorks RDS DB Instance resource.
    
    ~> **Note:** All arguments including the username and password will be stored in the raw state as plain-text.
    [Read more about sensitive data in state](https://www.terraform.io/docs/state/sensitive-data.html).
    """
    def __init__(__self__, __name__, __opts__=None, db_password=None, db_user=None, rds_db_instance_arn=None, stack_id=None):
        """Create a RdsDbInstance resource with the given unique name, props, and options."""
        if not __name__:
            raise TypeError('Missing resource name argument (for URN creation)')
        if not isinstance(__name__, basestring):
            raise TypeError('Expected resource name to be a string')
        if __opts__ and not isinstance(__opts__, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')

        __props__ = dict()

        if not db_password:
            raise TypeError('Missing required property db_password')
        elif not isinstance(db_password, basestring):
            raise TypeError('Expected property db_password to be a basestring')
        __self__.db_password = db_password
        """
        A db password
        """
        __props__['dbPassword'] = db_password

        if not db_user:
            raise TypeError('Missing required property db_user')
        elif not isinstance(db_user, basestring):
            raise TypeError('Expected property db_user to be a basestring')
        __self__.db_user = db_user
        """
        A db username
        """
        __props__['dbUser'] = db_user

        if not rds_db_instance_arn:
            raise TypeError('Missing required property rds_db_instance_arn')
        elif not isinstance(rds_db_instance_arn, basestring):
            raise TypeError('Expected property rds_db_instance_arn to be a basestring')
        __self__.rds_db_instance_arn = rds_db_instance_arn
        """
        The db instance to register for this stack. Changing this will force a new resource.
        """
        __props__['rdsDbInstanceArn'] = rds_db_instance_arn

        if not stack_id:
            raise TypeError('Missing required property stack_id')
        elif not isinstance(stack_id, basestring):
            raise TypeError('Expected property stack_id to be a basestring')
        __self__.stack_id = stack_id
        """
        The stack to register a db inatance for. Changing this will force a new resource.
        """
        __props__['stackId'] = stack_id

        super(RdsDbInstance, __self__).__init__(
            'aws:opsworks/rdsDbInstance:RdsDbInstance',
            __name__,
            __props__,
            __opts__)

    def set_outputs(self, outs):
        if 'dbPassword' in outs:
            self.db_password = outs['dbPassword']
        if 'dbUser' in outs:
            self.db_user = outs['dbUser']
        if 'rdsDbInstanceArn' in outs:
            self.rds_db_instance_arn = outs['rdsDbInstanceArn']
        if 'stackId' in outs:
            self.stack_id = outs['stackId']
