﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using conctactos.model;
using System.Threading.Tasks;

namespace conctactos.Data
{
    class FriendDatBase
    {
        private readonly SQLiteAsyncConnection database;
        public FriendDatBase(string dbPath)
        {
            database =new  SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<Friendmodel>().Wait();

        }
        public async Task<List<Friendmodel>> GetFriendsAsync()
        {
            return await database.Table<Friendmodel>().ToListAsync();
        }
        public List<Friendmodel> GetFriends(int id)
        {
            return database.Table<Friendmodel>().Where(f => f.ID == id).FirstOrDefaultAsync();
        }
        public Task<int> SavefriendAsync(Friendmodel friend)
        {
            if(friend.ID != 0)
            {
                return database.UpdateAllAsync(friend);
            }
            else
            {
                return database.InsertAsync(friend);
            }
        }
        public Task<int>DeleteFriendAsync( Friendmodel friend)
        {
            return database.DeleteAsync(friend);
        }
    }
}
