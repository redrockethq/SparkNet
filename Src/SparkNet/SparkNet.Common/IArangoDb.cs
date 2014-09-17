namespace SparkNet.Common
{

    public interface IArangoDb
    {
        IDatabase Databases { get; }

        void Connect();
    }
}
