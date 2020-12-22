// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package storagegateway

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Manages an AWS Storage Gateway NFS File Share.
//
// ## Example Usage
//
// ```go
// package main
//
// import (
// 	"github.com/pulumi/pulumi-aws/sdk/v3/go/aws/storagegateway"
// 	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
// )
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		_, err := storagegateway.NewNfsFileShare(ctx, "example", &storagegateway.NfsFileShareArgs{
// 			ClientLists: pulumi.StringArray{
// 				pulumi.String("0.0.0.0/0"),
// 			},
// 			GatewayArn:  pulumi.Any(aws_storagegateway_gateway.Example.Arn),
// 			LocationArn: pulumi.Any(aws_s3_bucket.Example.Arn),
// 			RoleArn:     pulumi.Any(aws_iam_role.Example.Arn),
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
//
// ## Import
//
// `aws_storagegateway_nfs_file_share` can be imported by using the NFS File Share Amazon Resource Name (ARN), e.g.
//
// ```sh
//  $ pulumi import aws:storagegateway/nfsFileShare:NfsFileShare example arn:aws:storagegateway:us-east-1:123456789012:share/share-12345678
// ```
type NfsFileShare struct {
	pulumi.CustomResourceState

	// Amazon Resource Name (ARN) of the NFS File Share.
	Arn pulumi.StringOutput `pulumi:"arn"`
	// Refresh cache information. see Cache Attributes for more details.
	CacheAttributes NfsFileShareCacheAttributesPtrOutput `pulumi:"cacheAttributes"`
	// The list of clients that are allowed to access the file gateway. The list must contain either valid IP addresses or valid CIDR blocks. Set to `["0.0.0.0/0"]` to not limit access. Minimum 1 item. Maximum 100 items.
	ClientLists pulumi.StringArrayOutput `pulumi:"clientLists"`
	// The default storage class for objects put into an Amazon S3 bucket by the file gateway. Defaults to `S3_STANDARD`. Valid values: `S3_STANDARD`, `S3_STANDARD_IA`, `S3_ONEZONE_IA`.
	DefaultStorageClass pulumi.StringPtrOutput `pulumi:"defaultStorageClass"`
	// The name of the file share. Must be set if an S3 prefix name is set in `locationArn`.
	FileShareName pulumi.StringOutput `pulumi:"fileShareName"`
	// ID of the NFS File Share.
	FileshareId pulumi.StringOutput `pulumi:"fileshareId"`
	// Amazon Resource Name (ARN) of the file gateway.
	GatewayArn pulumi.StringOutput `pulumi:"gatewayArn"`
	// Boolean value that enables guessing of the MIME type for uploaded objects based on file extensions. Defaults to `true`.
	GuessMimeTypeEnabled pulumi.BoolPtrOutput `pulumi:"guessMimeTypeEnabled"`
	// Boolean value if `true` to use Amazon S3 server side encryption with your own AWS KMS key, or `false` to use a key managed by Amazon S3. Defaults to `false`.
	KmsEncrypted pulumi.BoolPtrOutput `pulumi:"kmsEncrypted"`
	// Amazon Resource Name (ARN) for KMS key used for Amazon S3 server side encryption. This value can only be set when `kmsEncrypted` is true.
	KmsKeyArn pulumi.StringPtrOutput `pulumi:"kmsKeyArn"`
	// The ARN of the backed storage used for storing file data.
	LocationArn pulumi.StringOutput `pulumi:"locationArn"`
	// Nested argument with file share default values. More information below. see NFS File Share Defaults for more details.
	NfsFileShareDefaults NfsFileShareNfsFileShareDefaultsPtrOutput `pulumi:"nfsFileShareDefaults"`
	// The notification policy of the file share. For more information see the [AWS Documentation](https://docs.aws.amazon.com/storagegateway/latest/APIReference/API_CreateNFSFileShare.html#StorageGateway-CreateNFSFileShare-request-NotificationPolicy). Default value is `{}`.
	NotificationPolicy pulumi.StringPtrOutput `pulumi:"notificationPolicy"`
	// Access Control List permission for S3 bucket objects. Defaults to `private`.
	ObjectAcl pulumi.StringPtrOutput `pulumi:"objectAcl"`
	// File share path used by the NFS client to identify the mount point.
	Path pulumi.StringOutput `pulumi:"path"`
	// Boolean to indicate write status of file share. File share does not accept writes if `true`. Defaults to `false`.
	ReadOnly pulumi.BoolPtrOutput `pulumi:"readOnly"`
	// Boolean who pays the cost of the request and the data download from the Amazon S3 bucket. Set this value to `true` if you want the requester to pay instead of the bucket owner. Defaults to `false`.
	RequesterPays pulumi.BoolPtrOutput `pulumi:"requesterPays"`
	// The ARN of the AWS Identity and Access Management (IAM) role that a file gateway assumes when it accesses the underlying storage.
	RoleArn pulumi.StringOutput `pulumi:"roleArn"`
	// Maps a user to anonymous user. Defaults to `RootSquash`. Valid values: `RootSquash` (only root is mapped to anonymous user), `NoSquash` (no one is mapped to anonymous user), `AllSquash` (everyone is mapped to anonymous user)
	Squash pulumi.StringPtrOutput `pulumi:"squash"`
	// Key-value map of resource tags
	Tags pulumi.StringMapOutput `pulumi:"tags"`
}

// NewNfsFileShare registers a new resource with the given unique name, arguments, and options.
func NewNfsFileShare(ctx *pulumi.Context,
	name string, args *NfsFileShareArgs, opts ...pulumi.ResourceOption) (*NfsFileShare, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.ClientLists == nil {
		return nil, errors.New("invalid value for required argument 'ClientLists'")
	}
	if args.GatewayArn == nil {
		return nil, errors.New("invalid value for required argument 'GatewayArn'")
	}
	if args.LocationArn == nil {
		return nil, errors.New("invalid value for required argument 'LocationArn'")
	}
	if args.RoleArn == nil {
		return nil, errors.New("invalid value for required argument 'RoleArn'")
	}
	var resource NfsFileShare
	err := ctx.RegisterResource("aws:storagegateway/nfsFileShare:NfsFileShare", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetNfsFileShare gets an existing NfsFileShare resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetNfsFileShare(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *NfsFileShareState, opts ...pulumi.ResourceOption) (*NfsFileShare, error) {
	var resource NfsFileShare
	err := ctx.ReadResource("aws:storagegateway/nfsFileShare:NfsFileShare", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering NfsFileShare resources.
type nfsFileShareState struct {
	// Amazon Resource Name (ARN) of the NFS File Share.
	Arn *string `pulumi:"arn"`
	// Refresh cache information. see Cache Attributes for more details.
	CacheAttributes *NfsFileShareCacheAttributes `pulumi:"cacheAttributes"`
	// The list of clients that are allowed to access the file gateway. The list must contain either valid IP addresses or valid CIDR blocks. Set to `["0.0.0.0/0"]` to not limit access. Minimum 1 item. Maximum 100 items.
	ClientLists []string `pulumi:"clientLists"`
	// The default storage class for objects put into an Amazon S3 bucket by the file gateway. Defaults to `S3_STANDARD`. Valid values: `S3_STANDARD`, `S3_STANDARD_IA`, `S3_ONEZONE_IA`.
	DefaultStorageClass *string `pulumi:"defaultStorageClass"`
	// The name of the file share. Must be set if an S3 prefix name is set in `locationArn`.
	FileShareName *string `pulumi:"fileShareName"`
	// ID of the NFS File Share.
	FileshareId *string `pulumi:"fileshareId"`
	// Amazon Resource Name (ARN) of the file gateway.
	GatewayArn *string `pulumi:"gatewayArn"`
	// Boolean value that enables guessing of the MIME type for uploaded objects based on file extensions. Defaults to `true`.
	GuessMimeTypeEnabled *bool `pulumi:"guessMimeTypeEnabled"`
	// Boolean value if `true` to use Amazon S3 server side encryption with your own AWS KMS key, or `false` to use a key managed by Amazon S3. Defaults to `false`.
	KmsEncrypted *bool `pulumi:"kmsEncrypted"`
	// Amazon Resource Name (ARN) for KMS key used for Amazon S3 server side encryption. This value can only be set when `kmsEncrypted` is true.
	KmsKeyArn *string `pulumi:"kmsKeyArn"`
	// The ARN of the backed storage used for storing file data.
	LocationArn *string `pulumi:"locationArn"`
	// Nested argument with file share default values. More information below. see NFS File Share Defaults for more details.
	NfsFileShareDefaults *NfsFileShareNfsFileShareDefaults `pulumi:"nfsFileShareDefaults"`
	// The notification policy of the file share. For more information see the [AWS Documentation](https://docs.aws.amazon.com/storagegateway/latest/APIReference/API_CreateNFSFileShare.html#StorageGateway-CreateNFSFileShare-request-NotificationPolicy). Default value is `{}`.
	NotificationPolicy *string `pulumi:"notificationPolicy"`
	// Access Control List permission for S3 bucket objects. Defaults to `private`.
	ObjectAcl *string `pulumi:"objectAcl"`
	// File share path used by the NFS client to identify the mount point.
	Path *string `pulumi:"path"`
	// Boolean to indicate write status of file share. File share does not accept writes if `true`. Defaults to `false`.
	ReadOnly *bool `pulumi:"readOnly"`
	// Boolean who pays the cost of the request and the data download from the Amazon S3 bucket. Set this value to `true` if you want the requester to pay instead of the bucket owner. Defaults to `false`.
	RequesterPays *bool `pulumi:"requesterPays"`
	// The ARN of the AWS Identity and Access Management (IAM) role that a file gateway assumes when it accesses the underlying storage.
	RoleArn *string `pulumi:"roleArn"`
	// Maps a user to anonymous user. Defaults to `RootSquash`. Valid values: `RootSquash` (only root is mapped to anonymous user), `NoSquash` (no one is mapped to anonymous user), `AllSquash` (everyone is mapped to anonymous user)
	Squash *string `pulumi:"squash"`
	// Key-value map of resource tags
	Tags map[string]string `pulumi:"tags"`
}

type NfsFileShareState struct {
	// Amazon Resource Name (ARN) of the NFS File Share.
	Arn pulumi.StringPtrInput
	// Refresh cache information. see Cache Attributes for more details.
	CacheAttributes NfsFileShareCacheAttributesPtrInput
	// The list of clients that are allowed to access the file gateway. The list must contain either valid IP addresses or valid CIDR blocks. Set to `["0.0.0.0/0"]` to not limit access. Minimum 1 item. Maximum 100 items.
	ClientLists pulumi.StringArrayInput
	// The default storage class for objects put into an Amazon S3 bucket by the file gateway. Defaults to `S3_STANDARD`. Valid values: `S3_STANDARD`, `S3_STANDARD_IA`, `S3_ONEZONE_IA`.
	DefaultStorageClass pulumi.StringPtrInput
	// The name of the file share. Must be set if an S3 prefix name is set in `locationArn`.
	FileShareName pulumi.StringPtrInput
	// ID of the NFS File Share.
	FileshareId pulumi.StringPtrInput
	// Amazon Resource Name (ARN) of the file gateway.
	GatewayArn pulumi.StringPtrInput
	// Boolean value that enables guessing of the MIME type for uploaded objects based on file extensions. Defaults to `true`.
	GuessMimeTypeEnabled pulumi.BoolPtrInput
	// Boolean value if `true` to use Amazon S3 server side encryption with your own AWS KMS key, or `false` to use a key managed by Amazon S3. Defaults to `false`.
	KmsEncrypted pulumi.BoolPtrInput
	// Amazon Resource Name (ARN) for KMS key used for Amazon S3 server side encryption. This value can only be set when `kmsEncrypted` is true.
	KmsKeyArn pulumi.StringPtrInput
	// The ARN of the backed storage used for storing file data.
	LocationArn pulumi.StringPtrInput
	// Nested argument with file share default values. More information below. see NFS File Share Defaults for more details.
	NfsFileShareDefaults NfsFileShareNfsFileShareDefaultsPtrInput
	// The notification policy of the file share. For more information see the [AWS Documentation](https://docs.aws.amazon.com/storagegateway/latest/APIReference/API_CreateNFSFileShare.html#StorageGateway-CreateNFSFileShare-request-NotificationPolicy). Default value is `{}`.
	NotificationPolicy pulumi.StringPtrInput
	// Access Control List permission for S3 bucket objects. Defaults to `private`.
	ObjectAcl pulumi.StringPtrInput
	// File share path used by the NFS client to identify the mount point.
	Path pulumi.StringPtrInput
	// Boolean to indicate write status of file share. File share does not accept writes if `true`. Defaults to `false`.
	ReadOnly pulumi.BoolPtrInput
	// Boolean who pays the cost of the request and the data download from the Amazon S3 bucket. Set this value to `true` if you want the requester to pay instead of the bucket owner. Defaults to `false`.
	RequesterPays pulumi.BoolPtrInput
	// The ARN of the AWS Identity and Access Management (IAM) role that a file gateway assumes when it accesses the underlying storage.
	RoleArn pulumi.StringPtrInput
	// Maps a user to anonymous user. Defaults to `RootSquash`. Valid values: `RootSquash` (only root is mapped to anonymous user), `NoSquash` (no one is mapped to anonymous user), `AllSquash` (everyone is mapped to anonymous user)
	Squash pulumi.StringPtrInput
	// Key-value map of resource tags
	Tags pulumi.StringMapInput
}

func (NfsFileShareState) ElementType() reflect.Type {
	return reflect.TypeOf((*nfsFileShareState)(nil)).Elem()
}

type nfsFileShareArgs struct {
	// Refresh cache information. see Cache Attributes for more details.
	CacheAttributes *NfsFileShareCacheAttributes `pulumi:"cacheAttributes"`
	// The list of clients that are allowed to access the file gateway. The list must contain either valid IP addresses or valid CIDR blocks. Set to `["0.0.0.0/0"]` to not limit access. Minimum 1 item. Maximum 100 items.
	ClientLists []string `pulumi:"clientLists"`
	// The default storage class for objects put into an Amazon S3 bucket by the file gateway. Defaults to `S3_STANDARD`. Valid values: `S3_STANDARD`, `S3_STANDARD_IA`, `S3_ONEZONE_IA`.
	DefaultStorageClass *string `pulumi:"defaultStorageClass"`
	// The name of the file share. Must be set if an S3 prefix name is set in `locationArn`.
	FileShareName *string `pulumi:"fileShareName"`
	// Amazon Resource Name (ARN) of the file gateway.
	GatewayArn string `pulumi:"gatewayArn"`
	// Boolean value that enables guessing of the MIME type for uploaded objects based on file extensions. Defaults to `true`.
	GuessMimeTypeEnabled *bool `pulumi:"guessMimeTypeEnabled"`
	// Boolean value if `true` to use Amazon S3 server side encryption with your own AWS KMS key, or `false` to use a key managed by Amazon S3. Defaults to `false`.
	KmsEncrypted *bool `pulumi:"kmsEncrypted"`
	// Amazon Resource Name (ARN) for KMS key used for Amazon S3 server side encryption. This value can only be set when `kmsEncrypted` is true.
	KmsKeyArn *string `pulumi:"kmsKeyArn"`
	// The ARN of the backed storage used for storing file data.
	LocationArn string `pulumi:"locationArn"`
	// Nested argument with file share default values. More information below. see NFS File Share Defaults for more details.
	NfsFileShareDefaults *NfsFileShareNfsFileShareDefaults `pulumi:"nfsFileShareDefaults"`
	// The notification policy of the file share. For more information see the [AWS Documentation](https://docs.aws.amazon.com/storagegateway/latest/APIReference/API_CreateNFSFileShare.html#StorageGateway-CreateNFSFileShare-request-NotificationPolicy). Default value is `{}`.
	NotificationPolicy *string `pulumi:"notificationPolicy"`
	// Access Control List permission for S3 bucket objects. Defaults to `private`.
	ObjectAcl *string `pulumi:"objectAcl"`
	// Boolean to indicate write status of file share. File share does not accept writes if `true`. Defaults to `false`.
	ReadOnly *bool `pulumi:"readOnly"`
	// Boolean who pays the cost of the request and the data download from the Amazon S3 bucket. Set this value to `true` if you want the requester to pay instead of the bucket owner. Defaults to `false`.
	RequesterPays *bool `pulumi:"requesterPays"`
	// The ARN of the AWS Identity and Access Management (IAM) role that a file gateway assumes when it accesses the underlying storage.
	RoleArn string `pulumi:"roleArn"`
	// Maps a user to anonymous user. Defaults to `RootSquash`. Valid values: `RootSquash` (only root is mapped to anonymous user), `NoSquash` (no one is mapped to anonymous user), `AllSquash` (everyone is mapped to anonymous user)
	Squash *string `pulumi:"squash"`
	// Key-value map of resource tags
	Tags map[string]string `pulumi:"tags"`
}

// The set of arguments for constructing a NfsFileShare resource.
type NfsFileShareArgs struct {
	// Refresh cache information. see Cache Attributes for more details.
	CacheAttributes NfsFileShareCacheAttributesPtrInput
	// The list of clients that are allowed to access the file gateway. The list must contain either valid IP addresses or valid CIDR blocks. Set to `["0.0.0.0/0"]` to not limit access. Minimum 1 item. Maximum 100 items.
	ClientLists pulumi.StringArrayInput
	// The default storage class for objects put into an Amazon S3 bucket by the file gateway. Defaults to `S3_STANDARD`. Valid values: `S3_STANDARD`, `S3_STANDARD_IA`, `S3_ONEZONE_IA`.
	DefaultStorageClass pulumi.StringPtrInput
	// The name of the file share. Must be set if an S3 prefix name is set in `locationArn`.
	FileShareName pulumi.StringPtrInput
	// Amazon Resource Name (ARN) of the file gateway.
	GatewayArn pulumi.StringInput
	// Boolean value that enables guessing of the MIME type for uploaded objects based on file extensions. Defaults to `true`.
	GuessMimeTypeEnabled pulumi.BoolPtrInput
	// Boolean value if `true` to use Amazon S3 server side encryption with your own AWS KMS key, or `false` to use a key managed by Amazon S3. Defaults to `false`.
	KmsEncrypted pulumi.BoolPtrInput
	// Amazon Resource Name (ARN) for KMS key used for Amazon S3 server side encryption. This value can only be set when `kmsEncrypted` is true.
	KmsKeyArn pulumi.StringPtrInput
	// The ARN of the backed storage used for storing file data.
	LocationArn pulumi.StringInput
	// Nested argument with file share default values. More information below. see NFS File Share Defaults for more details.
	NfsFileShareDefaults NfsFileShareNfsFileShareDefaultsPtrInput
	// The notification policy of the file share. For more information see the [AWS Documentation](https://docs.aws.amazon.com/storagegateway/latest/APIReference/API_CreateNFSFileShare.html#StorageGateway-CreateNFSFileShare-request-NotificationPolicy). Default value is `{}`.
	NotificationPolicy pulumi.StringPtrInput
	// Access Control List permission for S3 bucket objects. Defaults to `private`.
	ObjectAcl pulumi.StringPtrInput
	// Boolean to indicate write status of file share. File share does not accept writes if `true`. Defaults to `false`.
	ReadOnly pulumi.BoolPtrInput
	// Boolean who pays the cost of the request and the data download from the Amazon S3 bucket. Set this value to `true` if you want the requester to pay instead of the bucket owner. Defaults to `false`.
	RequesterPays pulumi.BoolPtrInput
	// The ARN of the AWS Identity and Access Management (IAM) role that a file gateway assumes when it accesses the underlying storage.
	RoleArn pulumi.StringInput
	// Maps a user to anonymous user. Defaults to `RootSquash`. Valid values: `RootSquash` (only root is mapped to anonymous user), `NoSquash` (no one is mapped to anonymous user), `AllSquash` (everyone is mapped to anonymous user)
	Squash pulumi.StringPtrInput
	// Key-value map of resource tags
	Tags pulumi.StringMapInput
}

func (NfsFileShareArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*nfsFileShareArgs)(nil)).Elem()
}

type NfsFileShareInput interface {
	pulumi.Input

	ToNfsFileShareOutput() NfsFileShareOutput
	ToNfsFileShareOutputWithContext(ctx context.Context) NfsFileShareOutput
}

func (NfsFileShare) ElementType() reflect.Type {
	return reflect.TypeOf((*NfsFileShare)(nil)).Elem()
}

func (i NfsFileShare) ToNfsFileShareOutput() NfsFileShareOutput {
	return i.ToNfsFileShareOutputWithContext(context.Background())
}

func (i NfsFileShare) ToNfsFileShareOutputWithContext(ctx context.Context) NfsFileShareOutput {
	return pulumi.ToOutputWithContext(ctx, i).(NfsFileShareOutput)
}

type NfsFileShareOutput struct {
	*pulumi.OutputState
}

func (NfsFileShareOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*NfsFileShareOutput)(nil)).Elem()
}

func (o NfsFileShareOutput) ToNfsFileShareOutput() NfsFileShareOutput {
	return o
}

func (o NfsFileShareOutput) ToNfsFileShareOutputWithContext(ctx context.Context) NfsFileShareOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(NfsFileShareOutput{})
}
