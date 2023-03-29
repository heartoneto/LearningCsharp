// Abstracción sobre el concepto de motor
interface IEngine
{
    // Permite obtener la velocidad del motor
    double Speed { get; }

    // Enciende el motor
    void Start();

    // Apaga el motor
    void Stop();
}