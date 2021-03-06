namespace Microting.ItemsGroupPlanningBase.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using eForm.Infrastructure.Constants;
    using Infrastructure.Data.Entities;
    using Microsoft.EntityFrameworkCore;
    using NUnit.Framework;

    [TestFixture]
    public class UploadedDataUTest : DbTestFixture
    {
        [Test]
        public async Task UploadedData_Create_DoesCreate()
        {
            //Arrange
            ItemList itemList = new ItemList
            {
                Name = Guid.NewGuid().ToString()
            };

            await itemList.Create(DbContext);
            
            Item item = new Item
            {
                Name = Guid.NewGuid().ToString(),
                Description = Guid.NewGuid().ToString(),
                Enabled = true,
                ItemListId = itemList.Id,
            };
            
            await item.Create(DbContext);
            
            ItemCase itemCase = new ItemCase
            {
                MicrotingSdkSiteId = 24,
                MicrotingSdkCaseId = 34,
                MicrotingSdkeFormId = 234,
                Status = 66,
                ItemId = item.Id,
            };

            await itemCase.Create(DbContext);
            
            UploadedData uploadedData = new UploadedData
            {
                ItemCaseId   = itemCase.Id,
                Checksum = Guid.NewGuid().ToString(),
                Extension = Guid.NewGuid().ToString(),
                CurrentFile = Guid.NewGuid().ToString(),
                UploaderType = Guid.NewGuid().ToString(),
                FileLocation = Guid.NewGuid().ToString(),
                FileName = Guid.NewGuid().ToString()
            };
            //Act
            await uploadedData.Create(DbContext);

            UploadedData dbUploadedData = DbContext.UploadedDatas.AsNoTracking().First();
            List<UploadedData> uploadedDataList = DbContext.UploadedDatas.AsNoTracking().ToList();
            List<UploadedDataVersion> uploadedDataVersionList = DbContext.UploadedDataVersions.AsNoTracking().ToList();
            //Assert
            Assert.NotNull(dbUploadedData);
            
            Assert.AreEqual(1, uploadedDataList.Count);
            Assert.AreEqual(1, uploadedDataVersionList.Count);
            
            Assert.AreEqual(uploadedData.Checksum, dbUploadedData.Checksum);
            Assert.AreEqual(uploadedData.Extension, dbUploadedData.Extension);
            Assert.AreEqual(uploadedData.CurrentFile, dbUploadedData.CurrentFile);
            Assert.AreEqual(uploadedData.UploaderType, dbUploadedData.UploaderType);
            Assert.AreEqual(uploadedData.FileLocation, dbUploadedData.FileLocation);
            Assert.AreEqual(uploadedData.FileName, dbUploadedData.FileName);
            Assert.AreEqual(uploadedData.ItemCaseId, dbUploadedData.ItemCaseId);
        }

        [Test]
        public async Task UploadedData_Update_DoesUpdate()
        {
             //Arrange
            ItemList itemList = new ItemList
            {
                Name = Guid.NewGuid().ToString()
            };

            await itemList.Create(DbContext);
            
            Item item = new Item
            {
                Name = Guid.NewGuid().ToString(),
                Description = Guid.NewGuid().ToString(),
                Enabled = true,
                ItemListId = itemList.Id,
            };
            
            await item.Create(DbContext);
            
            ItemCase itemCase = new ItemCase
            {
                MicrotingSdkSiteId = 24,
                MicrotingSdkCaseId = 34,
                MicrotingSdkeFormId = 234,
                Status = 66,
                ItemId = item.Id,
            };

            await itemCase.Create(DbContext);
            
            UploadedData uploadedData = new UploadedData
            {
                ItemCaseId   = itemCase.Id,
                Checksum = Guid.NewGuid().ToString(),
                Extension = Guid.NewGuid().ToString(),
                CurrentFile = Guid.NewGuid().ToString(),
                UploaderType = Guid.NewGuid().ToString(),
                FileLocation = Guid.NewGuid().ToString(),
                FileName = Guid.NewGuid().ToString()
            };
            await uploadedData.Create(DbContext);

            string newCheckSum = Guid.NewGuid().ToString();
            string newExtension = Guid.NewGuid().ToString();
            string newCurrentFile = Guid.NewGuid().ToString();
            string newUploaderType = Guid.NewGuid().ToString();
            string newFileLocation = Guid.NewGuid().ToString();
            string newFileName = Guid.NewGuid().ToString();

            uploadedData.Checksum = newCheckSum;
            uploadedData.Extension = newExtension;
            uploadedData.CurrentFile = newCurrentFile;
            uploadedData.UploaderType = newUploaderType;
            uploadedData.FileLocation = newFileLocation;
            uploadedData.FileName = newFileName;
            //Act
            await uploadedData.Update(DbContext);

            UploadedData dbUploadedData = DbContext.UploadedDatas.AsNoTracking().First();
            List<UploadedData> uploadedDataList = DbContext.UploadedDatas.AsNoTracking().ToList();
            List<UploadedDataVersion> uploadedDataVersionList = DbContext.UploadedDataVersions.AsNoTracking().ToList();
            //Assert
            Assert.NotNull(dbUploadedData);
            
            Assert.AreEqual(1, uploadedDataList.Count);
            Assert.AreEqual(2, uploadedDataVersionList.Count);
            
            Assert.AreEqual(newCheckSum, dbUploadedData.Checksum);
            Assert.AreEqual(newExtension, dbUploadedData.Extension);
            Assert.AreEqual(newCurrentFile, dbUploadedData.CurrentFile);
            Assert.AreEqual(newUploaderType, dbUploadedData.UploaderType);
            Assert.AreEqual(newFileLocation, dbUploadedData.FileLocation);
            Assert.AreEqual(newFileName, dbUploadedData.FileName);
            Assert.AreEqual(uploadedData.ItemCaseId, dbUploadedData.ItemCaseId);
        }

        [Test]
        public async Task UploadedData_Delete_DoesDelete()
        {
              //Arrange
            ItemList itemList = new ItemList
            {
                Name = Guid.NewGuid().ToString()
            };

            await itemList.Create(DbContext);
            
            Item item = new Item
            {
                Name = Guid.NewGuid().ToString(),
                Description = Guid.NewGuid().ToString(),
                Enabled = true,
                ItemListId = itemList.Id,
            };
            
            await item.Create(DbContext);
            
            ItemCase itemCase = new ItemCase
            {
                MicrotingSdkSiteId = 24,
                MicrotingSdkCaseId = 34,
                MicrotingSdkeFormId = 234,
                Status = 66,
                ItemId = item.Id,
            };

            await itemCase.Create(DbContext);
            
            UploadedData uploadedData = new UploadedData
            {
                ItemCaseId   = itemCase.Id,
                Checksum = Guid.NewGuid().ToString(),
                Extension = Guid.NewGuid().ToString(),
                CurrentFile = Guid.NewGuid().ToString(),
                UploaderType = Guid.NewGuid().ToString(),
                FileLocation = Guid.NewGuid().ToString(),
                FileName = Guid.NewGuid().ToString()
            };
            await uploadedData.Create(DbContext);

            //Act
            await uploadedData.Delete(DbContext);

            UploadedData dbUploadedData = DbContext.UploadedDatas.AsNoTracking().First();
            List<UploadedData> uploadedDataList = DbContext.UploadedDatas.AsNoTracking().ToList();
            List<UploadedDataVersion> uploadedDataVersionList = DbContext.UploadedDataVersions.AsNoTracking().ToList();
            //Assert
            Assert.NotNull(dbUploadedData);
            
            Assert.AreEqual(1, uploadedDataList.Count);
            Assert.AreEqual(2, uploadedDataVersionList.Count);
           
            Assert.AreEqual(uploadedData.Checksum, dbUploadedData.Checksum);
            Assert.AreEqual(uploadedData.Extension, dbUploadedData.Extension);
            Assert.AreEqual(uploadedData.CurrentFile, dbUploadedData.CurrentFile);
            Assert.AreEqual(uploadedData.UploaderType, dbUploadedData.UploaderType);
            Assert.AreEqual(uploadedData.FileLocation, dbUploadedData.FileLocation);
            Assert.AreEqual(uploadedData.FileName, dbUploadedData.FileName);
            Assert.AreEqual(uploadedData.ItemCaseId, dbUploadedData.ItemCaseId);
            Assert.AreEqual(Constants.WorkflowStates.Removed, dbUploadedData.WorkflowState);
        }
        
    }
}