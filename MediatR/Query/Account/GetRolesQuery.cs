using MediatR;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace WeedStore.MediatR.Query
{
    public class GetRolesQuery : IRequest<List<IdentityRole>>
    {
    }
}
