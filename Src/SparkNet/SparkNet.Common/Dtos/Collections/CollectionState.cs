namespace SparkNet.Common.Dtos.Collections
{
    public enum CollectionState
    {
        New = 1,
        Unloaded = 2,
        Loaded = 3,
        InProcessOfUnloading = 4,
        Deleted = 5
    }
}