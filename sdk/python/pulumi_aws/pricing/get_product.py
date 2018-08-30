# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import pulumi
import pulumi.runtime
from .. import utilities

class GetProductResult(object):
    """
    A collection of values returned by getProduct.
    """
    def __init__(__self__, result=None, id=None):
        if result and not isinstance(result, basestring):
            raise TypeError('Expected argument result to be a basestring')
        __self__.result = result
        """
        Set to the product returned from the API.
        """
        if id and not isinstance(id, basestring):
            raise TypeError('Expected argument id to be a basestring')
        __self__.id = id
        """
        id is the provider-assigned unique ID for this managed resource.
        """

def get_product(filters=None, service_code=None):
    """
    Use this data source to get the pricing information of all products in AWS.
    This data source is only available in a us-east-1 or ap-south-1 provider.
    """
    __args__ = dict()

    __args__['filters'] = filters
    __args__['serviceCode'] = service_code
    __ret__ = pulumi.runtime.invoke('aws:pricing/getProduct:getProduct', __args__)

    return GetProductResult(
        result=__ret__.get('result'),
        id=__ret__.get('id'))
