namespace Sidewired.Core.Domain
{
    public enum S3DSubsamplingOrders
    {
        None = 0,
        OddLeft_OddRight = 2,
        OddLeft_EvenRight = 4,
        EvenLeft_OddRight = 8,
        EvenLeft_EvenRight = 22,
    }
}
