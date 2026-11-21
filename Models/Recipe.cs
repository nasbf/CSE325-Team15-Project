namespace Recipefy.Models;

public record Recipe(
    string Slug,
    string Title,
    string Image,
    string Category,
    string Time,
    string Rating,
    string Tag,
    string Color,
    string Description,
    int Servings,
    IReadOnlyList<string> Ingredients,
    IReadOnlyList<string> Instructions);
