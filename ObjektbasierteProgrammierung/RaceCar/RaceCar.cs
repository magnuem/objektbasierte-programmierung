namespace RaceCar;

public class RaceCar
    {
        /* Instanzvariablen: 
        Sämtliche neu erstellte Instanzen übernehmen folgende Felder.
        Die Felder sind auf private damit sie von aussen nicht geändert werden können.*/ 
        private int currentSpeed;
        private int maxSpeed;
        private int numberOfRounds;
        
        
        // properties
        public string BrandName { get; set; }
        public string ModelName { get; set; }
        public string ColorName { get; set; }
        public string DriverName { get; set; }
        public int StartingNumber { get; set; }

        public int MaxSpeed
        {
            get
            {
                return this.maxSpeed;
            }
            set
            {
                maxSpeed = value;
            }
        }
    }
