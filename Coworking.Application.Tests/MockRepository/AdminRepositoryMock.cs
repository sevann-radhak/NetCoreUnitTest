using Api.DataAccess.Contracts.Entities;
using Api.DataAccess.Contracts.Repositories;
using Coworking.Application.Unit.Tests.Stubs;
using Moq;

namespace Coworking.Application.Unit.Tests.MockRepository
{
    public class AdminReposiory
    {
        public Mock<IAdminRepository> _adminRepository { get; set; }

        public AdminReposiory()
        {
            _adminRepository = new Mock<IAdminRepository>();
            Setup();
        }

        private void Setup()
        {
            _adminRepository.Setup(x => x.Add(It.IsAny<AdminEntity>())).ReturnsAsync(AdminStub.admin1);
            //_adminRepository.Setup(x => x.DeleteAsync(It.Is<int>(p => p.Equals(3)))).ReturnsAsync(Task.Delay(5));
            //_adminRepository.Setup(x => x.DeleteAsync(It.IsAny<int>())).Returns(AdminStub.admin1);
            _adminRepository.Setup(x => x.Exists(It.Is<int>(p => p.Equals(3)))).ReturnsAsync(true);
            _adminRepository.Setup(x => x.Get(It.IsAny<int>())).ReturnsAsync(AdminStub.admin1);
            _adminRepository.Setup(x => x.GetAll()).ReturnsAsync(AdminStub.adminList);
            _adminRepository.Setup(x => x.Update(It.IsAny<AdminEntity>())).ReturnsAsync(AdminStub.admin1);
        }
    }
}
