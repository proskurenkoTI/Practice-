using System;
class Train
{
    public string DestinationPoint;
    public string DeparturePoint;
    public string Number;
    public int NumberOfSeats;

    public Train(string DestinationPoint,  string DeparturePoint, string Number, int NumberOfSeats)
    {
        this.DestinationPoint = DestinationPoint;
        this.DeparturePoint = DeparturePoint;
        this.Number = Number;
        this.NumberOfSeats = NumberOfSeats;
    }
}