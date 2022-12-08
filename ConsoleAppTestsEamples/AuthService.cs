namespace ConsoleAppTestsEamples;

public class AuthService
{
    private ITableUsers _tableUsers;

    public AuthService(ITableUsers tableUsers)
    {
        _tableUsers = tableUsers;
    }

    public bool AuthByLoginAndPassword(string login, string password)
    {
        User user = _tableUsers.FindUserByLoginAndPassword(login, password);

        if (user == null)
        {
            throw new Exception("user not found");
        }

        if (user.Role != "admin")
        {
            throw new Exception("user have not access");
        }

        return true;
    }
}