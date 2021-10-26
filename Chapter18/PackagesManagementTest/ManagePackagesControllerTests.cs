using Microsoft.AspNetCore.Mvc;
using Moq;
using PackagesManagement.Commands;
using PackagesManagement.Controllers;
using PackagesManagement.Models;
using PackagesManagement.Tools;
using System.Threading.Tasks;
using Xunit;

namespace PackagesManagementTest
{
    public class ManagePackagesControllerTests
    {
        [Fact]
        public async Task DeletePostValidationFailedTest()
        {
            var controller = new ManagePackagesController();
            controller.ModelState
                .AddModelError("Name", "fake error");
            var vm = new PackageFullEditViewModel();
            var result = await controller.Edit(vm, null);
            var viewResult = Assert.IsType<ViewResult>(result);
            Assert.Equal(vm, viewResult.Model);
        }

        [Fact]
        public async Task DeletePostSuccessTest()
        {
            var controller = new ManagePackagesController();
            var commandDependency = new Mock<ICommandHandler<UpdatePackageCommand>>();
            commandDependency
                .Setup(m => m.HandleAsync(It.IsAny<UpdatePackageCommand>()))
                .Returns(Task.CompletedTask);
            var vm = new PackageFullEditViewModel();
            var result = await controller.Edit(vm, commandDependency.Object);
            commandDependency.Verify(m => m.HandleAsync(
                It.IsAny<UpdatePackageCommand>()),
                Times.Once);
            var redirectResult = Assert.IsType<RedirectToActionResult>(result);
            Assert.Equal(nameof(ManagePackagesController.Index), redirectResult.ActionName);
            Assert.Null(redirectResult.ControllerName);
        }

    }
}
