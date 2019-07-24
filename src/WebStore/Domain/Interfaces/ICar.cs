using WebStore.Domain.Base;

namespace WebStore.Domain.Interfaces
{
    public interface ICar : IGenericEntity<ICar>
    {
        string Year { get; set; }
        string Maker { get; set; }
        string Model { get; set; }
    }
}
