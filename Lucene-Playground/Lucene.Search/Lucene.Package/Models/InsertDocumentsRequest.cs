using Lucene.Net.Documents;

namespace Lucene.Package.Models
{
    public class InsertDocumentsRequest
    {
        public required string IndexName { get; set; }

        public required List<DocumentRecord> Documents { get; set; }

        public InsertDocumentsRequest()
        {
            
        }

        public InsertDocumentsRequest(string indexName)
        {
            IndexName = indexName;
            Documents = new List<DocumentRecord>();
        }

        public InsertDocumentsRequest(string indexName, List<DocumentRecord> documents)
        {
            IndexName = indexName;
            Documents = documents;
        }

        public void AddDocument(DocumentRecord document)
        {
            if(Documents == null)
                Documents = new List<DocumentRecord>();

            if(document == null)
                throw new ArgumentNullException(nameof(document));

            Documents.Add(document);
        }

        public void AddDocuments(List<DocumentRecord> documents)
        {
            if (Documents == null)
                Documents = new List<DocumentRecord>();

            if (documents == null)
                throw new ArgumentNullException(nameof(documents));

            Documents.AddRange(documents);
        }

        public List<Document> GenerateDocuments()
        {
            var documents = Documents.Select(x => x.GenerateLuceneDocument()).ToList(); 

            return documents;
        }
    }
}
