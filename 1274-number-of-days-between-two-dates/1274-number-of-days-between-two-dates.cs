
public class Solution {
    public int DaysBetweenDates(string date1, string date2) {
        DateTime Date1=DateTime.Parse(date1);
        DateTime Date2=DateTime.Parse(date2);
        TimeSpan diff=Date2-Date1;
        return Math.Abs(diff.Days);
    }
}