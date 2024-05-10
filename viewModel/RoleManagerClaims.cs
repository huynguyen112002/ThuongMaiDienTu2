﻿using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Security.Claims;

namespace CuaHangCongNghe.Models
{
    public class RoleManagerClaims
    {
     public  string  name     { get; set; }

     public List<IdentityRole> Role { get; set; }

    }
}
