# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import pulumi
import pulumi.runtime
from .. import utilities

class Cluster(pulumi.CustomResource):
    """
    Provides an Neptune Cluster Resource. A Cluster Resource defines attributes that are
    applied to the entire cluster of Neptune Cluster Instances.
    
    Changes to a Neptune Cluster can occur when you manually change a
    parameter, such as `backup_retention_period`, and are reflected in the next maintenance
    window. Because of this, Terraform may report a difference in its planning
    phase because a modification has not yet taken place. You can use the
    `apply_immediately` flag to instruct the service to apply the change immediately
    (see documentation below).
    """
    def __init__(__self__, __name__, __opts__=None, apply_immediately=None, availability_zones=None, backup_retention_period=None, cluster_identifier=None, cluster_identifier_prefix=None, engine=None, engine_version=None, final_snapshot_identifier=None, iam_database_authentication_enabled=None, iam_roles=None, kms_key_arn=None, neptune_cluster_parameter_group_name=None, neptune_subnet_group_name=None, port=None, preferred_backup_window=None, preferred_maintenance_window=None, replication_source_identifier=None, skip_final_snapshot=None, snapshot_identifier=None, storage_encrypted=None, tags=None, vpc_security_group_ids=None):
        """Create a Cluster resource with the given unique name, props, and options."""
        if not __name__:
            raise TypeError('Missing resource name argument (for URN creation)')
        if not isinstance(__name__, basestring):
            raise TypeError('Expected resource name to be a string')
        if __opts__ and not isinstance(__opts__, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')

        __props__ = dict()

        if apply_immediately and not isinstance(apply_immediately, bool):
            raise TypeError('Expected property apply_immediately to be a bool')
        __self__.apply_immediately = apply_immediately
        """
        Specifies whether any cluster modifications are applied immediately, or during the next maintenance window. Default is `false`.
        """
        __props__['applyImmediately'] = apply_immediately

        if availability_zones and not isinstance(availability_zones, list):
            raise TypeError('Expected property availability_zones to be a list')
        __self__.availability_zones = availability_zones
        """
        A list of EC2 Availability Zones that instances in the Neptune cluster can be created in.
        """
        __props__['availabilityZones'] = availability_zones

        if backup_retention_period and not isinstance(backup_retention_period, int):
            raise TypeError('Expected property backup_retention_period to be a int')
        __self__.backup_retention_period = backup_retention_period
        """
        The days to retain backups for. Default `1`
        """
        __props__['backupRetentionPeriod'] = backup_retention_period

        if cluster_identifier and not isinstance(cluster_identifier, basestring):
            raise TypeError('Expected property cluster_identifier to be a basestring')
        __self__.cluster_identifier = cluster_identifier
        """
        The cluster identifier. If omitted, Terraform will assign a random, unique identifier.
        """
        __props__['clusterIdentifier'] = cluster_identifier

        if cluster_identifier_prefix and not isinstance(cluster_identifier_prefix, basestring):
            raise TypeError('Expected property cluster_identifier_prefix to be a basestring')
        __self__.cluster_identifier_prefix = cluster_identifier_prefix
        """
        Creates a unique cluster identifier beginning with the specified prefix. Conflicts with `cluster_identifer`.
        """
        __props__['clusterIdentifierPrefix'] = cluster_identifier_prefix

        if engine and not isinstance(engine, basestring):
            raise TypeError('Expected property engine to be a basestring')
        __self__.engine = engine
        """
        The name of the database engine to be used for this Neptune cluster. Defaults to `neptune`.
        """
        __props__['engine'] = engine

        if engine_version and not isinstance(engine_version, basestring):
            raise TypeError('Expected property engine_version to be a basestring')
        __self__.engine_version = engine_version
        """
        The database engine version.
        """
        __props__['engineVersion'] = engine_version

        if final_snapshot_identifier and not isinstance(final_snapshot_identifier, basestring):
            raise TypeError('Expected property final_snapshot_identifier to be a basestring')
        __self__.final_snapshot_identifier = final_snapshot_identifier
        """
        The name of your final Neptune snapshot when this Neptune cluster is deleted. If omitted, no final snapshot will be made.
        """
        __props__['finalSnapshotIdentifier'] = final_snapshot_identifier

        if iam_database_authentication_enabled and not isinstance(iam_database_authentication_enabled, bool):
            raise TypeError('Expected property iam_database_authentication_enabled to be a bool')
        __self__.iam_database_authentication_enabled = iam_database_authentication_enabled
        """
        Specifies whether or mappings of AWS Identity and Access Management (IAM) accounts to database accounts is enabled.
        """
        __props__['iamDatabaseAuthenticationEnabled'] = iam_database_authentication_enabled

        if iam_roles and not isinstance(iam_roles, list):
            raise TypeError('Expected property iam_roles to be a list')
        __self__.iam_roles = iam_roles
        """
        A List of ARNs for the IAM roles to associate to the Neptune Cluster.
        """
        __props__['iamRoles'] = iam_roles

        if kms_key_arn and not isinstance(kms_key_arn, basestring):
            raise TypeError('Expected property kms_key_arn to be a basestring')
        __self__.kms_key_arn = kms_key_arn
        """
        The ARN for the KMS encryption key. When specifying `kms_key_arn`, `storage_encrypted` needs to be set to true.
        """
        __props__['kmsKeyArn'] = kms_key_arn

        if neptune_cluster_parameter_group_name and not isinstance(neptune_cluster_parameter_group_name, basestring):
            raise TypeError('Expected property neptune_cluster_parameter_group_name to be a basestring')
        __self__.neptune_cluster_parameter_group_name = neptune_cluster_parameter_group_name
        """
        A cluster parameter group to associate with the cluster.
        """
        __props__['neptuneClusterParameterGroupName'] = neptune_cluster_parameter_group_name

        if neptune_subnet_group_name and not isinstance(neptune_subnet_group_name, basestring):
            raise TypeError('Expected property neptune_subnet_group_name to be a basestring')
        __self__.neptune_subnet_group_name = neptune_subnet_group_name
        """
        A Neptune subnet group to associate with this Neptune instance.
        """
        __props__['neptuneSubnetGroupName'] = neptune_subnet_group_name

        if port and not isinstance(port, int):
            raise TypeError('Expected property port to be a int')
        __self__.port = port
        """
        The port on which the Neptune accepts connections. Default is `8182`.
        """
        __props__['port'] = port

        if preferred_backup_window and not isinstance(preferred_backup_window, basestring):
            raise TypeError('Expected property preferred_backup_window to be a basestring')
        __self__.preferred_backup_window = preferred_backup_window
        """
        The daily time range during which automated backups are created if automated backups are enabled using the BackupRetentionPeriod parameter. Time in UTC. Default: A 30-minute window selected at random from an 8-hour block of time per region. e.g. 04:00-09:00
        """
        __props__['preferredBackupWindow'] = preferred_backup_window

        if preferred_maintenance_window and not isinstance(preferred_maintenance_window, basestring):
            raise TypeError('Expected property preferred_maintenance_window to be a basestring')
        __self__.preferred_maintenance_window = preferred_maintenance_window
        """
        The weekly time range during which system maintenance can occur, in (UTC) e.g. wed:04:00-wed:04:30
        """
        __props__['preferredMaintenanceWindow'] = preferred_maintenance_window

        if replication_source_identifier and not isinstance(replication_source_identifier, basestring):
            raise TypeError('Expected property replication_source_identifier to be a basestring')
        __self__.replication_source_identifier = replication_source_identifier
        """
        ARN of a source Neptune cluster or Neptune instance if this Neptune cluster is to be created as a Read Replica.
        """
        __props__['replicationSourceIdentifier'] = replication_source_identifier

        if skip_final_snapshot and not isinstance(skip_final_snapshot, bool):
            raise TypeError('Expected property skip_final_snapshot to be a bool')
        __self__.skip_final_snapshot = skip_final_snapshot
        """
        Determines whether a final Neptune snapshot is created before the Neptune cluster is deleted. If true is specified, no Neptune snapshot is created. If false is specified, a Neptune snapshot is created before the Neptune cluster is deleted, using the value from `final_snapshot_identifier`. Default is `false`.
        """
        __props__['skipFinalSnapshot'] = skip_final_snapshot

        if snapshot_identifier and not isinstance(snapshot_identifier, basestring):
            raise TypeError('Expected property snapshot_identifier to be a basestring')
        __self__.snapshot_identifier = snapshot_identifier
        """
        Specifies whether or not to create this cluster from a snapshot. You can use either the name or ARN when specifying a Neptune cluster snapshot, or the ARN when specifying a Neptune snapshot.
        """
        __props__['snapshotIdentifier'] = snapshot_identifier

        if storage_encrypted and not isinstance(storage_encrypted, bool):
            raise TypeError('Expected property storage_encrypted to be a bool')
        __self__.storage_encrypted = storage_encrypted
        """
        Specifies whether the Neptune cluster is encrypted. The default is `false` if not specified.
        """
        __props__['storageEncrypted'] = storage_encrypted

        if tags and not isinstance(tags, dict):
            raise TypeError('Expected property tags to be a dict')
        __self__.tags = tags
        """
        A mapping of tags to assign to the Neptune cluster.
        """
        __props__['tags'] = tags

        if vpc_security_group_ids and not isinstance(vpc_security_group_ids, list):
            raise TypeError('Expected property vpc_security_group_ids to be a list')
        __self__.vpc_security_group_ids = vpc_security_group_ids
        """
        List of VPC security groups to associate with the Cluster
        """
        __props__['vpcSecurityGroupIds'] = vpc_security_group_ids

        __self__.arn = pulumi.runtime.UNKNOWN
        """
        The Neptune Cluster Amazon Resource Name (ARN)
        """
        __self__.cluster_members = pulumi.runtime.UNKNOWN
        """
        List of Neptune Instances that are a part of this cluster
        """
        __self__.cluster_resource_id = pulumi.runtime.UNKNOWN
        """
        The Neptune Cluster Resource ID
        """
        __self__.endpoint = pulumi.runtime.UNKNOWN
        """
        The DNS address of the Neptune instance
        """
        __self__.hosted_zone_id = pulumi.runtime.UNKNOWN
        """
        The Route53 Hosted Zone ID of the endpoint
        """
        __self__.reader_endpoint = pulumi.runtime.UNKNOWN
        """
        A read-only endpoint for the Neptune cluster, automatically load-balanced across replicas
        """

        super(Cluster, __self__).__init__(
            'aws:neptune/cluster:Cluster',
            __name__,
            __props__,
            __opts__)

    def set_outputs(self, outs):
        if 'applyImmediately' in outs:
            self.apply_immediately = outs['applyImmediately']
        if 'arn' in outs:
            self.arn = outs['arn']
        if 'availabilityZones' in outs:
            self.availability_zones = outs['availabilityZones']
        if 'backupRetentionPeriod' in outs:
            self.backup_retention_period = outs['backupRetentionPeriod']
        if 'clusterIdentifier' in outs:
            self.cluster_identifier = outs['clusterIdentifier']
        if 'clusterIdentifierPrefix' in outs:
            self.cluster_identifier_prefix = outs['clusterIdentifierPrefix']
        if 'clusterMembers' in outs:
            self.cluster_members = outs['clusterMembers']
        if 'clusterResourceId' in outs:
            self.cluster_resource_id = outs['clusterResourceId']
        if 'endpoint' in outs:
            self.endpoint = outs['endpoint']
        if 'engine' in outs:
            self.engine = outs['engine']
        if 'engineVersion' in outs:
            self.engine_version = outs['engineVersion']
        if 'finalSnapshotIdentifier' in outs:
            self.final_snapshot_identifier = outs['finalSnapshotIdentifier']
        if 'hostedZoneId' in outs:
            self.hosted_zone_id = outs['hostedZoneId']
        if 'iamDatabaseAuthenticationEnabled' in outs:
            self.iam_database_authentication_enabled = outs['iamDatabaseAuthenticationEnabled']
        if 'iamRoles' in outs:
            self.iam_roles = outs['iamRoles']
        if 'kmsKeyArn' in outs:
            self.kms_key_arn = outs['kmsKeyArn']
        if 'neptuneClusterParameterGroupName' in outs:
            self.neptune_cluster_parameter_group_name = outs['neptuneClusterParameterGroupName']
        if 'neptuneSubnetGroupName' in outs:
            self.neptune_subnet_group_name = outs['neptuneSubnetGroupName']
        if 'port' in outs:
            self.port = outs['port']
        if 'preferredBackupWindow' in outs:
            self.preferred_backup_window = outs['preferredBackupWindow']
        if 'preferredMaintenanceWindow' in outs:
            self.preferred_maintenance_window = outs['preferredMaintenanceWindow']
        if 'readerEndpoint' in outs:
            self.reader_endpoint = outs['readerEndpoint']
        if 'replicationSourceIdentifier' in outs:
            self.replication_source_identifier = outs['replicationSourceIdentifier']
        if 'skipFinalSnapshot' in outs:
            self.skip_final_snapshot = outs['skipFinalSnapshot']
        if 'snapshotIdentifier' in outs:
            self.snapshot_identifier = outs['snapshotIdentifier']
        if 'storageEncrypted' in outs:
            self.storage_encrypted = outs['storageEncrypted']
        if 'tags' in outs:
            self.tags = outs['tags']
        if 'vpcSecurityGroupIds' in outs:
            self.vpc_security_group_ids = outs['vpcSecurityGroupIds']
