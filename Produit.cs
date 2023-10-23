internal class Produit
{
    public string Nom { get; set; }
    public float Prix { get; set; }

    public float CalculerRemise(float reduction)
    {
        if (reduction > Prix || reduction < 0) throw new ArgumentOutOfRangeException();

        return Prix - (Prix * (reduction / 100));
    }
}