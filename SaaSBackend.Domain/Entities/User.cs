 public enum UserRole
    {
        Admin,
        User
    } 

public class User
{
    public Guid ID {get; set;}
    public string Email {get; set;}
    public string PasswordHash {get; set;}
    public int OrgID {get; set;}
    public UserRole Role {get; set;}

}