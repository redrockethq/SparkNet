namespace SparkNet.Common
{

    public interface IArangoDb
    {
        IDatabaseManager Databases { get; }

        void Connect();
    }
}
