
# ----------------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# Code generated by Microsoft (R) AutoRest Code Generator.Changes may cause incorrect behavior and will be lost if the code
# is regenerated.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Create an in-memory object for ScaleRuleAuth.
.Description
Create an in-memory object for ScaleRuleAuth.

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ScaleRuleAuth
.Link
https://docs.microsoft.com/powershell/module/az./new-azcontainerappscaleruleauthobject
#>
function New-AzContainerAppScaleRuleAuthObject {
    [OutputType('Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ScaleRuleAuth')]
    [CmdletBinding(PositionalBinding=$false)]
    Param(

        [Parameter(HelpMessage="Name of the Container App secret from which to pull the auth params.")]
        [string]
        $SecretRef,
        [Parameter(HelpMessage="Trigger Parameter that uses the secret.")]
        [string]
        $TriggerParameter
    )

    process {
        $Object = [Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ScaleRuleAuth]::New()

        if ($PSBoundParameters.ContainsKey('SecretRef')) {
            $Object.SecretRef = $SecretRef
        }
        if ($PSBoundParameters.ContainsKey('TriggerParameter')) {
            $Object.TriggerParameter = $TriggerParameter
        }
        return $Object
    }
}

