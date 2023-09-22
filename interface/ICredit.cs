namespace interfacee
{
    public interface ICredit
    {
        int Amont { get; set; }
        int Days { get; set; }
        Guid Id { get; set; }
        int Months { get; set; }
        Client Name { get; set; }
        double Percent { get; set; }
    }
}