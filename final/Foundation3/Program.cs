using System;

class Program
{
    static void Main(string[] args)
    {

        // Event 1 - Lecture
        Address a1 = new Address("School St.", "Lake Shore", "IL", "USA");
        LectureEvent lectureEvent = new LectureEvent("Developing Talents", "For pursuing new career endeavors", "July 17, 2024", "10:45 AM", a1, "Quinn", 100);
        Console.WriteLine(lectureEvent.DisplayEventStandardDetails());
        Console.WriteLine(lectureEvent.DisplayLectureDetails());
        Console.WriteLine(lectureEvent.DisplayEventShortDetails());

        // Event 2 - Reception      
        Address a2 = new Address("Francis St.", "Laeie", "HI", "USA");
        ReceptionEvent receptionEvent = new ReceptionEvent("Wedding of Kims", "Wedding Reception for the Kims", "June 13, 2025", "11:00 AM", a2, "weddingKim@gmail.com");
        Console.WriteLine(lectureEvent.DisplayEventStandardDetails());
        Console.WriteLine(lectureEvent.DisplayLectureDetails());
        Console.WriteLine(lectureEvent.DisplayEventShortDetails());

        //Event 3 - Outdoor Gathering
        Address a3 = new Address("J. Escriva 15 St.", "Ortigas Business Center", "Pasig City", "Philippines");
        OutdoorGatheringEvent outdoorGatheringEvent = new OutdoorGatheringEvent("Boys Scout", "Camping for Boys Scount of the Philippines", "October 12, 2024", "8:00 AM", a3, "Sunny Day - 24C");
        Console.WriteLine(lectureEvent.DisplayEventStandardDetails());
        Console.WriteLine(lectureEvent.DisplayLectureDetails());
        Console.WriteLine(lectureEvent.DisplayEventShortDetails());
    }
}