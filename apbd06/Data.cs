using apbd06.Models;

namespace apbd06;

public class Data
{
    public static List<Room> Rooms = new List<Room>
    {
        new Room { Id = 1, Name = "Aula", BuildingCode = "A", Floor = 0, Capacity = 200, HasProjector = true, IsActive = true },
        new Room { Id = 102, Name = "Lab", BuildingCode = "A", Floor = 1, Capacity = 30, HasProjector = false, IsActive = true },
        new Room { Id = 217, Name = "Lab", BuildingCode = "B", Floor = 2, Capacity = 30, HasProjector = true, IsActive = true },
        new Room { Id = 310, Name = "Classroom", BuildingCode = "C", Floor = 3, Capacity = 15, HasProjector = false, IsActive = false }
    };

    public static List<Reservation> Reservations = new List<Reservation>
    {
        new Reservation { Id = 1, RoomId = 1, OrganizerName = "Jacob Smith", Topic = "Java", Date = new DateTime(2026, 5, 20), StartTime = new TimeSpan(9,0,0), EndTime = new TimeSpan(11,0,0), Status = "confirmed" },
        new Reservation { Id = 2, RoomId = 1, OrganizerName = "Emma White", Topic = "C#", Date = new DateTime(2026, 5, 20), StartTime = new TimeSpan(16,0,0), EndTime = new TimeSpan(17,30,0), Status = "confirmed" },
        new Reservation { Id = 3, RoomId = 102, OrganizerName = "William Williams", Topic = "Python", Date = new DateTime(2026, 5, 21), StartTime = new TimeSpan(9,0,0), EndTime = new TimeSpan(11,0,0), Status = "confirmed" },
        new Reservation { Id = 4, RoomId = 217, OrganizerName = "John Johnson", Topic = "Algebra", Date = new DateTime(2026, 5, 22), StartTime = new TimeSpan(9,0,0), EndTime = new TimeSpan(11,0,0), Status = "confirmed" },

    };
}