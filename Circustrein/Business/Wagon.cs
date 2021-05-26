using System;
using System.Collections.Generic;
using System.Text;

namespace Business
{
    class Wagon
    {
        private List<Animal> Animals;
        public int Wagonsize = 10;
        public Wagon()
        {
            Animals = new List<Animal>();
        }

        public void GetAllAnimals()
        {

        }
        public int GetPoints()
        {
            var points = 0;
            foreach (var item in Animals)
            {
                points += item.Getpoints();
            }
            return points;
        }
        public bool AnimalFits(Animal animal)
        {
            var WagonSize = GetPoints();
            if (WagonSize <= 0)
            {
                return true;
            }

            var AnimalSize = animal.Getpoints();
            if (WagonSize + AnimalSize > Wagonsize)
            {
                return false;
            }

            foreach (var wagonAnimal in Animals)
            {
                if (animal.foodType == FoodType.Carnivoor &&  animal.size >= wagonAnimal.size)
                {
                    return false;
                }
                if (animal.foodType == FoodType.Herbivoor && wagonAnimal.foodType == FoodType.Carnivoor && animal.size <= wagonAnimal.size )
                {
                    return false;
                }
            }
            return true;
        }

        public bool AddAnimals(Animal animal)
        {
            var result = AnimalFits(animal);
            if (result)
            {
                Animals.Add(animal);
            }
            return result;
        }
    }
}
