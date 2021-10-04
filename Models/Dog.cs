namespace web
{
  public class Dog
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string Breed { get; set; }

    public override string ToString() => $"id/{Id} : name/{Name} : age/{Age} : breed/{Breed}";
  }
}
