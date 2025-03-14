namespace NClubGA.Models.AvailableNewsletters
{
    /* Static data holding class */
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
            {
                return true;
            }
            else if (year == 2025 && _months[month] <= 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
