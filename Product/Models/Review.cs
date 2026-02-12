namespace Product.Models;

internal class Review
{
    public int Rating { get; private set; }
    public string Comment { get; private set; }

    public Review(int rating, string comment)
    {
        Rating = rating;
        Comment = comment;
    }
}
