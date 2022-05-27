﻿using Microsoft.AspNetCore.Http;

namespace ETradeParallel.Application.Abstractions.Storage
{
    public interface IStorage
    {
        Task<List<(string fileName, string pathOrContainerName)>> UploadAsync(string pathOrContainerName, IFormFileCollection files);
        Task DeleteAsync(string pathOrContainerName, string fileName);
        List<string> GetFiles(string pathOrContainerName);
        Task<bool> HasFile(string pathOrContainerName, string fileName);
    }

}
