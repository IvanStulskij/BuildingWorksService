﻿using BuildingWorks.Models.Overview;
using BuildingWorks.Models.Resources.Providers;
using BuildingWorks.UI.BlazorWebAssembly.Client.Services.Interfaces;

namespace BuildingWorks.UI.BlazorWebAssembly.Client.Services.Implementations
{
    public class ProviderService : OverviewService<ProviderForm, ProviderResource, ProviderOverview>, IProviderService
    {
        public ProviderService(HttpClient http) : base(http, "providers")
        {
        }
    }
}
