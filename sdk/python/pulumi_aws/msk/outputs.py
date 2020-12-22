# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union
from .. import _utilities, _tables
from . import outputs

__all__ = [
    'ClusterBrokerNodeGroupInfo',
    'ClusterClientAuthentication',
    'ClusterClientAuthenticationSasl',
    'ClusterClientAuthenticationTls',
    'ClusterConfigurationInfo',
    'ClusterEncryptionInfo',
    'ClusterEncryptionInfoEncryptionInTransit',
    'ClusterLoggingInfo',
    'ClusterLoggingInfoBrokerLogs',
    'ClusterLoggingInfoBrokerLogsCloudwatchLogs',
    'ClusterLoggingInfoBrokerLogsFirehose',
    'ClusterLoggingInfoBrokerLogsS3',
    'ClusterOpenMonitoring',
    'ClusterOpenMonitoringPrometheus',
    'ClusterOpenMonitoringPrometheusJmxExporter',
    'ClusterOpenMonitoringPrometheusNodeExporter',
]

@pulumi.output_type
class ClusterBrokerNodeGroupInfo(dict):
    def __init__(__self__, *,
                 client_subnets: Sequence[str],
                 ebs_volume_size: int,
                 instance_type: str,
                 security_groups: Sequence[str],
                 az_distribution: Optional[str] = None):
        """
        :param Sequence[str] client_subnets: A list of subnets to connect to in client VPC ([documentation](https://docs.aws.amazon.com/msk/1.0/apireference/clusters.html#clusters-prop-brokernodegroupinfo-clientsubnets)).
        :param int ebs_volume_size: The size in GiB of the EBS volume for the data drive on each broker node.
        :param str instance_type: Specify the instance type to use for the kafka brokers. e.g. kafka.m5.large. ([Pricing info](https://aws.amazon.com/msk/pricing/))
        :param Sequence[str] security_groups: A list of the security groups to associate with the elastic network interfaces to control who can communicate with the cluster.
        :param str az_distribution: The distribution of broker nodes across availability zones ([documentation](https://docs.aws.amazon.com/msk/1.0/apireference/clusters.html#clusters-model-brokerazdistribution)). Currently the only valid value is `DEFAULT`.
        """
        pulumi.set(__self__, "client_subnets", client_subnets)
        pulumi.set(__self__, "ebs_volume_size", ebs_volume_size)
        pulumi.set(__self__, "instance_type", instance_type)
        pulumi.set(__self__, "security_groups", security_groups)
        if az_distribution is not None:
            pulumi.set(__self__, "az_distribution", az_distribution)

    @property
    @pulumi.getter(name="clientSubnets")
    def client_subnets(self) -> Sequence[str]:
        """
        A list of subnets to connect to in client VPC ([documentation](https://docs.aws.amazon.com/msk/1.0/apireference/clusters.html#clusters-prop-brokernodegroupinfo-clientsubnets)).
        """
        return pulumi.get(self, "client_subnets")

    @property
    @pulumi.getter(name="ebsVolumeSize")
    def ebs_volume_size(self) -> int:
        """
        The size in GiB of the EBS volume for the data drive on each broker node.
        """
        return pulumi.get(self, "ebs_volume_size")

    @property
    @pulumi.getter(name="instanceType")
    def instance_type(self) -> str:
        """
        Specify the instance type to use for the kafka brokers. e.g. kafka.m5.large. ([Pricing info](https://aws.amazon.com/msk/pricing/))
        """
        return pulumi.get(self, "instance_type")

    @property
    @pulumi.getter(name="securityGroups")
    def security_groups(self) -> Sequence[str]:
        """
        A list of the security groups to associate with the elastic network interfaces to control who can communicate with the cluster.
        """
        return pulumi.get(self, "security_groups")

    @property
    @pulumi.getter(name="azDistribution")
    def az_distribution(self) -> Optional[str]:
        """
        The distribution of broker nodes across availability zones ([documentation](https://docs.aws.amazon.com/msk/1.0/apireference/clusters.html#clusters-model-brokerazdistribution)). Currently the only valid value is `DEFAULT`.
        """
        return pulumi.get(self, "az_distribution")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class ClusterClientAuthentication(dict):
    def __init__(__self__, *,
                 sasl: Optional['outputs.ClusterClientAuthenticationSasl'] = None,
                 tls: Optional['outputs.ClusterClientAuthenticationTls'] = None):
        """
        :param 'ClusterClientAuthenticationSaslArgs' sasl: Configuration block for specifying SASL client authentication. See below.
        :param 'ClusterClientAuthenticationTlsArgs' tls: Configuration block for specifying TLS client authentication. See below.
        """
        if sasl is not None:
            pulumi.set(__self__, "sasl", sasl)
        if tls is not None:
            pulumi.set(__self__, "tls", tls)

    @property
    @pulumi.getter
    def sasl(self) -> Optional['outputs.ClusterClientAuthenticationSasl']:
        """
        Configuration block for specifying SASL client authentication. See below.
        """
        return pulumi.get(self, "sasl")

    @property
    @pulumi.getter
    def tls(self) -> Optional['outputs.ClusterClientAuthenticationTls']:
        """
        Configuration block for specifying TLS client authentication. See below.
        """
        return pulumi.get(self, "tls")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class ClusterClientAuthenticationSasl(dict):
    def __init__(__self__, *,
                 scram: Optional[bool] = None):
        """
        :param bool scram: Enables SCRAM client authentication via AWS Secrets Manager. Defaults to `false`.
        """
        if scram is not None:
            pulumi.set(__self__, "scram", scram)

    @property
    @pulumi.getter
    def scram(self) -> Optional[bool]:
        """
        Enables SCRAM client authentication via AWS Secrets Manager. Defaults to `false`.
        """
        return pulumi.get(self, "scram")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class ClusterClientAuthenticationTls(dict):
    def __init__(__self__, *,
                 certificate_authority_arns: Optional[Sequence[str]] = None):
        """
        :param Sequence[str] certificate_authority_arns: List of ACM Certificate Authority Amazon Resource Names (ARNs).
        """
        if certificate_authority_arns is not None:
            pulumi.set(__self__, "certificate_authority_arns", certificate_authority_arns)

    @property
    @pulumi.getter(name="certificateAuthorityArns")
    def certificate_authority_arns(self) -> Optional[Sequence[str]]:
        """
        List of ACM Certificate Authority Amazon Resource Names (ARNs).
        """
        return pulumi.get(self, "certificate_authority_arns")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class ClusterConfigurationInfo(dict):
    def __init__(__self__, *,
                 arn: str,
                 revision: int):
        """
        :param str arn: Amazon Resource Name (ARN) of the MSK Configuration to use in the cluster.
        :param int revision: Revision of the MSK Configuration to use in the cluster.
        """
        pulumi.set(__self__, "arn", arn)
        pulumi.set(__self__, "revision", revision)

    @property
    @pulumi.getter
    def arn(self) -> str:
        """
        Amazon Resource Name (ARN) of the MSK Configuration to use in the cluster.
        """
        return pulumi.get(self, "arn")

    @property
    @pulumi.getter
    def revision(self) -> int:
        """
        Revision of the MSK Configuration to use in the cluster.
        """
        return pulumi.get(self, "revision")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class ClusterEncryptionInfo(dict):
    def __init__(__self__, *,
                 encryption_at_rest_kms_key_arn: Optional[str] = None,
                 encryption_in_transit: Optional['outputs.ClusterEncryptionInfoEncryptionInTransit'] = None):
        """
        :param str encryption_at_rest_kms_key_arn: You may specify a KMS key short ID or ARN (it will always output an ARN) to use for encrypting your data at rest.  If no key is specified, an AWS managed KMS ('aws/msk' managed service) key will be used for encrypting the data at rest.
        :param 'ClusterEncryptionInfoEncryptionInTransitArgs' encryption_in_transit: Configuration block to specify encryption in transit. See below.
        """
        if encryption_at_rest_kms_key_arn is not None:
            pulumi.set(__self__, "encryption_at_rest_kms_key_arn", encryption_at_rest_kms_key_arn)
        if encryption_in_transit is not None:
            pulumi.set(__self__, "encryption_in_transit", encryption_in_transit)

    @property
    @pulumi.getter(name="encryptionAtRestKmsKeyArn")
    def encryption_at_rest_kms_key_arn(self) -> Optional[str]:
        """
        You may specify a KMS key short ID or ARN (it will always output an ARN) to use for encrypting your data at rest.  If no key is specified, an AWS managed KMS ('aws/msk' managed service) key will be used for encrypting the data at rest.
        """
        return pulumi.get(self, "encryption_at_rest_kms_key_arn")

    @property
    @pulumi.getter(name="encryptionInTransit")
    def encryption_in_transit(self) -> Optional['outputs.ClusterEncryptionInfoEncryptionInTransit']:
        """
        Configuration block to specify encryption in transit. See below.
        """
        return pulumi.get(self, "encryption_in_transit")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class ClusterEncryptionInfoEncryptionInTransit(dict):
    def __init__(__self__, *,
                 client_broker: Optional[str] = None,
                 in_cluster: Optional[bool] = None):
        """
        :param str client_broker: Encryption setting for data in transit between clients and brokers. Valid values: `TLS`, `TLS_PLAINTEXT`, and `PLAINTEXT`. Default value is `TLS`.
        :param bool in_cluster: Whether data communication among broker nodes is encrypted. Default value: `true`.
        """
        if client_broker is not None:
            pulumi.set(__self__, "client_broker", client_broker)
        if in_cluster is not None:
            pulumi.set(__self__, "in_cluster", in_cluster)

    @property
    @pulumi.getter(name="clientBroker")
    def client_broker(self) -> Optional[str]:
        """
        Encryption setting for data in transit between clients and brokers. Valid values: `TLS`, `TLS_PLAINTEXT`, and `PLAINTEXT`. Default value is `TLS`.
        """
        return pulumi.get(self, "client_broker")

    @property
    @pulumi.getter(name="inCluster")
    def in_cluster(self) -> Optional[bool]:
        """
        Whether data communication among broker nodes is encrypted. Default value: `true`.
        """
        return pulumi.get(self, "in_cluster")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class ClusterLoggingInfo(dict):
    def __init__(__self__, *,
                 broker_logs: 'outputs.ClusterLoggingInfoBrokerLogs'):
        """
        :param 'ClusterLoggingInfoBrokerLogsArgs' broker_logs: Configuration block for Broker Logs settings for logging info. See below.
        """
        pulumi.set(__self__, "broker_logs", broker_logs)

    @property
    @pulumi.getter(name="brokerLogs")
    def broker_logs(self) -> 'outputs.ClusterLoggingInfoBrokerLogs':
        """
        Configuration block for Broker Logs settings for logging info. See below.
        """
        return pulumi.get(self, "broker_logs")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class ClusterLoggingInfoBrokerLogs(dict):
    def __init__(__self__, *,
                 cloudwatch_logs: Optional['outputs.ClusterLoggingInfoBrokerLogsCloudwatchLogs'] = None,
                 firehose: Optional['outputs.ClusterLoggingInfoBrokerLogsFirehose'] = None,
                 s3: Optional['outputs.ClusterLoggingInfoBrokerLogsS3'] = None):
        if cloudwatch_logs is not None:
            pulumi.set(__self__, "cloudwatch_logs", cloudwatch_logs)
        if firehose is not None:
            pulumi.set(__self__, "firehose", firehose)
        if s3 is not None:
            pulumi.set(__self__, "s3", s3)

    @property
    @pulumi.getter(name="cloudwatchLogs")
    def cloudwatch_logs(self) -> Optional['outputs.ClusterLoggingInfoBrokerLogsCloudwatchLogs']:
        return pulumi.get(self, "cloudwatch_logs")

    @property
    @pulumi.getter
    def firehose(self) -> Optional['outputs.ClusterLoggingInfoBrokerLogsFirehose']:
        return pulumi.get(self, "firehose")

    @property
    @pulumi.getter
    def s3(self) -> Optional['outputs.ClusterLoggingInfoBrokerLogsS3']:
        return pulumi.get(self, "s3")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class ClusterLoggingInfoBrokerLogsCloudwatchLogs(dict):
    def __init__(__self__, *,
                 enabled: bool,
                 log_group: Optional[str] = None):
        """
        :param bool enabled: Indicates whether you want to enable or disable streaming broker logs to Cloudwatch Logs.
        :param str log_group: Name of the Cloudwatch Log Group to deliver logs to.
        """
        pulumi.set(__self__, "enabled", enabled)
        if log_group is not None:
            pulumi.set(__self__, "log_group", log_group)

    @property
    @pulumi.getter
    def enabled(self) -> bool:
        """
        Indicates whether you want to enable or disable streaming broker logs to Cloudwatch Logs.
        """
        return pulumi.get(self, "enabled")

    @property
    @pulumi.getter(name="logGroup")
    def log_group(self) -> Optional[str]:
        """
        Name of the Cloudwatch Log Group to deliver logs to.
        """
        return pulumi.get(self, "log_group")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class ClusterLoggingInfoBrokerLogsFirehose(dict):
    def __init__(__self__, *,
                 enabled: bool,
                 delivery_stream: Optional[str] = None):
        """
        :param bool enabled: Indicates whether you want to enable or disable streaming broker logs to Cloudwatch Logs.
        :param str delivery_stream: Name of the Kinesis Data Firehose delivery stream to deliver logs to.
        """
        pulumi.set(__self__, "enabled", enabled)
        if delivery_stream is not None:
            pulumi.set(__self__, "delivery_stream", delivery_stream)

    @property
    @pulumi.getter
    def enabled(self) -> bool:
        """
        Indicates whether you want to enable or disable streaming broker logs to Cloudwatch Logs.
        """
        return pulumi.get(self, "enabled")

    @property
    @pulumi.getter(name="deliveryStream")
    def delivery_stream(self) -> Optional[str]:
        """
        Name of the Kinesis Data Firehose delivery stream to deliver logs to.
        """
        return pulumi.get(self, "delivery_stream")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class ClusterLoggingInfoBrokerLogsS3(dict):
    def __init__(__self__, *,
                 enabled: bool,
                 bucket: Optional[str] = None,
                 prefix: Optional[str] = None):
        """
        :param bool enabled: Indicates whether you want to enable or disable streaming broker logs to Cloudwatch Logs.
        :param str bucket: Name of the S3 bucket to deliver logs to.
        :param str prefix: Prefix to append to the folder name.
        """
        pulumi.set(__self__, "enabled", enabled)
        if bucket is not None:
            pulumi.set(__self__, "bucket", bucket)
        if prefix is not None:
            pulumi.set(__self__, "prefix", prefix)

    @property
    @pulumi.getter
    def enabled(self) -> bool:
        """
        Indicates whether you want to enable or disable streaming broker logs to Cloudwatch Logs.
        """
        return pulumi.get(self, "enabled")

    @property
    @pulumi.getter
    def bucket(self) -> Optional[str]:
        """
        Name of the S3 bucket to deliver logs to.
        """
        return pulumi.get(self, "bucket")

    @property
    @pulumi.getter
    def prefix(self) -> Optional[str]:
        """
        Prefix to append to the folder name.
        """
        return pulumi.get(self, "prefix")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class ClusterOpenMonitoring(dict):
    def __init__(__self__, *,
                 prometheus: 'outputs.ClusterOpenMonitoringPrometheus'):
        """
        :param 'ClusterOpenMonitoringPrometheusArgs' prometheus: Configuration block for Prometheus settings for open monitoring. See below.
        """
        pulumi.set(__self__, "prometheus", prometheus)

    @property
    @pulumi.getter
    def prometheus(self) -> 'outputs.ClusterOpenMonitoringPrometheus':
        """
        Configuration block for Prometheus settings for open monitoring. See below.
        """
        return pulumi.get(self, "prometheus")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class ClusterOpenMonitoringPrometheus(dict):
    def __init__(__self__, *,
                 jmx_exporter: Optional['outputs.ClusterOpenMonitoringPrometheusJmxExporter'] = None,
                 node_exporter: Optional['outputs.ClusterOpenMonitoringPrometheusNodeExporter'] = None):
        """
        :param 'ClusterOpenMonitoringPrometheusJmxExporterArgs' jmx_exporter: Configuration block for JMX Exporter. See below.
        :param 'ClusterOpenMonitoringPrometheusNodeExporterArgs' node_exporter: Configuration block for Node Exporter. See below.
        """
        if jmx_exporter is not None:
            pulumi.set(__self__, "jmx_exporter", jmx_exporter)
        if node_exporter is not None:
            pulumi.set(__self__, "node_exporter", node_exporter)

    @property
    @pulumi.getter(name="jmxExporter")
    def jmx_exporter(self) -> Optional['outputs.ClusterOpenMonitoringPrometheusJmxExporter']:
        """
        Configuration block for JMX Exporter. See below.
        """
        return pulumi.get(self, "jmx_exporter")

    @property
    @pulumi.getter(name="nodeExporter")
    def node_exporter(self) -> Optional['outputs.ClusterOpenMonitoringPrometheusNodeExporter']:
        """
        Configuration block for Node Exporter. See below.
        """
        return pulumi.get(self, "node_exporter")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class ClusterOpenMonitoringPrometheusJmxExporter(dict):
    def __init__(__self__, *,
                 enabled_in_broker: bool):
        """
        :param bool enabled_in_broker: Indicates whether you want to enable or disable the JMX Exporter.
        """
        pulumi.set(__self__, "enabled_in_broker", enabled_in_broker)

    @property
    @pulumi.getter(name="enabledInBroker")
    def enabled_in_broker(self) -> bool:
        """
        Indicates whether you want to enable or disable the JMX Exporter.
        """
        return pulumi.get(self, "enabled_in_broker")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class ClusterOpenMonitoringPrometheusNodeExporter(dict):
    def __init__(__self__, *,
                 enabled_in_broker: bool):
        """
        :param bool enabled_in_broker: Indicates whether you want to enable or disable the JMX Exporter.
        """
        pulumi.set(__self__, "enabled_in_broker", enabled_in_broker)

    @property
    @pulumi.getter(name="enabledInBroker")
    def enabled_in_broker(self) -> bool:
        """
        Indicates whether you want to enable or disable the JMX Exporter.
        """
        return pulumi.get(self, "enabled_in_broker")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


