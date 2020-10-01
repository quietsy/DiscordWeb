using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DiscordWeb.Data
{
    public class DiscordDAL
    {
        #region Private members
        private DiscordDbContext dbContext;
        #endregion

        #region Constructor
        public DiscordDAL(DiscordDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        #endregion

        #region Public methods
        public async Task<List<string>> GetDiscordChannelsAsync()
        {
            return await dbContext.DiscordEntries.Select(x => x.ChannelName).Distinct().ToListAsync();
        }

        public async Task<List<DiscordEntry>> GetDiscordEntriesAsync()
        {
            return await dbContext.DiscordEntries.ToListAsync();
        }

        public async Task<List<DiscordEntry>> GetDiscordEntriesByChannelAsync(string channel)
        {
            if (string.IsNullOrEmpty(channel)) return await GetDiscordEntriesAsync();
            return await dbContext.DiscordEntries.Where(x => x.ChannelName == channel).ToListAsync();
        }

        public async Task<DiscordEntry> AddDiscordEntryAsync(DiscordEntry discordEntry)
        {
            try
            {
                dbContext.DiscordEntries.Add(discordEntry);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
            return discordEntry;
        }

        public async Task<ActionResult<DiscordEntry>> GetDiscordEntryByMessageAsync(string message)
        {
            return await dbContext.DiscordEntries.FirstOrDefaultAsync(p => p.Message == message);
        }

        public async Task<DiscordEntry> UpdateDiscordEntryAsync(DiscordEntry discordEntry)
        {
            try
            {
                var entry = dbContext.DiscordEntries.FirstOrDefault(p => p.Id == discordEntry.Id);
                if (entry != null)
                {
                    dbContext.Update(discordEntry);
                    await dbContext.SaveChangesAsync();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return discordEntry;
        }

        public async Task<DiscordEntry> GetDiscordEntryAsync(int id)
        {
            return await dbContext.DiscordEntries.FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task DeleteDiscordEntryAsync(int id)
        {
            try
            {
                var entry = dbContext.DiscordEntries.FirstOrDefault(p => p.Id == id);
                if (entry != null)
                {
                    dbContext.DiscordEntries.Remove(entry);
                    await dbContext.SaveChangesAsync();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion
    }
}
