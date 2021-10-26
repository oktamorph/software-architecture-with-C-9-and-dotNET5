﻿namespace PackagesManagementDomain.Events
{
    public class PackagePriceChangedEvent : IEventNotification
    {
        public PackagePriceChangedEvent(int id, decimal price, long oldVersion, long newVersion)
        {
            PackageId = id;
            NewPrice = price;
            OldVersion = oldVersion;
            NewVersion = newVersion;
        }
        public int PackageId { get; }
        public decimal NewPrice { get; }
        public long OldVersion { get; }
        public long NewVersion { get; }
    }

}
