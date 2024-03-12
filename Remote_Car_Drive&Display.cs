using System;

class RemoteControlCar
{
    private int distance = 0;
    private int battery = 100;
    public static RemoteControlCar Buy()
    {
        return new RemoteControlCar();
    }

    public string DistanceDisplay()
    {
        return $"Driven {distance} meters";
    }

    public string BatteryDisplay()
    {
         return battery > -0 ? $"Battery at {battery}%" : "Battery empty";
    }

    public void Drive()
    {
        if (battery > 0) 
        {
            this.distance = distance +20;
            this.battery = battery-1;
            
        }
    }
}
