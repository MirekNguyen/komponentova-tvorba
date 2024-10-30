namespace komponentova_tvorba.Models;

public class Library
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required Address Address { get; set; }
}
