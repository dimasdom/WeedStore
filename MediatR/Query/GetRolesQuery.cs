using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeedStore.MediatR.Query
{
    public class GetRolesQuery:IRequest<List<IdentityRole>>
    {
    }
}
