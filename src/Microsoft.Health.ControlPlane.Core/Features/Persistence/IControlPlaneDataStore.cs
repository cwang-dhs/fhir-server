﻿// -------------------------------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

using System.Threading;
using System.Threading.Tasks;
using Microsoft.Health.ControlPlane.Core.Features.Rbac;
using Microsoft.Health.ControlPlane.Core.Features.Rbac.Roles;

namespace Microsoft.Health.ControlPlane.Core.Features.Persistence
{
    public interface IControlPlaneDataStore
    {
        Task<IdentityProvider> GetIdentityProviderAsync(string name, CancellationToken cancellationToken);

        Task<IdentityProvider> UpsertIdentityProviderAsync(IdentityProvider identityProvider, CancellationToken cancellationToken);

        Task<Role> GetRoleAsync(string name, CancellationToken cancellationToken);

        Task<Role> UpsertRoleAsync(Role role, CancellationToken cancellationToken);

        Task<Role> AddRoleAsync(Role role, CancellationToken cancellationToken);
    }
}
