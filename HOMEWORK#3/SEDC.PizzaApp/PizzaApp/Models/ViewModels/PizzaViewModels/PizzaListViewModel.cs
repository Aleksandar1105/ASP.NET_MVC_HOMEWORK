namespace PizzaApp.Models.ViewModels.PizzaViewModels
{
    public class PizzaListViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Price { get; set; }

        public string imgUrl { get; set; }
        public bool IsOnPromotion { get; set; }
    }
}
