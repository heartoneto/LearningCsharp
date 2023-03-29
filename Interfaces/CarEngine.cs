// Esta clase modela un motor de auto, implementa la interfaz IEngine
class CarEngine : IEngine
{
    public void Start()
    {
        this.Speed = 300.0;
        System.Console.WriteLine($"Car engine started, speed: {this.Speed} rpm");
    }

    public void Stop()
    {
        this.Speed = 0;
        System.Console.WriteLine($"Car engine stopped, speed: {this.Speed} rpm");
    }

    public double Speed { get; private set; }
}