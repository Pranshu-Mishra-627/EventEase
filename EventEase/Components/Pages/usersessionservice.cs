public class UserSessionService
{
    public string UserName { get; private set; }

    public void SetUser (string userName)
    {
        UserName = userName;
    }

    public void ClearUser ()
    {
        UserName = null;
    }
}
   