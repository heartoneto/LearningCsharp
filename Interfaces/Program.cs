
namespace Interfaces
{
    class Program
    {
        // Este método devuelve una colección de motores
        // Usa internamente una lista
        static IEnumerable<IEngine> GetEngines()
        {
            List<IEngine> engineList = new List<IEngine>();
            engineList.Add(new CarEngine());
            engineList.Add(new JetEngine());

            return engineList;
        }

        // Este método crea una colección de marcas
        // Usa un array
        static IEnumerable<string> Brands()
        {
            var brands = new string[] {
                "Ariete",
                "Rolls Royce",
            };

            return brands;
        }

        static void Main()
        {
            // Obtenemos motores y marcas
            IEnumerable<IEngine> engines = GetEngines();
            IEnumerable<string> brands = Brands();

            // Zip es la función canónica, empareja un elemento de la colección A con uno de la B
            // En este caso emparejamos un motor con una marca
            var pairs = engines.Zip(brands);

            // Para cada par en los pares...
            // item sera una tupla  (bonus: las tuplas se pueden componer, cómo lo harías conceptualmente?)  
            foreach (var item in pairs)
            {
                // Creamos una lavadora usando el motor (que será el primer elemento del par)
                // y la marca (que será el segundo elemento del par)
                var wm = new WashingMachine(item.First, item.Second);

                // Encendemos esta lavadora
                wm.TurnOn();
                // Apagamos esta lavadora
                wm.TurnOff();

                // Una Línea en blanco... legibilidad
                System.Console.WriteLine();
            }
        }
    }
}