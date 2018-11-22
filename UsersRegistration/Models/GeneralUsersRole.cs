using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UsersRegistration.Models
{
    public class GeneralUsersRole
    {
        public Users myusers { get; set; }
        public Role roleOfUser { get; set; }

        public List<GeneralUsersRole> mylist = new List<GeneralUsersRole>();


        public void AddUsers(GeneralUsersRole user)
        {
            user.myusers.Id = (mylist.Any() ? mylist.Max(i => i.myusers.Id):0) + 1;
            mylist.Add(user);
        }

    }
}