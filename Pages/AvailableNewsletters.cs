namespace Newsletters
{
    /* Static data holding class */
    public static class Util
    {
        public static int[] Years { get { return _years; } }
        public static Dictionary<string, uint> Months { get { return _months; } }

        public static string NewsletterBaseNamespace { get {return _newsletterBaseNamespace; } }
        
        private static readonly string _newsletterBaseNamespace = "NClubGA.Components.Newsletters";
        private static readonly int[] _years = { 2025 };

        private static readonly Dictionary<string, uint> _months = new()
        {
            { "January", 1 },
            { "February", 2 },
            { "March", 3 },
            { "April", 4 },
            { "May", 5 },
            { "June", 6 },
            { "July", 7 },
            { "August", 8 },
            { "September", 9 },
            { "October", 10 },
            { "November", 11 },
            { "December", 12 }
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
