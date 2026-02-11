public class Organization
{
    public Guid ID {get; set;}
    public string OrgName {get; set;}
    public List<User> Users { get; set; } = new();
}