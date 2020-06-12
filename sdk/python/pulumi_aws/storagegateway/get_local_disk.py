# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import json
import warnings
import pulumi
import pulumi.runtime
from typing import Union
from .. import utilities, tables

class GetLocalDiskResult:
    """
    A collection of values returned by getLocalDisk.
    """
    def __init__(__self__, disk_id=None, disk_node=None, disk_path=None, gateway_arn=None, id=None):
        if disk_id and not isinstance(disk_id, str):
            raise TypeError("Expected argument 'disk_id' to be a str")
        __self__.disk_id = disk_id
        """
        The disk identifier. e.g. `pci-0000:03:00.0-scsi-0:0:0:0`
        """
        if disk_node and not isinstance(disk_node, str):
            raise TypeError("Expected argument 'disk_node' to be a str")
        __self__.disk_node = disk_node
        if disk_path and not isinstance(disk_path, str):
            raise TypeError("Expected argument 'disk_path' to be a str")
        __self__.disk_path = disk_path
        if gateway_arn and not isinstance(gateway_arn, str):
            raise TypeError("Expected argument 'gateway_arn' to be a str")
        __self__.gateway_arn = gateway_arn
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        __self__.id = id
        """
        The provider-assigned unique ID for this managed resource.
        """
class AwaitableGetLocalDiskResult(GetLocalDiskResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetLocalDiskResult(
            disk_id=self.disk_id,
            disk_node=self.disk_node,
            disk_path=self.disk_path,
            gateway_arn=self.gateway_arn,
            id=self.id)

def get_local_disk(disk_node=None,disk_path=None,gateway_arn=None,opts=None):
    """
    Retrieve information about a Storage Gateway local disk. The disk identifier is useful for adding the disk as a cache or upload buffer to a gateway.

    ## Example Usage



    ```python
    import pulumi
    import pulumi_aws as aws

    test = aws.storagegateway.get_local_disk(disk_path=aws_volume_attachment["test"]["device_name"],
        gateway_arn=aws_storagegateway_gateway["test"]["arn"])
    ```


    :param str disk_node: The device node of the local disk to retrieve. For example, `/dev/sdb`.
    :param str disk_path: The device path of the local disk to retrieve. For example, `/dev/xvdb` or `/dev/nvme1n1`.
    :param str gateway_arn: The Amazon Resource Name (ARN) of the gateway.
    """
    __args__ = dict()


    __args__['diskNode'] = disk_node
    __args__['diskPath'] = disk_path
    __args__['gatewayArn'] = gateway_arn
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = utilities.get_version()
    __ret__ = pulumi.runtime.invoke('aws:storagegateway/getLocalDisk:getLocalDisk', __args__, opts=opts).value

    return AwaitableGetLocalDiskResult(
        disk_id=__ret__.get('diskId'),
        disk_node=__ret__.get('diskNode'),
        disk_path=__ret__.get('diskPath'),
        gateway_arn=__ret__.get('gatewayArn'),
        id=__ret__.get('id'))
