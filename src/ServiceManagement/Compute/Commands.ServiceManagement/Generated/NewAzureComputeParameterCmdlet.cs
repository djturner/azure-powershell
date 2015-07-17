// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using Microsoft.Azure;
using Microsoft.WindowsAzure.Management.Compute;
using Microsoft.WindowsAzure.Management.Compute.Models;
using System;
using System.Collections.Generic;
using System.Management.Automation;

namespace Microsoft.WindowsAzure.Commands.Compute.Automation
{
    [Cmdlet(VerbsCommon.New, "AzureComputeParameter")]
    [OutputType(typeof(object))]
    public partial class NewAzureComputeParameterCmdlet : ComputeAutomationBaseCmdlet
    {
        [Parameter(ParameterSetName = "CreateParameterListByMethodName", Mandatory = true, Position = 0)]
        [ValidateSet(
            "DeploymentChangeConfigurationByName",
            "DeploymentChangeConfigurationBySlot",
            "DeploymentCreate",
            "DeploymentDeleteByName",
            "DeploymentDeleteBySlot",
            "DeploymentDeleteRoleInstanceByDeploymentName",
            "DeploymentDeleteRoleInstanceByDeploymentSlot",
            "DeploymentGetByName",
            "DeploymentGetBySlot",
            "DeploymentGetPackageByName",
            "DeploymentGetPackageBySlot",
            "DeploymentListEvents",
            "DeploymentListEventsBySlot",
            "DeploymentRebootRoleInstanceByDeploymentName",
            "DeploymentRebootRoleInstanceByDeploymentSlot",
            "DeploymentRebuildRoleInstanceByDeploymentName",
            "DeploymentRebuildRoleInstanceByDeploymentSlot",
            "DeploymentReimageRoleInstanceByDeploymentName",
            "DeploymentReimageRoleInstanceByDeploymentSlot",
            "DeploymentRollbackUpdateOrUpgradeByDeploymentName",
            "DeploymentRollbackUpdateOrUpgradeByDeploymentSlot",
            "DeploymentSwap",
            "DeploymentUpdateStatusByDeploymentName",
            "DeploymentUpdateStatusByDeploymentSlot",
            "DeploymentUpgradeByName",
            "DeploymentUpgradeBySlot",
            "DeploymentWalkUpgradeDomainByDeploymentName",
            "DeploymentWalkUpgradeDomainByDeploymentSlot",
            "DNSServerAddDNSServer",
            "DNSServerDeleteDNSServer",
            "DNSServerUpdateDNSServer",
            "ExtensionImageRegister",
            "ExtensionImageUnregister",
            "ExtensionImageUpdate",
            "HostedServiceAddExtension",
            "HostedServiceCheckNameAvailability",
            "HostedServiceCreate",
            "HostedServiceDelete",
            "HostedServiceDeleteAll",
            "HostedServiceDeleteExtension",
            "HostedServiceGet",
            "HostedServiceGetDetailed",
            "HostedServiceGetExtension",
            "HostedServiceList",
            "HostedServiceListAvailableExtensions",
            "HostedServiceListExtensions",
            "HostedServiceListExtensionVersions",
            "HostedServiceUpdate",
            "LoadBalancerCreate",
            "LoadBalancerDelete",
            "LoadBalancerUpdate",
            "OperatingSystemList",
            "OperatingSystemListFamilies",
            "ServiceCertificateCreate",
            "ServiceCertificateDelete",
            "ServiceCertificateGet",
            "ServiceCertificateList",
            "VirtualMachineDiskCreateDataDisk",
            "VirtualMachineDiskCreateDisk",
            "VirtualMachineDiskDeleteDataDisk",
            "VirtualMachineDiskDeleteDisk",
            "VirtualMachineDiskGetDataDisk",
            "VirtualMachineDiskGetDisk",
            "VirtualMachineDiskListDisks",
            "VirtualMachineDiskUpdateDataDisk",
            "VirtualMachineDiskUpdateDisk",
            "VirtualMachineDiskUpdateDiskSize",
            "VirtualMachineExtensionList",
            "VirtualMachineExtensionListVersions",
            "VirtualMachineCaptureOSImage",
            "VirtualMachineCaptureVMImage",
            "VirtualMachineCreate",
            "VirtualMachineCreateDeployment",
            "VirtualMachineDelete",
            "VirtualMachineGet",
            "VirtualMachineGetRemoteDesktopFile",
            "VirtualMachineRestart",
            "VirtualMachineShutdown",
            "VirtualMachineShutdownRoles",
            "VirtualMachineStart",
            "VirtualMachineStartRoles",
            "VirtualMachineUpdate",
            "VirtualMachineUpdateLoadBalancedEndpointSet",
            "VirtualMachineOSImageCreate",
            "VirtualMachineOSImageDelete",
            "VirtualMachineOSImageGet",
            "VirtualMachineOSImageGetDetails",
            "VirtualMachineOSImageList",
            "VirtualMachineOSImageReplicate",
            "VirtualMachineOSImageShare",
            "VirtualMachineOSImageUnreplicate",
            "VirtualMachineOSImageUpdate",
            "VirtualMachineVMImageCreate",
            "VirtualMachineVMImageDelete",
            "VirtualMachineVMImageGetDetails",
            "VirtualMachineVMImageList",
            "VirtualMachineVMImageReplicate",
            "VirtualMachineVMImageShare",
            "VirtualMachineVMImageUnreplicate",
            "VirtualMachineVMImageUpdate"
        )]
        public string MethodName { get; set; }

        [Parameter(ParameterSetName = "CreateParameterObjectByTypeName", Mandatory = true, Position = 0)]
        [ValidateSet(
            "DeploymentChangeConfigurationParameters",
            "DeploymentCreateParameters",
            "DeploymentDeleteRoleInstanceParameters",
            "DeploymentExtension",
            "DeploymentExtensionConfiguration",
            "DeploymentExtensionList",
            "DeploymentGetPackageParameters",
            "DeploymentNamedRole",
            "DeploymentNamedRoleList",
            "DeploymentRollbackUpdateOrUpgradeParameters",
            "DeploymentSwapParameters",
            "DeploymentUpdateStatusParameters",
            "DeploymentUpgradeParameters",
            "DeploymentWalkUpgradeDomainParameters",
            "DNSServerDNSAddParameters",
            "DNSServerDNSUpdateParameters",
            "ExtensionImageExtensionCertificateConfiguration",
            "ExtensionImageExtensionEndpointConfiguration",
            "ExtensionImageExtensionLocalResourceConfiguration",
            "ExtensionImageExtensionLocalResourceConfigurationList",
            "ExtensionImageInputEndpoint",
            "ExtensionImageInputEndpointList",
            "ExtensionImageInternalEndpoint",
            "ExtensionImageInternalEndpointList",
            "ExtensionImageRegisterParameters",
            "ExtensionImageUpdateParameters",
            "HostedServiceAddExtensionParameters",
            "HostedServiceCreateParameters",
            "HostedServiceUpdateParameters",
            "LoadBalancerCreateParameters",
            "LoadBalancerFrontendIPConfiguration",
            "LoadBalancerUpdateParameters",
            "ServiceCertificateCreateParameters",
            "ServiceCertificateDeleteParameters",
            "ServiceCertificateGetParameters",
            "VirtualMachineCaptureOSImageParameters",
            "VirtualMachineCaptureVMImageParameters",
            "VirtualMachineConfigurationSet",
            "VirtualMachineConfigurationSetList",
            "VirtualMachineCreateDeploymentParameters",
            "VirtualMachineCreateParameters",
            "VirtualMachineDataDiskConfiguration",
            "VirtualMachineDataDiskConfigurationList",
            "VirtualMachineDataVirtualHardDisk",
            "VirtualMachineDataVirtualHardDiskList",
            "VirtualMachineDiskCreateParameters",
            "VirtualMachineDiskUpdateParameters",
            "VirtualMachineDiskVirtualMachineDataDiskCreateParameters",
            "VirtualMachineDiskVirtualMachineDataDiskUpdateParameters",
            "VirtualMachineDnsServer",
            "VirtualMachineDnsServerList",
            "VirtualMachineDnsSettings",
            "VirtualMachineDomainJoinCredentials",
            "VirtualMachineDomainJoinProvisioning",
            "VirtualMachineDomainJoinSettings",
            "VirtualMachineInputEndpoint",
            "VirtualMachineInputEndpointList",
            "VirtualMachineLoadBalancer",
            "VirtualMachineLoadBalancerList",
            "VirtualMachineNetworkInterface",
            "VirtualMachineNetworkInterfaceList",
            "VirtualMachineOSDiskConfiguration",
            "VirtualMachineOSImageComputeImageAttributes",
            "VirtualMachineOSImageCreateParameters",
            "VirtualMachineOSImageMarketplaceImageAttributes",
            "VirtualMachineOSImagePlan",
            "VirtualMachineOSImageReplicateParameters",
            "VirtualMachineOSImageUpdateParameters",
            "VirtualMachineOSVirtualHardDisk",
            "VirtualMachinePublicIP",
            "VirtualMachinePublicIPList",
            "VirtualMachineResourceExtensionReference",
            "VirtualMachineResourceExtensionReferenceList",
            "VirtualMachineRole",
            "VirtualMachineRoleList",
            "VirtualMachineShutdownParameters",
            "VirtualMachineShutdownRolesParameters",
            "VirtualMachineSshSettingKeyPair",
            "VirtualMachineSshSettingKeyPairList",
            "VirtualMachineSshSettingPublicKey",
            "VirtualMachineSshSettingPublicKeyList",
            "VirtualMachineSshSettings",
            "VirtualMachineStartRolesParameters",
            "VirtualMachineStoredCertificateSettings",
            "VirtualMachineStoredCertificateSettingsList",
            "VirtualMachineUpdateLoadBalancedSetParameters",
            "VirtualMachineUpdateParameters",
            "VirtualMachineVMImageComputeImageAttributes",
            "VirtualMachineVMImageCreateParameters",
            "VirtualMachineVMImageDataDiskConfigurationCreateParameters",
            "VirtualMachineVMImageDataDiskConfigurationCreateParametersList",
            "VirtualMachineVMImageDataDiskConfigurationUpdateParameters",
            "VirtualMachineVMImageDataDiskConfigurationUpdateParametersList",
            "VirtualMachineVMImageInput",
            "VirtualMachineVMImageMarketplaceImageAttributes",
            "VirtualMachineVMImageOSDiskConfigurationCreateParameters",
            "VirtualMachineVMImageOSDiskConfigurationUpdateParameters",
            "VirtualMachineVMImagePlan",
            "VirtualMachineVMImageReplicateParameters",
            "VirtualMachineVMImageUpdateParameters",
            "VirtualMachineWindowsRemoteManagementListener",
            "VirtualMachineWindowsRemoteManagementListenerList",
            "VirtualMachineWindowsRemoteManagementSettings"
        )]
        public string TypeName { get; set; }

        public override void ExecuteCmdlet()
        {
            base.ExecuteCmdlet();
            ExecuteClientAction(() =>
            {
                if (ParameterSetName == "CreateParameterListByMethodName")
                {
                    switch (MethodName)
                    {
                        case "DeploymentChangeConfigurationByName" : WriteObject(CreateDeploymentChangeConfigurationByNameParameters()); break;
                        case "DeploymentChangeConfigurationBySlot" : WriteObject(CreateDeploymentChangeConfigurationBySlotParameters()); break;
                        case "DeploymentCreate" : WriteObject(CreateDeploymentCreateParameters()); break;
                        case "DeploymentDeleteByName" : WriteObject(CreateDeploymentDeleteByNameParameters()); break;
                        case "DeploymentDeleteBySlot" : WriteObject(CreateDeploymentDeleteBySlotParameters()); break;
                        case "DeploymentDeleteRoleInstanceByDeploymentName" : WriteObject(CreateDeploymentDeleteRoleInstanceByDeploymentNameParameters()); break;
                        case "DeploymentDeleteRoleInstanceByDeploymentSlot" : WriteObject(CreateDeploymentDeleteRoleInstanceByDeploymentSlotParameters()); break;
                        case "DeploymentGetByName" : WriteObject(CreateDeploymentGetByNameParameters()); break;
                        case "DeploymentGetBySlot" : WriteObject(CreateDeploymentGetBySlotParameters()); break;
                        case "DeploymentGetPackageByName" : WriteObject(CreateDeploymentGetPackageByNameParameters()); break;
                        case "DeploymentGetPackageBySlot" : WriteObject(CreateDeploymentGetPackageBySlotParameters()); break;
                        case "DeploymentListEvents" : WriteObject(CreateDeploymentListEventsParameters()); break;
                        case "DeploymentListEventsBySlot" : WriteObject(CreateDeploymentListEventsBySlotParameters()); break;
                        case "DeploymentRebootRoleInstanceByDeploymentName" : WriteObject(CreateDeploymentRebootRoleInstanceByDeploymentNameParameters()); break;
                        case "DeploymentRebootRoleInstanceByDeploymentSlot" : WriteObject(CreateDeploymentRebootRoleInstanceByDeploymentSlotParameters()); break;
                        case "DeploymentRebuildRoleInstanceByDeploymentName" : WriteObject(CreateDeploymentRebuildRoleInstanceByDeploymentNameParameters()); break;
                        case "DeploymentRebuildRoleInstanceByDeploymentSlot" : WriteObject(CreateDeploymentRebuildRoleInstanceByDeploymentSlotParameters()); break;
                        case "DeploymentReimageRoleInstanceByDeploymentName" : WriteObject(CreateDeploymentReimageRoleInstanceByDeploymentNameParameters()); break;
                        case "DeploymentReimageRoleInstanceByDeploymentSlot" : WriteObject(CreateDeploymentReimageRoleInstanceByDeploymentSlotParameters()); break;
                        case "DeploymentRollbackUpdateOrUpgradeByDeploymentName" : WriteObject(CreateDeploymentRollbackUpdateOrUpgradeByDeploymentNameParameters()); break;
                        case "DeploymentRollbackUpdateOrUpgradeByDeploymentSlot" : WriteObject(CreateDeploymentRollbackUpdateOrUpgradeByDeploymentSlotParameters()); break;
                        case "DeploymentSwap" : WriteObject(CreateDeploymentSwapParameters()); break;
                        case "DeploymentUpdateStatusByDeploymentName" : WriteObject(CreateDeploymentUpdateStatusByDeploymentNameParameters()); break;
                        case "DeploymentUpdateStatusByDeploymentSlot" : WriteObject(CreateDeploymentUpdateStatusByDeploymentSlotParameters()); break;
                        case "DeploymentUpgradeByName" : WriteObject(CreateDeploymentUpgradeByNameParameters()); break;
                        case "DeploymentUpgradeBySlot" : WriteObject(CreateDeploymentUpgradeBySlotParameters()); break;
                        case "DeploymentWalkUpgradeDomainByDeploymentName" : WriteObject(CreateDeploymentWalkUpgradeDomainByDeploymentNameParameters()); break;
                        case "DeploymentWalkUpgradeDomainByDeploymentSlot" : WriteObject(CreateDeploymentWalkUpgradeDomainByDeploymentSlotParameters()); break;
                        case "DNSServerAddDNSServer" : WriteObject(CreateDNSServerAddDNSServerParameters()); break;
                        case "DNSServerDeleteDNSServer" : WriteObject(CreateDNSServerDeleteDNSServerParameters()); break;
                        case "DNSServerUpdateDNSServer" : WriteObject(CreateDNSServerUpdateDNSServerParameters()); break;
                        case "ExtensionImageRegister" : WriteObject(CreateExtensionImageRegisterParameters()); break;
                        case "ExtensionImageUnregister" : WriteObject(CreateExtensionImageUnregisterParameters()); break;
                        case "ExtensionImageUpdate" : WriteObject(CreateExtensionImageUpdateParameters()); break;
                        case "HostedServiceAddExtension" : WriteObject(CreateHostedServiceAddExtensionParameters()); break;
                        case "HostedServiceCheckNameAvailability" : WriteObject(CreateHostedServiceCheckNameAvailabilityParameters()); break;
                        case "HostedServiceCreate" : WriteObject(CreateHostedServiceCreateParameters()); break;
                        case "HostedServiceDelete" : WriteObject(CreateHostedServiceDeleteParameters()); break;
                        case "HostedServiceDeleteAll" : WriteObject(CreateHostedServiceDeleteAllParameters()); break;
                        case "HostedServiceDeleteExtension" : WriteObject(CreateHostedServiceDeleteExtensionParameters()); break;
                        case "HostedServiceGet" : WriteObject(CreateHostedServiceGetParameters()); break;
                        case "HostedServiceGetDetailed" : WriteObject(CreateHostedServiceGetDetailedParameters()); break;
                        case "HostedServiceGetExtension" : WriteObject(CreateHostedServiceGetExtensionParameters()); break;
                        case "HostedServiceList" : WriteObject(CreateHostedServiceListParameters()); break;
                        case "HostedServiceListAvailableExtensions" : WriteObject(CreateHostedServiceListAvailableExtensionsParameters()); break;
                        case "HostedServiceListExtensions" : WriteObject(CreateHostedServiceListExtensionsParameters()); break;
                        case "HostedServiceListExtensionVersions" : WriteObject(CreateHostedServiceListExtensionVersionsParameters()); break;
                        case "HostedServiceUpdate" : WriteObject(CreateHostedServiceUpdateParameters()); break;
                        case "LoadBalancerCreate" : WriteObject(CreateLoadBalancerCreateParameters()); break;
                        case "LoadBalancerDelete" : WriteObject(CreateLoadBalancerDeleteParameters()); break;
                        case "LoadBalancerUpdate" : WriteObject(CreateLoadBalancerUpdateParameters()); break;
                        case "OperatingSystemList" : WriteObject(CreateOperatingSystemListParameters()); break;
                        case "OperatingSystemListFamilies" : WriteObject(CreateOperatingSystemListFamiliesParameters()); break;
                        case "ServiceCertificateCreate" : WriteObject(CreateServiceCertificateCreateParameters()); break;
                        case "ServiceCertificateDelete" : WriteObject(CreateServiceCertificateDeleteParameters()); break;
                        case "ServiceCertificateGet" : WriteObject(CreateServiceCertificateGetParameters()); break;
                        case "ServiceCertificateList" : WriteObject(CreateServiceCertificateListParameters()); break;
                        case "VirtualMachineDiskCreateDataDisk" : WriteObject(CreateVirtualMachineDiskCreateDataDiskParameters()); break;
                        case "VirtualMachineDiskCreateDisk" : WriteObject(CreateVirtualMachineDiskCreateDiskParameters()); break;
                        case "VirtualMachineDiskDeleteDataDisk" : WriteObject(CreateVirtualMachineDiskDeleteDataDiskParameters()); break;
                        case "VirtualMachineDiskDeleteDisk" : WriteObject(CreateVirtualMachineDiskDeleteDiskParameters()); break;
                        case "VirtualMachineDiskGetDataDisk" : WriteObject(CreateVirtualMachineDiskGetDataDiskParameters()); break;
                        case "VirtualMachineDiskGetDisk" : WriteObject(CreateVirtualMachineDiskGetDiskParameters()); break;
                        case "VirtualMachineDiskListDisks" : WriteObject(CreateVirtualMachineDiskListDisksParameters()); break;
                        case "VirtualMachineDiskUpdateDataDisk" : WriteObject(CreateVirtualMachineDiskUpdateDataDiskParameters()); break;
                        case "VirtualMachineDiskUpdateDisk" : WriteObject(CreateVirtualMachineDiskUpdateDiskParameters()); break;
                        case "VirtualMachineDiskUpdateDiskSize" : WriteObject(CreateVirtualMachineDiskUpdateDiskSizeParameters()); break;
                        case "VirtualMachineExtensionList" : WriteObject(CreateVirtualMachineExtensionListParameters()); break;
                        case "VirtualMachineExtensionListVersions" : WriteObject(CreateVirtualMachineExtensionListVersionsParameters()); break;
                        case "VirtualMachineCaptureOSImage" : WriteObject(CreateVirtualMachineCaptureOSImageParameters()); break;
                        case "VirtualMachineCaptureVMImage" : WriteObject(CreateVirtualMachineCaptureVMImageParameters()); break;
                        case "VirtualMachineCreate" : WriteObject(CreateVirtualMachineCreateParameters()); break;
                        case "VirtualMachineCreateDeployment" : WriteObject(CreateVirtualMachineCreateDeploymentParameters()); break;
                        case "VirtualMachineDelete" : WriteObject(CreateVirtualMachineDeleteParameters()); break;
                        case "VirtualMachineGet" : WriteObject(CreateVirtualMachineGetParameters()); break;
                        case "VirtualMachineGetRemoteDesktopFile" : WriteObject(CreateVirtualMachineGetRemoteDesktopFileParameters()); break;
                        case "VirtualMachineRestart" : WriteObject(CreateVirtualMachineRestartParameters()); break;
                        case "VirtualMachineShutdown" : WriteObject(CreateVirtualMachineShutdownParameters()); break;
                        case "VirtualMachineShutdownRoles" : WriteObject(CreateVirtualMachineShutdownRolesParameters()); break;
                        case "VirtualMachineStart" : WriteObject(CreateVirtualMachineStartParameters()); break;
                        case "VirtualMachineStartRoles" : WriteObject(CreateVirtualMachineStartRolesParameters()); break;
                        case "VirtualMachineUpdate" : WriteObject(CreateVirtualMachineUpdateParameters()); break;
                        case "VirtualMachineUpdateLoadBalancedEndpointSet" : WriteObject(CreateVirtualMachineUpdateLoadBalancedEndpointSetParameters()); break;
                        case "VirtualMachineOSImageCreate" : WriteObject(CreateVirtualMachineOSImageCreateParameters()); break;
                        case "VirtualMachineOSImageDelete" : WriteObject(CreateVirtualMachineOSImageDeleteParameters()); break;
                        case "VirtualMachineOSImageGet" : WriteObject(CreateVirtualMachineOSImageGetParameters()); break;
                        case "VirtualMachineOSImageGetDetails" : WriteObject(CreateVirtualMachineOSImageGetDetailsParameters()); break;
                        case "VirtualMachineOSImageList" : WriteObject(CreateVirtualMachineOSImageListParameters()); break;
                        case "VirtualMachineOSImageReplicate" : WriteObject(CreateVirtualMachineOSImageReplicateParameters()); break;
                        case "VirtualMachineOSImageShare" : WriteObject(CreateVirtualMachineOSImageShareParameters()); break;
                        case "VirtualMachineOSImageUnreplicate" : WriteObject(CreateVirtualMachineOSImageUnreplicateParameters()); break;
                        case "VirtualMachineOSImageUpdate" : WriteObject(CreateVirtualMachineOSImageUpdateParameters()); break;
                        case "VirtualMachineVMImageCreate" : WriteObject(CreateVirtualMachineVMImageCreateParameters()); break;
                        case "VirtualMachineVMImageDelete" : WriteObject(CreateVirtualMachineVMImageDeleteParameters()); break;
                        case "VirtualMachineVMImageGetDetails" : WriteObject(CreateVirtualMachineVMImageGetDetailsParameters()); break;
                        case "VirtualMachineVMImageList" : WriteObject(CreateVirtualMachineVMImageListParameters()); break;
                        case "VirtualMachineVMImageReplicate" : WriteObject(CreateVirtualMachineVMImageReplicateParameters()); break;
                        case "VirtualMachineVMImageShare" : WriteObject(CreateVirtualMachineVMImageShareParameters()); break;
                        case "VirtualMachineVMImageUnreplicate" : WriteObject(CreateVirtualMachineVMImageUnreplicateParameters()); break;
                        case "VirtualMachineVMImageUpdate" : WriteObject(CreateVirtualMachineVMImageUpdateParameters()); break;
                        default : WriteWarning("Cannot find the method by name = '" + MethodName + "'."); break;
                    }
                }
                else
                {
                    switch (TypeName)
                    {
                        case "DeploymentChangeConfigurationParameters" : WriteObject(new DeploymentChangeConfigurationParameters()); break;
                        case "DeploymentCreateParameters" : WriteObject(new DeploymentCreateParameters()); break;
                        case "DeploymentDeleteRoleInstanceParameters" : WriteObject(new DeploymentDeleteRoleInstanceParameters()); break;
                        case "DeploymentExtension" : WriteObject(new ExtensionConfiguration.Extension()); break;
                        case "DeploymentExtensionConfiguration" : WriteObject(new ExtensionConfiguration()); break;
                        case "DeploymentExtensionList" : WriteObject(new List<ExtensionConfiguration.Extension>()); break;
                        case "DeploymentGetPackageParameters" : WriteObject(new DeploymentGetPackageParameters()); break;
                        case "DeploymentNamedRole" : WriteObject(new ExtensionConfiguration.NamedRole()); break;
                        case "DeploymentNamedRoleList" : WriteObject(new List<ExtensionConfiguration.NamedRole>()); break;
                        case "DeploymentRollbackUpdateOrUpgradeParameters" : WriteObject(new DeploymentRollbackUpdateOrUpgradeParameters()); break;
                        case "DeploymentSwapParameters" : WriteObject(new DeploymentSwapParameters()); break;
                        case "DeploymentUpdateStatusParameters" : WriteObject(new DeploymentUpdateStatusParameters()); break;
                        case "DeploymentUpgradeParameters" : WriteObject(new DeploymentUpgradeParameters()); break;
                        case "DeploymentWalkUpgradeDomainParameters" : WriteObject(new DeploymentWalkUpgradeDomainParameters()); break;
                        case "DNSServerDNSAddParameters" : WriteObject(new DNSAddParameters()); break;
                        case "DNSServerDNSUpdateParameters" : WriteObject(new DNSUpdateParameters()); break;
                        case "ExtensionImageExtensionCertificateConfiguration" : WriteObject(new ExtensionCertificateConfiguration()); break;
                        case "ExtensionImageExtensionEndpointConfiguration" : WriteObject(new ExtensionEndpointConfiguration()); break;
                        case "ExtensionImageExtensionLocalResourceConfiguration" : WriteObject(new ExtensionLocalResourceConfiguration()); break;
                        case "ExtensionImageExtensionLocalResourceConfigurationList" : WriteObject(new List<ExtensionLocalResourceConfiguration>()); break;
                        case "ExtensionImageInputEndpoint" : WriteObject(new ExtensionEndpointConfiguration.InputEndpoint()); break;
                        case "ExtensionImageInputEndpointList" : WriteObject(new List<ExtensionEndpointConfiguration.InputEndpoint>()); break;
                        case "ExtensionImageInternalEndpoint" : WriteObject(new ExtensionEndpointConfiguration.InternalEndpoint()); break;
                        case "ExtensionImageInternalEndpointList" : WriteObject(new List<ExtensionEndpointConfiguration.InternalEndpoint>()); break;
                        case "ExtensionImageRegisterParameters" : WriteObject(new ExtensionImageRegisterParameters()); break;
                        case "ExtensionImageUpdateParameters" : WriteObject(new ExtensionImageUpdateParameters()); break;
                        case "HostedServiceAddExtensionParameters" : WriteObject(new HostedServiceAddExtensionParameters()); break;
                        case "HostedServiceCreateParameters" : WriteObject(new HostedServiceCreateParameters()); break;
                        case "HostedServiceUpdateParameters" : WriteObject(new HostedServiceUpdateParameters()); break;
                        case "LoadBalancerCreateParameters" : WriteObject(new LoadBalancerCreateParameters()); break;
                        case "LoadBalancerFrontendIPConfiguration" : WriteObject(new FrontendIPConfiguration()); break;
                        case "LoadBalancerUpdateParameters" : WriteObject(new LoadBalancerUpdateParameters()); break;
                        case "ServiceCertificateCreateParameters" : WriteObject(new ServiceCertificateCreateParameters()); break;
                        case "ServiceCertificateDeleteParameters" : WriteObject(new ServiceCertificateDeleteParameters()); break;
                        case "ServiceCertificateGetParameters" : WriteObject(new ServiceCertificateGetParameters()); break;
                        case "VirtualMachineCaptureOSImageParameters" : WriteObject(new VirtualMachineCaptureOSImageParameters()); break;
                        case "VirtualMachineCaptureVMImageParameters" : WriteObject(new VirtualMachineCaptureVMImageParameters()); break;
                        case "VirtualMachineConfigurationSet" : WriteObject(new ConfigurationSet()); break;
                        case "VirtualMachineConfigurationSetList" : WriteObject(new List<ConfigurationSet>()); break;
                        case "VirtualMachineCreateDeploymentParameters" : WriteObject(new VirtualMachineCreateDeploymentParameters()); break;
                        case "VirtualMachineCreateParameters" : WriteObject(new VirtualMachineCreateParameters()); break;
                        case "VirtualMachineDataDiskConfiguration" : WriteObject(new DataDiskConfiguration()); break;
                        case "VirtualMachineDataDiskConfigurationList" : WriteObject(new List<DataDiskConfiguration>()); break;
                        case "VirtualMachineDataVirtualHardDisk" : WriteObject(new DataVirtualHardDisk()); break;
                        case "VirtualMachineDataVirtualHardDiskList" : WriteObject(new List<DataVirtualHardDisk>()); break;
                        case "VirtualMachineDiskCreateParameters" : WriteObject(new VirtualMachineDiskCreateParameters()); break;
                        case "VirtualMachineDiskUpdateParameters" : WriteObject(new VirtualMachineDiskUpdateParameters()); break;
                        case "VirtualMachineDiskVirtualMachineDataDiskCreateParameters" : WriteObject(new VirtualMachineDataDiskCreateParameters()); break;
                        case "VirtualMachineDiskVirtualMachineDataDiskUpdateParameters" : WriteObject(new VirtualMachineDataDiskUpdateParameters()); break;
                        case "VirtualMachineDnsServer" : WriteObject(new DnsServer()); break;
                        case "VirtualMachineDnsServerList" : WriteObject(new List<DnsServer>()); break;
                        case "VirtualMachineDnsSettings" : WriteObject(new DnsSettings()); break;
                        case "VirtualMachineDomainJoinCredentials" : WriteObject(new DomainJoinCredentials()); break;
                        case "VirtualMachineDomainJoinProvisioning" : WriteObject(new DomainJoinProvisioning()); break;
                        case "VirtualMachineDomainJoinSettings" : WriteObject(new DomainJoinSettings()); break;
                        case "VirtualMachineInputEndpoint" : WriteObject(new InputEndpoint()); break;
                        case "VirtualMachineInputEndpointList" : WriteObject(new List<InputEndpoint>()); break;
                        case "VirtualMachineLoadBalancer" : WriteObject(new LoadBalancer()); break;
                        case "VirtualMachineLoadBalancerList" : WriteObject(new List<LoadBalancer>()); break;
                        case "VirtualMachineNetworkInterface" : WriteObject(new NetworkInterface()); break;
                        case "VirtualMachineNetworkInterfaceList" : WriteObject(new List<NetworkInterface>()); break;
                        case "VirtualMachineOSDiskConfiguration" : WriteObject(new OSDiskConfiguration()); break;
                        case "VirtualMachineOSImageComputeImageAttributes" : WriteObject(new ComputeImageAttributes()); break;
                        case "VirtualMachineOSImageCreateParameters" : WriteObject(new VirtualMachineOSImageCreateParameters()); break;
                        case "VirtualMachineOSImageMarketplaceImageAttributes" : WriteObject(new MarketplaceImageAttributes()); break;
                        case "VirtualMachineOSImagePlan" : WriteObject(new Plan()); break;
                        case "VirtualMachineOSImageReplicateParameters" : WriteObject(new VirtualMachineOSImageReplicateParameters()); break;
                        case "VirtualMachineOSImageUpdateParameters" : WriteObject(new VirtualMachineOSImageUpdateParameters()); break;
                        case "VirtualMachineOSVirtualHardDisk" : WriteObject(new OSVirtualHardDisk()); break;
                        case "VirtualMachinePublicIP" : WriteObject(new ConfigurationSet.PublicIP()); break;
                        case "VirtualMachinePublicIPList" : WriteObject(new List<ConfigurationSet.PublicIP>()); break;
                        case "VirtualMachineResourceExtensionReference" : WriteObject(new ResourceExtensionReference()); break;
                        case "VirtualMachineResourceExtensionReferenceList" : WriteObject(new List<ResourceExtensionReference>()); break;
                        case "VirtualMachineRole" : WriteObject(new Role()); break;
                        case "VirtualMachineRoleList" : WriteObject(new List<Role>()); break;
                        case "VirtualMachineShutdownParameters" : WriteObject(new VirtualMachineShutdownParameters()); break;
                        case "VirtualMachineShutdownRolesParameters" : WriteObject(new VirtualMachineShutdownRolesParameters()); break;
                        case "VirtualMachineSshSettingKeyPair" : WriteObject(new SshSettingKeyPair()); break;
                        case "VirtualMachineSshSettingKeyPairList" : WriteObject(new List<SshSettingKeyPair>()); break;
                        case "VirtualMachineSshSettingPublicKey" : WriteObject(new SshSettingPublicKey()); break;
                        case "VirtualMachineSshSettingPublicKeyList" : WriteObject(new List<SshSettingPublicKey>()); break;
                        case "VirtualMachineSshSettings" : WriteObject(new SshSettings()); break;
                        case "VirtualMachineStartRolesParameters" : WriteObject(new VirtualMachineStartRolesParameters()); break;
                        case "VirtualMachineStoredCertificateSettings" : WriteObject(new StoredCertificateSettings()); break;
                        case "VirtualMachineStoredCertificateSettingsList" : WriteObject(new List<StoredCertificateSettings>()); break;
                        case "VirtualMachineUpdateLoadBalancedSetParameters" : WriteObject(new VirtualMachineUpdateLoadBalancedSetParameters()); break;
                        case "VirtualMachineUpdateParameters" : WriteObject(new VirtualMachineUpdateParameters()); break;
                        case "VirtualMachineVMImageComputeImageAttributes" : WriteObject(new ComputeImageAttributes()); break;
                        case "VirtualMachineVMImageCreateParameters" : WriteObject(new VirtualMachineVMImageCreateParameters()); break;
                        case "VirtualMachineVMImageDataDiskConfigurationCreateParameters" : WriteObject(new DataDiskConfigurationCreateParameters()); break;
                        case "VirtualMachineVMImageDataDiskConfigurationCreateParametersList" : WriteObject(new List<DataDiskConfigurationCreateParameters>()); break;
                        case "VirtualMachineVMImageDataDiskConfigurationUpdateParameters" : WriteObject(new DataDiskConfigurationUpdateParameters()); break;
                        case "VirtualMachineVMImageDataDiskConfigurationUpdateParametersList" : WriteObject(new List<DataDiskConfigurationUpdateParameters>()); break;
                        case "VirtualMachineVMImageInput" : WriteObject(new VMImageInput()); break;
                        case "VirtualMachineVMImageMarketplaceImageAttributes" : WriteObject(new MarketplaceImageAttributes()); break;
                        case "VirtualMachineVMImageOSDiskConfigurationCreateParameters" : WriteObject(new OSDiskConfigurationCreateParameters()); break;
                        case "VirtualMachineVMImageOSDiskConfigurationUpdateParameters" : WriteObject(new OSDiskConfigurationUpdateParameters()); break;
                        case "VirtualMachineVMImagePlan" : WriteObject(new Plan()); break;
                        case "VirtualMachineVMImageReplicateParameters" : WriteObject(new VirtualMachineVMImageReplicateParameters()); break;
                        case "VirtualMachineVMImageUpdateParameters" : WriteObject(new VirtualMachineVMImageUpdateParameters()); break;
                        case "VirtualMachineWindowsRemoteManagementListener" : WriteObject(new WindowsRemoteManagementListener()); break;
                        case "VirtualMachineWindowsRemoteManagementListenerList" : WriteObject(new List<WindowsRemoteManagementListener>()); break;
                        case "VirtualMachineWindowsRemoteManagementSettings" : WriteObject(new WindowsRemoteManagementSettings()); break;
                        default : WriteWarning("Cannot find the type by name = '" + TypeName + "'."); break;
                    }
                }
            });
        }
    }
}
