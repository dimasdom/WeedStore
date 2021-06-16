using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeedStore.MediatR.Command
{
    public class CreateNewCategoryCommand:IRequest<bool>
    {
        public CreateNewCategoryCommand(string name)
        {
            Name = name;
        }

        public string Name { get;set; }
    }
}
