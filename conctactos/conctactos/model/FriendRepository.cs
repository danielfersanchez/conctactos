using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace conctactos.model
{
   class FriendRepository
    {
    

        public FriendRepository()
        {
            Task.Run(async () => 
            friends = await App.Database.GetFriendsAsync()).Wait();
        }

    }

}
