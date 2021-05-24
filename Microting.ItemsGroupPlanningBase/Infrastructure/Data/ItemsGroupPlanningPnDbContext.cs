/*
The MIT License (MIT)

Copyright (c) 2007 - 2021 Microting A/S

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*/

namespace Microting.ItemsGroupPlanningBase.Infrastructure.Data
{
    using eFormApi.BasePn.Abstractions;
    using eFormApi.BasePn.Infrastructure.Database.Entities;
    using Entities;
    using Microsoft.EntityFrameworkCore;

    public class ItemsGroupPlanningPnDbContext: DbContext, IPluginDbContext
    {
        public ItemsGroupPlanningPnDbContext() { }

        public ItemsGroupPlanningPnDbContext(DbContextOptions<ItemsGroupPlanningPnDbContext> options) : base(options)
        {
        }

        // tables
        public DbSet<Item> Items { get; set; }
        public DbSet<ItemList> ItemLists { get; set; }
        public DbSet<ItemCase> ItemCases { get; set; }
        public DbSet<ItemCaseSite> ItemCaseSites { get; set; }
        public DbSet<UploadedData> UploadedDatas { get; set; }

        // versions table
        public DbSet<ItemVersion> ItemVersions { get; set;}
        public DbSet<ItemListVersion> ItemListVersions { get; set; }
        public DbSet<ItemCaseVersion> ItemCaseVersions { get; set; }
        public DbSet<ItemCaseSiteVersion> ItemCaseSiteVersions { get; set; }
        public DbSet<UploadedDataVersion> UploadedDataVersions { get; set; }
        
        // common tables
        public DbSet<PluginConfigurationValue> PluginConfigurationValues { get; set; }
        public DbSet<PluginConfigurationValueVersion> PluginConfigurationValueVersions { get; set; }
        public DbSet<PluginPermission> PluginPermissions { get; set; }
        public DbSet<PluginGroupPermission> PluginGroupPermissions { get; set; }
        public DbSet<PluginGroupPermissionVersion> PluginGroupPermissionVersions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }
}