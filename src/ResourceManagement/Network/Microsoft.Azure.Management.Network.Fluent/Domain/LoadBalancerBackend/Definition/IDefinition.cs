// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
namespace Microsoft.Azure.Management.Network.Fluent.LoadBalancerBackend.Definition
{
    using Microsoft.Azure.Management.ResourceManager.Fluent.Core.ChildResource.Definition;

    /// <summary>
    /// The entirety of a load balancer backend definition.
    /// </summary>
    /// <typeparam name="ParentT">The return type of the final  DefinitionStages.WithAttach.attach().</typeparam>
    public interface IDefinition<ParentT>  :
        Microsoft.Azure.Management.Network.Fluent.LoadBalancerBackend.Definition.IBlank<ParentT>,
        Microsoft.Azure.Management.Network.Fluent.LoadBalancerBackend.Definition.IWithAttach<ParentT>
    {
    }

    /// <summary>
    /// The first stage of a load balancer backend definition.
    /// </summary>
    /// <typeparam name="ParentT">The stage of the parent definition to return to after attaching this definition.</typeparam>
    public interface IBlank<ParentT>  :
        Microsoft.Azure.Management.Network.Fluent.LoadBalancerBackend.Definition.IWithAttach<ParentT>
    {
    }

    /// <summary>
    /// The final stage of a load balancer backend definition.
    /// At this stage, any remaining optional settings can be specified, or the definition
    /// can be attached to the parent load balancer definition using  WithAttach.attach().
    /// </summary>
    /// <typeparam name="ParentT">The return type of  WithAttach.attach().</typeparam>
    public interface IWithAttach<ParentT>  :
        Microsoft.Azure.Management.ResourceManager.Fluent.Core.ChildResource.Definition.IInDefinition<ParentT>
    {
    }
}