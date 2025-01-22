namespace Task1.Entities
{
    public class HotMeal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string MealSize { get; set; }
        public bool IsVegetarian { get; set; }
        public int Price { get; set; }
        public bool IsSpicy { get; set; }
    }
}
