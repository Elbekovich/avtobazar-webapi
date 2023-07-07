using System.Runtime.CompilerServices;

namespace AvtoBazar.Domain.Exceptions.Cars;

public class CarNotFoundException : NotFoundException
{
    public CarNotFoundException()
    {
        this.TitleMessage = "Car not found";
    }
}
