namespace Pizza.Models
{
    public class Ingredient
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public static implicit operator string(Ingredient ingredient) => ingredient.Name ?? "";
        public static implicit operator Ingredient(string str) => new Ingredient() { Name = str };
    }
}
