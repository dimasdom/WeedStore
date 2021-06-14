using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeedStore.MediatR.Command
{
    public class DeleteRoleCommand : IRequest<List<IdentityRole>>
    {
        public DeleteRoleCommand(string id)
        {
            Id = id;
        }

        public string Id { get; set; }
    }
}
