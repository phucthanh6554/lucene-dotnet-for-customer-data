namespace Lucene.Package.Models
{
    public class InsertDocumentRequest
    {
        public required string IndexName { get; set; }

        public List<FieldRecord> Fields { get; set; }

        public InsertDocumentRequest(string indexName)
        {
            IndexName = indexName;
            Fields = new List<FieldRecord>();
        }

        public InsertDocumentRequest(string indexName, List<FieldRecord> fields)
        {
            IndexName = indexName;
            Fields = fields;
        }

        public void AddField(FieldRecord field)
        {
            if(Fields == null)
                Fields = new List<FieldRecord>();

            if(field == null)
                throw new ArgumentNullException(nameof(field));

            Fields.Add(field);
        }

        public void AddFields(List<FieldRecord> fields)
        {
            if (Fields == null)
                Fields = new List<FieldRecord>();

            if (fields == null)
                throw new ArgumentNullException(nameof(fields));

            Fields.AddRange(fields);
        }
    }


}
