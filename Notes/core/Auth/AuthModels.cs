using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.core.Auth;

record UserCredsDto
{
    public string login { get; init; }
    public string password { get; init; }
}

interface IAuthRepo
{
    public bool loginInUse(string login);
    public bool passwordInUse(string password);
    public bool validateCreds(UserCredsDto dto);
    public void createUser(UserCredsDto dto);
    public int getIdByCreds(UserCredsDto dto);
}