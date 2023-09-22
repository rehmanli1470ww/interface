namespace interfacee
{
    public interface ICeo
    {
        string Age { get; set; }
        Guid Id { get; set; }
        string Name { get; set; }
        string Position { get; set; }
        int Salary { get; set; }
        string Surname { get; set; }
    }
}