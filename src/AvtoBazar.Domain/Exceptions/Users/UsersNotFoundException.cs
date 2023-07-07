namespace AvtoBazar.Domain.Exceptions.Users;

public class UsersNotFoundException : NotFoundException
{
    public UsersNotFoundException()
    {
        this.TitleMessage = "User not found";
    }

}
