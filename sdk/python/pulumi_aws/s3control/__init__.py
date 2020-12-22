# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

# Export this package's modules as members:
from .bucket import *
from .bucket_lifecycle_configuration import *
from .bucket_policy import *
from ._inputs import *
from . import outputs

def _register_module():
    import pulumi
    from .. import _utilities


    class Module(pulumi.runtime.ResourceModule):
        _version = _utilities.get_semver_version()

        def version(self):
            return Module._version

        def construct(self, name: str, typ: str, urn: str) -> pulumi.Resource:
            if typ == "aws:s3control/bucket:Bucket":
                return Bucket(name, pulumi.ResourceOptions(urn=urn))
            elif typ == "aws:s3control/bucketLifecycleConfiguration:BucketLifecycleConfiguration":
                return BucketLifecycleConfiguration(name, pulumi.ResourceOptions(urn=urn))
            elif typ == "aws:s3control/bucketPolicy:BucketPolicy":
                return BucketPolicy(name, pulumi.ResourceOptions(urn=urn))
            else:
                raise Exception(f"unknown resource type {typ}")


    _module_instance = Module()
    pulumi.runtime.register_resource_module("aws", "s3control/bucket", _module_instance)
    pulumi.runtime.register_resource_module("aws", "s3control/bucketLifecycleConfiguration", _module_instance)
    pulumi.runtime.register_resource_module("aws", "s3control/bucketPolicy", _module_instance)

_register_module()