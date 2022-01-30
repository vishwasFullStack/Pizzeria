namespace Pizzeria.Common.Interface
{
    public interface IOrderInput
    {
        int CheeseId { get; set; }
        int CurstId { get; set; }
        int CustomerId { get; set; }
        int SauceId { get; set; }
        int ToppingsId { get; set; }
    }
}