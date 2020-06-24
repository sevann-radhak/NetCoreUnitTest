using Api.DataAccess.Contracts.Repositories;
using Coworking.Application.Configuration;
using Coworking.Application.Contracts.Services;
using Coworking.Application.Services;
using Coworking.Application.Unit.Tests.Config;
using Coworking.Application.Unit.Tests.MockRepository;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Threading.Tasks;

namespace Coworking.Application.Unit.Tests
{
    [TestClass]
    public class AdminServiceTest
    {
        private static IAdminService _adminService;

        [ClassInitialize()]
        public static void Setup(TestContext context)
        {
            Mock<IAdminRepository> _adminRepository = new AdminReposiory()._adminRepository;
            Mock<IAppConfig> _appConfig = new AppConfigMock()._appConfig;

            //TODO: change to inject
            _adminService = new AdminService(_adminRepository.Object, _appConfig.Object);
        }

        [TestMethod]
        public async Task GetAdminById_Ok()
        {
            // prepare

            // eject
            var result = await _adminService.GetAdmin(3);

            // asserts
            result.Id.Should().NotBe(2);
            result.Name.Should().NotBeNullOrEmpty();
            result.Name.Should().Be("Name 1 Test");
        }

        [TestMethod]
        public async Task GetAllAdmins_Ok()
        {
            // prepare

            // eject
            var result = await _adminService.GetAllAdmins();

            // asserts
            result.Should().NotBeNullOrEmpty();
            result.Should().HaveCountGreaterOrEqualTo(1);
        }
    }
}
