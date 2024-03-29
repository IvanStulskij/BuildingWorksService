﻿namespace BuildingWorks.Repositories.Abstractions.Addresses
{
    public interface IAddressNamespaceRepository<T> : IRepository<T>
    {
        public T GetByName(string name);
    }
}
