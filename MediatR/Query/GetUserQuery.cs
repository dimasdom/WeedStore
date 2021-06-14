using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeedStore.Models.User;

namespace WeedStore.MediatR.Query
{
    public class GetUserQuery:IRequest<UserModel>
    {
        public GetUserQuery(string userName)
        {
            UserName = userName;
        }

        public string UserName { get; set; }
    }
}
