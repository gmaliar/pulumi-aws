# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

from enum import Enum

__all__ = [
    'EngineMode',
    'EngineType',
    'InstanceType',
    'StorageType',
]


class EngineMode(str, Enum):
    PROVISIONED = "provisioned"
    SERVERLESS = "serverless"
    PARALLEL_QUERY = "parallelquery"
    GLOBAL_ = "global"


class EngineType(str, Enum):
    AURORA = "aurora"
    AURORA_MYSQL = "aurora-mysql"
    AURORA_POSTGRESQL = "aurora-postgresql"


class InstanceType(str, Enum):
    T3_MICRO = "db.t3.micro"
    T3_SMALL = "db.t3.small"
    T3_MEDIUM = "db.t3.medium"
    T3_LARGE = "db.t3.large"
    T3_X_LARGE = "db.t3.xlarge"
    T3_2_X_LARGE = "db.t3.2xlarge"
    T2_MICRO = "db.t2.micro"
    T2_SMALL = "db.t2.small"
    T2_MEDIUM = "db.t2.medium"
    T2_LARGE = "db.t2.large"
    T2_X_LARGE = "db.t2.xlarge"
    T2_2_X_LARGE = "db.t2.2xlarge"
    M1_SMALL = "db.m1.small"
    M1_MEDIUM = "db.m1.medium"
    M1_LARGE = "db.m1.large"
    M1_X_LARGE = "db.m1.xlarge"
    M2_X_LARGE = "db.m2.xlarge"
    M2_2_X_LARGE = "db.m2.2xlarge"
    M2_4_X_LARGE = "db.m2.4xlarge"
    M3_MEDIUM = "db.m3.medium"
    M3_LARGE = "db.m3.large"
    M3_X_LARGE = "db.m3.xlarge"
    M3_2_X_LARGE = "db.m3.2xlarge"
    M4_LARGE = "db.m4.large"
    M4_X_LARGE = "db.m4.xlarge"
    M4_2_X_LARGE = "db.m4.2xlarge"
    M4_4_X_LARGE = "db.m4.4xlarge"
    M4_10_X_LARGE = "db.m4.10xlarge"
    M4_16_X_LARGE = "db.m4.10xlarge"
    M5_LARGE = "db.m5.large"
    M5_X_LARGE = "db.m5.xlarge"
    M5_2_X_LARGE = "db.m5.2xlarge"
    M5_4_X_LARGE = "db.m5.4xlarge"
    M5_12_X_LARGE = "db.m5.12xlarge"
    M5_24_X_LARGE = "db.m5.24xlarge"
    R3_LARGE = "db.r3.large"
    R3_X_LARGE = "db.r3.xlarge"
    R3_2_X_LARGE = "db.r3.2xlarge"
    R3_4_X_LARGE = "db.r3.4xlarge"
    R3_8_X_LARGE = "db.r3.8xlarge"
    R4_LARGE = "db.r4.large"
    R4_X_LARGE = "db.r4.xlarge"
    R4_2_X_LARGE = "db.r4.2xlarge"
    R4_4_X_LARGE = "db.r4.4xlarge"
    R4_8_X_LARGE = "db.r4.8xlarge"
    R4_16_X_LARGE = "db.r4.16xlarge"
    R5_LARGE = "db.r5.large"
    R5_X_LARGE = "db.r5.xlarge"
    R5_2_X_LARGE = "db.r5.2xlarge"
    R5_4_X_LARGE = "db.r5.4xlarge"
    R5_12_X_LARGE = "db.r5.12xlarge"
    R5_24_X_LARGE = "db.r5.24xlarge"
    X1_16_X_LARGE = "db.x1.16xlarge"
    X1_32_X_LARGE = "db.x1.32xlarge"
    X1_E_X_LARGE = "db.x1e.xlarge"
    X1_E_2_X_LARGE = "db.x1e.2xlarge"
    X1_E_4_X_LARGE = "db.x1e.4xlarge"
    X1_E_8_X_LARGE = "db.x1e.8xlarge"
    X1_E_32_X_LARGE = "db.x1e.32xlarge"


class StorageType(str, Enum):
    STANDARD = "standard"
    GP2 = "gp2"
    IO1 = "io1"
