namespace ConsoleAppTestsEamples;

public interface ITableUsers
{
    User FindUserByLoginAndPassword(string login, string password);
}