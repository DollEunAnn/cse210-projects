using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        // Event 1 - Lecture
        Address a1 = new Address("School St.", "Lake Shore", "IL", "USA");
        Lecture lecture = new Lecture("Developing Talents", "For pursuing new career endeavors", "July 17, 2024", "10:45 AM", a1, "Quinn", 100);
        string t1 = lecture.GetType().ToString();
        Console.WriteLine("Standard Details:");
        Console.WriteLine(lecture.DisplayEventStandardDetails());
        Console.WriteLine();
        Console.WriteLine("Full Details:");
        Console.WriteLine(lecture.DisplayEventStandardDetails());
        Console.WriteLine(lecture.LectureDetails());
        Console.WriteLine();
        Console.WriteLine("Short Description:");
        Console.WriteLine(lecture.DisplayEventShortDetails(t1));

        Console.WriteLine($"-------------------------------------------------");

        // Event 2 - Reception      
        Address a2 = new Address("Francis St.", "Laeie", "HI", "USA");
        Reception reception = new Reception("Wedding of Kims", "Wedding Reception for the Kims", "June 13, 2025", "11:00 AM", a2, "weddingKim@gmail.com");
        string t2 = reception.GetType().ToString();
        Console.WriteLine("Standard Details:");
        Console.WriteLine(reception.DisplayEventStandardDetails());
        Console.WriteLine();
        Console.WriteLine("Full Details:");
        Console.WriteLine(reception.DisplayEventStandardDetails());
        Console.WriteLine(reception.ReceptionDetails());
        Console.WriteLine();
        Console.WriteLine("Short Description:");
        Console.WriteLine(reception.DisplayEventShortDetails(t2));

        Console.WriteLine($"-------------------------------------------------");

        // 3 - Outdoor Gathering
        Address a3 = new Address("J. Escriva 15 St.", "Ortigas Business Center", "Pasig City", "Philippines");
        OutdoorGathering outdoorGathering = new OutdoorGathering("Boys Scout", "Camping for Boys Scount of the Philippines", "October 12, 2024", "8:00 AM", a3, "The weather forecast for Pasig on October 12, 2024, predicts a high of 30°C and a low of 26°C. There is a high chance of thunderstorms throughout the day, with periods of moderate rain expected as well. Humidity levels will be high, around 80-90%, making it feel warmer than the actual temperature. Winds will be moderate, coming from the west-southwest at speeds of 25-30 km/h.");
        string t3 = outdoorGathering.GetType().ToString();
        Console.WriteLine("Standard Details:");
        Console.WriteLine(outdoorGathering.DisplayEventStandardDetails());
        Console.WriteLine();
        Console.WriteLine("Full Details:");
        Console.WriteLine(outdoorGathering.DisplayEventStandardDetails());
        Console.WriteLine(outdoorGathering.OutdoorGatheringDetails());
        Console.WriteLine();
        Console.WriteLine("Short Description:");
        Console.WriteLine(outdoorGathering.DisplayEventShortDetails(t3));


    }
}