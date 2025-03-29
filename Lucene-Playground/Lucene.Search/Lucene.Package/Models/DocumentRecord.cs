namespace Lucene.Package.Models
{
    public class DocumentRecord
    {
        public required List<FieldRecord> Fields { get; set; }

        public DocumentRecord()
        {

        }

        public DocumentRecord(List<FieldRecord> fields)
        {
            Fields = fields;
        }

        public void AddField(FieldRecord field)
        {
            if (Fields == null)
                Fields = new List<FieldRecord>();

            if (field == null)
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
