using System;

class TrainHelper
{
    public void PrintTrain(Train train)
    {
        Console.WriteLine(train.DestinationPoint);
        Console.WriteLine(train.DeparturePoint);
        Console.WriteLine(train.Number);
        Console.WriteLine(train.NumberOfSeats);
        Console.WriteLine("*********************************************");
    }
    public Train FindTrain(Train[] trains, string number)
    {
        foreach(var train in trains)
        {
            if (train.Number == number)
            {
                return train;
            }
        }
        return null;
    }
    public Train FindBigNumberOfSeats(Train[] trains)
    {
        int counter = 0;
        Train biggestNumberTrain = null;
        foreach(var train in trains)
        {
            if (train.NumberOfSeats > counter)
            {
                counter = train.NumberOfSeats;
                biggestNumberTrain = train;
            }
        }
        return biggestNumberTrain;
    }
    public Train[] SortByNumber(Train[] trains)
    {
        int n = trains.Length;
        int gap = n / 2;
        while (gap > 0)
        {
            for (int i = gap; i < n; i++)
            {
                Train temp = trains[i];
                int j;
                for (j = i; j >= gap && String.Compare(trains[j - gap].Number, temp.Number) > 0; j -= gap)
                {
                    trains[j] = trains[j - gap];
                }
                trains[j] = temp;
            }
            gap /= 2;
        }
        return trains;
    }
}