using Recipefy.Models;

namespace Recipefy.Data;

/// <summary>Hard-coded sample recipes used while the app is UI-only (no database yet).</summary>
public static class MockRecipes
{
    public static IReadOnlyList<Recipe> All { get; } =
    [
        new(
            Slug: "lemon-ricotta-pasta",
            Title: "Lemon ricotta pasta",
            Image: "/recipes/hero-pasta.png",
            Category: "Dinner",
            Time: "25 min",
            Rating: "4.9",
            Tag: "A little sunshine",
            Color: "orange",
            Description: "A bright, silky pasta with whipped ricotta, sweet blistered tomatoes, and plenty of fresh basil. A simple supper that tastes like a little celebration.",
            Servings: 4,
            Ingredients:
            [
            "12 oz rigatoni or your favorite short pasta",
            "1 cup whole-milk ricotta",
            "1 lemon, zested and juiced",
            "2 cups cherry tomatoes",
            "2 tbsp extra-virgin olive oil",
            "½ cup finely grated parmesan",
            "1 small bunch fresh basil",
            "Kosher salt and cracked black pepper"
            ],
            Instructions:
            [
            "Bring a large pot of generously salted water to a boil. Cook the pasta until just al dente, reserving 1 cup of pasta water before draining.",
            "While the pasta cooks, warm the olive oil in a wide skillet over medium-high heat. Add the tomatoes and cook until blistered and beginning to burst, about 5–7 minutes. Season with salt and pepper.",
            "Whisk the ricotta with the lemon zest, lemon juice, parmesan, and a splash of pasta water until smooth and spoonable.",
            "Add the drained pasta to the tomatoes. Fold in the lemon ricotta, loosening with more pasta water as needed until glossy.",
            "Tear over the basil, finish with extra parmesan and black pepper, and serve warm."
            ]),
        new(
            Slug: "miso-salmon-bowl",
            Title: "Miso salmon bowl",
            Image: "/recipes/salmon-bowl.png",
            Category: "Lunch",
            Time: "30 min",
            Rating: "4.8",
            Tag: "Weeknight favorite",
            Color: "green",
            Description: "Flaky, sweet-savory salmon over rice with cool cucumber, creamy avocado, and a quick miso glaze. A colorful bowl for lunch or dinner.",
            Servings: 2,
            Ingredients:
            [
            "2 salmon fillets, about 5 oz each",
            "2 tbsp white miso",
            "1 tbsp honey",
            "1 tsp toasted sesame oil",
            "2 cups cooked rice",
            "1 ripe avocado, sliced",
            "½ cucumber, thinly sliced",
            "Sesame seeds and sliced scallions"
            ],
            Instructions:
            [
            "Heat the oven to 425°F. Whisk together the miso, honey, and sesame oil.",
            "Pat the salmon dry and brush generously with the miso glaze. Roast on a lined sheet pan for 10–12 minutes, until just opaque and flaky.",
            "Divide warm rice between two bowls. Add avocado and cucumber alongside.",
            "Top with salmon and finish with sesame seeds, scallions, and any extra glaze."
            ]),
        new(
            Slug: "green-goddess-grains",
            Title: "Green goddess grains",
            Image: "/recipes/green-salad.png",
            Category: "Lunch",
            Time: "20 min",
            Rating: "4.7",
            Tag: "Fresh & feel-good",
            Color: "green",
            Description: "Tender grains, crisp vegetables, and a creamy herb dressing make this a bright, satisfying bowl for any day of the week.",
            Servings: 2,
            Ingredients:
            [
            "1 cup cooked farro or quinoa",
            "1 cup fresh peas, blanched",
            "1 small cucumber, chopped",
            "1 cup asparagus, sliced and blanched",
            "½ cup Greek yogurt",
            "1 cup mixed soft herbs",
            "1 lemon, juiced",
            "2 tbsp olive oil"
            ],
            Instructions:
            [
            "Blend the yogurt, herbs, lemon juice, and olive oil until smooth. Season to taste.",
            "Toss the cooked grains with half of the dressing while still a little warm.",
            "Fold through the peas, cucumber, and asparagus.",
            "Spoon into bowls and finish with the remaining dressing and extra herbs."
            ]),
        new(
            Slug: "sunday-berry-pancakes",
            Title: "Sunday berry pancakes",
            Image: "/recipes/pancakes.png",
            Category: "Breakfast",
            Time: "20 min",
            Rating: "5.0",
            Tag: "Slow morning",
            Color: "orange",
            Description: "Soft, golden pancakes with crisp edges, piled high with fresh berries and a generous pour of maple syrup.",
            Servings: 4,
            Ingredients:
            [
            "1½ cups all-purpose flour",
            "2 tbsp sugar",
            "2 tsp baking powder",
            "1 large egg",
            "1¼ cups buttermilk",
            "3 tbsp melted butter",
            "1 cup mixed berries",
            "Maple syrup, to serve"
            ],
            Instructions:
            [
            "Whisk the flour, sugar, baking powder, and a pinch of salt in a large bowl.",
            "In a second bowl, whisk the egg, buttermilk, and melted butter. Stir the wet ingredients into the dry until just combined.",
            "Heat a lightly buttered skillet over medium heat. Scoop in the batter and cook until bubbles appear, then flip and cook until golden.",
            "Serve warm with berries and maple syrup."
            ]),
        new(
            Slug: "tomato-butter-bean-soup",
            Title: "Tomato & butter bean soup",
            Image: "/recipes/tomato-soup.png",
            Category: "Dinner",
            Time: "35 min",
            Rating: "4.9",
            Tag: "Comfort in a bowl",
            Color: "orange",
            Description: "A cozy tomato soup made hearty with creamy butter beans, fresh basil, and a good piece of crusty bread on the side.",
            Servings: 4,
            Ingredients:
            [
            "2 tbsp extra-virgin olive oil",
            "1 yellow onion, diced",
            "3 garlic cloves, thinly sliced",
            "1 can (28 oz) crushed tomatoes",
            "2 cans butter beans, drained",
            "2 cups vegetable stock",
            "1 small bunch fresh basil",
            "Crusty bread, to serve"
            ],
            Instructions:
            [
            "Warm the olive oil in a Dutch oven over medium heat. Add the onion and cook until soft, about 6 minutes.",
            "Add the garlic and cook for 30 seconds, then stir in the crushed tomatoes and stock.",
            "Bring to a gentle simmer and cook for 15 minutes. Stir in the butter beans and simmer for another 8–10 minutes.",
            "Season well, tear in the basil, and serve with warm crusty bread."
            ]),
    ];

    public static Recipe? FindBySlug(string slug) =>
        All.FirstOrDefault(recipe => recipe.Slug == slug);
}
