using System;
using System.Linq;
class BirdCount
{
    private int[] birdsPerDay;
    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }
    public static int[] LastWeek()
    {
        return new int[] {0, 2, 5, 3, 7, 8, 4};  
        }
    public int Today()
    {
    return birdsPerDay.Last();
    }
    public void IncrementTodaysCount(){
       birdsPerDay[^1]++;
        }
    public bool HasDayWithoutBirds()
    {
    return birdsPerDay.Contains(0);
    }
    public int CountForFirstDays(int numberOfDays)
    {
    return birdsPerDay.Take(numberOfDays).Sum();
    }
    public int BusyDays()
    {
        int busyDays = 0;
        foreach(int birds in birdsPerDay)
        {
            if(birds >= 5)
                {
                busyDays ++;
            }
        }
    return busyDays;
    }
}