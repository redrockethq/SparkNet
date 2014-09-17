namespace SparkNet.Common
{
    public interface IUser
    {
        void ByName(string name);

        void Create(string name);

        void Update(string name, bool shouldReplaceDocument = false);

        void Delete(string name);
    }
}