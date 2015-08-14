﻿using System.Threading.Tasks;

namespace Salesforce.Common
{
    public interface IBulkServiceHttpClient
    {
        Task<T> HttpPostXmlAsync<T>(object inputObject, string urlSuffix);
    }
}
