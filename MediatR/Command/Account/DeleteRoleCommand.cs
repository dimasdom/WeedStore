using MediatR;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

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
