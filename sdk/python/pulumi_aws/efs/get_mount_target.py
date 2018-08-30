# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import pulumi
import pulumi.runtime
from .. import utilities

class GetMountTargetResult(object):
    """
    A collection of values returned by getMountTarget.
    """
    def __init__(__self__, dns_name=None, file_system_id=None, ip_address=None, network_interface_id=None, security_groups=None, subnet_id=None, id=None):
        if dns_name and not isinstance(dns_name, basestring):
            raise TypeError('Expected argument dns_name to be a basestring')
        __self__.dns_name = dns_name
        """
        The DNS name for the given subnet/AZ per [documented convention](http://docs.aws.amazon.com/efs/latest/ug/mounting-fs-mount-cmd-dns-name.html).
        """
        if file_system_id and not isinstance(file_system_id, basestring):
            raise TypeError('Expected argument file_system_id to be a basestring')
        __self__.file_system_id = file_system_id
        """
        ID of the file system for which the mount target is intended.
        """
        if ip_address and not isinstance(ip_address, basestring):
            raise TypeError('Expected argument ip_address to be a basestring')
        __self__.ip_address = ip_address
        """
        Address at which the file system may be mounted via the mount target.
        """
        if network_interface_id and not isinstance(network_interface_id, basestring):
            raise TypeError('Expected argument network_interface_id to be a basestring')
        __self__.network_interface_id = network_interface_id
        """
        The ID of the network interface that Amazon EFS created when it created the mount target.
        """
        if security_groups and not isinstance(security_groups, list):
            raise TypeError('Expected argument security_groups to be a list')
        __self__.security_groups = security_groups
        """
        List of VPC security group IDs attached to the mount target.
        """
        if subnet_id and not isinstance(subnet_id, basestring):
            raise TypeError('Expected argument subnet_id to be a basestring')
        __self__.subnet_id = subnet_id
        """
        ID of the mount target's subnet.
        """
        if id and not isinstance(id, basestring):
            raise TypeError('Expected argument id to be a basestring')
        __self__.id = id
        """
        id is the provider-assigned unique ID for this managed resource.
        """

def get_mount_target(mount_target_id=None):
    """
    Provides information about an Elastic File System Mount Target (EFS).
    """
    __args__ = dict()

    __args__['mountTargetId'] = mount_target_id
    __ret__ = pulumi.runtime.invoke('aws:efs/getMountTarget:getMountTarget', __args__)

    return GetMountTargetResult(
        dns_name=__ret__.get('dnsName'),
        file_system_id=__ret__.get('fileSystemId'),
        ip_address=__ret__.get('ipAddress'),
        network_interface_id=__ret__.get('networkInterfaceId'),
        security_groups=__ret__.get('securityGroups'),
        subnet_id=__ret__.get('subnetId'),
        id=__ret__.get('id'))
