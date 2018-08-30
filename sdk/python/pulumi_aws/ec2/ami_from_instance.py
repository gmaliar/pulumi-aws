# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import pulumi
import pulumi.runtime
from .. import utilities

class AmiFromInstance(pulumi.CustomResource):
    """
    The "AMI from instance" resource allows the creation of an Amazon Machine
    Image (AMI) modelled after an existing EBS-backed EC2 instance.
    
    The created AMI will refer to implicitly-created snapshots of the instance's
    EBS volumes and mimick its assigned block device configuration at the time
    the resource is created.
    
    This resource is best applied to an instance that is stopped when this instance
    is created, so that the contents of the created image are predictable. When
    applied to an instance that is running, *the instance will be stopped before taking
    the snapshots and then started back up again*, resulting in a period of
    downtime.
    
    Note that the source instance is inspected only at the initial creation of this
    resource. Ongoing updates to the referenced instance will not be propagated into
    the generated AMI. Users may taint or otherwise recreate the resource in order
    to produce a fresh snapshot.
    """
    def __init__(__self__, __name__, __opts__=None, description=None, ebs_block_devices=None, ephemeral_block_devices=None, name=None, snapshot_without_reboot=None, source_instance_id=None, tags=None):
        """Create a AmiFromInstance resource with the given unique name, props, and options."""
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
        A longer, human-readable description for the AMI.
        """
        __props__['description'] = description

        if ebs_block_devices and not isinstance(ebs_block_devices, list):
            raise TypeError('Expected property ebs_block_devices to be a list')
        __self__.ebs_block_devices = ebs_block_devices
        """
        Nested block describing an EBS block device that should be
        attached to created instances. The structure of this block is described below.
        """
        __props__['ebsBlockDevices'] = ebs_block_devices

        if ephemeral_block_devices and not isinstance(ephemeral_block_devices, list):
            raise TypeError('Expected property ephemeral_block_devices to be a list')
        __self__.ephemeral_block_devices = ephemeral_block_devices
        """
        Nested block describing an ephemeral block device that
        should be attached to created instances. The structure of this block is described below.
        """
        __props__['ephemeralBlockDevices'] = ephemeral_block_devices

        if name and not isinstance(name, basestring):
            raise TypeError('Expected property name to be a basestring')
        __self__.name = name
        """
        A region-unique name for the AMI.
        """
        __props__['name'] = name

        if snapshot_without_reboot and not isinstance(snapshot_without_reboot, bool):
            raise TypeError('Expected property snapshot_without_reboot to be a bool')
        __self__.snapshot_without_reboot = snapshot_without_reboot
        """
        Boolean that overrides the behavior of stopping
        the instance before snapshotting. This is risky since it may cause a snapshot of an
        inconsistent filesystem state, but can be used to avoid downtime if the user otherwise
        guarantees that no filesystem writes will be underway at the time of snapshot.
        """
        __props__['snapshotWithoutReboot'] = snapshot_without_reboot

        if not source_instance_id:
            raise TypeError('Missing required property source_instance_id')
        elif not isinstance(source_instance_id, basestring):
            raise TypeError('Expected property source_instance_id to be a basestring')
        __self__.source_instance_id = source_instance_id
        """
        The id of the instance to use as the basis of the AMI.
        """
        __props__['sourceInstanceId'] = source_instance_id

        if tags and not isinstance(tags, dict):
            raise TypeError('Expected property tags to be a dict')
        __self__.tags = tags
        __props__['tags'] = tags

        __self__.architecture = pulumi.runtime.UNKNOWN
        """
        Machine architecture for created instances. Defaults to "x86_64".
        """
        __self__.ena_support = pulumi.runtime.UNKNOWN
        """
        Specifies whether enhanced networking with ENA is enabled. Defaults to `false`.
        """
        __self__.image_location = pulumi.runtime.UNKNOWN
        """
        Path to an S3 object containing an image manifest, e.g. created
        by the `ec2-upload-bundle` command in the EC2 command line tools.
        """
        __self__.kernel_id = pulumi.runtime.UNKNOWN
        """
        The id of the kernel image (AKI) that will be used as the paravirtual
        kernel in created instances.
        """
        __self__.manage_ebs_snapshots = pulumi.runtime.UNKNOWN
        __self__.ramdisk_id = pulumi.runtime.UNKNOWN
        """
        The id of an initrd image (ARI) that will be used when booting the
        created instances.
        """
        __self__.root_device_name = pulumi.runtime.UNKNOWN
        """
        The name of the root device (for example, `/dev/sda1`, or `/dev/xvda`).
        """
        __self__.root_snapshot_id = pulumi.runtime.UNKNOWN
        __self__.sriov_net_support = pulumi.runtime.UNKNOWN
        """
        When set to "simple" (the default), enables enhanced networking
        for created instances. No other value is supported at this time.
        """
        __self__.virtualization_type = pulumi.runtime.UNKNOWN
        """
        Keyword to choose what virtualization mode created instances
        will use. Can be either "paravirtual" (the default) or "hvm". The choice of virtualization type
        changes the set of further arguments that are required, as described below.
        """

        super(AmiFromInstance, __self__).__init__(
            'aws:ec2/amiFromInstance:AmiFromInstance',
            __name__,
            __props__,
            __opts__)

    def set_outputs(self, outs):
        if 'architecture' in outs:
            self.architecture = outs['architecture']
        if 'description' in outs:
            self.description = outs['description']
        if 'ebsBlockDevices' in outs:
            self.ebs_block_devices = outs['ebsBlockDevices']
        if 'enaSupport' in outs:
            self.ena_support = outs['enaSupport']
        if 'ephemeralBlockDevices' in outs:
            self.ephemeral_block_devices = outs['ephemeralBlockDevices']
        if 'imageLocation' in outs:
            self.image_location = outs['imageLocation']
        if 'kernelId' in outs:
            self.kernel_id = outs['kernelId']
        if 'manageEbsSnapshots' in outs:
            self.manage_ebs_snapshots = outs['manageEbsSnapshots']
        if 'name' in outs:
            self.name = outs['name']
        if 'ramdiskId' in outs:
            self.ramdisk_id = outs['ramdiskId']
        if 'rootDeviceName' in outs:
            self.root_device_name = outs['rootDeviceName']
        if 'rootSnapshotId' in outs:
            self.root_snapshot_id = outs['rootSnapshotId']
        if 'snapshotWithoutReboot' in outs:
            self.snapshot_without_reboot = outs['snapshotWithoutReboot']
        if 'sourceInstanceId' in outs:
            self.source_instance_id = outs['sourceInstanceId']
        if 'sriovNetSupport' in outs:
            self.sriov_net_support = outs['sriovNetSupport']
        if 'tags' in outs:
            self.tags = outs['tags']
        if 'virtualizationType' in outs:
            self.virtualization_type = outs['virtualizationType']
