using PackagesManagement.Tools;

namespace PackagesManagement.Commands
{
    public class DeletePackageCommand : ICommand
    {
        public DeletePackageCommand(int id)
        {
            PackageId = id;
        }
        public int PackageId { get; private set; }
    }
}