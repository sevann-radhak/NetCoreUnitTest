using Api.DataAccess.Contracts.Entities;
using System.Collections.Generic;

namespace Coworking.Application.Unit.Tests.Stubs
{
    public static class AdminStub
    {
        public static AdminEntity admin1 = new AdminEntity
        {
            Email = "email1@test.com",
            Id = 1,
            Name = "Name 1 Test",
            Phone = "1111111111"
        };

        public static AdminEntity admin2 = new AdminEntity
        {
            Email = "email2@test.com",
            Id = 1,
            Name = "Name 2 Test",
            Phone = "2222222222"
        };

        public static List<AdminEntity> adminList = new List<AdminEntity> { admin1, admin2 };
    }
}
