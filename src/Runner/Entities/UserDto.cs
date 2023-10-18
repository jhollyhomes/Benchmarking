namespace Runner.Entities;

public class UserDto
{
    public UserDto()
    {
        UserId = 0;
        FirstName = string.Empty;
        LastName = string.Empty;
        Email = string.Empty;
    }

    public UserDto(int id, string firstName, string lastName, string email)
    {
        UserId = id;
        FirstName = firstName;
        LastName = lastName;
        Email = email;
    }

    public int UserId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
}