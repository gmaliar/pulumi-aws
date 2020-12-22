# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union
from .. import _utilities, _tables

__all__ = [
    'EndpointNetworkInterface',
]

@pulumi.output_type
class EndpointNetworkInterface(dict):
    def __init__(__self__, *,
                 network_interface_id: Optional[str] = None):
        """
        :param str network_interface_id: Identifier of the Elastic Network Interface (ENI).
        """
        if network_interface_id is not None:
            pulumi.set(__self__, "network_interface_id", network_interface_id)

    @property
    @pulumi.getter(name="networkInterfaceId")
    def network_interface_id(self) -> Optional[str]:
        """
        Identifier of the Elastic Network Interface (ENI).
        """
        return pulumi.get(self, "network_interface_id")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


