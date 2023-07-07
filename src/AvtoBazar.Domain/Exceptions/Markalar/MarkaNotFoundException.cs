namespace AvtoBazar.Domain.Exceptions.Markalar;

public class MarkaNotFoundException : NotFoundException
{
    public MarkaNotFoundException()
    {
        this.TitleMessage = "Marka not found";
    }
}
