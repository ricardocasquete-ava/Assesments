using App.Factory.Animals;

namespace App.Factory;

/// <summary>
/// Only this class knows the logic of how each IAnimal is selected and instantiated.
/// The IAnimal objects themselves doesn't know when they get instantiated or who instantiates them.
/// </summary>
public class AnimalFinder
{
    public IAnimal[] FindAnimals(params Attributes[] attributes)
    {
        var list = _animalAttributes;

        var shortlist = list.AsEnumerable<KeyValuePair<Type, Attributes[]>>();
        foreach(var attribute in attributes)
        {
            shortlist = shortlist.Where(a => a.Key.IsAssignableTo(typeof(IAnimal)) && a.Value.Contains(attribute));
        }

        var found = shortlist.Select(a => a.Key);
        var response = new List<IAnimal>();
        foreach(var animal in found)
        {
            var instance = Activator.CreateInstance(animal) as IAnimal;
            if (instance == null) { continue; }

            response.Add(instance);
        }

        return response.ToArray();
    }

    private static IReadOnlyDictionary<Type, Attributes[]> _animalAttributes => new Dictionary<Type, Attributes[]>
    {
        {
            typeof(Dog),
            Dog.Features
        },

        {
            typeof(Duck),
            Duck.Features
        },

        {
            typeof(Eagle),
            Eagle.Features
        },

        {
            typeof(Shark),
            Shark.Features
        },

        {
            typeof(Sheep),
            Sheep.Features
        },

        {
            typeof(Snake),
            Snake.Features
        }
    };
}