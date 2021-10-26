using PackagesManagement.Tools;
using PackagesManagementDomain.DTOs;

namespace PackagesManagement.Commands
{
    public class CreatePackageCommand : ICommand
    {
        public CreatePackageCommand(IPackageFullEditDTO values)
        {
            Values = values;
        }
        public IPackageFullEditDTO Values { get; private set; }
    }
}