using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeedStore.MediatR.Command
{
    public class DeleteCategoryCommand:IRequest<bool>
    {
        public DeleteCategoryCommand(string id)
        {
            Id = id;
        }

        public string Id { get; set; }
    }
}
