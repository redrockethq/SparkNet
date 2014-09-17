namespace SparkNet.Common
{
    public interface IDocument
    {
        void All();

        void Create();

        void ById(string id);

        void Update(bool shouldReplaceDocument = false);

        void Delete();
    }
}