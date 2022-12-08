using ConsoleAppTestsEamples;
using Moq;

namespace ConsoleAppTestsEamplesTest;

public class AuthServiceTest
{
    // public class FakeTableUsers : ITableUsers
    // {
    //     public User FindUserByLoginAndPassword(string login, string password)
    //     {
    //         return new User() { Login = "admin", Password = "admin", Role = "admin" };
    //     }
    // }

    [Fact]
    public void AuthByLoginAndPassword_AdminAdmin_ReturnTrue()
    {
        //arrange //give //подготовка
        //AuthService authService = new AuthService(new FakeTableUsers());

        Mock<ITableUsers> tableUsers = new Mock<ITableUsers>();

        tableUsers.Setup(x => x.FindUserByLoginAndPassword("admin", "admin"))
            .Returns(new User() { Role = "admin" });

        AuthService authService = new AuthService(tableUsers.Object);
        
        //act //when //тестирование
        bool expected = true;
        bool actual = authService.AuthByLoginAndPassword("admin", "admin");

        //aasert //than //проверка
       
        //Assert.Equal(expected, actual);
        
        Assert.True(actual);
    }
}