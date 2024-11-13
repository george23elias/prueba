namespace Entity.Animal
{
    public class Animal
    {
        public string Nombre { get; set; } = string.Empty;
        public string Tipo { get; set; } = string.Empty;
    }

    public class AnimalRepository
    {
        public List<Animal> Animales { get; set; } = new List<Animal>();
    }
}
