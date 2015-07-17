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
    [Cmdlet(VerbsLifecycle.Invoke, "AzureComputeMethod")]
    [OutputType(typeof(object))]
    public partial class InvokeAzureComputeMethodCmdlet : ComputeAutomationBaseCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
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
        public string Name { get; set; }

        [Parameter(Position = 1)]
        public object[] Parameter { get; set; }

        protected object ParseParameter(object input)
        {
            if (input is PSObject)
            {
                return (input as PSObject).BaseObject;
            }
            else
            {
                return input;
            }
        }

        public override void ExecuteCmdlet()
        {
            base.ExecuteCmdlet();
            ExecuteClientAction(() =>
            {
                switch (Name)
                {
                    case "DeploymentChangeConfigurationByName" : ExecuteDeploymentChangeConfigurationByNameMethod(Parameter); break;
                    case "DeploymentChangeConfigurationBySlot" : ExecuteDeploymentChangeConfigurationBySlotMethod(Parameter); break;
                    case "DeploymentCreate" : ExecuteDeploymentCreateMethod(Parameter); break;
                    case "DeploymentDeleteByName" : ExecuteDeploymentDeleteByNameMethod(Parameter); break;
                    case "DeploymentDeleteBySlot" : ExecuteDeploymentDeleteBySlotMethod(Parameter); break;
                    case "DeploymentDeleteRoleInstanceByDeploymentName" : ExecuteDeploymentDeleteRoleInstanceByDeploymentNameMethod(Parameter); break;
                    case "DeploymentDeleteRoleInstanceByDeploymentSlot" : ExecuteDeploymentDeleteRoleInstanceByDeploymentSlotMethod(Parameter); break;
                    case "DeploymentGetByName" : ExecuteDeploymentGetByNameMethod(Parameter); break;
                    case "DeploymentGetBySlot" : ExecuteDeploymentGetBySlotMethod(Parameter); break;
                    case "DeploymentGetPackageByName" : ExecuteDeploymentGetPackageByNameMethod(Parameter); break;
                    case "DeploymentGetPackageBySlot" : ExecuteDeploymentGetPackageBySlotMethod(Parameter); break;
                    case "DeploymentListEvents" : ExecuteDeploymentListEventsMethod(Parameter); break;
                    case "DeploymentListEventsBySlot" : ExecuteDeploymentListEventsBySlotMethod(Parameter); break;
                    case "DeploymentRebootRoleInstanceByDeploymentName" : ExecuteDeploymentRebootRoleInstanceByDeploymentNameMethod(Parameter); break;
                    case "DeploymentRebootRoleInstanceByDeploymentSlot" : ExecuteDeploymentRebootRoleInstanceByDeploymentSlotMethod(Parameter); break;
                    case "DeploymentRebuildRoleInstanceByDeploymentName" : ExecuteDeploymentRebuildRoleInstanceByDeploymentNameMethod(Parameter); break;
                    case "DeploymentRebuildRoleInstanceByDeploymentSlot" : ExecuteDeploymentRebuildRoleInstanceByDeploymentSlotMethod(Parameter); break;
                    case "DeploymentReimageRoleInstanceByDeploymentName" : ExecuteDeploymentReimageRoleInstanceByDeploymentNameMethod(Parameter); break;
                    case "DeploymentReimageRoleInstanceByDeploymentSlot" : ExecuteDeploymentReimageRoleInstanceByDeploymentSlotMethod(Parameter); break;
                    case "DeploymentRollbackUpdateOrUpgradeByDeploymentName" : ExecuteDeploymentRollbackUpdateOrUpgradeByDeploymentNameMethod(Parameter); break;
                    case "DeploymentRollbackUpdateOrUpgradeByDeploymentSlot" : ExecuteDeploymentRollbackUpdateOrUpgradeByDeploymentSlotMethod(Parameter); break;
                    case "DeploymentSwap" : ExecuteDeploymentSwapMethod(Parameter); break;
                    case "DeploymentUpdateStatusByDeploymentName" : ExecuteDeploymentUpdateStatusByDeploymentNameMethod(Parameter); break;
                    case "DeploymentUpdateStatusByDeploymentSlot" : ExecuteDeploymentUpdateStatusByDeploymentSlotMethod(Parameter); break;
                    case "DeploymentUpgradeByName" : ExecuteDeploymentUpgradeByNameMethod(Parameter); break;
                    case "DeploymentUpgradeBySlot" : ExecuteDeploymentUpgradeBySlotMethod(Parameter); break;
                    case "DeploymentWalkUpgradeDomainByDeploymentName" : ExecuteDeploymentWalkUpgradeDomainByDeploymentNameMethod(Parameter); break;
                    case "DeploymentWalkUpgradeDomainByDeploymentSlot" : ExecuteDeploymentWalkUpgradeDomainByDeploymentSlotMethod(Parameter); break;
                    case "DNSServerAddDNSServer" : ExecuteDNSServerAddDNSServerMethod(Parameter); break;
                    case "DNSServerDeleteDNSServer" : ExecuteDNSServerDeleteDNSServerMethod(Parameter); break;
                    case "DNSServerUpdateDNSServer" : ExecuteDNSServerUpdateDNSServerMethod(Parameter); break;
                    case "ExtensionImageRegister" : ExecuteExtensionImageRegisterMethod(Parameter); break;
                    case "ExtensionImageUnregister" : ExecuteExtensionImageUnregisterMethod(Parameter); break;
                    case "ExtensionImageUpdate" : ExecuteExtensionImageUpdateMethod(Parameter); break;
                    case "HostedServiceAddExtension" : ExecuteHostedServiceAddExtensionMethod(Parameter); break;
                    case "HostedServiceCheckNameAvailability" : ExecuteHostedServiceCheckNameAvailabilityMethod(Parameter); break;
                    case "HostedServiceCreate" : ExecuteHostedServiceCreateMethod(Parameter); break;
                    case "HostedServiceDelete" : ExecuteHostedServiceDeleteMethod(Parameter); break;
                    case "HostedServiceDeleteAll" : ExecuteHostedServiceDeleteAllMethod(Parameter); break;
                    case "HostedServiceDeleteExtension" : ExecuteHostedServiceDeleteExtensionMethod(Parameter); break;
                    case "HostedServiceGet" : ExecuteHostedServiceGetMethod(Parameter); break;
                    case "HostedServiceGetDetailed" : ExecuteHostedServiceGetDetailedMethod(Parameter); break;
                    case "HostedServiceGetExtension" : ExecuteHostedServiceGetExtensionMethod(Parameter); break;
                    case "HostedServiceList" : ExecuteHostedServiceListMethod(Parameter); break;
                    case "HostedServiceListAvailableExtensions" : ExecuteHostedServiceListAvailableExtensionsMethod(Parameter); break;
                    case "HostedServiceListExtensions" : ExecuteHostedServiceListExtensionsMethod(Parameter); break;
                    case "HostedServiceListExtensionVersions" : ExecuteHostedServiceListExtensionVersionsMethod(Parameter); break;
                    case "HostedServiceUpdate" : ExecuteHostedServiceUpdateMethod(Parameter); break;
                    case "LoadBalancerCreate" : ExecuteLoadBalancerCreateMethod(Parameter); break;
                    case "LoadBalancerDelete" : ExecuteLoadBalancerDeleteMethod(Parameter); break;
                    case "LoadBalancerUpdate" : ExecuteLoadBalancerUpdateMethod(Parameter); break;
                    case "OperatingSystemList" : ExecuteOperatingSystemListMethod(Parameter); break;
                    case "OperatingSystemListFamilies" : ExecuteOperatingSystemListFamiliesMethod(Parameter); break;
                    case "ServiceCertificateCreate" : ExecuteServiceCertificateCreateMethod(Parameter); break;
                    case "ServiceCertificateDelete" : ExecuteServiceCertificateDeleteMethod(Parameter); break;
                    case "ServiceCertificateGet" : ExecuteServiceCertificateGetMethod(Parameter); break;
                    case "ServiceCertificateList" : ExecuteServiceCertificateListMethod(Parameter); break;
                    case "VirtualMachineDiskCreateDataDisk" : ExecuteVirtualMachineDiskCreateDataDiskMethod(Parameter); break;
                    case "VirtualMachineDiskCreateDisk" : ExecuteVirtualMachineDiskCreateDiskMethod(Parameter); break;
                    case "VirtualMachineDiskDeleteDataDisk" : ExecuteVirtualMachineDiskDeleteDataDiskMethod(Parameter); break;
                    case "VirtualMachineDiskDeleteDisk" : ExecuteVirtualMachineDiskDeleteDiskMethod(Parameter); break;
                    case "VirtualMachineDiskGetDataDisk" : ExecuteVirtualMachineDiskGetDataDiskMethod(Parameter); break;
                    case "VirtualMachineDiskGetDisk" : ExecuteVirtualMachineDiskGetDiskMethod(Parameter); break;
                    case "VirtualMachineDiskListDisks" : ExecuteVirtualMachineDiskListDisksMethod(Parameter); break;
                    case "VirtualMachineDiskUpdateDataDisk" : ExecuteVirtualMachineDiskUpdateDataDiskMethod(Parameter); break;
                    case "VirtualMachineDiskUpdateDisk" : ExecuteVirtualMachineDiskUpdateDiskMethod(Parameter); break;
                    case "VirtualMachineDiskUpdateDiskSize" : ExecuteVirtualMachineDiskUpdateDiskSizeMethod(Parameter); break;
                    case "VirtualMachineExtensionList" : ExecuteVirtualMachineExtensionListMethod(Parameter); break;
                    case "VirtualMachineExtensionListVersions" : ExecuteVirtualMachineExtensionListVersionsMethod(Parameter); break;
                    case "VirtualMachineCaptureOSImage" : ExecuteVirtualMachineCaptureOSImageMethod(Parameter); break;
                    case "VirtualMachineCaptureVMImage" : ExecuteVirtualMachineCaptureVMImageMethod(Parameter); break;
                    case "VirtualMachineCreate" : ExecuteVirtualMachineCreateMethod(Parameter); break;
                    case "VirtualMachineCreateDeployment" : ExecuteVirtualMachineCreateDeploymentMethod(Parameter); break;
                    case "VirtualMachineDelete" : ExecuteVirtualMachineDeleteMethod(Parameter); break;
                    case "VirtualMachineGet" : ExecuteVirtualMachineGetMethod(Parameter); break;
                    case "VirtualMachineGetRemoteDesktopFile" : ExecuteVirtualMachineGetRemoteDesktopFileMethod(Parameter); break;
                    case "VirtualMachineRestart" : ExecuteVirtualMachineRestartMethod(Parameter); break;
                    case "VirtualMachineShutdown" : ExecuteVirtualMachineShutdownMethod(Parameter); break;
                    case "VirtualMachineShutdownRoles" : ExecuteVirtualMachineShutdownRolesMethod(Parameter); break;
                    case "VirtualMachineStart" : ExecuteVirtualMachineStartMethod(Parameter); break;
                    case "VirtualMachineStartRoles" : ExecuteVirtualMachineStartRolesMethod(Parameter); break;
                    case "VirtualMachineUpdate" : ExecuteVirtualMachineUpdateMethod(Parameter); break;
                    case "VirtualMachineUpdateLoadBalancedEndpointSet" : ExecuteVirtualMachineUpdateLoadBalancedEndpointSetMethod(Parameter); break;
                    case "VirtualMachineOSImageCreate" : ExecuteVirtualMachineOSImageCreateMethod(Parameter); break;
                    case "VirtualMachineOSImageDelete" : ExecuteVirtualMachineOSImageDeleteMethod(Parameter); break;
                    case "VirtualMachineOSImageGet" : ExecuteVirtualMachineOSImageGetMethod(Parameter); break;
                    case "VirtualMachineOSImageGetDetails" : ExecuteVirtualMachineOSImageGetDetailsMethod(Parameter); break;
                    case "VirtualMachineOSImageList" : ExecuteVirtualMachineOSImageListMethod(Parameter); break;
                    case "VirtualMachineOSImageReplicate" : ExecuteVirtualMachineOSImageReplicateMethod(Parameter); break;
                    case "VirtualMachineOSImageShare" : ExecuteVirtualMachineOSImageShareMethod(Parameter); break;
                    case "VirtualMachineOSImageUnreplicate" : ExecuteVirtualMachineOSImageUnreplicateMethod(Parameter); break;
                    case "VirtualMachineOSImageUpdate" : ExecuteVirtualMachineOSImageUpdateMethod(Parameter); break;
                    case "VirtualMachineVMImageCreate" : ExecuteVirtualMachineVMImageCreateMethod(Parameter); break;
                    case "VirtualMachineVMImageDelete" : ExecuteVirtualMachineVMImageDeleteMethod(Parameter); break;
                    case "VirtualMachineVMImageGetDetails" : ExecuteVirtualMachineVMImageGetDetailsMethod(Parameter); break;
                    case "VirtualMachineVMImageList" : ExecuteVirtualMachineVMImageListMethod(Parameter); break;
                    case "VirtualMachineVMImageReplicate" : ExecuteVirtualMachineVMImageReplicateMethod(Parameter); break;
                    case "VirtualMachineVMImageShare" : ExecuteVirtualMachineVMImageShareMethod(Parameter); break;
                    case "VirtualMachineVMImageUnreplicate" : ExecuteVirtualMachineVMImageUnreplicateMethod(Parameter); break;
                    case "VirtualMachineVMImageUpdate" : ExecuteVirtualMachineVMImageUpdateMethod(Parameter); break;
                    default : WriteWarning("Cannot find the method by name = '" + Name + "'."); break;
                }
            });
        }
    }
}
