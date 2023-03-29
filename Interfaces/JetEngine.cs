// Esta clase modela un motor de avión, implementa la interfaz IEngine
class JetEngine : IEngine
{
    public void Start()
    {
        this.Speed = 3000;
        System.Console.WriteLine($"Jet engine started, speed: {this.Speed} rpm");
    }

    public void Stop()
    {
        this.Speed = 0;
        System.Console.WriteLine($"Jet engine stopped, speed: {this.Speed} rpm");
    }
    public double Speed { get; private set; }
}