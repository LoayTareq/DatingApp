using System;

namespace API.Entities;

public class AppUser
{
    //guid is a global unique id
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public required string DisplayName { get; set; }
    public required string Email { get; set; }
}
