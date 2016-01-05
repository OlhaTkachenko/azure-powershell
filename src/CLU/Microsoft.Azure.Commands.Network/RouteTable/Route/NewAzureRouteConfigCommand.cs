﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using System.Management.Automation;
using Microsoft.Azure.Commands.Network.Models;

namespace Microsoft.Azure.Commands.Network
{
    [Cmdlet(VerbsCommon.New, "AzureRmRouteConfig"), OutputType(typeof(PSRoute))]
    public class NewAzureRouteConfigCommand : AzureRouteConfigBase
    {
        public override void ExecuteCmdlet()
        {
            base.ExecuteCmdlet();

            var route = new PSRoute();

            route.Name = this.Name;
            route.AddressPrefix = this.AddressPrefix;
            route.NextHopType = this.NextHopType;
            route.NextHopIpAddress = this.NextHopIpAddress;

            WriteObject(route);
        }
    }
}
