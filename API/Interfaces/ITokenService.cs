using System;
using API.Entities;
using SQLitePCL;

namespace API.Interfaces;

public interface ITokenService
{
    string CreateToken(AppUser user);

}
