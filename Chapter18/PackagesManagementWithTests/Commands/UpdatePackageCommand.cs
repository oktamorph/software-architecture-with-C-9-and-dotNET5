using PackagesManagement.Tools;
using PackagesManagementDomain.DTOs;

namespace PackagesManagement.Commands
{
    public class UpdatePackageCommand : ICommand
    {
        public UpdatePackageCommand(IPackageFullEditDTO updates)
        {
            Updates = updates;
        }
        public IPackageFullEditDTO Updates { get; private set; }
    }
}
