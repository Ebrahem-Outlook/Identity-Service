﻿
using Identity_Domain.Core.BaseType;
using Identity_Domain.Users.ValueObjects;

namespace Identity_Domain.Users;

public sealed class User : AggregateRoot
{
    private User(FirstName firstName, LastName lastName, Email email, Password password) : base(Guid.NewGuid())
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        Password = password;
    }

    private User() { }

    public FirstName FirstName{ get; private set; } = default!;
    public LastName LastName { get; private set; } = default!;
    public Email Email { get; private set; } = default!;
    public Password Password { get; private set; } = default!;

    public static User Create(FirstName firstName, LastName lastName, Email email, Password password)
    {
        User user = new User(firstName, lastName, email, password);

        return user;
    }
}
