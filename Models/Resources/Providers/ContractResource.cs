﻿using BuildingWorks.Common.Extensions;

namespace BuildingWorks.Models.Resources.Providers
{
    public class ContractResource : ContractForm, IResource
    {
        public int Id { get; set; }
    }

    public class ContractForm
    {
        public string Conditions { get; set; }

        public int ProviderId { get; set; }
    }
}
