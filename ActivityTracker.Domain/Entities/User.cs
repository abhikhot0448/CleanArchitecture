﻿namespace ActivityTracker.Domain.Entities;

public class User
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public DateTime Created_At { get; set; }
    public DateTime? Updated_At { get; set;}
}
