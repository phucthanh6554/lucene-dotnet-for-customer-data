using Lucene.Net.Documents;

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

        public Document GenerateLuceneDocument()
        {
            var doc = new Document();

            if (Fields == null || Fields.Count == 0)
                throw new ArgumentException("Invalid fields number");

            foreach (var field in Fields)
            {
                Field luceneField = null;

                switch (field.FieldType)
                {
                    default:
                    case FieldType.Text:
                        luceneField = new TextField(field.Name, field.Value, Field.Store.YES);
                        break;
                    case FieldType.String:
                        luceneField = new StringField(field.Name, field.Value, Field.Store.YES);
                        break;
                    case FieldType.Int:
                        luceneField = new Int32Field(field.Name, int.Parse(field.Value), Field.Store.YES);
                        break;
                    case FieldType.Long:
                        luceneField = new Int64Field(field.Name, long.Parse(field.Value), Field.Store.YES);
                        break;
                    case FieldType.Float:
                        luceneField = new SingleField(field.Name, float.Parse(field.Value), Field.Store.YES);
                        break;
                }

                doc.Add(luceneField);
            }

            return doc;
        }
    }
}
