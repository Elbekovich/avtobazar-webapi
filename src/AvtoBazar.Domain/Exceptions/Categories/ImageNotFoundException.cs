using System.Drawing;

namespace AvtoBazar.Domain.Exceptions.Categories;

public class ImageNotFoundException : NotFoundException
{
    public ImageNotFoundException()
    {
        this.TitleMessage = "Image not found!";
    }
}
