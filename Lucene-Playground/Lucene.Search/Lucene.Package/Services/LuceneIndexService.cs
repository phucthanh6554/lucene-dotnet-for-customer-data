using Lucene.Net.Analysis.Standard;
using Lucene.Net.Index;
using Lucene.Net.Store;
using Lucene.Net.Util;
using Lucene.Package.Configs;
using Lucene.Package.Models;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Lucene.Package.Services
{
    public class LuceneIndexService
    {
        private readonly ILogger<LuceneIndexService> _logger;

        protected readonly LuceneConfig _luceneConfig;

        public LuceneIndexService(IOptions<LuceneConfig> luceneConfigOptions, ILogger<LuceneIndexService> logger)
        {
            _luceneConfig = luceneConfigOptions.Value;
            _logger = logger;
        }

        public void InsertDocument(InsertDocumentsRequest insertDocsRequest)
        {
            var dirPath = Path.Combine(GetBaseIndexPath(), insertDocsRequest.IndexName);

            using var fsDirectory = FSDirectory.Open(dirPath);

            using var analyzer = new StandardAnalyzer(LuceneVersion.LUCENE_48);

            var indexWriterConfig = new IndexWriterConfig(LuceneVersion.LUCENE_48, analyzer);

            using var indexWriter = new IndexWriter(fsDirectory, indexWriterConfig);

            var documents = insertDocsRequest.GenerateDocuments();

            foreach(var doc in documents)
            {
                indexWriter.AddDocument(doc);
            }

            indexWriter.Commit();
        }

        private string GetBaseIndexPath()
        {
            if (!string.IsNullOrEmpty(_luceneConfig.IndexBasePath))
            {
                _logger.LogDebug("Config found, using config index path");
                return _luceneConfig.IndexBasePath;
            }

            _logger.LogDebug("Config not found, using default index path");
            return Path.Combine(Environment.CurrentDirectory, "lucene_indexes");
        }
    }
}
