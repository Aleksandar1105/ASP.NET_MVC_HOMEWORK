using PizzaApp.Models.Domain;
using PizzaApp.Models.ViewModels.PizzaViewModels;

internal static class PizzaMapperHelpers
{

    public static PizzaViewModel MapFromPizzaToPizzaViewModel(this Pizza pizza)
    {
        if (pizza.HasExtras)
        {
            pizza.Price += 10;
        }

        return new PizzaViewModel()
        {
            Id = pizza.Id,
            Name = pizza.Name,
            Price = pizza.Price,
            PizzaSize = pizza.PizzaSize,
            HasExtras = pizza.HasExtras
        };


    }
}