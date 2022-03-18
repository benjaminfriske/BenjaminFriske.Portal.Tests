
using BenjaminFriske.Portal.Models;
using Bogus;

namespace BenjaminFriske.Portal.Tests.Fakes.Models;

public static class UserModelFake {
    public static UserModel CreateUser() {
        UserModel model = new Faker<UserModel>();
        return new UserModel();
    }
}
