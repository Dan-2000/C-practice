using System;
class RemoteControlCar
{
    // TODO: define the constructor for the 'RemoteControlCar' class
    private int speed;
    private int batteryDrain;
    private int batteryPercentage;
    private int distanceLog;
    public RemoteControlCar(int spd, int batDr)
    {
        speed = spd;
        batteryDrain = batDr;      
        batteryPercentage = 100;
        distanceLog = 0;
    }
    
    public bool BatteryDrained()
    {
    return batteryPercentage < batteryDrain; 
    }
    public int DistanceDriven()
    {
        return distanceLog;
    }
    public void Drive()
    {
        if(!BatteryDrained() && batteryPercentage >= batteryDrain)
        {
         distanceLog = distanceLog + speed;
        }
    batteryPercentage = batteryPercentage - batteryDrain;
    }
    public static RemoteControlCar Nitro()
    {
        return new   RemoteControlCar(50,4);
    }
}
class RaceTrack
{
    // TODO: define the constructor for the 'RaceTrack' class
    private int distance;
    public RaceTrack(int dist) 
    { 
    distance = dist;    
    }
    public bool TryFinishTrack(RemoteControlCar car)
    {
    while(!car.BatteryDrained())
    {
        car.Drive();
        if(car.DistanceDriven() >= distance) 
            {
            return true;
        }
    }
    return false;
    }
}