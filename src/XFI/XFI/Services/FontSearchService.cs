using Microsoft.Azure.Storage;
using Microsoft.Azure.Storage.Blob;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using XFI.Models;

namespace XFI.Services
{
    public class FontSearchService
    {
        string storageConnectionString = @"DefaultEndpointsProtocol=https;AccountName=xfi;EndpointSuffix=core.windows.net";
        readonly CloudStorageAccount storageAccount;
        CloudBlobClient cloudBlobClient;
        CloudBlobContainer cloudBlobContainer;

        public FontSearchService()
        {
            if (CloudStorageAccount.TryParse(storageConnectionString, out storageAccount))
            {
                cloudBlobClient = storageAccount.CreateCloudBlobClient();
                cloudBlobContainer = cloudBlobClient.GetContainerReference("xfi-fonts");

            }
            else
            {
                MessageBox.Show("Cannot Connect to Remote Font Repository!", "Connection Error!");
            }
        }

        public async Task<List<Font>> FetchFontListAsync(string prefix)
        {
            var fonts = new List<Font>();
            if (string.IsNullOrEmpty(prefix))
                return null;

            BlobContinuationToken blobContinuationToken = null;
            do
            {
                var results = await cloudBlobContainer.ListBlobsSegmentedAsync(prefix, blobContinuationToken);
                // Get the value of the continuation token returned by the listing call.
                blobContinuationToken = results.ContinuationToken;
                foreach (IListBlobItem item in results.Results)
                {
                    fonts.Add(new Font { Url = item.Uri.ToString(), Name = item.Uri.Segments.Last().Substring(0, item.Uri.Segments.Last().IndexOf('.') )}); 
                }
            } while (blobContinuationToken != null);

            return fonts;

        }
    }
}
