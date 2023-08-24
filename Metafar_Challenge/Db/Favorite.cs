namespace Metafar_Challenge.Db;

public partial class Favorite
{
    public Guid Id { get; set; }

    public string UserId { get; set; } = null!;

    public string Symbol { get; set; } = null!;
}
