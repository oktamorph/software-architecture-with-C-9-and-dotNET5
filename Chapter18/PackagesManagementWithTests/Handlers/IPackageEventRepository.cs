namespace PackagesManagement.Handlers
{
    public interface IPackageEventRepository
    {
        void New(object costChanged, int packageId, long oldVersion, long newVersion, decimal newPrice);
    }
}