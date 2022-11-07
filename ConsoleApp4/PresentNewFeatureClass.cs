namespace ConsoleApp4
{
    internal static class PresentNewFeatureClass
    {
        public static bool IsLetter(this char c) =>
                 c is >= 'a' and <= 'z' or >= 'A' and <= 'Z';


        public static bool IsLetterOrSeparator(this char c) =>
               c is (>= 'a' and <= 'z') or (>= 'A' and <= 'Z') or '.' or ',';


        public static bool IsConferenceDay(DateTime date) =>
            date is { Year: 2020, Month: 5, Day: 19 or 20 or 21 };


        public record Point(int X, int Y);

        public static Point Transform(Point point) => point switch
        {
            var (x, y) when x < y => new Point(-x, y),
            var (x, y) when x > y => new Point(x, -y),
            var (x, y) => new Point(x, y),
        };

        static bool IsAcceptable(int id, int absLimit) =>
                         SimulateDataFetch(id) is var results
                         && results.Min() >= -absLimit
                         && results.Max() <= absLimit;

        static int[] SimulateDataFetch(int id)
        {
            var rand = new Random();
            return Enumerable
                       .Range(start: 0, count: 5)
                       .Select(s => rand.Next(minValue: -10, maxValue: 11))
                       .ToArray();
        }
        public static bool IsNullTest(object e)
        {
            if (e is not null)
            {
               return true;
            }
            else
                
                return false;
        }
    }
}
