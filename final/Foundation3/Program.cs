using System;

class Program
{
    static void Main(string[] args)
    {
        // Lecture.
        DateTime lectureDate = new DateTime(2023, 11, 8, 14, 0, 0);
        Address lectureAddress = new Address("Central Concert Hall", "New York City", "New York");

        Lecture lecture = new Lecture
        (
            "Getting More Done with Less",
            "Come listen to see how you can improve your productivity!",
            lectureDate,
            lectureAddress,
            "Ashley Wright",
            150
        );

        // Reception.
        DateTime receptionDate = new DateTime(2021, 4, 23, 17, 15, 00);
        Address receptionAddress = new Address("1st Ward", "Rexburg", "Idaho");

        Reception reception = new Reception
        (
            "Wedding Reception",
            "We would like to invite you to our wedding reception! We would love for you to come.",
            receptionDate,
            receptionAddress,
            "@weddingreceptionemailaddress"
        );

        // OutdoorGathering.
        DateTime outdoorGatheringDate = new DateTime(2024, 7, 30, 11, 30, 00);
        Address outdoorGatheringAddress = new Address("Central Park", "Idaho Falls", "Idaho");

        OutdoorGathering outdoorGathering = new OutdoorGathering
        (
            "Ward Picnic",
            "We are having a ward picnic! Food and games will be enjoyed. Please feel free to bring your own food and drinks as well!",
            outdoorGatheringDate,
            outdoorGatheringAddress,
            "sunny"
        );

        // Lecture displays.
        lecture.GetStandardDetails();
        Console.WriteLine();
        lecture.GetFullDetails();
        Console.WriteLine();
        lecture.GetShortDescription();

        // Blank line.
        Console.WriteLine();

        // Reception Displays.
        reception.GetStandardDetails();
        Console.WriteLine();
        reception.GetFullDetails();
        Console.WriteLine();
        reception.GetShortDescription();

        // Blank line.
        Console.WriteLine();

        // OutdoorGathering displays.
        outdoorGathering.GetStandardDetails();
        Console.WriteLine();
        outdoorGathering.GetFullDetails();
        Console.WriteLine();
        outdoorGathering.GetShortDescription();
    }
}