// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
namespace Microsoft.Azure.Management.Network.Fluent
{
    using Microsoft.Azure.Management.Network.Fluent.Models;
    using Microsoft.Azure.Management.ResourceManager.Fluent.Core;

    /// <summary>
    /// An immutable client-side representation of an application gateway's HTTP listener.
    /// </summary>
    /// <remarks>
    /// (Beta: This functionality is in preview and as such is subject to change in non-backwards compatible ways in
    /// future releases, including removal, regardless of any compatibility expectations set by the containing library
    /// version number.).
    /// </remarks>
    public interface IApplicationGatewayListener  :
        Microsoft.Azure.Management.ResourceManager.Fluent.Core.IHasInner<Models.ApplicationGatewayHttpListenerInner>,
        Microsoft.Azure.Management.ResourceManager.Fluent.Core.IChildResource<Microsoft.Azure.Management.Network.Fluent.IApplicationGateway>,
        Microsoft.Azure.Management.Network.Fluent.IHasSslCertificate<Microsoft.Azure.Management.Network.Fluent.IApplicationGatewaySslCertificate>,
        Microsoft.Azure.Management.Network.Fluent.IHasPublicIPAddress,
        Microsoft.Azure.Management.Network.Fluent.IHasProtocol<Models.ApplicationGatewayProtocol>,
        Microsoft.Azure.Management.Network.Fluent.IHasHostName,
        Microsoft.Azure.Management.Network.Fluent.IHasServerNameIndication,
        Microsoft.Azure.Management.ResourceManager.Fluent.Core.IHasSubnet
    {
        /// <summary>
        /// Gets the frontend IP configuration this listener is associated with.
        /// </summary>
        Microsoft.Azure.Management.Network.Fluent.IApplicationGatewayFrontend Frontend { get; }

        /// <summary>
        /// Gets the name of the frontend port the listener is listening on.
        /// </summary>
        string FrontendPortName { get; }

        /// <summary>
        /// Gets the number of the frontend port the listener is listening on.
        /// </summary>
        int FrontendPortNumber { get; }
    }
}