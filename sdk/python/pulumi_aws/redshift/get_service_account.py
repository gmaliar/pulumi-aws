# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import json
import warnings
import pulumi
import pulumi.runtime
from typing import Union
from .. import utilities, tables

class GetServiceAccountResult:
    """
    A collection of values returned by getServiceAccount.
    """
    def __init__(__self__, arn=None, id=None, region=None):
        if arn and not isinstance(arn, str):
            raise TypeError("Expected argument 'arn' to be a str")
        __self__.arn = arn
        """
        The ARN of the AWS Redshift service account in the selected region.
        """
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        __self__.id = id
        """
        The provider-assigned unique ID for this managed resource.
        """
        if region and not isinstance(region, str):
            raise TypeError("Expected argument 'region' to be a str")
        __self__.region = region
class AwaitableGetServiceAccountResult(GetServiceAccountResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetServiceAccountResult(
            arn=self.arn,
            id=self.id,
            region=self.region)

def get_service_account(region=None,opts=None):
    """
    Use this data source to get the Account ID of the [AWS Redshift Service Account](http://docs.aws.amazon.com/redshift/latest/mgmt/db-auditing.html#db-auditing-enable-logging)
    in a given region for the purpose of allowing Redshift to store audit data in S3.

    ## Example Usage



    ```python
    import pulumi
    import pulumi_aws as aws

    main = aws.redshift.get_service_account()
    bucket = aws.s3.Bucket("bucket",
        force_destroy=True,
        policy=f\"\"\"{{
    	"Version": "2008-10-17",
    	"Statement": [
    		{{
            			"Sid": "Put bucket policy needed for audit logging",
            			"Effect": "Allow",
            			"Principal": {{
    						"AWS": "{main.arn}"
            			}},
            			"Action": "s3:PutObject",
            			"Resource": "arn:aws:s3:::tf-redshift-logging-test-bucket/*"
            		}},
            		{{
            			"Sid": "Get bucket policy needed for audit logging ",
            			"Effect": "Allow",
            			"Principal": {{
    						"AWS": "{main.arn}"
            			}},
            			"Action": "s3:GetBucketAcl",
            			"Resource": "arn:aws:s3:::tf-redshift-logging-test-bucket"
            		}}
    	]
    }}

    \"\"\")
    ```


    :param str region: Name of the region whose AWS Redshift account ID is desired.
           Defaults to the region from the AWS provider configuration.
    """
    __args__ = dict()


    __args__['region'] = region
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = utilities.get_version()
    __ret__ = pulumi.runtime.invoke('aws:redshift/getServiceAccount:getServiceAccount', __args__, opts=opts).value

    return AwaitableGetServiceAccountResult(
        arn=__ret__.get('arn'),
        id=__ret__.get('id'),
        region=__ret__.get('region'))
