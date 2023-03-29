class WashingMachine
{
    IEngine engine;
    string brand;

    bool isOn;

    public WashingMachine(IEngine motor, string brand)
    {
        isOn = false;
        engine = motor;
        this.brand = brand;
    }


    public void TurnOn()
    {
        if (this.isOn)
        {
            System.Console.WriteLine("Error: it doesn't make sense to turn on wats already on! :facepalm");
            return;
        }

        System.Console.WriteLine($"Turning on this WashingMachine: {this.brand}...");
        engine.Start();

        if (this.engine.Speed > 0)
        {
            this.isOn = true;
            System.Console.WriteLine("WashingMachine turned on!");
        }
    }

    public void TurnOff()
    {
        System.Console.WriteLine($"Turning on off WashingMachine: {this.brand}...");
        engine.Start();

        if (this.engine.Speed == 0)
        {
            this.isOn = false;
            System.Console.WriteLine("WashingMachine turned off!");
        }
    }
}