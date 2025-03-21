
namespace NClubGA.Models.Newsletters
{

    public static class Util
    {
        public static int[] Years { get { return _years; } }
        public static Dictionary<string, int> Months { get { return _months; } }

        public static string NewsletterBaseNamespace { get {return _newsletterBaseNamespace; } }
    
        private static readonly string _newsletterBaseNamespace = "NClubGA.Components.Newsletters";
        private static readonly int[] _years = [2025, 2024];

        private static readonly Dictionary<string, int> _months = new()
        {
            { "December", 12 },
            { "November", 11 },
            { "October", 10 },
            { "September", 9 },
            { "August", 8 },
            { "July", 7 },
            { "June", 6 },
            { "May", 5 },
            { "April", 4 },
            { "March", 3 },
            { "February", 2 },
            { "January", 1 }
        };

        public static bool DetermineIfLegacy(int year, string month)
        {
            /* return true if date is anywhere between August 2024 and March 2025 */
            if (year == 2024 && _months[month] >= 8)
                return true;
            else if (year == 2025 && _months[month] <= 3)
                return true;
            else
                return false;
        }

        public static string? GetWinningPhotoPath(int year, string month)
        {
            if (DetermineIfLegacy(year, month))
                return null;
            else
                return $"images/PhotoContestWinners/{year}/{month}.jpg";
        }
    }

    public class Event {
        required public string Title { get; set; }
        required public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        required public string LocationName { get; set; }
        public string? LocationURL { get; set; }
        required public string AddressLine1 { get; set; }
        required public string AddressLine2 { get; set; }
        required public string Cost { get; set; }
        public string? MainImageUrl { get; set; }
        public string? Description { get; set; }
        public string? FacebookEventUrl { get; set; }
        public Dictionary<string, string>? OtherLinks { get; set; }
    }

    public class Newsletter
    {
        required public int Year { get; set; }
        required public string Month { get; set; }
        public List<Event>? Events { get; set; }
        public List<string>? NewsItems { get; set; }
        public string? PhotoContestWinner { get; set; }
    }
}