namespace PackagesManagementDomain.Aggregates
{
    public interface IEntity<T>
    {
        int Id { get; set; }
    }

}