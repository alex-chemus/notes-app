using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.core.Auth;

class AuthService
{
    IAuthRepo authRepo;

    public AuthService(IAuthRepo authRepo)
    {
        this.authRepo = authRepo;
    }

    public int login(UserCredsDto dto)
    {

        bool valid = authRepo.validateCreds(dto);

        if (!valid) throw new Exception();

        return authRepo.getIdByCreds(dto);
    }

    public int register(UserCredsDto dto)
    {
        bool loginInUse = authRepo.loginInUse(dto.login);
        bool passwordInUse = authRepo.passwordInUse(dto.password);

        if (loginInUse || passwordInUse) throw new Exception();
            
        authRepo.createUser(dto);

        return authRepo.getIdByCreds(dto);
    }
}
