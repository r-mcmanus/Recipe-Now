using Microsoft.EntityFrameworkCore.Migrations;

namespace Recipe_Now.Migrations
{
    public partial class AddRecipes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Recipes",
                columns: table => new
                {
                    Name = table.Column<string>(nullable: false),
                    URL = table.Column<string>(nullable: true),
                    ImagePath = table.Column<string>(nullable: true),
                    Ingredients = table.Column<string>(nullable: true),
                    IsDrink = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipes", x => x.Name);
                });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "'Got Some Crust' Macaroni and Cheese", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F878511.jpg", "'2 cups elbow macaroni', '� cup butter, divided', '1 small onion, chopped', '2 tablespoons all-purpose flour', '� cups milk', '1 teaspoon salt', '1 teaspoon white pepper', '1 teaspoon Worcestershire sauce', '� teaspoon hot pepper sauce (such as Tabasco)', '1 teaspoon prepared yellow mustard', '2 cups shredded Cheddar cheese', '� cup grated Parmesan cheese', '1 cup shredded Cheddar cheese', '� cup grated Parmesan cheese', '1 cup dry bread crumbs']", false, "https://www.allrecipes.com/recipe/60700/got-some-crust-macaroni-and-cheese/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Okinawa Shoyu Pork", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F4650080.jpg", "'� pounds whole pork belly', '� cup soy sauce', '� cup packed brown sugar', '� cup water', '� cup mirin (Japanese sweet wine)', '2 teaspoons ground ginger', '1 clove garlic, or to taste']", false, "https://www.allrecipes.com/recipe/216760/okinawa-shoyu-pork/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Old Fashioned Coconut Cream Pie", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F4899464.jpg", "'1 cup sweetened flaked coconut', '3 cups half-and-half', '2 eggs, beaten', '� cup white sugar', '� cup all-purpose flour', '� teaspoon salt', '1 teaspoon vanilla extract', '1 (9 inch) pie shell, baked', '1 cup frozen whipped topping, thawed']", false, "https://www.allrecipes.com/recipe/12481/old-fashioned-coconut-cream-pie/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Old Fashioned Mac and Cheese", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F4524672.jpg", "'2 cups uncooked elbow macaroni', '4 tablespoons butter', '2 tablespoons all-purpose flour', '2 cups milk', '� onion, minced', 'salt and pepper to taste', '� pound processed cheese food', '� pound shredded Cheddar cheese', '� pound shredded Swiss cheese']", false, "https://www.allrecipes.com/recipe/18805/old-fashioned-mac-and-cheese/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Old Fashioned Onion Rings", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F207422.jpg", "'1 large onion, cut into 1/4-inch slices', '� cups all-purpose flour', '1 teaspoon baking powder', '1 teaspoon salt', '1 egg', '1 cup milk, or as needed', '� cup dry bread crumbs', 'seasoned salt to taste', '1 quart oil for frying, or as needed']", false, "https://www.allrecipes.com/recipe/82659/old-fashioned-onion-rings/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Old Fashioned Potato Cakes", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F874657.jpg", "'2 cups mashed potatoes', '1 cup all-purpose flour', '1 onion, diced', '1 egg', '� teaspoon ground black pepper', '� teaspoon salt', '� cup vegetable oil, or as needed']", false, "https://www.allrecipes.com/recipe/223597/old-fashioned-potato-cakes/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Old Fashioned Potato Salad", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F829508.jpg", "'5 potatoes', '3 eggs', '1 cup chopped celery', '� cup chopped onion', '� cup sweet pickle relish', '� teaspoon garlic salt', '� teaspoon celery salt', '1 tablespoon prepared mustard', 'ground black pepper to taste', '� cup mayonnaise']", false, "https://www.allrecipes.com/recipe/16729/old-fashioned-potato-salad/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Old School Mac n' Cheese", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F872665.jpg", "'� pounds whole-wheat macaroni', '� cup butter', '� cup all-purpose flour', '6 cups milk, divided', '1 tablespoon Worcestershire sauce', '1 teaspoon mustard powder', '1 teaspoon onion powder', '1 teaspoon cayenne pepper', 'salt and ground black pepper to taste', '1 (8 ounce) package shredded Cheddar cheese, divided', '3 (8 ounce) packages shredded American cheese', \"1 (8 ounce) bag potato chips (such as Lay's), crushed\", '1 cup shredded Cheddar cheese', ' cup grated Parmesan cheese', 'butter-flavored cooking spray']", false, "https://www.allrecipes.com/recipe/223400/old-school-mac-n-cheese/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Olive-Brined Air-Fryer Turkey Breast", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F5819973.jpg", "'� cup brine from a can of olives', '� cup buttermilk', '� pounds boneless, skinless turkey breast', '1 sprig fresh rosemary', '2 sprigs fresh thyme']", false, "https://www.allrecipes.com/recipe/268511/olive-brined-air-fryer-turkey-breast/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "One Bowl Chocolate Cake III", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F708879.jpg", "'2 cups white sugar', '� cups all-purpose flour', '� cup unsweetened cocoa powder', '� teaspoons baking powder', '� teaspoons baking soda', '1 teaspoon salt', '2 eggs', '1 cup milk', '� cup vegetable oil', '2 teaspoons vanilla extract', '1 cup boiling water']", false, "https://www.allrecipes.com/recipe/17981/one-bowl-chocolate-cake-iii/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Oh-So-Easy Caramel Sauce", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F3018670.jpg", "'1 cup packed brown sugar', '� cup butter', '� cup milk', '1 teaspoon vanilla extract']", false, "https://www.allrecipes.com/recipe/245648/oh-so-easy-caramel-sauce/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "One-Pan White Cheddar Mac and Cheese", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F5925391.jpg", "'16 ounces uncooked elbow macaroni', '� cups milk', '2 cups water', '1 teaspoon garlic salt', '� teaspoon salt', '� cup margarine', '� teaspoon ground black pepper', '� cups shredded white Cheddar cheese', '� cup shredded Parmesan cheese, divided', '� cup panko bread crumbs', '� cup real bacon bits', '1 tablespoon snipped chives']", false, "https://www.allrecipes.com/recipe/269006/one-pan-white-cheddar-mac-and-cheese/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Orange and Rosemary Baked Olives", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F90697.jpg", "'� cups whole mixed olives, drained', '� cup dry white wine', '2 tablespoons fresh orange juice', '2 tablespoons olive oil', '2 cloves garlic, minced', '2 sprigs fresh rosemary', '2 tablespoons fresh parsley, chopped', '� tablespoons chopped fresh oregano', '4 teaspoons grated orange zest', '� teaspoon crushed red pepper flakes']", false, "https://www.allrecipes.com/recipe/166526/orange-and-rosemary-baked-olives/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Orange Meringue Pie", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F761940.jpg", "'1 (9 inch) unbaked pie crust', '� cup sugar', ' cup cornstarch', '1 pinch salt', '1 cup orange juice', '� cup lemon juice', '� cup water', '4 eggs, separated', '4 tablespoons butter or margarine, cut into pieces', '2 teaspoons grated orange zest', '� cup diced orange segments', '� cup white sugar', '� teaspoon cream of tartar']", false, "https://www.allrecipes.com/recipe/165149/orange-meringue-pie/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Original Nestle Toll House Chocolate Chip Cookies", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F4109813.jpg", "'� cups all-purpose flour', '1 teaspoon baking soda', '1 teaspoon salt', '1 cup butter, softened', '� cup granulated sugar', '� cup packed brown sugar', '1 teaspoon vanilla extract', '2 large eggs', '2 cups NESTLE TOLL HOUSE Semi-Sweet Chocolate Morsels', '1 cup chopped nuts ']", false, "https://www.allrecipes.com/recipe/174864/original-nestle-toll-house-chocolate-chip-cookies/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Orzo Ham Salad", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F632142.jpg", "' cup uncooked orzo pasta', '� cup mayonnaise', '� cup sour cream', '1 tablespoon cider vinegar', '1 tablespoon Dijon mustard', '1 tablespoon yellow mustard', '2 tablespoons chopped fresh chives', '� teaspoon white sugar', '� teaspoon black pepper', '� teaspoon salt', '� cups chopped fully cooked ham', '1 cup diced red onion', '� cup chopped green bell pepper', '� cup halved cherry or grape tomatoes']", false, "https://www.allrecipes.com/recipe/213592/orzo-ham-salad/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Our Best Cheesecake", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F5962310.jpg", "'� cups HONEY MAID Graham Cracker Crumbs', ' cup butter, melted', '� cups sugar, divided', '3 (8 ounce) packages PHILADELPHIA Cream Cheese, softened', \"1 cup BREAKSTONE'S or KNUDSEN Sour Cream\", '2 teaspoons vanilla', '3 eggs', '1 (21 ounce) can cherry pie filling']", false, "https://www.allrecipes.com/recipe/236064/our-best-cheesecake/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Our Favorite Balsamic Vinaigrette", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F670959.jpg", "'� cup olive oil', '� cup balsamic vinegar', '1 teaspoon honey', '1 teaspoon Dijon mustard', '1 shallot, minced', '1 clove garlic, minced', 'salt and ground black pepper to taste']", false, "https://www.allrecipes.com/recipe/218337/our-favorite-balsamic-vinaigrette/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Oven Baked Omelet", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F2060670.jpg", "'1 teaspoon butter', '9 large eggs', '� cup sour cream', '� cup milk', '1 teaspoon salt', '2 green onions, chopped', '� cup shredded Cheddar cheese']", false, "https://www.allrecipes.com/recipe/233287/oven-baked-omelet/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Oven-Roasted Asparagus", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fcf-images.us-east-1.prod.boltdns.net%2Fv1%2Fstatic%2F1033249144001%2F7aec9997-6b00-4a22-9c5c-7e6e70f43a5a%2F9b657006-1a90-47a6-8d68-674be63206a9%2F1280x720%2Fmatch%2Fimage.jpg", "'1 bunch thin asparagus spears, trimmed', '3 tablespoons olive oil', '� tablespoons grated Parmesan cheese', '1 clove garlic, minced', '1 teaspoon sea salt', '� teaspoon ground black pepper', '1 tablespoon lemon juice']", false, "https://www.allrecipes.com/recipe/214931/oven-roasted-asparagus/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Oven-Roasted Turkey Breast", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F2663892.jpg", "'� cup butter, softened', '1 clove garlic, minced', '1 teaspoon paprika', '1 teaspoon Italian seasoning', '� teaspoon salt-free garlic and herb seasoning blend (such as Mrs. Dash)', 'salt and ground black pepper to taste', '1 (3 pound) turkey breast with skin', '1 teaspoon minced shallot', '1 tablespoon butter', '1 splash dry white wine', '1 cup chicken stock', '3 tablespoons all-purpose flour', '2 tablespoons half-and-half']", false, "https://www.allrecipes.com/recipe/229658/oven-roasted-turkey-breast/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Orange and Milk-Braised Pork Carnitas", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F2280918.jpg", "'� pounds boneless pork shoulder, cut into large pieces', '1 tablespoon freshly ground black pepper', '1 tablespoon kosher salt, or more to taste', '2 tablespoons vegetable oil', '2 bay leaves', '2 teaspoons ground cumin', '1 teaspoon dried oregano', '� teaspoon cayenne pepper', '1 orange, juiced and zested', '2 cups whole milk']", false, "https://www.allrecipes.com/recipe/242405/orange-and-milk-braised-pork-carnitas/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Pan de Muertos (Mexican Bread of the Dead)", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F286833.jpg", "'� cup margarine', '� cup milk', '� cup warm water (110 degrees F/45 degrees C)', '3 cups all-purpose flour', '� teaspoons active dry yeast', '� teaspoon salt', '2 teaspoons anise seed', '� cup white sugar', '2 eggs, beaten', '2 teaspoons orange zest', '� cup white sugar', '� cup orange juice', '1 tablespoon orange zest', '2 tablespoons white sugar']", false, "https://www.allrecipes.com/recipe/7224/pan-de-muertos-mexican-bread-of-the-dead/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "October Apple Pie", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F1780211.jpg", "'1 recipe pastry for a 9 inch double crust pie', '6 cups thinly sliced apples', '1 lemon, juiced', '� cup packed light brown sugar', '� cup white sugar', '2 teaspoons ground cinnamon', '� teaspoon freshly grated nutmeg', '3 tablespoons all-purpose flour', '� cup butter, chilled and diced', '9 caramel squares, quartered', '1 tablespoon white sugar']", false, "https://www.allrecipes.com/recipe/12247/october-apple-pie/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Nutella Cream Cheese Pound Cake", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F5901065.jpg", "'� cups all-purpose flour', '� teaspoon baking powder', '� cup white sugar', '� cup cream cheese, at room temperature  ', '� cup full fat plain yogurt, at room temperature', '3 eggs, at room temperature', '� teaspoon vanilla bean paste', '� cup chocolate-hazelnut spread (such as Nutella)']", false, "https://www.allrecipes.com/recipe/268910/nutella-cream-cheese-pound-cake/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Mom's Best Macaroni Salad", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F714651.jpg", "'16 ounces uncooked elbow macaroni', '4 carrots, shredded', '1 large red onion, chopped', '� green bell pepper, seeded and chopped', '� red bell pepper, seeded and chopped', '1 cup chopped celery', '2 cups mayonnaise', '1 (14 ounce) can sweetened condensed milk', '� cup white sugar', '� cup white vinegar', 'salt and pepper to taste']", false, "https://www.allrecipes.com/recipe/65052/moms-best-macaroni-salad/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Mom's Country Gravy", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F6173609.jpg", "'� cup vegetable oil', '� cup all-purpose flour', '1 teaspoon salt', '1 teaspoon ground black pepper', '4 cups milk']", false, "https://www.allrecipes.com/recipe/65104/moms-country-gravy/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Mom's Fabulous Chicken Pot Pie with Biscuit Crust", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F6660391.jpg", "'� cup butter', '1 small onion, chopped', '3 celery ribs, chopped', '3 carrots, chopped', ' cup frozen peas', '3 tablespoons chopped fresh parsley', '� teaspoon dried thyme', '� cup all-purpose flour', '2 cups lower-sodium chicken broth', ' cup half-and-half cream', 'salt and ground black pepper to taste', '3 cups cooked chicken, cut into bite-size pieces', '1 (16.3 ounce) can refrigerated flaky-style biscuits (such as Pillsbury Grands)', '1 egg yolk, beaten', '1 tablespoon water']", false, "https://www.allrecipes.com/recipe/216758/moms-fabulous-chicken-pot-pie-with-biscuit-crust/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Mom's Favorite Baked Mac and Cheese", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F743158.jpg", "'2 tablespoons butter', '� cup finely chopped onion', '2 tablespoons all-purpose flour', '2 cups milk', '� teaspoon salt', '� teaspoon dry mustard', '� teaspoon ground black pepper', '1 (8 ounce) package elbow macaroni', '2 cups shredded sharp Cheddar cheese', '1 (8 ounce) package processed American cheese, cut into strips']", false, "https://www.allrecipes.com/recipe/24321/moms-favorite-baked-mac-and-cheese/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Mom's Scalloped Potatoes", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F1883772.jpg", "'3 pounds potatoes, thinly sliced ', '� onion, thinly sliced', '9 tablespoons all-purpose flour, divided', '6 tablespoons butter, diced and divided', 'salt and ground black pepper to taste', '3 cups whole milk, or as needed']", false, "https://www.allrecipes.com/recipe/240290/moms-scalloped-potatoes/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Mom's Zucchini Bread", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F1037957.jpg", "'3 cups all-purpose flour', '1 teaspoon salt', '1 teaspoon baking soda', '1 teaspoon baking powder', '1 tablespoon ground cinnamon', '3 eggs', '1 cup vegetable oil', '� cups white sugar', '3 teaspoons vanilla extract', '2 cups grated zucchini', '1 cup chopped walnuts']", false, "https://www.allrecipes.com/recipe/6698/moms-zucchini-bread/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Monkey Bread I", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F546316.jpg", "'3 (12 ounce) packages refrigerated biscuit dough', '1 cup white sugar', '2 teaspoons ground cinnamon', '� cup margarine', '1 cup packed brown sugar', '� cup chopped walnuts', '� cup raisins']", false, "https://www.allrecipes.com/recipe/6815/monkey-bread-i/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Monte Cristo Sandwich", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F4728363.jpg", "'2 slices bread', '1 teaspoon mayonnaise', '1 teaspoon prepared mustard', '2 slices cooked ham', '2 slices cooked turkey meat', '1 slice Swiss cheese', '1 egg', '� cup milk']", false, "https://www.allrecipes.com/recipe/20803/monte-cristo-sandwich/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Mouse's Macaroni and Cheese", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F390253.jpg", "'� cups uncooked elbow macaroni', '� cup butter', '2 tablespoons all-purpose flour', '1 teaspoon mustard powder', '1 teaspoon ground black pepper', '2 cups milk', '8 ounces American cheese, cubed', '8 ounces processed cheese food (eg. Velveeta), cubed', '� cup seasoned dry bread crumbs']", false, "https://www.allrecipes.com/recipe/11805/mouses-macaroni-and-cheese/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Oatmeal Raisin Cookies I", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F5435445.jpg", "'� cup butter, softened', '� cup white sugar', '� cup packed light brown sugar', '2 eggs', '1 teaspoon vanilla extract', '� cups all-purpose flour', '1 teaspoon baking soda', '� teaspoon ground cinnamon', '� teaspoon salt', '� cups rolled oats', '1 cup raisins']", false, "https://www.allrecipes.com/recipe/10264/oatmeal-raisin-cookies-i/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Mouth-Watering Stuffed Mushrooms", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F414837.jpg", "'12 whole fresh mushrooms', '1 tablespoon vegetable oil', '1 tablespoon minced garlic', '1 (8 ounce) package cream cheese, softened', '� cup grated Parmesan cheese', '� teaspoon ground black pepper', '� teaspoon onion powder', '� teaspoon ground cayenne pepper']", false, "https://www.allrecipes.com/recipe/15184/mouth-watering-stuffed-mushrooms/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Mussels Mariniere", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F894859.jpg", "'4 quarts mussels, cleaned and debearded', '2 cloves garlic, minced', '1 onion, chopped', '6 tablespoons chopped fresh parsley', '1 bay leaf', '� teaspoon dried thyme', '2 cups white wine', '3 tablespoons butter, divided']", false, "https://www.allrecipes.com/recipe/12718/mussels-mariniere/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "My Best Clam Chowder", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F1700474.jpg", "'3 (6.5 ounce) cans minced clams', '1 cup minced onion', '1 cup diced celery', '2 cups cubed potatoes', '1 cup diced carrots', '� cup butter', '� cup all-purpose flour', '1 quart half-and-half cream', '2 tablespoons red wine vinegar', '� teaspoons salt', 'ground black pepper to taste']", false, "https://www.allrecipes.com/recipe/13041/my-best-clam-chowder/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "My Favorite Beet Salad", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F672001.jpg", "'6 large beets, trimmed', '� cup extra virgin olive oil', 'salt and ground black pepper to taste', '1 (8 ounce) package baby spinach leaves', '2 tomatoes, cut into bite-sized pieces', '2 avocados - peeled, pitted, and cut into bite-sized pieces', '� red onion, chopped, or to taste', '1 (4 ounce) container crumbled feta cheese', '� cup balsamic vinegar', '� cup extra-virgin olive oil', '1 tablespoon Dijon mustard, or more to taste']", false, "https://www.allrecipes.com/recipe/218179/my-favorite-beet-salad/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "My Favorite Chicken Salad", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F5261952.jpg", "'2 cooked skinless, boneless chicken breast halves, cut into cubes', '3 stalks celery, finely diced', '� cup chopped pecans', '� cup mayonnaise', '2 tablespoons minced yellow onion', '� tablespoons sweet pickle relish', '2 teaspoons prepared mustard', '� teaspoons ground black pepper', '� teaspoons minced fresh dill', '1 teaspoon lemon juice', '� teaspoon white sugar', '� teaspoon salt', '� teaspoon garlic powder', '� teaspoon paprika']", false, "https://www.allrecipes.com/recipe/234350/my-favorite-chicken-salad/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Naan", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F1016308.jpg", "'1 (.25 ounce) package active dry yeast', '1 cup warm water', '� cup white sugar', '3 tablespoons milk', '1 egg, beaten', '2 teaspoons salt', '4\\u2009� cups bread flour', '2 teaspoons minced garlic', '� cup butter, melted']", false, "https://www.allrecipes.com/recipe/14565/naan/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Napa Cabbage Salad", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F3671208.jpg", "'1 head napa cabbage', '1 bunch minced green onions', ' cup butter', '1 (3 ounce) package ramen noodles, broken', '2 tablespoons sesame seeds', '1 cup slivered almonds', '� cup cider vinegar', '� cup vegetable oil', '� cup white sugar', '2 tablespoons soy sauce']", false, "https://www.allrecipes.com/recipe/18517/napa-cabbage-salad/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Natasha's Chicken Burgers", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F3752216.jpg", "'1 pound extra-lean ground chicken', '� cup Italian-seasoned bread crumbs, divided', '� small onion, finely grated', '1 egg', '2 cloves garlic, minced', 'salt and ground black pepper to taste', '2 teaspoons olive oil']", false, "https://www.allrecipes.com/recipe/232375/natashas-chicken-burgers/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "New England Clam Chowder I", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F751037.jpg", "'4 slices bacon, diced', '� cups chopped onion', '� cups water', '4 cups peeled and cubed potatoes', '� teaspoons salt', 'ground black pepper to taste', '3 cups half-and-half', '3 tablespoons butter', '2 (10 ounce) cans minced clams']", false, "https://www.allrecipes.com/recipe/13078/new-england-clam-chowder-i/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "No-Yeast Pizza Crust", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F4548649.jpg", "' cups all-purpose flour', '1 teaspoon baking powder', '� teaspoon salt', '� cup fat-free milk', '2 tablespoons olive oil']", false, "https://www.allrecipes.com/recipe/244638/no-yeast-pizza-crust/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Mushroom Pork Chops", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F714402.jpg", "'4 pork chops', 'salt and pepper to taste', '1 pinch garlic salt, or to taste', '1 onion, chopped', '� pound fresh mushrooms, sliced', '1 (10.75 ounce) can  condensed cream of mushroom soup']", false, "https://www.allrecipes.com/recipe/14746/mushroom-pork-chops/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Mom's Baked Macaroni and Cheese", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F3404143.jpg", "'1 (16 ounce) package macaroni', '1 (10.75 ounce) can  condensed Cheddar cheese soup', '1 cup milk', '1 pound shredded Colby cheese']", false, "https://www.allrecipes.com/recipe/19427/moms-baked-macaroni-and-cheese/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Pasta Salad with Homemade Dressing", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F1265880.jpg", "'1 (8 ounce) package uncooked tri-color rotini pasta', '6 ounces pepperoni sausage, diced', '6 ounces provolone cheese, cubed', '1 red onion, thinly sliced', '1 small cucumber, thinly sliced', '� cup chopped green bell pepper', '� cup chopped red bell pepper', '1 (6 ounce) can pitted black olives', '� cup minced fresh parsley', '� cup grated Parmesan cheese', '� cup olive oil', '� cup red wine vinegar', '2 cloves garlic, minced', '1 teaspoon dried basil', '1 teaspoon dried oregano', '� teaspoon ground mustard seed', '� teaspoon salt', ' teaspoon ground black pepper']", false, "https://www.allrecipes.com/recipe/73963/pasta-salad-with-homemade-dressing/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Pasta with Peas and Sausage", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F1800425.jpg", "'1 pound rigatoni pasta', '2 tablespoons olive oil', '1 clove garlic, minced', '1 pound sweet Italian sausage, casings removed', '12 ounces frozen green peas', '� cups heavy cream', '4 tablespoons butter', '2 tablespoons grated Parmesan cheese']", false, "https://www.allrecipes.com/recipe/23974/pasta-with-peas-and-sausage/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Portuguese Custard Tarts (Pasteis de Nata)", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F5948860.jpg", "'1 cup all-purpose flour', '� teaspoon kosher salt', ' cup cold water', '1 stick high-quality unsalted butter, fully softened, divided', '� cup white sugar', '� cup water', '1 tablespoon water', '1 cinnamon stick', '1 lemon, zested in large strips', ' cup all-purpose flour', '� teaspoon kosher salt', '� cups milk', '6 large egg yolks', '1 teaspoon vanilla extract']", false, "https://www.allrecipes.com/recipe/269064/portuguese-custard-tarts-pasteis-de-nata/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Potato Pancakes I", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F6188685.jpg", "'4 large potatoes', '1 yellow onion', '1 egg, beaten', '1 teaspoon salt', '2 tablespoons all-purpose flour', 'ground black pepper to taste', '2 cups vegetable oil for frying']", false, "https://www.allrecipes.com/recipe/14089/potato-pancakes-i/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Prime Rib Au Jus with Yorkshire Pudding", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F343775.jpg", "'1 (5 pound) bone-in beef rib roast', '8 cloves garlic, quartered', '� teaspoon salt', '1 teaspoon freshly ground black pepper', '2 cups eggs', '2 cups milk', '1 pinch salt', '2 cups all-purpose flour', '� cup pan drippings from prime rib', '� cup white wine', '2 cups beef stock']", false, "https://www.allrecipes.com/recipe/160399/prime-rib-au-jus-with-yorkshire-pudding/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Pumpkin Bars with Cream Cheese Frosting", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F3090361.jpg", "'cooking spray', '4 eggs', '2 cups white sugar', '1 cup vegetable oil', '1 (15 ounce) can pumpkin puree', '2 cups all-purpose flour', '2 teaspoons baking powder', '2 teaspoons ground cinnamon', '1 teaspoon baking soda', '� teaspoon salt', '1 (8 ounce) package cream cheese, softened', '1 cup butter, softened', '2 teaspoons vanilla extract', \"4 cups confectioners' sugar\", '1 pinch ground cinnamon, for dusting']", false, "https://www.allrecipes.com/recipe/229508/pumpkin-bars-with-cream-cheese-frosting/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Pumpkin Cake III", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F733165.jpg", "'2 cups white sugar', '� cups vegetable oil', '1 teaspoon vanilla extract', '2 cups canned pumpkin', '4 eggs', '2 cups all-purpose flour', '3 teaspoons baking powder', '2 teaspoons baking soda', '� teaspoon salt', '2 teaspoons ground cinnamon', '1 cup chopped walnuts']", false, "https://www.allrecipes.com/recipe/19079/pumpkin-cake-iii/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Pumpkin Chocolate Chip Cookies III", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F473562.jpg", "'1 cup canned pumpkin', '1 cup white sugar', '� cup vegetable oil', '1 egg', '2 cups all-purpose flour', '2 teaspoons baking powder', '2 teaspoons ground cinnamon', '� teaspoon salt', '1 teaspoon baking soda', '1 teaspoon milk', '1 tablespoon vanilla extract', '2 cups semisweet chocolate chips', '� cup chopped walnuts']", false, "https://www.allrecipes.com/recipe/10740/pumpkin-chocolate-chip-cookies-iii/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Pumpkin Chocolate Chip Muffins", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F266600.jpg", "'� cup white sugar', '� cup vegetable oil', '2 eggs', '� cup canned pumpkin', '� cup water', '� cups all-purpose flour', '� teaspoon baking powder', '� teaspoon baking soda', '� teaspoon ground cloves', '� teaspoon ground cinnamon', '� teaspoon salt', '� teaspoon ground nutmeg', '� cup semisweet chocolate chips']", false, "https://www.allrecipes.com/recipe/7958/pumpkin-chocolate-chip-muffins/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Pumpkin Dump Cake", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F1046644.jpg", "'1 (29 ounce) can pumpkin puree', '3 eggs', '� cup packed brown sugar', '� cup white sugar', '1 (12 fluid ounce) can evaporated milk', '1 teaspoon ground cinnamon', '� teaspoon ground ginger', '� teaspoon ground cloves', '� teaspoon salt', '1 (18.25 ounce) package spice cake mix', '� cup coarsely chopped pecans', '� cup melted butter']", false, "https://www.allrecipes.com/recipe/26060/pumpkin-dump-cake/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Pumpkin Fluff Dip", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F25114.jpg", "'1 (16 ounce) container frozen whipped topping, thawed', '1 (5 ounce) package instant vanilla pudding mix', '1 (15 ounce) can solid pack pumpkin', '1 teaspoon pumpkin pie spice']", false, "https://www.allrecipes.com/recipe/24740/pumpkin-fluff-dip/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Pork Loin Roast with Baby Bellas", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F3805141.jpg", "'1 (3 pound) boneless pork loin roast, trimmed of fat', '3 cloves garlic, divided', '8 small baby bella mushrooms, roughly chopped', '� teaspoon dried parsley', '� teaspoon dried thyme', 'salt and ground black pepper to taste', '1 teaspoon olive oil', '� cup dry white wine', '� cup chicken broth', '1 teaspoon cornstarch, or as needed', '� cup water']", false, "https://www.allrecipes.com/recipe/247371/pork-loin-roast-with-baby-bellas/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Pumpkin Pancakes", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F705316.jpg", "'� cups milk', '1 cup pumpkin puree', '1 egg', '2 tablespoons vegetable oil', '2 tablespoons vinegar', '2 cups all-purpose flour', '3 tablespoons brown sugar', '2 teaspoons baking powder', '1 teaspoon baking soda', '1 teaspoon ground allspice', '1 teaspoon ground cinnamon', '� teaspoon ground ginger', '� teaspoon salt']", false, "https://www.allrecipes.com/recipe/17036/pumpkin-pancakes/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Pumpkin Pie Spice I", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F458219.jpg", "'� cup ground cinnamon', '4 teaspoons ground nutmeg', '4 teaspoons ground ginger', '1 tablespoon ground allspice']", false, "https://www.allrecipes.com/recipe/20477/pumpkin-pie-spice-i/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Pumpkin Roll I", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fstatic.onecms.io%2Fwp-content%2Fuploads%2Fsites%2F43%2F2020%2F10%2F26%2FPumpkin-Roll_1st-Place.jpg", "'3  large eggs eggs, beaten', '1 cup white sugar', '� teaspoon ground cinnamon', ' cup pumpkin puree', '� cup all-purpose flour', '1 teaspoon baking soda', '2 tablespoons butter, softened', '8 ounces cream cheese', \"1 cup confectioners' sugar\", '� teaspoon vanilla extract', \"confectioners' sugar for dusting\"]", false, "https://www.allrecipes.com/recipe/13731/pumpkin-roll-i/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Pumpkin Soup", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fcf-images.us-east-1.prod.boltdns.net%2Fv1%2Fstatic%2F1033249144001%2Fc91701c4-7afb-43c7-a561-99e8146603ac%2Fc028ecb0-f977-405d-91f6-d2bfe229d772%2F1280x720%2Fmatch%2Fimage.jpg", "'6 cups chicken stock', '� teaspoons salt', '4 cups pumpkin puree', '1 teaspoon chopped fresh parsley', '1 cup chopped onion', '� teaspoon chopped fresh thyme', '1 clove garlic, minced', '� cup heavy whipping cream', '5 whole black peppercorns']", false, "https://www.allrecipes.com/recipe/9191/pumpkin-soup/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Pumpkin Spice Cupcakes", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F466758.jpg", "'� cups all-purpose flour', '1 teaspoon ground cinnamon', '� teaspoon ground nutmeg', '� teaspoon ground ginger', '� teaspoon ground cloves', '� teaspoon ground allspice', '� teaspoon salt', '1 tablespoon baking powder', '� teaspoon baking soda', '� cup butter, softened', '1 cup white sugar', ' cup brown sugar', '2 eggs, room temperature', '� cup milk', '1 cup pumpkin puree', '1 (8 ounce) package cream cheese, softened', '� cup butter, softened', \"3 cups confectioners' sugar\", '1 teaspoon vanilla extract', '1 teaspoon ground cinnamon']", false, "https://www.allrecipes.com/recipe/153245/pumpkin-spice-cupcakes/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Pumpkin Spice Latte Coffee Cake", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F8680962.jpg", "'1 cup all-purpose flour', '1 cup firmly packed dark brown sugar', '2 tablespoons instant espresso powder', '1 tablespoon unsweetened cocoa powder', '1 teaspoon pumpkin pie spice', '1 teaspoon vanilla extract', '1 pinch salt', '� cup unsalted butter, cut into cubes', '� cups all-purpose flour', '1 tablespoon instant espresso powder', '2 teaspoons pumpkin pie spice', '1 teaspoon baking powder', '1 teaspoon baking soda', '� teaspoon salt', '� cup unsalted butter, softened', '� cups white sugar', '3 large eggs, at room temperature', '1 cup pumpkin puree', '1 tablespoon vanilla extract', '� cup strongly brewed coffee, cooled to room temperature', '� cup heavy cream, at room temperature']", false, "https://www.allrecipes.com/recipe/282211/pumpkin-spice-latte-coffee-cake/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Pumpkin Whoopie Pies", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F744202.jpg", "'2 cups packed brown sugar', '1 cup vegetable oil', '� cups solid pack pumpkin puree', '2 eggs', '3 cups all-purpose flour', '1 teaspoon salt', '1 teaspoon baking powder', '1 teaspoon baking soda', '1 teaspoon vanilla extract', '� tablespoons ground cinnamon', '� tablespoon ground ginger', '� tablespoon ground cloves', '1 egg white', '2 tablespoons milk', '1 teaspoon vanilla extract', \"2 cups confectioners' sugar\", '� cup shortening']", false, "https://www.allrecipes.com/recipe/11331/pumpkin-whoopie-pies/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Quick & Crispy Home Fries", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F4516186.jpg", "'3 large russet potatoes, peeled and quartered', '2 tablespoons olive oil', '1 tablespoon butter', 'Salt and freshly ground black pepper to taste', '� teaspoon paprika', 'cayenne pepper to taste', '1 pinch garlic powder', '1 pinch onion powder', '1 tablespoon Chopped fresh chives']", false, "https://www.allrecipes.com/recipe/258117/quick-crispy-home-fries/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Quick and Almost-Professional Buttercream Icing", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fcf-images.us-east-1.prod.boltdns.net%2Fv1%2Fstatic%2F1033249144001%2Fd3dbde80-ff34-4705-9f0c-fd2fd38467ac%2Fc7220f0e-f238-4cf4-b1b3-2691b2dacce3%2F640x360%2Fmatch%2Fimage.jpg", "'� cup unsalted butter, softened', '� teaspoons vanilla extract', \"2 cups confectioners' sugar, sifted\", '2 tablespoons milk', '3 drops food coloring, or as needed']", false, "https://www.allrecipes.com/recipe/174347/quick-and-almost-professional-buttercream-icing/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Quick and Easy Alfredo Sauce", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F5149928.jpg", "'� cup butter', '1 (8 ounce) package cream cheese', '2 teaspoons garlic powder', '2 cups milk', '6 ounces grated Parmesan cheese', ' teaspoon ground black pepper']", false, "https://www.allrecipes.com/recipe/19402/quick-and-easy-alfredo-sauce/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Pumpkin Pie Bread Pudding", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F2777912.jpg", "'1 loaf French bread, cut into cubes', '� cup raisins, or more to taste', '1 teaspoon maple-flavored extract', '1 teaspoon rum-flavored extract', '� cup water, or as needed', '3 cups milk', '1 (15 ounce) can pumpkin puree', '1 (14 ounce) can sweetened condensed milk (such as Eagle Brand)', '3 large eggs', ' cup brown sugar', ' cup butter, melted', '2 tablespoons molasses', '2 teaspoons vanilla extract', '2 teaspoons pumpkin pie spice', '2 teaspoons ground cinnamon', '1 teaspoon ground allspice', '� teaspoon ground ginger']", false, "https://www.allrecipes.com/recipe/239483/pumpkin-pie-bread-pudding/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Pasta Salad", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F3512373.jpg", "'1 pound tri-colored spiral pasta', '6 tablespoons salad seasoning mix', '1 (16 ounce) bottle Italian-style salad dressing', '2 cups cherry tomatoes, diced', '1 green bell pepper, chopped', '1 red bell pepper, diced', '� yellow bell pepper, chopped', '1 (2.25 ounce) can black olives, chopped']", false, "https://www.allrecipes.com/recipe/14385/pasta-salad/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Pomelo Salad with Rice Vermicelli", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F7707962.jpg", "'2 ounces rice vermicelli', '� large pomelo- peeled, membranes removed, and cut into bite-sized pieces', '� cup julienned carrot', '� cup julienned cucumber', '1 scallion, thinly sliced', '2 tablespoons chopped cilantro', '1 tablespoon fish sauce', '1 tablespoon water', '1 tablespoon Thai sweet chili sauce', '1 teaspoon packed brown sugar', '1 teaspoon seasoned rice vinegar']", false, "https://www.allrecipes.com/recipe/278679/pomelo-salad-with-rice-vermicelli/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Pine Cone Cheese Ball", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F1833381.jpg", "'2 (8 ounce) packages cream cheese, softened', '4 ounces goat cheese, softened', '3 tablespoons chopped fresh flat-leaf parsley', '2 tablespoons chopped fresh tarragon', '1 tablespoon chopped fresh thyme', '� clove garlic, minced, or more to taste', '1 pinch cayenne pepper, or to taste', 'salt and ground black pepper to taste', '1 cup whole almonds, or as needed', '3 large fresh rosemary sprigs']", false, "https://www.allrecipes.com/recipe/240702/pine-cone-cheese-ball/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Pastry Cream for Pies", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F5762967.jpg", "'1 cup milk', '3 egg yolks', '� cup white sugar', '� cup all-purpose flour', '1 tablespoon butter', '1 tablespoon vanilla extract']", false, "https://www.allrecipes.com/recipe/23355/pastry-cream-for-pies/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Paul's Pumpkin Bars", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fcf-images.us-east-1.prod.boltdns.net%2Fv1%2Fstatic%2F1033249144001%2Fc164f5b0-e8a0-4705-9b22-0d9792a78c2d%2F1368174d-c535-4697-9d36-2ced6124154a%2F1280x720%2Fmatch%2Fimage.jpg", "'4 large eggs', ' cups white sugar', '1 cup vegetable oil', '1 (15 ounce) can pumpkin puree', '2 cups all-purpose flour', '2 teaspoons baking powder', '1 teaspoon baking soda', '2 teaspoons ground cinnamon', '1 teaspoon salt', '1 (3 ounce) package cream cheese, softened', '� cup butter, softened', '1 teaspoon vanilla extract', \"2 cups sifted confectioners' sugar\"]", false, "https://www.allrecipes.com/recipe/11646/pauls-pumpkin-bars/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Peach Cobbler Dump Cake I", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F6500176.jpg", "'2 (16 ounce) cans peaches in heavy syrup', '1 (18.25 ounce) package yellow cake mix', '� cup butter', '� teaspoon ground cinnamon, or to taste']", false, "https://www.allrecipes.com/recipe/7987/peach-cobbler-dump-cake-i/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Peach Pie the Old Fashioned Two Crust Way", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F264202.jpg", "'1 (15 ounce) package pastry for a 9 inch double crust pie', '1 egg, beaten', '5 cups sliced peeled peaches', '2 tablespoons lemon juice', '� cup all-purpose flour', '1 cup white sugar', '� teaspoon ground cinnamon', '� teaspoon ground nutmeg', '� teaspoon salt', '2 tablespoons butter']", false, "https://www.allrecipes.com/recipe/87979/peach-pie-the-old-fashioned-two-crust-way/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Peanut Butter Banana Smoothie", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F1011848.jpg", "'2 bananas, broken into chunks', '2 cups milk', '� cup peanut butter', '2 tablespoons honey, or to taste', '2 cups ice cubes']", false, "https://www.allrecipes.com/recipe/221261/peanut-butter-banana-smoothie/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Peanut Butter Pie", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F190359.jpg", "'1 (9 inch) prepared graham cracker crust', '1 (8 ounce) package cream cheese, softened', '� cup creamy peanut butter', \"� cup confectioners' sugar\", '1 (16 ounce) container frozen whipped topping, thawed', '15 miniature chocolate covered peanut butter cups, unwrapped']", false, "https://www.allrecipes.com/recipe/9174/peanut-butter-pie/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Pearl Couscous Salad", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F2161670.jpg", "'5 tablespoons olive oil, divided', '2 cups pearl (Israeli) couscous', '� cups water', '� cup French lentils', 'water to cover', '2 Roma (plum) tomatoes, diced', '1 small cucumber, seeded and diced', '1 red bell pepper, diced', '� cup dried cranberries', '� cup golden raisins', ' cup diced red onion', '� cup 1/2-inch slices of fresh chives', '2 tablespoons chopped flat-leaf parsley, or more to taste', '1 green onion, thinly sliced', '1 teaspoon ground sumac', '� cup olive oil', '2 lemons, juiced', '2 tablespoons honey, or more to taste', 'salt and ground black pepper to taste']", false, "https://www.allrecipes.com/recipe/239813/pearl-couscous-salad/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Pecan Pie", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F5819873.jpg", "'� cups white sugar', '� cup dark corn syrup', '� cup butter', '1 tablespoon cold water', '2 teaspoons cornstarch', '3 eggs', '� teaspoon salt', '1 teaspoon vanilla extract', '� cups chopped pecans', '1 (9 inch) unbaked pie shell']", false, "https://www.allrecipes.com/recipe/9487/pecan-pie/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Pecan Snack", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F4102938.jpg", "'1 egg white', '1 tablespoon water', '1 pound pecans', '� cup white sugar', '1 teaspoon ground cinnamon', '1 teaspoon salt']", false, "https://www.allrecipes.com/recipe/27157/pecan-snack/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Pollo alla Birra for Two", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F7999248.jpg", "'2 skinless chicken leg quarters', '1 large clove garlic, crushed', '2 tablespoons dried rosemary, divided', 'salt and freshly ground pepper to taste', '1 cup beer', '3 tablespoons cornstarch', '3 tablespoons olive oil', '1 medium yellow onion, halved and cut into 1/4-inch-thick slices']", false, "https://www.allrecipes.com/recipe/279648/pollo-alla-birra-for-two/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Penang Pork Satay", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F6941217.jpg", "'� inch piece turmeric root, peeled and sliced thinly across the grain', '1 teaspoon ground turmeric, or to taste', '1 (2 inch) piece fresh ginger root, sliced', '1 large shallot, roughly chopped', '8 cloves garlic, peeled, or more to taste', '� cup light brown sugar', '3 tablespoons ancho chili powder', '2 teaspoons ground coriander', '1 teaspoon chipotle chili powder', '� teaspoon cayenne pepper', '� cup rice vinegar', '2 tablespoons soy sauce', '1 tablespoon fish sauce', '1 teaspoon tamarind paste', '� bunch lightly packed cilantro leaves and stems', '1 (2 1/2 pound) pork shoulder roast ', '1 tablespoon kosher salt', '5 large metal skewers']", false, "https://www.allrecipes.com/recipe/275397/penang-pork-satay/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Perfect Pumpkin Pie", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F5895606.jpg", "'1 (15 ounce) can pumpkin', '1 (14 ounce) can EAGLE BRAND Sweetened Condensed Milk', '2 large eggs', '1 teaspoon ground cinnamon', '� teaspoon ground ginger', '� teaspoon ground nutmeg', '� teaspoon salt', '1 (9 inch) unbaked pie crust']", false, "https://www.allrecipes.com/recipe/23439/perfect-pumpkin-pie/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Perfect Summer Fruit Salad", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F2289556.jpg", "' cup fresh orange juice', ' cup fresh lemon juice', ' cup packed brown sugar', '� teaspoon grated orange zest', '� teaspoon grated lemon zest', '1 teaspoon vanilla extract', '2 cups cubed fresh pineapple', '2 cups strawberries, hulled and sliced', '3 kiwi fruit, peeled and sliced', '3 bananas, sliced', '2 oranges, peeled and sectioned', '1 cup seedless grapes ', '2 cups blueberries']", false, "https://www.allrecipes.com/recipe/214947/perfect-summer-fruit-salad/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Perfect Sushi Rice", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F5646437.jpg", "'2 cups uncooked glutinous white rice (sushi rice)', '3 cups water', '� cup rice vinegar', '1 tablespoon vegetable oil', '� cup white sugar', '1 teaspoon salt']", false, "https://www.allrecipes.com/recipe/99211/perfect-sushi-rice/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Perfect Ten Baked Cod", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F4523973.jpg", "'2 tablespoons butter', '� sleeve buttery round crackers (such as Ritz), crushed', '2 tablespoons butter', '1 pound thick-cut cod loin', '� lemon, juiced', '� cup dry white wine', '1 tablespoon chopped fresh parsley', '1 tablespoon chopped green onion', '1 lemon, cut into wedges']", false, "https://www.allrecipes.com/recipe/228319/perfect-ten-baked-cod/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Perfect Turkey", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F1656944.jpg", "'1 (18 pound) whole turkey, neck and giblets removed', '2 cups kosher salt', '� cup butter, melted', '2 large onions, peeled and chopped', '4 carrots, peeled and chopped', '4 stalks celery, chopped', '2 sprigs fresh thyme', '1 bay leaf', '1 cup dry white wine']", false, "https://www.allrecipes.com/recipe/43655/perfect-turkey/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Pesto Pasta", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F4475574.jpg", "'� cup chopped onion', '� tablespoons pesto', '2 tablespoons olive oil', '2 tablespoons grated Parmesan cheese', '1 (16 ounce) package pasta', 'salt to taste', 'ground black pepper to taste']", false, "https://www.allrecipes.com/recipe/11887/pesto-pasta/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Picante Chicken Chili", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F4574116.jpg", "'� teaspoons vegetable oil, or as needed', '1 large white onion, chopped', '2 cloves garlic, chopped', '4 large boneless, skinless chicken breasts, cubed', '2 cups picante sauce', '� cup dry white wine', '2 tablespoons ground cumin', '1 tablespoon dried sage', '1 bay leaf', '1 (15 ounce) can black beans, undrained', '1 (15 ounce) can pinto beans, undrained', '6 Roma tomatoes, chopped', '1 (4 ounce) can chopped green chilies']", false, "https://www.allrecipes.com/recipe/260998/picante-chicken-chili/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Pickled Beets", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F1341511.jpg", "'10 pounds fresh small beets, stems removed', '2 cups white sugar', '1 tablespoon pickling salt', '1 quart white vinegar', '� cup whole cloves']", false, "https://www.allrecipes.com/recipe/38109/pickled-beets/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Pico de Gallo", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F282674.jpg", "'6 roma (plum) tomatoes, diced', '� red onion, minced', '3 tablespoons chopped fresh cilantro', '� jalapeno pepper, seeded and minced', '� lime, juiced', '1 clove garlic, minced', '1 pinch garlic powder', '1 pinch ground cumin, or to taste', 'salt and ground black pepper to taste']", false, "https://www.allrecipes.com/recipe/203800/pico-de-gallo/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Perfect Baked Potato", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F613276.jpg", "'1 medium baking potato', '1 teaspoon olive oil', '� teaspoon salt', '2 teaspoons butter', '1 pinch freshly ground black pepper', '� cup shredded Cheddar cheese']", false, "https://www.allrecipes.com/recipe/54679/perfect-baked-potato/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Quick and Easy Chicken Noodle Soup", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F4545057.jpg", "'1 tablespoon butter', '� cup chopped onion', '� cup chopped celery', '4 (14.5 ounce) cans chicken broth', '1 (14.5 ounce) can vegetable broth', '� pound chopped cooked chicken breast', '� cups egg noodles', '1 cup sliced carrots', '� teaspoon dried basil', '� teaspoon dried oregano', 'salt and pepper to taste']", false, "https://www.allrecipes.com/recipe/26460/quick-and-easy-chicken-noodle-soup/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Mom's Apple Fritters", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F393365.jpg", "'1 quart vegetable oil for deep-frying', '� cups all-purpose flour', '1 tablespoon white sugar', '2 teaspoons baking powder', '� teaspoon salt', ' cup milk', '2 eggs, beaten', '1 tablespoon vegetable oil', '3 cups apples - peeled, cored and chopped', '1 cup cinnamon sugar']", false, "https://www.allrecipes.com/recipe/90295/moms-apple-fritters/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Miso Soup", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F365400.jpg", "'2 teaspoons dashi granules', '4 cups water', '3 tablespoons miso paste', '1 (8 ounce) package silken tofu, diced', '2 green onions, sliced diagonally into 1/2 inch pieces']", false, "https://www.allrecipes.com/recipe/13107/miso-soup/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Instant Pot Refried Beans", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F6252480.jpg", "'� cup vegetable oil', '1 medium white onion, chopped', '2 cloves garlic', '1 teaspoon dried Mexican oregano', '1 pound dried pinto beans', '8 cups water', '2 teaspoons salt']", false, "https://www.allrecipes.com/recipe/268230/instant-pot-refried-beans/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Instant Pot Ribs", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F5623822.jpg", "'2 cups apple juice', '� cup apple cider vinegar', '2 tablespoons liquid smoke', '2 bay leaves, or more to taste', '2 racks baby back pork ribs']", false, "https://www.allrecipes.com/recipe/267242/instant-pot-ribs/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Instant Pot Spicy Macaroni Salad", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F7205907.jpg", "'� (8 ounce) package elbow macaroni', '� cups water', '1 large egg', ' cup diced red bell pepper', ' cup cubed pepper Jack cheese', '� cup diced jalapeno pepper, or to taste', '� cup sliced celery', '2 tablespoons diced onion', '� cup mayonnaise', '� tablespoon apple cider vinegar', '2 teaspoons chile-garlic sauce (such as Sriracha)', '� teaspoon salt', '� teaspoon garlic powder', ' teaspoon cayenne pepper', 'freshly ground black pepper to taste']", false, "https://www.allrecipes.com/recipe/277362/instant-pot-spicy-macaroni-salad/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Instant Pot Turkey Breast", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F6030057.jpg", "'1 (1 ounce) package onion soup mix', '1 (6 pound) turkey breast, thawed', '2 ribs celery, cut into large chunks', '1 onion, cut into large chunks', '1 cup chicken broth', '2 tablespoons water', '1 tablespoon cornstarch, or more as needed']", false, "https://www.allrecipes.com/recipe/260227/instant-pot-turkey-breast/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Instant Pot Vegan Korma", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F7159025.jpg", "'1 red onion, quartered, divided', \"1 green bird's eye chile pepper, stemmed\", '� cup water, divided', '� cup raw cashews', '2 cloves garlic', '2 tablespoons tomato paste', '1 (1 inch) piece fresh ginger', '5 whole cloves', '3 green cardamom pods ', '1 black cardamom pod', '1 bay leaf', '1 teaspoon cumin seeds', '� teaspoon whole black peppercorns', '� teaspoon ground coriander', '� inch cinnamon stick', '� cup light vegetable oil', '8\\u2009� ounces cauliflower, cut into large pieces', '5\\u2009� ounces broccoli, cut into large pieces', '2 tomatoes, cut into large chunks', '1 cup canned chickpeas (garbanzo beans), drained with liquid reserved', '1 carrot, sliced', \"1 red bird's eye chile pepper, chopped\", '� tablespoon garam masala', '� teaspoon ground turmeric', '� teaspoon chili powder', '1 cup baby spinach leaves', '1 cup full-fat coconut milk', '� cup vegan yogurt', '2 ounces roasted cashews, chopped', '� cup chopped fresh cilantro']", false, "https://www.allrecipes.com/recipe/276575/instant-pot-vegan-korma/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Israeli Couscous Salad", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F7670981.jpg", "'1 teaspoon extra-virgin olive oil', '1 medium shallot, diced', '2 cloves garlic, minced', '1 cup Israeli couscous, uncooked', '� cups chicken stock', '2 Persian cucumbers, sliced', '1 cup chopped fresh spinach', '1 cup grape tomatoes, halved', '1 cup quartered black olives', '� cup sliced scallions', '� cup chopped fresh Italian parsley', '� cup julienned fresh mint leaves', '� cup julienned fresh basil leaves', 'lemon, zested and juiced', '3 tablespoons extra-virgin olive oil', '� tablespoon Dijon mustard', 'salt and ground black pepper to taste']", false, "https://www.allrecipes.com/recipe/279842/israeli-couscous-salad/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Italian Ribollita (Vegetable and Bread Soup)", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F57171.jpg", "'1 tablespoon olive oil', '1 large red onion, diced', '2 carrots, diced', '1 stalk celery, diced', '4 potatoes, diced', '10 (5 inch) zucchini, diced', '1 leek, sliced', '1 quart hot water', '1 bunch Swiss chard, chopped', '1 head Savoy cabbage, quartered, cored and shredded', '1 bunch kale, shredded', '2 (15.5 ounce) cans cannellini beans, drained and rinsed', 'salt and ground black pepper to taste', '3 tablespoons tomato puree', '8 slices day-old bread']", false, "https://www.allrecipes.com/recipe/112310/italian-ribollita-vegetable-and-bread-soup/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Italian Spaghetti Sauce with Meatballs", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F5864844.jpg", "'1 pound lean ground beef', '1 cup fresh bread crumbs', '1 tablespoon dried parsley', '1 tablespoon grated Parmesan cheese', '� teaspoon ground black pepper', ' teaspoon garlic powder', '1 egg, beaten', '� cup chopped onion', '5 cloves garlic, minced', '� cup olive oil', '2 (28 ounce) cans whole peeled tomatoes', '2 teaspoons salt', '1 teaspoon white sugar', '1 bay leaf', '1 (6 ounce) can tomato paste', '� teaspoon dried basil', '� teaspoon ground black pepper']", false, "https://www.allrecipes.com/recipe/21353/italian-spaghetti-sauce-with-meatballs/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Italian Wedding Soup I", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F1087470.jpg", "'� pound extra-lean ground beef', '1 egg, lightly beaten', '2 tablespoons dry bread crumbs', '1 tablespoon grated Parmesan cheese', '� teaspoon dried basil', '� teaspoon onion powder', '5\\u2009� cups chicken broth', '2 cups thinly sliced escarole', '1 cup uncooked orzo pasta', ' cup finely chopped carrot']", false, "https://www.allrecipes.com/recipe/13024/italian-wedding-soup-i/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Instant Pot Mac and Cheese with Ham and Peas", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F4548620.jpg", "'4 cups water', '1 (16 ounce) package elbow macaroni', \"1 teaspoon dry mustard powder (such as Colman's)\", '1 teaspoon salt', '1 teaspoon hot sauce', '1 (12 fluid ounce) can evaporated milk', ' cup whole milk', '2 tablespoons unsalted butter', '2 cups shredded 2% milk Cheddar cheese (such as Kraft)', '1 cup shredded Monterey Jack cheese', '1 cup diced cooked ham', '� cup frozen peas, defrosted', 'salt and ground black pepper to taste']", false, "https://www.allrecipes.com/recipe/259690/instant-pot-mac-and-cheese-with-ham-and-peas/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Jambalaya", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F3857773.jpg", "'2 tablespoons peanut oil, divided', '1 tablespoon Cajun seasoning', '10 ounces andouille sausage, sliced into rounds', '1 pound boneless skinless chicken breasts, cut into 1 inch pieces', '1 onion, diced', '1 small green bell pepper, diced', '2 stalks celery, diced', '3 cloves garlic, minced', '1 (16 ounce) can crushed Italian tomatoes', '� teaspoon red pepper flakes', '� teaspoon ground black pepper', '1 teaspoon salt', '� teaspoon hot pepper sauce', '2 teaspoons Worcestershire sauce', '1 teaspoon file powder', '� cups uncooked white rice', '� cups chicken broth']", false, "https://www.allrecipes.com/recipe/31848/jambalaya/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Janet's Rich Banana Bread", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F171761.jpg", "'� cup butter, melted', '1 cup white sugar', '2 eggs', '1 teaspoon vanilla extract', '� cups all-purpose flour', '1 teaspoon baking soda', '� teaspoon salt', '� cup sour cream', '� cup chopped walnuts', '2 medium bananas, sliced']", false, "https://www.allrecipes.com/recipe/17066/janets-rich-banana-bread/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Jeff's Hot Dog Chili", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F869971.jpg", "'1 pound ground beef', ' cup water', '� (10 ounce) can tomato sauce', '� cup ketchup', '� teaspoons chili powder', '� teaspoon salt', '� teaspoon ground black pepper', '� teaspoon white sugar', '� teaspoon onion powder', '1 dash Worcestershire sauce']", false, "https://www.allrecipes.com/recipe/223538/jeffs-hot-dog-chili/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Joy's Easy Banana Bread", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F2226688.jpg", "'3 ripe bananas, mashed', '1 cup white sugar', '1 egg', '� cup melted butter', '� cups all-purpose flour', '1 teaspoon baking soda', '1 teaspoon salt']", false, "https://www.allrecipes.com/recipe/241707/joys-easy-banana-bread/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Judy's Strawberry Pretzel Salad", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F597421.jpg", "'� cups crushed pretzels', '4\\u2009� tablespoons white sugar', '� cup butter, melted', '1 cup white sugar', '2 (8 ounce) packages cream cheese', '1 (8 ounce) container frozen whipped topping, thawed', '1 (6 ounce) package strawberry flavored Jell-O', '2 cups boiling water', '1 (16 ounce) package frozen strawberries']", false, "https://www.allrecipes.com/recipe/16080/judys-strawberry-pretzel-salad/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Juicy Roasted Chicken", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F389250.jpg", "'1 (3 pound) whole chicken, giblets removed', 'salt and black pepper to taste', '1 tablespoon onion powder, or to taste', '� cup margarine, divided', '1 stalk celery, leaves removed']", false, "https://www.allrecipes.com/recipe/83557/juicy-roasted-chicken/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Juicy Thanksgiving Turkey", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fcf-images.us-east-1.prod.boltdns.net%2Fv1%2Fstatic%2F1033249144001%2F2c1c2f42-ed2b-4880-897d-45a6d02dcde5%2F183e6b59-a274-41b2-a386-5f35f6bf16fb%2F1280x720%2Fmatch%2Fimage.jpg", "'2 tablespoons dried parsley', '2 tablespoons ground dried rosemary', '2 tablespoons rubbed dried sage', '2 tablespoons dried thyme leaves', '1 tablespoon lemon pepper', '1 tablespoon salt', '1 (15 pound) whole turkey, neck and giblets removed', '2 stalks celery, chopped', '1 orange, cut into wedges', '1 onion, chopped', '1 carrot, chopped', '1 (14.5 ounce) can chicken broth', '1 (750 milliliter) bottle champagne']", false, "https://www.allrecipes.com/recipe/166160/juicy-thanksgiving-turkey/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Jump Rope Pie", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F2636699.jpg", "'1 recipe pastry for a double crust 9-inch pie', '1 cup white sugar', '3 tablespoons all-purpose flour, or more as needed', '� teaspoon ground cinnamon', '1 pinch freshly grated nutmeg', '2 cups peeled, cored and sliced apples', '1 cup peeled, pitted and sliced peaches', '1 cup peeled, cored and sliced pears', '1 cup pitted and sliced plums', '1 teaspoon grated fresh ginger root', '1 tablespoon lemon juice']", false, "https://www.allrecipes.com/recipe/245114/jump-rope-pie/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Keema Aloo (Ground Beef and Potatoes)", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F6282786.jpg", "'2 tablespoons extra-virgin olive oil', '1 extra-large Spanish onion, chopped', '2 tablespoons water', '2 pounds lean ground beef', '4 cloves garlic, minced', '2 tablespoons grated fresh ginger root', '1 serrano chile pepper, finely chopped', '2 teaspoons chopped fresh cilantro', '1 tablespoon ground coriander', '� teaspoons salt', '� teaspoons ground cumin', '1 teaspoon ground cayenne pepper', '1 teaspoon ground turmeric', '1 (28 ounce) can diced tomatoes', '3 potatoes, peeled and diced', '1 cup frozen green peas', '1 teaspoon garam masala']", false, "https://www.allrecipes.com/recipe/231026/keema-aloo-ground-beef-and-potatoes/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Key Lime Pie VII", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F4543755.jpg", "'1 (9 inch) prepared graham cracker crust', '3 cups sweetened condensed milk', '� cup sour cream', '� cup key lime juice', '1 tablespoon grated lime zest']", false, "https://www.allrecipes.com/recipe/15880/key-lime-pie-vii/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Jamie's Cranberry Spinach Salad", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F273205.jpg", "'1 tablespoon butter', '� cup almonds, blanched and slivered', '1 pound spinach, rinsed and torn into bite-size pieces', '1 cup dried cranberries', '2 tablespoons toasted sesame seeds', '1 tablespoon poppy seeds', '� cup white sugar', '2 teaspoons minced onion', '� teaspoon paprika', '� cup white wine vinegar', '� cup cider vinegar', '� cup vegetable oil']", false, "https://www.allrecipes.com/recipe/14469/jamies-cranberry-spinach-salad/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Kicked Up Mac and Cheese", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F4062060.jpg", "'� cups rotelle pasta', '4 tablespoons butter, divided', '� cup all-purpose flour', '3 cups whole milk', '1 teaspoon dry mustard', '� teaspoon salt', '� teaspoon ground white pepper', '3 teaspoons hot pepper sauce', '1 cup shredded pepperjack cheese', '� cups shredded sharp Cheddar cheese', '� cup grated Parmesan cheese', ' cup dry bread crumbs', '2 teaspoons chili powder']", false, "https://www.allrecipes.com/recipe/21122/kicked-up-mac-and-cheese/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Instant Pot Brown Rice", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F7165111.jpg", "'� cups water', '2 cups brown basmati rice', '1 tablespoon grapeseed oil', '1 teaspoon kosher salt']", false, "https://www.allrecipes.com/recipe/275886/instant-pot-brown-rice/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Indian Chicken Curry (Murgh Kari)", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F4465974.jpg", "'2 pounds skinless, boneless chicken breast halves', '2 teaspoons salt', '� cup cooking oil', '� cups chopped onion', '1 tablespoon minced garlic', '� teaspoons minced fresh ginger root', '1 tablespoon curry powder', '1 teaspoon ground cumin', '1 teaspoon ground turmeric', '1 teaspoon ground coriander', '1 teaspoon cayenne pepper', '1 tablespoon water', '1 (15 ounce) can crushed tomatoes', '1 cup plain yogurt', '1 tablespoon chopped fresh cilantro', '1 teaspoon salt', '� cup water', '1 teaspoon garam masala', '1 tablespoon chopped fresh cilantro', '1 tablespoon fresh lemon juice']", false, "https://www.allrecipes.com/recipe/212721/indian-chicken-curry-murgh-kari/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Homemade Chicken Soup", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F17638.jpg", "'1 (3 pound) whole chicken', '4 carrots, halved', '4 stalks celery, halved', '1 large onion, halved', 'water to cover', 'salt and pepper to taste', '1 teaspoon chicken bouillon granules']", false, "https://www.allrecipes.com/recipe/8814/homemade-chicken-soup/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Homemade Dog Food", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F1432665.jpg", "'6 cups water', '1 pound ground turkey', '2 cups brown rice', '1 teaspoon dried rosemary', '� (16 ounce) package frozen broccoli, carrots and cauliflower combination']", false, "https://www.allrecipes.com/recipe/140286/homemade-dog-food/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Homemade Flour Tortillas", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F663757.jpg", "'4 cups all-purpose flour', '1 teaspoon salt', '2 teaspoons baking powder', '2 tablespoons lard', '� cups water']", false, "https://www.allrecipes.com/recipe/157642/homemade-flour-tortillas/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Homemade Four Cheese Ravioli", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F5943283.jpg", "'2 cups all-purpose flour', '1 pinch salt', '1 teaspoon olive oil', '2 eggs', '� tablespoons water', '1 (8 ounce) container ricotta cheese', '1 (4 ounce) package cream cheese, softened', '� cup shredded mozzarella cheese', '� cup provolone cheese, shredded', '1 egg', '� teaspoons dried parsley', '2 tablespoons olive oil', '2 cloves garlic, crushed', '3 tablespoons prepared basil pesto sauce', '2 cups heavy cream', '� cup grated Parmesan cheese', '1 (24 ounce) jar marinara sauce', '1 egg', '1 tablespoon water']", false, "https://www.allrecipes.com/recipe/213131/homemade-four-cheese-ravioli/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Homemade Fresh Pumpkin Pie", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F1071493.jpg", "' cups all-purpose flour', '� teaspoon salt', '� cup shortening', '� tablespoons cold water', '2 cups mashed, cooked pumpkin', '1 (12 fluid ounce) can evaporated milk', '2 eggs, beaten', '� cup packed brown sugar', '� teaspoon ground cinnamon', '� teaspoon ground ginger', '� teaspoon ground nutmeg', '� teaspoon salt']", false, "https://www.allrecipes.com/recipe/13711/homemade-fresh-pumpkin-pie/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Homemade Hamburger Buns", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F2212308.jpg", "\"1 (.25 ounce) package active dry yeast (such as Fleischmann's ActiveDry Yeast)\", '1 pound all-purpose flour, or as needed - divided', '1 cup warm water (105 degrees F/41 degrees C)', '1 large egg', '3 tablespoons butter, melted', '3 tablespoons white sugar', '� teaspoons salt', '1 teaspoon olive oil', '1 egg, beaten', '1 tablespoon milk', '1 teaspoon sesame seeds, or as needed']", false, "https://www.allrecipes.com/recipe/233652/homemade-hamburger-buns/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Homemade Lasagna", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F4581957.jpg", "'1 (16 ounce) package lasagna noodles', '� pound ground pork', '� pound lean ground beef', '1 (8 ounce) can tomato sauce', '1 (28 ounce) can crushed tomatoes', '1 tablespoon chopped fresh parsley', '1 clove garlic, crushed', '� teaspoon dried oregano', '� cup minced onion', ' teaspoon white sugar', '� teaspoons dried basil', '� teaspoons salt', '1 pound small curd cottage cheese', '3 eggs', '� cup grated Parmesan cheese', '2 teaspoons salt', '� teaspoon ground black pepper', '1 pound shredded mozzarella cheese']", false, "https://www.allrecipes.com/recipe/19344/homemade-lasagna/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Homemade Mac and Cheese", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F6174584.jpg", "'8 ounces uncooked elbow macaroni', '2 cups shredded sharp Cheddar cheese', '� cup grated Parmesan cheese', '3 cups milk', '� cup butter', '� tablespoons all-purpose flour', '2 tablespoons butter', '� cup bread crumbs', '1 pinch paprika']", false, "https://www.allrecipes.com/recipe/11679/homemade-mac-and-cheese/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Homemade Miso Soup", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F6243395.jpg", "'1 tablespoon finely chopped wakame', '4 cups water', '2 teaspoons dashi granules', '3 tablespoons miso paste', '4 ounces silken tofu, cubed', '2 green onions, sliced on the bias']", false, "https://www.allrecipes.com/recipe/263694/homemade-miso-soup/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Instant Pot Baby Back Ribs", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fcf-images.us-east-1.prod.boltdns.net%2Fv1%2Fstatic%2F1033249144001%2Fe8c35bd6-0848-4300-8184-1a451976240d%2F7bd1ad75-d598-466c-8d95-5c051414db71%2F1280x720%2Fmatch%2Fimage.jpg", "'2 tablespoons kosher salt', '1 tablespoon brown sugar', '1 tablespoon chili powder', '1 tablespoon paprika', '2 teaspoons garlic powder', '� teaspoons cayenne pepper', '1 teaspoon ground black pepper', '1 rack baby back pork ribs', '1 cup beef broth', '� cup barbeque sauce, or as needed']", false, "https://www.allrecipes.com/recipe/262225/instant-pot-baby-back-ribs/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Homemade Sloppy Joes", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F3793689.jpg", "'� pounds extra lean ground beef', '� onion, diced', '2 cloves garlic, minced', '1 green pepper, diced', '1 cup water', '� cup ketchup', '1 dash Worcestershire sauce', '2 tablespoons brown sugar', '1 teaspoon Dijon mustard', '� teaspoons salt, or to taste', '� teaspoon ground black pepper', '1 cup water', '1 pinch cayenne pepper to taste']", false, "https://www.allrecipes.com/recipe/220182/homemade-sloppy-joes/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Honey-Garlic Slow Cooker Chicken Thighs", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F1411947.jpg", "'4 skinless, boneless chicken thighs', '� cup soy sauce', '� cup ketchup', ' cup honey', '3 cloves garlic, minced', '1 teaspoon dried basil']", false, "https://www.allrecipes.com/recipe/236609/honey-garlic-slow-cooker-chicken-thighs/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Hot Artichoke and Spinach Dip II", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F3391875.jpg", "'1 (8 ounce) package cream cheese, softened', '� cup mayonnaise', '� cup grated Parmesan cheese', '� cup grated Romano cheese', '1 clove garlic, peeled and minced', '� teaspoon dried basil', '� teaspoon garlic salt', 'salt and pepper to taste', '1 (14 ounce) can artichoke hearts, drained and chopped', '� cup frozen chopped spinach, thawed and drained', '� cup shredded mozzarella cheese']", false, "https://www.allrecipes.com/recipe/26819/hot-artichoke-and-spinach-dip-ii/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Hot Dog Mummies", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F4567008.jpg", "'8 hot dogs', '1 (8 ounce) package refrigerated crescent rolls (such as Pillsbury Grands! Big and Flaky)', '1 teaspoon yellow mustard, or as needed']", false, "https://www.allrecipes.com/recipe/244231/hot-dog-mummies/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Hot German Potato Salad III", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F2209523.jpg", "'9 potatoes, peeled', '6 slices bacon', '� cup chopped onions', '2 tablespoons all-purpose flour', '2 tablespoons white sugar', '2 teaspoons salt', '� teaspoon celery seed', ' teaspoon ground black pepper', '� cup water', ' cup distilled white vinegar']", false, "https://www.allrecipes.com/recipe/18085/hot-german-potato-salad-iii/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Hot Tamale Pie", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F6622167.jpg", "'cooking spray', '2 pounds ground beef', '2 cups diced poblano peppers', '1 teaspoon salt', '1 (16 ounce) jar salsa', '� teaspoon dried oregano', '1 teaspoon ground dried chipotle pepper', '2 (8.5 ounce) boxes dry corn muffin mix (such as Jiffy)', '2 eggs', ' cup milk, divided', '4 ounces shredded Cheddar cheese, divided', '4 ounces shredded Monterey Jack cheese, divided', '8 ounces frozen corn, thawed']", false, "https://www.allrecipes.com/recipe/220414/hot-tamale-pie/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "How to Cook a Turkey", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F1747481.jpg", "'1 onion, coarsely chopped', '1 stalk celery, coarsely chopped', '1 carrot, coarsely chopped', '1 (12 pound) whole turkey, neck and giblets reserved', '2 tablespoons kosher salt', '1 tablespoon ground black pepper', '1 teaspoon cayenne pepper', '3 tablespoons butter', '4 sprigs fresh rosemary', '� bunch chopped fresh sage']", false, "https://www.allrecipes.com/recipe/222332/how-to-cook-a-turkey/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "How to Make Perfect Polenta", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F3778721.jpg", "'4 cups water', '1 teaspoon fine salt', '1 cup polenta', '3 tablespoons butter, divided', '� cup freshly grated Parmigiano-Reggiano cheese, plus more for garnish']", false, "https://www.allrecipes.com/recipe/234933/how-to-make-perfect-polenta/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Hudson's Baked Tilapia with Dill Sauce", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F5202473.jpg", "'4 (4 ounce) fillets tilapia', 'salt and pepper to taste', '1 tablespoon Cajun seasoning, or to taste', '1 lemon, thinly sliced', '� cup mayonnaise', '� cup sour cream', ' teaspoon garlic powder', '1 teaspoon fresh lemon juice', '2 tablespoons chopped fresh dill']", false, "https://www.allrecipes.com/recipe/74169/hudsons-baked-tilapia-with-dill-sauce/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Incredibly Easy Chicken and Noodles", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F1014757.jpg", "'1 (26 ounce) can condensed cream of chicken soup', '1 (10.75 ounce) can  condensed cream of mushroom soup', '3 (14.5 ounce) cans chicken broth', '2 cups diced, cooked chicken breast meat', '2 teaspoons onion powder', '1 teaspoon seasoning salt', '� teaspoon garlic powder', '2 (9 ounce) packages frozen egg noodles']", false, "https://www.allrecipes.com/recipe/17846/incredibly-easy-chicken-and-noodles/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Honey Whole Wheat Peanut Butter Cookies", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F7689729.jpg", "'cooking spray', ' cup natural peanut butter', '� cup honey', '� cup brown sugar', '� cup nonfat Greek yogurt', '1 egg', '1 teaspoon vanilla extract', '1 cup whole wheat flour', '� teaspoon baking soda', ' teaspoon salt']", false, "https://www.allrecipes.com/recipe/278541/honey-whole-wheat-peanut-butter-cookies/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Miss Betty's 24 Hour Lettuce Salad", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F1748202.jpg", "'� pound sliced bacon', '1 large head iceberg lettuce, shredded', '� cup sliced onion', '� cup thinly sliced celery', '1 (8 ounce) can water chestnuts, drained and sliced', '1 (10 ounce) package frozen peas', '1 cup mayonnaise, or to taste', '1 tablespoon white sugar', '2 tablespoons grated Romano or Parmesan cheese', '4 tomatoes, cut into wedges', '2 hard-cooked eggs, sliced', '1 tablespoon chopped fresh parsley for garnish']", false, "https://www.allrecipes.com/recipe/72471/miss-bettys-24-hour-lettuce-salad/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Kickin' Collard Greens", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F822015.jpg", "'1 tablespoon olive oil', '3 slices bacon', '1 large onion, chopped', '2 cloves garlic, minced', '1 teaspoon salt', '1 teaspoon pepper', '3 cups chicken broth', '1 pinch red pepper flakes', '1 pound fresh collard greens, cut into 2-inch pieces']", false, "https://www.allrecipes.com/recipe/51803/kickin-collard-greens/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Kitty Litter Cake", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F197010.jpg", "'1 (18.25 ounce) package German chocolate cake mix', '1 (18.25 ounce) package white cake mix', '2 (3.5 ounce) packages instant vanilla pudding mix', '1 (12 ounce) package vanilla sandwich cookies', '3 drops green food coloring', '1 (12 ounce) package tootsie rolls']", false, "https://www.allrecipes.com/recipe/7415/kitty-litter-cake/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Maple Apple Turkey Sausage", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F4553597.jpg", "'1 pound lean ground turkey', '1 small apple - peeled, cored, and finely chopped', '1 tablespoon pure maple syrup, or more to taste', '� teaspoon salt', '� teaspoon dried sage', '� teaspoon garlic powder', '� teaspoon ground black pepper', '� teaspoon dried marjoram', ' teaspoon ground cinnamon', '1 dash ground cloves', '1 tablespoon olive oil']", false, "https://www.allrecipes.com/recipe/259473/maple-apple-turkey-sausage/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Maple Buttercream Frosting", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F1791438.jpg", "\"4 cups confectioners' sugar\", '� cup butter, softened', '7 tablespoons pure maple syrup', '3 tablespoons heavy whipping cream']", false, "https://www.allrecipes.com/recipe/240463/maple-buttercream-frosting/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Maple Roasted Brussels Sprouts with Bacon", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F6431264.jpg", "'1 pound Brussels sprouts, trimmed', '� cup extra-virgin olive oil', '3 tablespoons pure maple syrup', '4 slices bacon, cut into 1/2-inch pieces', '� teaspoon salt', '� teaspoon freshly ground black pepper']", false, "https://www.allrecipes.com/recipe/228875/maple-roasted-brussels-sprouts-with-bacon/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Maple Salmon", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F862371.jpg", "'� cup maple syrup', '2 tablespoons soy sauce', '1 clove garlic, minced', '� teaspoon garlic salt', ' teaspoon ground black pepper', '1 pound salmon']", false, "https://www.allrecipes.com/recipe/51283/maple-salmon/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Margaret's Southern Chocolate Pie", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F461794.jpg", "'� cup unsweetened cocoa powder', '� cup all-purpose flour', '3 egg yolks', ' cups white sugar', '1 (12 fluid ounce) can evaporated milk', '3 tablespoons butter', '1 (9 inch) pie shell, baked', '3 egg whites', ' teaspoon cream of tartar', '6 tablespoons white sugar']", false, "https://www.allrecipes.com/recipe/12187/margarets-southern-chocolate-pie/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Marie's Easy Slow Cooker Pot Roast", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F3566746.jpg", "'4 pounds chuck roast', 'salt and pepper to taste', '1 packet dry onion soup mix', '1 cup water', '3 carrots, chopped', '1 onion, chopped', '3 potatoes, peeled and cubed', '1 stalk celery, chopped']", false, "https://www.allrecipes.com/recipe/16346/maries-easy-slow-cooker-pot-roast/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Marinated Tuna Steak", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F1608428.jpg", "'� cup orange juice', '� cup soy sauce', '2 tablespoons olive oil', '1 tablespoon lemon juice', '2 tablespoons chopped fresh parsley', '1 clove garlic, minced', '� teaspoon chopped fresh oregano', '� teaspoon ground black pepper', '4 (4 ounce) tuna steaks']", false, "https://www.allrecipes.com/recipe/39455/marinated-tuna-steak/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Mary's Roasted Red Pepper Dip", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F890811.jpg", "'1 (7 ounce) jar roasted red peppers, drained and diced', '� pound shredded Monterey Jack cheese', '1 (8 ounce) package cream cheese, softened', '1 cup mayonnaise', '1 tablespoon minced onion', '1 clove garlic, minced', '2 tablespoons prepared Dijon-style mustard']", false, "https://www.allrecipes.com/recipe/23929/marys-roasted-red-pepper-dip/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Mashed Sweet Potatoes", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F4576638.jpg", "'6 sweet potatoes, peeled and cubed', '� cup milk', '� cup butter', '� cup maple syrup']", false, "https://www.allrecipes.com/recipe/21220/mashed-sweet-potatoes/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Manicotti", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F48652.jpg", "'1 pint part-skim ricotta cheese', '8 ounces shredded mozzarella cheese', '� cup grated Parmesan cheese', '2 eggs', '1 teaspoon dried parsley', 'salt to taste', 'ground black pepper to taste', '1 (16 ounce) jar spaghetti sauce', '5\\u2009� ounces manicotti pasta ']", false, "https://www.allrecipes.com/recipe/13883/manicotti/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Maya's Perfect Pesto Pasta Salad", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F7096407.jpg", "'1 (16 ounce) package corkscrew-shaped pasta (fusilli)', '� cup chopped fresh basil', '� cup shredded Parmesan cheese', ' cup pine nuts', ' cup extra-virgin olive oil', '1 clove garlic, diced', '� cup finely diced red onion', '� cup finely diced radicchio', '1 tablespoon mayonnaise, or to taste', 'salt and ground black pepper to taste']", false, "https://www.allrecipes.com/recipe/275867/mayas-perfect-pesto-pasta-salad/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Mediterranean Greek Salad", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F8187761.jpg", "'3 cucumbers, seeded and sliced', '� cups crumbled feta cheese', '1 cup black olives, pitted and sliced', '3 cups diced roma tomatoes', ' cup diced oil packed sun-dried tomatoes, drained, oil reserved', '� red onion, sliced']", false, "https://www.allrecipes.com/recipe/14403/mediterranean-greek-salad/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Mediterranean Orzo Salad", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F8190439.jpg", "'� (16 ounce) package uncooked orzo pasta', '� pint cherry tomatoes, halved', '� cup diced red onion', '1 cup diced cucumber', '1 cup pitted Mediterranean olives, cut in half', '1 cup finely diced Asiago cheese', '� teaspoons minced fresh garlic', '� cup extra-virgin olive oil', '� cup red wine vinegar', '� lemon, juiced', '1 teaspoon salt', '� teaspoon ground black pepper', '� cup chopped fresh basil', '2 tablespoons chopped fresh parsley']", false, "https://www.allrecipes.com/recipe/280504/mediterranean-orzo-salad/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Mediterranean Salmon Pasta Salad", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F8537016.jpg", "'� (16 ounce) package mezze (short) penne pasta', '1 cup sliced and quartered cucumber', '1 cup halved cherry tomatoes', '2 tablespoons minced shallot', '1 (2.6 ounce) pouch wild-caught pink salmon (such as Chicken of the Sea)', '� cup extra-virgin olive oil', '1 tablespoon white wine vinegar', '1 tablespoon freshly squeezed lemon juice', '1 teaspoon lemon-pepper seasoning', '� teaspoon Dijon mustard', '� teaspoon salt', '� teaspoon dried dill weed']", false, "https://www.allrecipes.com/recipe/281580/mediterranean-salmon-pasta-salad/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Mexican Bean Salad", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F828805.jpg", "'1 (15 ounce) can black beans, rinsed and drained', '1 (15 ounce) can kidney beans, drained', '1 (15 ounce) can cannellini beans, drained and rinsed', '1 green bell pepper, chopped', '1 red bell pepper, chopped', '1 (10 ounce) package frozen corn kernels', '1 red onion, chopped', '� cup olive oil', '� cup red wine vinegar', '2 tablespoons fresh lime juice', '1 tablespoon lemon juice', '2 tablespoons white sugar', '1 tablespoon salt', '1 clove crushed garlic', '� cup chopped fresh cilantro', '� tablespoon ground cumin', '� tablespoon ground black pepper', '1 dash hot pepper sauce', '� teaspoon chili powder']", false, "https://www.allrecipes.com/recipe/14169/mexican-bean-salad/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Mexican Pumpkin Empanadas", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F2795791.jpg", "'3 cups all-purpose flour', ' cup white sugar', '� teaspoons salt', '� teaspoon baking powder', '1 cup vegetable shortening', '1 cup warm water', '4 cups canned pure pumpkin', '2 eggs', '1 cup white sugar', '1 teaspoon salt', '� teaspoons ground cinnamon', '1 teaspoon ground ginger', '� teaspoon ground cloves', '1 beaten egg']", false, "https://www.allrecipes.com/recipe/216489/mexican-pumpkin-empanadas/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Microwave Baked Potato", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F438952.jpg", "'1 large russet potato', '1 tablespoon butter or margarine', '3 tablespoons shredded Cheddar cheese', 'salt and pepper to taste', '3 teaspoons sour cream']", false, "https://www.allrecipes.com/recipe/85337/microwave-baked-potato/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Microwave Chocolate Mug Cake", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F4541090.jpg", "'� cup all-purpose flour', '� cup white sugar', '2 tablespoons unsweetened cocoa powder', ' teaspoon baking soda', ' teaspoon salt', '3 tablespoons milk', '2 tablespoons canola oil', '1 tablespoon water', '� teaspoon vanilla extract']", false, "https://www.allrecipes.com/recipe/241038/microwave-chocolate-mug-cake/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Mini Brownie Turkeys", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F7074829.jpg", "'nonstick cooking spray (such as BakeEasy)', '� cup butter, softened', '� cup white sugar', '1 egg', '� teaspoon vanilla extract', '� cup all-purpose flour', '3 tablespoons unsweetened cocoa powder', ' teaspoon baking powder', ' teaspoon salt', '3 tablespoons butter, softened', '3 tablespoons unsweetened cocoa powder', '� tablespoons milk', '1 cup powdered sugar', \"12 red candy-coated chocolate pieces (such as M&M's)\", '60 candy corn, or as needed', '24 candy eyeballs']", false, "https://www.allrecipes.com/recipe/276135/mini-brownie-turkeys/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Mini Meatloaf Ghosts", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F8612967.jpg", "'1 pound lean ground beef', '� teaspoons kosher salt', '� teaspoon freshly ground black pepper', '1 pinch cayenne pepper', '2 tablespoons minced green onions', '1 tablespoon chopped fresh parsley, or to taste', ' cup plain dry bread crumbs', '1 large egg, beaten', '1 teaspoon Worcestershire sauce', '10 slices provolone cheese', '� cup ketchup', '� cup barbeque sauce', '2 tablespoons Sriracha sauce']", false, "https://www.allrecipes.com/recipe/281842/mini-meatloaf-ghosts/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Meatball Sandwich", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F2601802.jpg", "'1 pound ground beef', '� cup bread crumbs', '2 teaspoons dried Italian seasoning', '2 cloves garlic, minced', '2 tablespoons chopped fresh parsley', '2 tablespoons grated Parmesan cheese', '1 egg, beaten', '1 French baguette', '1 tablespoon extra-virgin olive oil', '� teaspoon garlic powder', '1 pinch salt, or to taste', '1 (14 ounce) jar spaghetti sauce', '4 slices provolone cheese']", false, "https://www.allrecipes.com/recipe/90321/meatball-sandwich/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "King Ranch Chicken Casserole", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F3980244.jpg", "'1 tablespoon vegetable oil', '1 white onion, diced', '1 red bell pepper, diced', '1 green bell pepper, diced', '1 (10.75 ounce) can  condensed cream of mushroom soup', '1 (10.75 ounce) can  condensed cream of chicken soup', '1 (10 ounce) can diced tomatoes with green chile peppers (such as RO*TEL)', '1 cup chicken broth', '2 tablespoons sour cream', '2 teaspoons ground cumin', '1 teaspoon ancho chile powder', '� teaspoon dried oregano', '� teaspoon chipotle chile powder', '1 cooked chicken, torn into shreds or cut into chunks', '8 ounces shredded Cheddar cheese', '10 corn tortillas, cut into quarters']", false, "https://www.allrecipes.com/recipe/236805/king-ranch-chicken-casserole/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Mamaw's Chicken and Rice Casserole", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F1040851.jpg", "'3 chicken breasts, cut into cubes', '2 cups water', '2 cups instant white rice', '1 (10.75 ounce) can  cream of chicken soup', '1 (10.75 ounce) can  cream of celery soup', '1 (10.75 ounce) can  cream of mushroom soup', 'salt and ground black pepper to taste', '� cup butter, sliced into pats']", false, "https://www.allrecipes.com/recipe/233983/mamaws-chicken-and-rice-casserole/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Magnificent Macaroni Salad", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fcf-images.us-east-1.prod.boltdns.net%2Fv1%2Fstatic%2F1033249144001%2F982dc0f5-f88c-4bdc-b6b4-c96b7268f7cd%2F40130cc2-72fb-4a96-a5f4-c5b3d315ef91%2F1280x720%2Fmatch%2Fimage.jpg", "'3 cups elbow macaroni', '� cups mayonnaise', ' large onion, minced', '� cup chopped fresh parsley', '2 tablespoons prepared yellow mustard', '2 teaspoons rice vinegar', '1 teaspoon white sugar, or more to taste', '� teaspoon celery seed', '� teaspoon salt', '3 hard-cooked eggs, chopped']", false, "https://www.allrecipes.com/recipe/221132/magnificent-macaroni-salad/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Laura's Quick Slow Cooker Turkey Chili", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F1009122.jpg", "'1 tablespoon vegetable oil', '1 pound ground turkey', '2 (10.75 ounce) cans  low sodium tomato soup', '2 (15 ounce) cans kidney beans, drained', '1 (15 ounce) can black beans, drained', '� medium onion, chopped', '2 tablespoons chili powder', '1 teaspoon red pepper flakes', '� tablespoon garlic powder', '� tablespoon ground cumin', '1 pinch ground black pepper', '1 pinch ground allspice', 'salt to taste']", false, "https://www.allrecipes.com/recipe/82768/lauras-quick-slow-cooker-turkey-chili/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Leftover Ham -n- Potato Casserole", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F4160306.jpg", "'6 small potatoes, peeled and cubed', '3 tablespoons butter', '2 cups cubed fully cooked ham', '1 small onion, finely chopped', '� cup butter', '3 tablespoons all-purpose flour', '� cups milk', 'salt and ground black pepper to taste', '1 (8 ounce) package shredded Cheddar cheese', '� cup bread crumbs']", false, "https://www.allrecipes.com/recipe/220961/leftover-ham-n-potato-casserole/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Lemon Cloud Pie I", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F8145385.jpg", "'1 (9 inch) pie crust, baked', '� cup white sugar', '3 tablespoons cornstarch', '1 cup water', '1 teaspoon lemon zest', '� cup lemon juice', '1 (3 ounce) package cream cheese', '2 eggs', '� cup white sugar']", false, "https://www.allrecipes.com/recipe/12104/lemon-cloud-pie-i/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Lemon Couscous", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F2276861.jpg", "'1 cup chicken broth', '2 tablespoons fresh lemon juice', '1 tablespoon lemon zest', '1 tablespoon butter', '� teaspoon salt', ' cup couscous ', '1 (2 ounce) jar sliced pimento peppers, drained', '2 tablespoons toasted pine nuts', '2 tablespoons chopped fresh parsley']", false, "https://www.allrecipes.com/recipe/242232/lemon-couscous/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Lemon Cream Cheese Bars", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F1133810.jpg", "'cooking spray', '2 (8 ounce) packages refrigerated crescent roll dough (such as Pillsbury Recipe Creations), divided', '2 lemons, zested and juiced, divided', '2 (8 ounce) packages cream cheese, softened', '� cup white sugar', '2 tablespoons butter, melted', '3 tablespoons white sugar']", false, "https://www.allrecipes.com/recipe/237181/lemon-cream-cheese-bars/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Lemon-Ricotta Cornmeal Waffles", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F6879705.jpg", "'1 cup all-purpose flour', '� cup cornmeal', '� cup white sugar', '� teaspoons baking powder', '� teaspoon baking soda', '� teaspoon salt', '� cup half-and-half', '� cup ricotta cheese', '2 large eggs', '2 tablespoons melted butter', '1 teaspoon lemon extract', 'cooking spray']", false, "https://www.allrecipes.com/recipe/274974/lemon-ricotta-cornmeal-waffles/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Lemony Dill Salmon Pasta Salad", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F8112690.jpg", "'� (16 ounce) package large shell pasta', '1 tablespoon lemon-infused olive oil', '1 tablespoon finely minced shallot', '2 teaspoons lemon juice', '2 teaspoons capers', '� teaspoons chopped fresh dill', '1 lemon, zested', '1 teaspoon minced garlic', 'salt and ground black pepper to taste', '� pound cooked salmon fillet, flaked', '1 tablespoon freshly grated Parmesan cheese, or to taste']", false, "https://www.allrecipes.com/recipe/280225/lemony-dill-salmon-pasta-salad/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Lentil Soup", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F6236012.jpg", "'1 onion, chopped', '� cup olive oil', '2 carrots, diced', '2 stalks celery, chopped', '2 cloves garlic, minced', '1 teaspoon dried oregano', '1 bay leaf', '1 teaspoon dried basil', '1 (14.5 ounce) can crushed tomatoes', '2 cups dry lentils', '8 cups water', '� cup spinach, rinsed and thinly sliced', '2 tablespoons vinegar', 'salt to taste', 'ground black pepper to taste']", false, "https://www.allrecipes.com/recipe/13978/lentil-soup/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Libby's Famous Pumpkin Pie", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F1680564.jpg", "'1 (9 inch) unbaked deep dish pie crust', '� cup white sugar', '1 teaspoon ground cinnamon', '� teaspoon salt', '� teaspoon ground ginger', '� teaspoon ground cloves', '2 eggs', \"1 (15 ounce) can LIBBY'S 100% Pure Pumpkin\", '1 (12 fluid ounce) can NESTLE CARNATION Evaporated Milk']", false, "https://www.allrecipes.com/recipe/22755/libbys-famous-pumpkin-pie/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Make-Ahead Freezer Chicken Parmesan", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F7980195.jpg", "'1 pound skinless, boneless chicken breast halves', '1 large egg, beaten', ' cup bread crumbs', '2 tablespoons grated Parmesan cheese', '� teaspoon Italian seasoning', '� teaspoon garlic powder', '1 (8 ounce) can tomato sauce', '� cup shredded mozzarella cheese']", false, "https://www.allrecipes.com/recipe/279629/make-ahead-freezer-chicken-parmesan/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Lighter Chicken Fettuccine Alfredo", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F1114753.jpg", "'2 large boneless skinless chicken breasts', '2 cups low-sodium chicken broth', '4 cloves garlic, minced', 'ground black pepper to taste', '2 cups heavy cream', '2 egg yolks', 'salt to taste', '1 pound fettuccine', '1 sprig chopped fresh parsley', '2 cups freshly grated Parmigiano-Reggiano cheese, divided']", false, "https://www.allrecipes.com/recipe/219965/lighter-chicken-fettuccine-alfredo/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Lisa's Favorite Carne Asada Marinade", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F6693569.jpg", "'� cup orange juice', '� cup lemon juice', ' cup lime juice', '4 cloves garlic, minced', '� cup soy sauce', '1 teaspoon finely chopped canned chipotle pepper ', '1 tablespoon chili powder', '1 tablespoon ground cumin', '1 tablespoon paprika', '1 teaspoon dried oregano', '1 tablespoon black pepper', '1 bunch fresh cilantro, chopped', '� cup olive oil', '3 pounds flank steak']", false, "https://www.allrecipes.com/recipe/186691/lisas-favorite-carne-asada-marinade/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Lobster Mac and Cheese", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F547056.jpg", "'1 (16 ounce) package elbow macaroni', '1 (2 pound) lobster, split', '2 tablespoons butter', '1 small onion, diced', '1 clove garlic, minced', '1 shallot, chopped', '10 black peppercorns', '2 cups milk', '5 tablespoons butter', '5 tablespoons all-purpose flour', '1 pound shredded Gruyere cheese', '3 cups shredded Cheddar cheese', '1 cup grated Romano cheese', 'kosher salt and pepper to taste', '3 tablespoons panko bread crumbs']", false, "https://www.allrecipes.com/recipe/171001/lobster-mac-and-cheese/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Low Carb Turkey-Stuffed Peppers", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F7193347.jpg", "'nonfat cooking spray', '1 tablespoon olive oil', '1 pound ground turkey', '� cup diced onion', '3 tablespoons diced fresh jalapeno pepper, or to taste', '2 cloves garlic, chopped', '2 cups frozen cauliflower rice (such as Green Giant)', '1 (14.5 ounce) can diced tomatoes, undrained', '1 (8 ounce) can tomato sauce', '� cup water', '2 teaspoons sambal oelek chili paste', '� teaspoon salt', '� teaspoon freshly ground black pepper', '2 large bell peppers, any color - cut in half lengthwise, cored, and seeded', '4 (1 inch) cubes Colby-Jack cheese', 'aluminum foil', ' cup shredded Colby-Jack cheese', '4 teaspoons reduced-fat sour cream', '8 slices pickled jalapeno peppers']", false, "https://www.allrecipes.com/recipe/276832/low-carb-turkey-stuffed-peppers/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Ma'amoul (Lebanese Date Cookies)", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F7618972.jpg", "'2 cups semolina flour', '1 cup all-purpose flour', '� teaspoon ground mahlab', '� teaspoon salt', '1 cup clarified butter, at room temperature', '5 tablespoons milk', '2 tablespoons white sugar', '1 teaspoon active dry yeast', '4 tablespoons orange blossom water, or more as needed', '10 tablespoons date paste (such as Ziyad), cut into small pieces', '2 tablespoons powdered sugar, or to taste']", false, "https://www.allrecipes.com/recipe/278238/maamoul-lebanese-date-cookies/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Macaron (French Macaroon)", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F7426387.jpg", "'3 egg whites', '� cup white sugar', \" cups confectioners' sugar\", '1 cup finely ground almonds']", false, "https://www.allrecipes.com/recipe/223234/macaron-french-macaroon/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Macaroni and Cheese with Caramelized Onions and Bacon", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F1098409.jpg", "'1 (16 ounce) package elbow macaroni', '� cup butter', '� cup sour cream', '1 egg, beaten', '2 tablespoons cream cheese, softened', '4 cups grated Asiago cheese', '4 cups grated Vermont Cheddar cheese', '4 slices bacon', '2 tablespoons butter', '1 large onion, sliced thin', '4 cloves garlic, minced', ' teaspoon brown sugar', '� cup chopped fresh parsley', '� cup panko bread crumbs', '2 tablespoons butter', '5 tablespoons all-purpose flour', '3 cups milk', '� teaspoon ground mustard', '� teaspoon paprika', '� teaspoon salt', '� teaspoon pepper', '1 tablespoon hot pepper sauce']", false, "https://www.allrecipes.com/recipe/180905/macaroni-and-cheese-with-caramelized-onions-and-bacon/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Macaroni Pie", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F7970611.jpg", "'32 ounces elbow macaroni', '3 eggs', '3 cups milk', '4 cups shredded Cheddar cheese', '� teaspoon salt']", false, "https://www.allrecipes.com/recipe/22725/macaroni-pie/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Macaroni Salad with Peas", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F8032359.jpg", "'1 (8 ounce) package elbow macaroni', '4 whole green onions, thinly sliced', '2 stalks celery, diced', '� large red bell pepper, diced', ' cup frozen petite peas, thawed', '1 tablespoon minced fresh parsley, or to taste', ' cup mayonnaise', '3 tablespoons sour cream, or more to taste', '2 tablespoons cider vinegar', '2 teaspoons white sugar', '2 teaspoons dry mustard', 'salt and freshly ground black pepper to taste']", false, "https://www.allrecipes.com/recipe/279750/macaroni-salad-with-peas/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Magic Cookie Bars from EAGLE BRAND", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F8099979.jpg", "'� cup butter or margarine, melted', '� cups graham cracker crumbs', '1 (14 ounce) can EAGLE BRAND Sweetened Condensed Milk', '2 cups semisweet chocolate morsels', ' cups flaked coconut', '1 cup chopped nuts ']", false, "https://www.allrecipes.com/recipe/63959/magic-cookie-bars-from-eagle-brand/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Lime Bars", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F1116121.jpg", "'2 cups all-purpose flour', \"� cup confectioners' sugar\", '� teaspoon salt', '1 cup butter', '4 eggs', ' cup lime juice', '� cup all-purpose flour', '2 cups white sugar', '2 teaspoons grated lime peel, or more to taste', '� teaspoon baking powder', '1 drop green food coloring, or as desired', \"� cups confectioners' sugar\", '1 tablespoon lime juice', '1 teaspoon grated lime peel']", false, "https://www.allrecipes.com/recipe/223532/lime-bars/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Homemade Chicken Gravy", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F956217.jpg", "'� cup unsalted butter', '� cup all-purpose flour', '1 quart cold chicken stock', ' cup heavy cream', 'salt and ground white pepper to taste', '1 pinch cayenne pepper']", false, "https://www.allrecipes.com/recipe/219090/homemade-chicken-gravy/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Quick and Easy Cream of Tomato Soup", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F1005051.jpg", "'1 (28 ounce) can diced tomatoes in juice', '� teaspoon baking soda', '1 (10 ounce) can condensed tomato soup', '1 tablespoon dried parsley', '2 teaspoons white sugar', '1 teaspoon margarine', '� teaspoon chicken base', '� teaspoon ground white pepper', '2 cups whole milk']", false, "https://www.allrecipes.com/recipe/232190/quick-and-easy-cream-of-tomato-soup/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Quick and Easy Pizza Crust", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fcf-images.us-east-1.prod.boltdns.net%2Fv1%2Fstatic%2F1033249144001%2F83108818-1b7b-4971-b363-c924665417d7%2Fd1a0f6a1-5e24-41f9-8645-9d86c4c592ba%2F1280x720%2Fmatch%2Fimage.jpg", "'1 (.25 ounce) package active dry yeast', '1 teaspoon white sugar', '1 cup warm water (110 degrees F/45 degrees C)', '� cups bread flour', '2 tablespoons olive oil', '1 teaspoon salt']", false, "https://www.allrecipes.com/recipe/20171/quick-and-easy-pizza-crust/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Super-Delicious Zuppa Toscana", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fcf-images.us-east-1.prod.boltdns.net%2Fv1%2Fstatic%2F1033249144001%2F23d2c233-8761-4375-8415-64043b233bf0%2Faa86db20-a368-4caf-b263-38e5c3a374d0%2F1280x720%2Fmatch%2Fimage.jpg", "'1 pound bulk mild Italian sausage', '� teaspoons crushed red pepper flakes', '4 slices bacon, cut into 1/2 inch pieces', '1 large onion, diced', '1 tablespoon minced garlic', '5 (13.75 ounce) cans chicken broth', '6 potatoes, thinly sliced ', '1 cup heavy cream', '� bunch fresh spinach, tough stems removed']", false, "https://www.allrecipes.com/recipe/143069/super-delicious-zuppa-toscana/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Super-Easy Pulled Pork Sandwiches", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F1180586.jpg", "'3 tablespoons brown sugar', '3 tablespoons paprika', '� tablespoons garlic powder (such as McCormick California Style)', '� tablespoons ground black pepper', '� teaspoons salt', \"� cup Dijon mustard (such as Hellmann's)\", '8 pounds pork shoulder roast (butt roast), rind removed', '� cup barbeque sauce, or to taste', '18 large hamburger buns, split']", false, "https://www.allrecipes.com/recipe/235378/super-easy-pulled-pork-sandwiches/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Superb Sauteed Mushrooms", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F6051829.jpg", "'3 tablespoons olive oil', '3 tablespoons butter', '1 pound button mushrooms, sliced', '1 clove garlic, thinly sliced', '1 tablespoon red cooking wine', '1 tablespoon teriyaki sauce, or more to taste', '� teaspoon garlic salt, or to taste', 'freshly ground black pepper to taste']", false, "https://www.allrecipes.com/recipe/222795/superb-sauteed-mushrooms/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Sweet and Savory Hasselback Butternut Squash", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F5689691.jpg", "'1 tablespoon oil, or as needed', '1 large butternut squash - peeled, halved lengthwise, and seeded', '� teaspoon salt', '3 tablespoons water', '� cup butter', '� cup honey', '1 tablespoon cinnamon', '1 teaspoon minced garlic', '1 teaspoon fresh oregano leaves', '1 teaspoon dried orange peel', '� teaspoon smoked paprika', '2 sprigs fresh oregano, or as needed', '� cup dried cranberries', '� cup chopped pistachio nuts']", false, "https://www.allrecipes.com/recipe/267866/sweet-and-savory-hasselback-butternut-squash/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Sweet Potato and Venison Shepherd's Pie", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F7234883.jpg", "'1 large sweet potato', '2 tablespoons unsalted butter, softened', '2 tablespoons milk, or more as needed', '� teaspoon salt, or to taste', '� teaspoon ground black pepper, or to taste', '� teaspoon dried sage', '1 pinch freshly ground nutmeg', '� cup shredded sharp Cheddar cheese', '2 tablespoons vegetable oil', '1 (8 ounce) package cremini mushrooms, sliced', '1 large onion, chopped', '2 carrots, peeled and chopped', '1 stalk celery, chopped', '4 cloves garlic, chopped', 'salt to taste', '1 pound ground venison', '1 teaspoon dried thyme', '1 teaspoon dried oregano', '1 teaspoon garlic powder', '1 teaspoon onion powder', '� teaspoon ground black pepper, or to taste', '� teaspoon dried sage', '2 tablespoons all-purpose flour', ' cup dry white wine', '1 cup low-sodium chicken broth', '1 cup frozen peas']", false, "https://www.allrecipes.com/recipe/277079/sweet-potato-and-venison-shepherds-pie/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Sweet Potato Crunch", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F2785856.jpg", "'6 sweet potatoes', ' cup butter', '2 tablespoons white sugar', '� cup milk', '2 eggs, beaten', '1 teaspoon vanilla extract', '� cup brown sugar', '� cup sweetened flaked coconut', '� cup chopped pecans', '3 tablespoons all-purpose flour', '3 tablespoons melted butter']", false, "https://www.allrecipes.com/recipe/235663/sweet-potato-crunch/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Sweet Potato Pie I", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fcf-images.us-east-1.prod.boltdns.net%2Fv1%2Fstatic%2F1033249144001%2F18545bbe-6c01-42a5-9272-14fe6ab46ffb%2F3f909324-f7fa-43ed-a963-adbe737222ce%2F1280x720%2Fmatch%2Fimage.jpg", "'1 (1 pound) sweet potato', '� cup butter, softened', '1 cup white sugar', '� cup milk', '2 eggs', '� teaspoon ground nutmeg', '� teaspoon ground cinnamon', '1 teaspoon vanilla extract', '1 (9 inch) unbaked pie crust']", false, "https://www.allrecipes.com/recipe/12142/sweet-potato-pie-i/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Sweet Restaurant Slaw", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F2276935.jpg", "'1 (16 ounce) bag coleslaw mix', '2 tablespoons diced onion', ' cup creamy salad dressing (such as Miracle Whip�)', '3 tablespoons vegetable oil', '� cup white sugar', '1 tablespoon white vinegar', '� teaspoon salt', '� teaspoon poppy seeds']", false, "https://www.allrecipes.com/recipe/142027/sweet-restaurant-slaw/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Tackee David's Split Pea with Ham", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F7008429.jpg", "'1 pound dried split peas', '8 cups water', '1 meaty ham bone', '1 cup chopped onion', '� teaspoon dried marjoram leaves, crushed ', '� teaspoon dried thyme leaves, crushed', '� teaspoon garlic powder', '� teaspoon ground black pepper, or to taste', '1 cup chopped celery', '� teaspoon salt, or to taste']", false, "https://www.allrecipes.com/recipe/217084/tackee-davids-split-pea-with-ham/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Super Simple Salmon", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F3561232.jpg", "'1 tablespoon garlic powder', '1 tablespoon dried basil', '� teaspoon salt', '4 (6 ounce) salmon', '2 tablespoons butter', '4 lemon wedges']", false, "https://www.allrecipes.com/recipe/189058/super-simple-salmon/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Taco Salad I", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F38529.jpg", "'1 pound lean ground beef', '1 (1.25 ounce) package taco seasoning mix', '1 (16 ounce) can chili beans', '1 (16 ounce) bottle French dressing', '1 head iceberg lettuce', '1 (14.5 ounce) package tortilla chips', '2 cups shredded Cheddar cheese', '1 cup chopped tomatoes', '4 tablespoons sour cream', '� cup prepared salsa']", false, "https://www.allrecipes.com/recipe/14253/taco-salad-i/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Tartar Sauce I", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F2547466.jpg", "'1 cup mayonnaise', '1 tablespoon sweet pickle relish', '1 tablespoon minced onion', '2 tablespoons lemon juice', 'salt and pepper to taste']", false, "https://www.allrecipes.com/recipe/12788/tartar-sauce-i/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Tasty Baked Mac n Cheese", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F1787823.jpg", "'1 (16 ounce) package elbow macaroni', '� teaspoon salt', '� cup butter, softened - divided', '1 cup sour cream', '1 tablespoon cream cheese, softened', '1 (8 ounce) package shredded sharp Cheddar cheese', '1 egg yolk', '2 tablespoons all-purpose flour', '� teaspoon salt', '� teaspoon ground cayenne pepper', '1 cup milk', '1 (8 ounce) package shredded mild Cheddar cheese']", false, "https://www.allrecipes.com/recipe/230283/tasty-baked-mac-n-cheese/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Tasty Roasted Beets", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F5428733.jpg", "'4 beets, peeled and cut into 3/4-inch cubes', '2 tablespoons olive oil', '1 teaspoon dried thyme leaves', '1 pinch sea salt, or to taste']", false, "https://www.allrecipes.com/recipe/218185/tasty-roasted-beets/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Tater Tot Hot Dish II", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F805005.jpg", "'� pounds lean ground beef', '1 onion, chopped', '� teaspoon salt', '1 pinch ground black pepper', '1 (32 ounce) package tater tots, thawed', '1 (10.75 ounce) can  condensed cream of mushroom soup', '1 (10.75 ounce) can  condensed cream of celery soup', '1 (6 ounce) can French-fried onion rings']", false, "https://www.allrecipes.com/recipe/23069/tater-tot-hot-dish-ii/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Tatertot Casserole", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F4482008.jpg", "'1 pound ground beef', '1 pinch salt and ground black pepper to taste', '1 (10.75 ounce) can  condensed cream of mushroom soup', '2 cups shredded Cheddar cheese', '1 (16 ounce) package frozen tater tots']", false, "https://www.allrecipes.com/recipe/222037/tatertot-casserole/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Ten Minute Enchilada Sauce", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F4575029.jpg", "'� cup vegetable oil', '2 tablespoons self-rising flour', '� cup New Mexico or California chili powder', '1 (8 ounce) can tomato sauce', '� cups water', '� teaspoon ground cumin', '� teaspoon garlic powder', '� teaspoon onion salt', 'salt to taste']", false, "https://www.allrecipes.com/recipe/61727/ten-minute-enchilada-sauce/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Tennessee Meatloaf", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F1044986.jpg", "'� cup ketchup', '� cup brown sugar', '2 tablespoons cider vinegar', 'cooking spray', '1 onion, chopped', '� green bell pepper, chopped', '2 cloves garlic, minced', '2 large eggs, lightly beaten', '1 teaspoon dried thyme', '1 teaspoon seasoned salt', '� teaspoon ground black pepper', '2 teaspoons prepared mustard', '2 teaspoons Worcestershire sauce', '� teaspoon hot pepper sauce (such as Tabasco)', '� cup milk', ' cup quick cooking oats', '1 pound ground beef', '� pound ground pork', '� pound ground veal']", false, "https://www.allrecipes.com/recipe/232247/tennessee-meatloaf/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Terrific Turkey Chili", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F2352398.jpg", "'3 tablespoons vegetable oil, divided', '� pounds ground turkey', '1 (1 ounce) package taco seasoning mix', '1 teaspoon ground coriander', '1 teaspoon dried oregano', '1 teaspoon chili pepper flakes', '2 tablespoons tomato paste', '1 (14.5 ounce) can beef broth', '1 (7 ounce) can salsa', '1 (14.5 ounce) can crushed tomatoes, or coarsely chopped tomatoes packed in puree', '1 (7 ounce) can chopped green chile peppers', '1 medium onion, finely chopped', '1 green bell pepper, diced', '3 medium zucchini, halved lengthwise and sliced ', '1 bunch green onions, chopped', '1 cup sour cream', '1 cup shredded Cheddar cheese']", false, "https://www.allrecipes.com/recipe/62763/terrific-turkey-chili/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Thai-Inspired Noodle Salad", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F3894268.jpg", "'15 ounces dried soba noodles', '� teaspoons dark sesame oil', ' cup rice vinegar', ' cup soy sauce', '1 lime, zested and juiced', '2 tablespoons brown sugar', '2 cloves garlic, minced', '2 teaspoons red pepper flakes, or to taste', '1 cup finely grated carrot', '� cup chopped fresh cilantro', '� cup coarsely chopped salted peanuts']", false, "https://www.allrecipes.com/recipe/83087/thai-inspired-noodle-salad/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Taco Slaw", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F5397998.jpg", "'� small head cabbage, chopped', '1 jalapeno pepper, seeded and minced', '� red onion, minced', '1 carrot, chopped', '1 tablespoon chopped fresh cilantro', '1 lime, juiced']", false, "https://www.allrecipes.com/recipe/215030/taco-slaw/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "The Best Banana Pudding", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F771986.jpg", "'1 (5 ounce) package instant vanilla pudding mix', '2 cups cold milk', '1 (14 ounce) can sweetened condensed milk', '1 tablespoon vanilla extract', '1 (12 ounce) container frozen whipped topping, thawed', '1 (16 ounce) package vanilla wafers', '14 bananas, sliced']", false, "https://www.allrecipes.com/recipe/22749/the-best-banana-pudding/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Super Easy Egg Casserole", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F2195255.jpg", "'1 cup shredded Cheddar cheese', '6 eggs, whisked', '6 slices bacon, diced', '2 slices bread, cubed', ' red bell pepper, diced', '2 green onions, chopped', '3 tablespoons milk', '� teaspoon minced garlic, or to taste', 'salt and ground black pepper to taste']", false, "https://www.allrecipes.com/recipe/241925/super-easy-egg-casserole/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Stuffed Shells III", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F3384410.jpg", "'1 (12 ounce) package jumbo pasta shells', '2 eggs, beaten', '1 (32 ounce) container ricotta cheese', '1 pound shredded mozzarella cheese, divided', '8 ounces grated Parmesan cheese, divided', '1 tablespoon dried parsley', '2 teaspoons salt', '1 teaspoon ground black pepper', '1 (28 ounce) jar pasta sauce', '8 ounces sliced fresh mushrooms']", false, "https://www.allrecipes.com/recipe/21532/stuffed-shells-iii/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Spaghetti Sauce with Ground Beef", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F667748.jpg", "'1 pound ground beef', '1 onion, chopped', '4 cloves garlic, minced', '1 small green bell pepper, diced', '1 (28 ounce) can diced tomatoes', '1 (16 ounce) can tomato sauce', '1 (6 ounce) can tomato paste', '2 teaspoons dried oregano', '2 teaspoons dried basil', '1 teaspoon salt', '� teaspoon black pepper']", false, "https://www.allrecipes.com/recipe/158140/spaghetti-sauce-with-ground-beef/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "SPAM Fries with Spicy Garlic Sriracha Dipping Sauce", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F3977811.jpg", "'1 clove garlic, minced', '� teaspoon paprika', '1 pinch salt', '1 cup mayonnaise', '1 tablespoon sriracha sauce', '1 tablespoon ketchup', '1 quart vegetable oil for frying', '2 (12 ounce) cans fully cooked luncheon meat (such as SPAM), sliced into fries']", false, "https://www.allrecipes.com/recipe/237501/spam-fries-with-spicy-garlic-sriracha-dipping-sauce/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Spiced Orange Olive Oil Cake", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F4460247.jpg", "'4 eggs', '� cup white sugar', ' cup extra-virgin olive oil', '2 tablespoons fresh orange zest', '1 teaspoon Chinese five-spice powder', '� cups all-purpose flour', '1 tablespoon baking powder', '1 pinch salt']", false, "https://www.allrecipes.com/recipe/256811/spiced-orange-olive-oil-cake/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Spiced Pumpkin Seeds", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F4569239.jpg", "'� tablespoons margarine, melted', '� teaspoon salt', ' teaspoon garlic salt', '2 teaspoons Worcestershire sauce', '2 cups raw whole pumpkin seeds']", false, "https://www.allrecipes.com/recipe/13839/spiced-pumpkin-seeds/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Spiced Slow Cooker Applesauce", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F277498.jpg", "'8 apples - peeled, cored, and thinly sliced', '� cup water', '� cup packed brown sugar', '� teaspoon pumpkin pie spice']", false, "https://www.allrecipes.com/recipe/149218/spiced-slow-cooker-applesauce/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Spicy Grilled Cheese Sandwich", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F5081856.jpg", "'2 tablespoons butter or margarine', '4 slices white bread', '2 slices American cheese', '1 roma (plum) tomato, thinly sliced', '� small onion, chopped', '1 jalapeno pepper, chopped']", false, "https://www.allrecipes.com/recipe/85901/spicy-grilled-cheese-sandwich/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Spicy Pork Tenderloin with Apples and Sweet Potatoes", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F7251995.jpg", "'cooking spray', '1 tablespoon ground ginger', '1 tablespoon light brown sugar', '1 teaspoon chipotle chili powder, or to taste', 'salt and ground black pepper to taste', '2 (1 1/2 pound) pork tenderloins', '4 apples, peeled and cut into 8 pieces each', '1 large sweet potato, peeled and cut into 1 1/2-inch pieces', '4 tablespoons butter, cut into small pieces', '� cups apple cider', '1 lime, juiced', '� teaspoon granulated garlic', '� teaspoon ground ginger', ' teaspoon chipotle chile powder', ' teaspoon garam masala', 'salt and ground black pepper to taste', 'aluminum foil']", false, "https://www.allrecipes.com/recipe/277116/spicy-pork-tenderloin-with-apples-and-sweet-potatoes/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Spicy Thai Basil Chicken (Pad Krapow Gai)", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F4507925.jpg", "' cup chicken broth', '1 tablespoon oyster sauce', '1 tablespoon soy sauce, or as needed', '2 teaspoons fish sauce', '1 teaspoon white sugar', '1 teaspoon brown sugar', '2 tablespoons vegetable oil', '1 pound skinless, boneless chicken thighs, coarsely chopped', '� cup sliced shallots', '4 cloves garlic, minced', '2 tablespoons minced Thai chilies, Serrano, or other hot pepper', '1 cup very thinly sliced fresh basil leaves', '2 cups hot cooked rice']", false, "https://www.allrecipes.com/recipe/257938/spicy-thai-basil-chicken-pad-krapow-gai/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Spinach and Mushroom Quiche with Shiitake Mushrooms", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F2548652.jpg", "'1 prepared 9-inch single pie crust', '� cup butter', '1 bunch green onions, chopped', '3 cloves garlic, chopped', '1 slice turkey bacon, cut into 1/2-inch pieces', '1 (9 ounce) bag fresh spinach', '1 (3.5 ounce) package shiitake mushrooms, sliced', '� cup chopped broccoli florets', '� cup shredded sharp Cheddar cheese', '4 eggs, beaten', '� cup milk', '� teaspoon sea salt', '� teaspoon black pepper', '� cup shredded sharp Cheddar cheese']", false, "https://www.allrecipes.com/recipe/221199/spinach-and-mushroom-quiche-with-shiitake-mushrooms/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Summer Nights Eggplants", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F2366.jpg", "'2 large eggplants', '� cup olive oil for frying', '2 medium onions, chopped', '2 cloves garlic, minced', '2 small tomatoes, chopped', '1 green bell pepper, seeded and chopped', '1 tablespoon chopped fresh parsley', 'salt and pepper to taste', '4 cups dry bread crumbs', '1 cup crumbled feta cheese']", false, "https://www.allrecipes.com/recipe/31818/summer-nights-eggplants/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Spinach and Orzo Salad", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F681644.jpg", "'1 (16 ounce) package uncooked orzo pasta', '1 (10 ounce) package baby spinach leaves, finely chopped', '� pound crumbled feta cheese', '� red onion, finely chopped', '� cup pine nuts', '� teaspoon dried basil', '� teaspoon ground white pepper', '� cup olive oil', '� cup balsamic vinegar']", false, "https://www.allrecipes.com/recipe/26301/spinach-and-orzo-salad/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Split Pea Soup", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F2182112.jpg", "'� cups dried split peas', '2 quarts cold water', '� pounds ham bone', '2 onions, thinly sliced', '� teaspoon salt', '� teaspoon ground black pepper', '1 pinch dried marjoram', '3 stalks celery, chopped', '3 carrots, chopped', '1 potato, diced']", false, "https://www.allrecipes.com/recipe/13384/split-pea-soup/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Spooky Witches' Fingers", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F501265.jpg", "'1 cup butter, softened', \"1 cup confectioners' sugar\", '1 egg', '1 teaspoon almond extract', '1 teaspoon vanilla extract', ' cups all-purpose flour', '1 teaspoon baking powder', '1 teaspoon salt', '� cup whole almonds', '1 (.75 ounce) tube red decorating gel']", false, "https://www.allrecipes.com/recipe/146819/spooky-witches-fingers/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Stabilized Whipped Cream Icing", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F8616407.jpg", "'� cup cold water', '1 teaspoon unflavored gelatin', '1 cup heavy whipping cream', '1 tablespoon white sugar', '� teaspoon vanilla extract']", false, "https://www.allrecipes.com/recipe/18041/stabilized-whipped-cream-icing/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Stephanie's Freezer Spaghetti Sauce", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F825519.jpg", "'4 onions, chopped', '4 cloves garlic, minced', '1 green bell pepper, chopped', '� cup vegetable oil', '16 cups chopped tomatoes', '2 tablespoons dried oregano', '2 tablespoons dried basil', '� cup chopped parsley', '� cup white sugar', '2 tablespoons salt', '� teaspoon ground black pepper', '1 (6 ounce) can tomato paste']", false, "https://www.allrecipes.com/recipe/12054/stephanies-freezer-spaghetti-sauce/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Strawberry Bread", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F836956.jpg", "'2 cups fresh strawberries', ' cups all-purpose flour', '2 cups white sugar', '1 tablespoon ground cinnamon', '1 teaspoon salt', '1 teaspoon baking soda', '� cups vegetable oil', '4 eggs, beaten', '� cups chopped pecans']", false, "https://www.allrecipes.com/recipe/9353/strawberry-bread/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Strawberry Oatmeal Breakfast Smoothie", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F409456.jpg", "'1 cup soy milk', '� cup rolled oats', '1 banana, broken into chunks', '14 frozen strawberries', '� teaspoon vanilla extract', '� teaspoons white sugar']", false, "https://www.allrecipes.com/recipe/23539/strawberry-oatmeal-breakfast-smoothie/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Strawberry Spinach Salad I", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F4539063.jpg", "'2 tablespoons sesame seeds', '1 tablespoon poppy seeds', '� cup white sugar', '� cup olive oil', '� cup distilled white vinegar', '� teaspoon paprika', '� teaspoon Worcestershire sauce', '1 tablespoon minced onion', '10 ounces fresh spinach - rinsed, dried and torn into bite-size pieces', '1 quart strawberries - cleaned, hulled and sliced', '� cup almonds, blanched and slivered']", false, "https://www.allrecipes.com/recipe/14276/strawberry-spinach-salad-i/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Stuffed Peppers with Turkey and Vegetables", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F221297.jpg", "'4 green bell peppers, tops removed, seeded', '1 pound ground turkey', '2 tablespoons olive oil', '� onion, chopped', '1 cup sliced mushrooms', '1 zucchini, chopped', '� red bell pepper, chopped', '� yellow bell pepper, chopped', '1 cup fresh spinach', '1 (14.5 ounce) can diced tomatoes, drained', '1 tablespoon tomato paste', 'Italian seasoning to taste', 'garlic powder to taste', 'salt and pepper to taste']", false, "https://www.allrecipes.com/recipe/79805/stuffed-peppers-with-turkey-and-vegetables/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Stuffed Peppers", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F6957707.jpg", "'1 pound ground beef', '� cup uncooked long grain white rice', '1 cup water', '6 green bell peppers', '2 (8 ounce) cans tomato sauce', '1 tablespoon Worcestershire sauce', '� teaspoon garlic powder', '� teaspoon onion powder', 'salt and pepper to taste', '1 teaspoon Italian seasoning']", false, "https://www.allrecipes.com/recipe/16330/stuffed-peppers/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Spinach Enchiladas", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F454897.jpg", "'1 tablespoon butter', '� cup sliced green onions', '2 cloves garlic, minced', '1 (10 ounce) package frozen chopped spinach , thawed, drained and squeezed dry', '1 cup ricotta cheese', '� cup sour cream', '2 cups shredded Monterey Jack cheese', '10 (6 inch) corn tortillas', '1 (19 ounce) can enchilada sauce']", false, "https://www.allrecipes.com/recipe/59661/spinach-enchiladas/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Spaghetti Cacio e Pepe", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F3478412.jpg", "'1 pound spaghetti', '6 tablespoons olive oil', '2 cloves garlic, minced', '2 teaspoons ground black pepper', '� cups grated Pecorino Romano cheese']", false, "https://www.allrecipes.com/recipe/246628/spaghetti-cacio-e-pepe/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "The Best Chicken Fried Steak", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F5179074.jpg", "'4 (1/2 pound) beef cube steaks', '2 cups all-purpose flour', '2 teaspoons baking powder', '1 teaspoon baking soda', '1 teaspoon black pepper', '� teaspoon salt', '� cups buttermilk', '1 egg', '1 tablespoon hot pepper sauce (e.g. Tabasco�)', '2 cloves garlic, minced', '3 cups vegetable shortening for deep frying', '� cup all-purpose flour', '4 cups milk', 'kosher salt and ground black pepper to taste']", false, "https://www.allrecipes.com/recipe/150306/the-best-chicken-fried-steak/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "The Best Meatballs", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F887350.jpg", "'1 pound ground beef', '� pound ground veal', '� pound ground pork', '2 cloves garlic, minced', '2 eggs', '1 cup freshly grated Romano cheese', '� tablespoons chopped Italian flat leaf parsley', 'salt and ground black pepper to taste', '2 cups stale Italian bread, crumbled', '� cups lukewarm water', '1 cup olive oil']", false, "https://www.allrecipes.com/recipe/40399/the-best-meatballs/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Turkey Tetrazzini II", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F1940741.jpg", "'1 (16 ounce) package uncooked spaghetti', '� cup butter', '� cup all-purpose flour', '3 cups chicken broth', '2 cups milk', ' cups grated Parmesan cheese', '4 cups chopped cooked turkey']", false, "https://www.allrecipes.com/recipe/40545/turkey-tetrazzini-ii/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Two Ingredient Pumpkin Cake", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F733878.jpg", "'1 (18.25 ounce) package spice cake mix', '1 (15 ounce) can pumpkin']", false, "https://www.allrecipes.com/recipe/77375/two-ingredient-pumpkin-cake/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Ukrainian Red Borscht Soup", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F1085847.jpg", "'1 (16 ounce) package pork sausage', '3 medium beets, peeled and shredded', '3 carrots, peeled and shredded', '3 medium baking potatoes, peeled and cubed', '1 tablespoon vegetable oil', '1 medium onion, chopped', '1 (6 ounce) can tomato paste', '� cup water', '� medium head cabbage, cored and shredded', '1 (8 ounce) can diced tomatoes, drained', '3 cloves garlic, minced', 'salt and pepper to taste', '1 teaspoon white sugar, or to taste', '� cup sour cream, for topping', '1 tablespoon chopped fresh parsley for garnish']", false, "https://www.allrecipes.com/recipe/84450/ukrainian-red-borscht-soup/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Ultimate Twice Baked Potatoes", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F4535940.jpg", "'4 large baking potatoes', '8 slices bacon', '1 cup sour cream', '� cup milk', '4 tablespoons butter', '� teaspoon salt', '� teaspoon pepper', '1 cup shredded Cheddar cheese, divided', '8 green onions, sliced, divided']", false, "https://www.allrecipes.com/recipe/24332/ultimate-twice-baked-potatoes/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Unstuffed Cabbage Roll", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F4540812.jpg", "'2 pounds ground beef', '1 large onion, chopped', '1 small head cabbage, chopped', '2 (14.5 ounce) cans diced tomatoes', '1 (8 ounce) can tomato sauce', '� cup water', '2 cloves garlic, minced', '2 teaspoons salt', '1 teaspoon ground black pepper']", false, "https://www.allrecipes.com/recipe/235997/unstuffed-cabbage-roll/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Vegetarian Chickpea Sandwich Filling", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F362677.jpg", "'1 (19 ounce) can garbanzo beans, drained and rinsed', '1 stalk celery, chopped', '� onion, chopped', '1 tablespoon mayonnaise', '1 tablespoon lemon juice', '1 teaspoon dried dill weed', 'salt and pepper to taste']", false, "https://www.allrecipes.com/recipe/16715/vegetarian-chickpea-sandwich-filling/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "VELVEETA Down-Home Macaroni and Cheese", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F8194943.jpg", "'� cup butter, divided', '� cup flour', '1 cup milk', '� pound VELVEETA, cut into 1/2-inch cubes', '2 cups elbow macaroni, cooked and drained', '� cup KRAFT Shredded Cheddar Cheese', '6 RITZ Crackers, crushed']", false, "https://www.allrecipes.com/recipe/232331/velveeta-down-home-macaroni-and-cheese/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Vietnamese Fresh Spring Rolls", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F5265636.jpg", "'2 ounces rice vermicelli', '8 rice wrappers (8.5 inch diameter)', '8 large cooked shrimp - peeled, deveined and cut in half', ' tablespoons chopped fresh Thai basil', '3 tablespoons chopped fresh mint leaves', '3 tablespoons chopped fresh cilantro', '2 leaves lettuce, chopped', '4 teaspoons fish sauce', '� cup water', '2 tablespoons fresh lime juice', '1 clove garlic, minced', '2 tablespoons white sugar', '� teaspoon garlic chili sauce', '3 tablespoons hoisin sauce', '1 teaspoon finely chopped peanuts']", false, "https://www.allrecipes.com/recipe/24239/vietnamese-fresh-spring-rolls/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Virgina's Tuna Salad", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F44694.jpg", "'1 egg', '1 (5 ounce) can tuna, drained and flaked', '3 tablespoons mayonnaise', '2 stalks celery, chopped', '2 tablespoons sweet pickle relish', '1 pinch ground black pepper']", false, "https://www.allrecipes.com/recipe/20185/virginas-tuna-salad/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Turkey Tetrazzini a la Stouffers", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F1056677.jpg", "'2 teaspoons butter', '� cup butter, divided', '1 cup chopped celery', '1 (8 ounce) package sliced fresh mushrooms', '� cup all-purpose flour', ' cups chicken broth', '1 cup heavy whipping cream', '� cup sherry wine', '1 teaspoon salt', '� teaspoon white pepper', '� (12 ounce) package angel hair pasta', '2 cups diced cooked turkey', '� cup panko bread crumbs']", false, "https://www.allrecipes.com/recipe/232097/turkey-tetrazzini-a-la-stouffers/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Waffles I", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F3875444.jpg", "'2 eggs', '2 cups all-purpose flour', '� cups milk', '� cup vegetable oil', '1 tablespoon white sugar', '4 teaspoons baking powder', '� teaspoon salt', '� teaspoon vanilla extract']", false, "https://www.allrecipes.com/recipe/22180/waffles-i/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Whipped Cream", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F587542.jpg", "'1 cup heavy cream', '1 teaspoon vanilla extract', \"1 tablespoon confectioners' sugar\"]", false, "https://www.allrecipes.com/recipe/18352/whipped-cream/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "White Chicken Enchilada Slow-Cooker Casserole", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F3389638.jpg", "'15 boneless, skinless chicken thighs or breasts', '1 (26 ounce) can condensed cream of chicken soup', '2 cloves garlic, chopped', '1 (16 ounce) container sour cream', '1 (7 ounce) can diced green chile peppers', '15 flour tortillas', '� cups shredded Monterey Jack cheese', '1 (10 ounce) can sliced black olives', '1 bunch chives for garnish', 'black pepper to taste']", false, "https://www.allrecipes.com/recipe/87133/white-chicken-enchilada-slow-cooker-casserole/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "White Chili with Ground Turkey", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F3359183.jpg", "'1 onion, chopped', '3 cloves garlic, minced', '� pounds ground turkey', '2 (4 ounce) cans canned green chile peppers, chopped', '1 tablespoon ground cumin', '1 tablespoon dried oregano', '1 teaspoon ground cinnamon', 'ground cayenne pepper to taste', 'ground white pepper to taste', '3 (15 ounce) cans cannellini beans', '5 cups chicken broth', '2 cups shredded Monterey Jack cheese']", false, "https://www.allrecipes.com/recipe/17023/white-chili-with-ground-turkey/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Whole Wheat Beer Bread", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F390936.jpg", "'� cups all-purpose flour', '� cups whole wheat flour', '4\\u2009� teaspoons baking powder', '� teaspoons salt', ' cup packed brown sugar', '1 (12 fluid ounce) can or bottle beer']", false, "https://www.allrecipes.com/recipe/24932/whole-wheat-beer-bread/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Wisconsin Five-Cheese Bake", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F1067771.jpg", "'1 (16 ounce) package elbow macaroni', '1 cup shredded mozzarella cheese', '1 cup shredded Swiss cheese', '1 cup grated Parmesan cheese', '1 cup shredded provolone cheese', '� cup ricotta cheese', '� cup sour cream', '� cup heavy cream', '1 tablespoon chopped fresh parsley', '� teaspoon dried Italian seasoning', '� teaspoon garlic salt']", false, "https://www.allrecipes.com/recipe/103088/wisconsin-five-cheese-bake/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "World's Best Honey Garlic Pork Chops", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F4519164.jpg", "'� cup ketchup', ' tablespoons honey', '2 tablespoons low-sodium soy sauce', '2 cloves garlic, crushed', '6 (4 ounce) (1-inch thick) pork chops']", false, "https://www.allrecipes.com/recipe/235158/worlds-best-honey-garlic-pork-chops/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Yellow Squash Casserole", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F806193.jpg", "'4 cups sliced yellow squash', '� cup chopped onion', '35 buttery round crackers, crushed', '1 cup shredded Cheddar cheese', '2 eggs, beaten', '� cup milk', '� cup butter, melted', '1 teaspoon salt', 'ground black pepper to taste', '2 tablespoons butter']", false, "https://www.allrecipes.com/recipe/18045/yellow-squash-casserole/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Yummy Honey Mustard Dipping Sauce", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F704099.jpg", "'� cup mayonnaise', '2 tablespoons prepared yellow mustard', '1 tablespoon Dijon mustard', '2 tablespoons honey', '� tablespoon lemon juice']", false, "https://www.allrecipes.com/recipe/173697/yummy-honey-mustard-dipping-sauce/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Yummy Sweet Potato Casserole", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F4573472.jpg", "'4 cups sweet potato, cubed', '� cup white sugar', '2 eggs, beaten', '� teaspoon salt', '4 tablespoons butter, softened', '� cup milk', '� teaspoon vanilla extract', '� cup packed brown sugar', ' cup all-purpose flour', '3 tablespoons butter, softened', '� cup chopped pecans']", false, "https://www.allrecipes.com/recipe/21261/yummy-sweet-potato-casserole/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Walnut-Cream Roll", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F6732635.jpg", "'4 egg whites', '1 teaspoon vanilla extract', '� teaspoon salt', '� cup white sugar', '4 egg yolks', '� cup sifted enriched flour', '� cup chopped walnuts', \"1 tablespoon sifted confectioners' sugar, or as needed\", '1 cup cold heavy cream', '1 tablespoon white sugar, or to taste', '1 tablespoon walnut halves, or as needed']", false, "https://www.allrecipes.com/recipe/273684/walnut-cream-roll/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "The Best Marinade Around", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F800834.jpg", "'� cup soy sauce', '� cup olive oil', '1 lemon, juiced', '1 clove garlic, crushed']", false, "https://www.allrecipes.com/recipe/14591/the-best-marinade-around/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Turkey Meatball Stew", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F8553035.jpg", "'cooking spray', '1 pound 93% lean ground turkey', '1 cup fresh bread crumbs', '1 large egg, lightly beaten', '2 tablespoons minced fresh parsley', '1 teaspoon Worcestershire sauce', '1 teaspoon garlic powder', '� teaspoon Italian seasoning', '� teaspoon onion powder', '1 pinch salt and ground black pepper to taste', '� cup olive oil', '1 medium onion, chopped', '2 stalks celery, chopped', '2 (14.5 ounce) cans fire-roasted diced tomatoes, undrained', '3 cups low-sodium chicken broth', '2 cups cubed peeled potatoes', '1 cup peeled, chopped carrots', '1 cup frozen peas', '1 teaspoon dried basil', '� teaspoon crushed red pepper flakes']", false, "https://www.allrecipes.com/recipe/281661/turkey-meatball-stew/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Turkey Goulash", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F5168274.jpg", "'1 pound lean ground turkey', '1 (14 ounce) can stewed, diced tomatoes', '3 cloves garlic, minced', '1 cup tomato sauce', '2 teaspoons white sugar', '� teaspoon dried basil', '1 (16 ounce) package bow tie pasta']", false, "https://www.allrecipes.com/recipe/18783/turkey-goulash/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "The Best Meatloaf I've Ever Made", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F265924.jpg", "'1 tablespoon butter', '� cup minced onion', '2 cloves garlic, minced', '� teaspoons salt', '� teaspoons freshly ground black pepper', '2 pounds extra-lean ground beef', '3 slices bread, toasted and crumbled', '7 buttery round crackers, crushed', '1 egg, lightly beaten', '� tablespoons sour cream', '� tablespoons Worcestershire sauce', '1 (15 ounce) can tomato sauce, divided', '� cup milk', '3 tablespoons ketchup']", false, "https://www.allrecipes.com/recipe/74360/the-best-meatloaf-ive-ever-made/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "The Best Rolled Sugar Cookies", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fcf-images.us-east-1.prod.boltdns.net%2Fv1%2Fstatic%2F1033249144001%2Fea876c31-785e-421a-9c4c-c9da9316376b%2F885558ad-2c7a-4ac3-89e2-4ca94c35a847%2F1280x720%2Fmatch%2Fimage.jpg", "'� cups butter, softened', '2 cups white sugar', '4 eggs', '1 teaspoon vanilla extract', '5 cups all-purpose flour', '2 teaspoons baking powder', '1 teaspoon salt']", false, "https://www.allrecipes.com/recipe/10402/the-best-rolled-sugar-cookies/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "The Best Steak Marinade", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F7968044.jpg", "'� cup olive oil', '� cup balsamic vinegar', '� cup Worcestershire sauce', '� cup soy sauce', '2 teaspoons Dijon mustard', '2 teaspoons minced garlic', 'salt and pepper to taste']", false, "https://www.allrecipes.com/recipe/176770/the-best-steak-marinade/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "The Best Thai Coconut Soup", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F2319909.jpg", "'1 tablespoon vegetable oil', '2 tablespoons grated fresh ginger ', '1 stalk lemon grass, minced', '2 teaspoons red curry paste', '4 cups chicken broth', '3 tablespoons fish sauce', '1 tablespoon light brown sugar', '3 (13.5 ounce) cans coconut milk', '� pound fresh shiitake mushrooms, sliced', '1 pound medium shrimp - peeled and deveined', '2 tablespoons fresh lime juice', 'salt to taste', '� cup chopped fresh cilantro']", false, "https://www.allrecipes.com/recipe/146035/the-best-thai-coconut-soup/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "The Best Unbaked Cherry Cheesecake Ever", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F26887.jpg", "'� cups graham cracker crumbs', '� cup margarine, softened', '� cup sugar', '1 (8 ounce) package cream cheese', '1 cup powdered sugar', '1 teaspoon vanilla extract', '1 cup heavy cream, whipped', '1 (12.5 ounce) can cherry pie filling (or other filling of your choice)']", false, "https://www.allrecipes.com/recipe/49066/the-best-unbaked-cherry-cheesecake-ever/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "The Best Vegetarian Chili in the World", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F4565674.jpg", "'1 tablespoon olive oil', '� medium onion, chopped', '2 bay leaves', '1 teaspoon ground cumin', '2 tablespoons dried oregano', '1 tablespoon salt', '2 stalks celery, chopped', '2 green bell peppers, chopped', '2 jalapeno peppers, chopped', '3 cloves garlic, chopped', '2 (4 ounce) cans chopped green chile peppers, drained', '2 (12 ounce) packages vegetarian burger crumbles', '3 (28 ounce) cans whole peeled tomatoes, crushed', '� cup chili powder', '1 tablespoon ground black pepper', '1 (15 ounce) can kidney beans, drained', '1 (15 ounce) can garbanzo beans, drained', '1 (15 ounce) can black beans', '1 (15 ounce) can whole kernel corn']", false, "https://www.allrecipes.com/recipe/72508/the-best-vegetarian-chili-in-the-world/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "The Real Deal Korean Beef Ribs", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F845264.jpg", "'4 pounds Korean-style short ribs (beef chuck flanken, cut 1/3 to 1/2 inch thick across bones)', '� cup reduced-sodium soy sauce', '� cup white sugar', '2 tablespoons honey', '2 tablespoons minced garlic', '2 tablespoons ground black pepper', '3 tablespoons water', '1 tablespoon Asian (toasted) sesame oil', '� tablespoons Asian plum wine']", false, "https://www.allrecipes.com/recipe/158229/the-real-deal-korean-beef-ribs/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Three Bean Salad", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F1284727.jpg", "'1 (15 ounce) can green beans', '1 pound wax beans', '1 (15 ounce) can kidney beans, drained and rinsed', '1 onion, sliced into thin rings', '� cup white sugar', ' cup distilled white vinegar', ' cup vegetable oil', '� teaspoon salt', '� teaspoon ground black pepper', '� teaspoon celery seed']", false, "https://www.allrecipes.com/recipe/13637/three-bean-salad/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Three Ingredient Peanut Butter Cookies", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F178805.jpg", "'1 cup peanut butter', '1 cup white sugar', '1 egg']", false, "https://www.allrecipes.com/recipe/11352/three-ingredient-peanut-butter-cookies/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Turkey in a Smoker", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F2833871.jpg", "'1 (10 pound) whole turkey, neck and giblets removed', '4 cloves garlic, crushed', '2 tablespoons seasoned salt', '� cup butter', '2 (12 fluid ounce) cans cola-flavored carbonated beverage', '1 apple, quartered', '1 onion, quartered', '1 tablespoon garlic powder', '1 tablespoon salt', '1 tablespoon ground black pepper']", false, "https://www.allrecipes.com/recipe/16984/turkey-in-a-smoker/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "To Die For Blueberry Muffins", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F662790.jpg", "'� cups all-purpose flour', '� cup white sugar', '� teaspoon salt', '2 teaspoons baking powder', ' cup vegetable oil', '1 egg', ' cup milk, or more as needed', '1 cup fresh blueberries', '� cup white sugar', ' cup all-purpose flour', '� cup butter, cubed', '� teaspoons ground cinnamon']", false, "https://www.allrecipes.com/recipe/6865/to-die-for-blueberry-muffins/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Tomato-Cream Sauce for Pasta", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F376244.jpg", "'2 tablespoons olive oil', '1 onion, diced', '1 clove garlic, minced', '1 (14.5 ounce) can Italian-style diced tomatoes, undrained', '1 tablespoon dried basil leaves', '� teaspoon white sugar', '� teaspoon dried oregano', '� teaspoon salt', ' teaspoon ground black pepper', '� cup heavy cream', '1 tablespoon butter']", false, "https://www.allrecipes.com/recipe/23404/tomato-cream-sauce-for-pasta/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Tortellini Salad", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F3871772.jpg", "'1 (16 ounce) package refrigerated cheese tortellini', '4 ounces sliced pepperoni, quartered', '2 green onions, sliced', '1 (2.25 ounce) can sliced black olives', '1 (6.5 ounce) jar marinated artichoke hearts, drained and chopped', '6 ounces mozzarella cheese, diced', ' cup extra-virgin olive oil', '� tablespoons balsamic vinegar', '� tablespoons distilled white vinegar', '1 teaspoon dried Italian herb seasoning', 'salt and black pepper to taste']", false, "https://www.allrecipes.com/recipe/206441/tortellini-salad/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Tres Leches (Milk Cake)", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F384988.jpg", "'� cups all-purpose flour', '1 teaspoon baking powder', '� cup unsalted butter', '1 cup white sugar', '5 eggs', '� teaspoon vanilla extract', '2 cups whole milk', '1 (14 ounce) can sweetened condensed milk', '1 (12 fluid ounce) can evaporated milk', '� cups heavy whipping cream', '1 cup white sugar', '1 teaspoon vanilla extract']", false, "https://www.allrecipes.com/recipe/7399/tres-leches-milk-cake/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Triple Chocolate Chunk Cookies", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F7910460.jpg", "'� cup brown sugar', '� cup unsalted butter, at room temperature', '� cup white sugar', '1 teaspoon salt', '1 large egg', '1 teaspoon vanilla extract', '� cups all-purpose flour', '� teaspoon baking soda', '1 cup milk chocolate chips', '1 (3 ounce) bar dark chocolate, cut into chunks', '3 tablespoons white chocolate chips']", false, "https://www.allrecipes.com/recipe/278882/triple-chocolate-chunk-cookies/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Triple the Ginger Cookies", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F2743790.jpg", "'� cup butter', '1 cup packed brown sugar', '1 egg', '� cup molasses', '� cups all-purpose flour', '2 teaspoons ground ginger', '2 teaspoons baking soda', '� teaspoon salt', '� tablespoons minced fresh ginger root', '� cup chopped crystallized ginger']", false, "https://www.allrecipes.com/recipe/9584/triple-the-ginger-cookies/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Tropical Turkey Salad", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F1642537.jpg", "' cup low-fat sour cream', '2 tablespoons mango chutney', '1 tablespoon fresh lemon juice', '1 tablespoon honey', '� teaspoon curry powder', '4 cups chopped cooked turkey', '1 cup diced red bell pepper', '1 cup diced celery', '1 cup pineapple chunks', '1 cup chopped orange segments', '� cup chopped green onion']", false, "https://www.allrecipes.com/recipe/43781/tropical-turkey-salad/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Tuna Fish Salad", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F236438.jpg", "'1 (5 ounce) can tuna, drained', '1 tablespoon chopped fresh parsley', '� cup chopped celery', '� cup mayonnaise', '� teaspoon lemon juice', '� cup chopped onion', '� teaspoon garlic powder', ' teaspoon salt', ' teaspoon ground black pepper', 'paprika to taste']", false, "https://www.allrecipes.com/recipe/16468/tuna-fish-salad/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Tuna Rice Puff", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F3827402.jpg", "' cup uncooked white rice', ' cups water', ' cup butter', '� cup all-purpose flour', '1 teaspoon salt', '� teaspoon ground black pepper', '� cups milk', '2 egg yolks', '1 (12 ounce) can tuna, undrained', '2 tablespoons grated onion', '1 tablespoon lemon juice', '2 egg whites']", false, "https://www.allrecipes.com/recipe/213731/tuna-rice-puff/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Turkey Carcass Soup", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F4589306.jpg", "'1 turkey carcass', '4 quarts water', '6 small potatoes, diced', '4 large carrots, diced', '2 stalks celery, diced', '1 large onion, diced', '� cups shredded cabbage', '1 (28 ounce) can whole peeled tomatoes, chopped', '� cup uncooked barley', '1 tablespoon Worcestershire sauce', '� teaspoons salt', '1 teaspoon dried parsley', '1 teaspoon dried basil', '1 bay leaf', '� teaspoon freshly cracked black pepper', '� teaspoon paprika', '� teaspoon poultry seasoning', '1 pinch dried thyme']", false, "https://www.allrecipes.com/recipe/218804/turkey-carcass-soup/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "To Die For Fettuccine Alfredo", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F8135663.jpg", "'24 ounces dry fettuccini pasta', '1 cup butter', '� pint heavy cream', 'salt and pepper to taste', '1 dash garlic salt', '� cup grated Romano cheese', '� cup grated Parmesan cheese']", false, "https://www.allrecipes.com/recipe/23431/to-die-for-fettuccine-alfredo/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Quick and Easy Hollandaise Sauce in the Microwave", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F3519728.jpg", "'2 egg yolks', '� lemon, juiced, or to taste', '1 pinch salt', '1 pinch cayenne pepper', '� cup salted butter, melted']", false, "https://www.allrecipes.com/recipe/233971/quick-and-easy-hollandaise-sauce-in-the-microwave/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Spaghetti Aglio e Olio", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F3727226.jpg", "'1 pound uncooked spaghetti', '6 cloves garlic, thinly sliced', '� cup olive oil', '� teaspoon red pepper flakes, or to taste', 'salt and freshly ground black pepper to taste', '� cup chopped fresh Italian parsley', '1 cup finely grated Parmigiano-Reggiano cheese']", false, "https://www.allrecipes.com/recipe/222000/spaghetti-aglio-e-olio/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Southern Fried Cabbage", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F4874581.jpg", "'3 slices bacon, cut into thirds', ' cup vegetable oil', '1 teaspoon salt, or to taste', '1 teaspoon ground black pepper, or to taste', '1 head cabbage, cored and sliced', '1 white onion, chopped', '1 pinch white sugar']", false, "https://www.allrecipes.com/recipe/73833/southern-fried-cabbage/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Roasted Cauliflower with Pecorino and Mint", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F6648240.jpg", "'4 tablespoons unsalted butter', '1 small head cauliflower, cut into florets', '� teaspoon kosher salt, plus more to taste', '� cup thinly sliced red onion', '� cup finely grated Pecorino Romano cheese', '10 leaves fresh mint, cut into thin strips', '1 tablespoon lemon juice']", false, "https://www.allrecipes.com/recipe/273523/roasted-cauliflower-with-pecorino-and-mint/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Roasted Eggplant Pastitsio", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F4577103.jpg", "'1 large eggplant, halved lengthwise', '1 tablespoon olive oil', '� cups chopped onions', '1 pound ground lamb', '1 clove garlic, minced', '� teaspoons salt', '1 teaspoon ground cumin', '1 teaspoon dried oregano', '� teaspoon freshly ground black pepper', '� teaspoon ground cinnamon', '1 (14 ounce) can diced tomatoes', '1 (14 ounce) can crushed tomatoes', '1 tablespoon chopped fresh mint', '2 eggs', '2 tablespoons unsalted butter', '2 tablespoons all-purpose flour', '2 cups milk', '1 clove garlic, lightly crushed', '1 (8 ounce) package crumbled feta cheese', '� teaspoon salt', 'black pepper to taste', '1 pinch freshly grated nutmeg', 'cooking spray', '1 (12 ounce) package penne pasta']", false, "https://www.allrecipes.com/recipe/261325/roasted-eggplant-pastitsio/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Roasted Garlic-Parmesan Fingerling Potatoes", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F6093953.jpg", "'1 pound fingerling potatoes, halved lengthwise', '2 cloves garlic, minced', '2 tablespoons grated Parmesan cheese', '1 teaspoon lemon zest', '� teaspoon salt', '� teaspoon freshly ground black pepper', '2 tablespoons olive oil', '1 tablespoon butter', '2 tablespoons chopped fresh parsley']", false, "https://www.allrecipes.com/recipe/269519/roasted-garlic-parmesan-fingerling-potatoes/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Roasted Pumpkin Seeds", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F729337.jpg", "'� cups raw whole pumpkin seeds', '2 teaspoons butter, melted', '1 pinch salt']", false, "https://www.allrecipes.com/recipe/13768/roasted-pumpkin-seeds/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Roasted Turkey Legs", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F6034573.jpg", "'3 stalks celery stalks, cut in thirds', '3 turkey legs', '6 tablespoons butter', 'salt to taste', '� cup water, or as needed']", false, "https://www.allrecipes.com/recipe/84456/roasted-turkey-legs/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Roasted Vegetables", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F1486.jpg", "'1 small butternut squash, cubed', '2 red bell peppers, seeded and diced', '1 sweet potato, peeled and cubed', '3 Yukon Gold potatoes, cubed', '1 red onion, quartered', '1 tablespoon chopped fresh thyme', '2 tablespoons chopped fresh rosemary', '� cup olive oil', '2 tablespoons balsamic vinegar', 'salt and freshly ground black pepper']", false, "https://www.allrecipes.com/recipe/9377/roasted-vegetables/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Rockin' Oysters Rockefeller", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F2610379.jpg", "'48 fresh, unopened oysters', '� cups beer', '2 cloves garlic', 'seasoned salt to taste', '7 black peppercorns', '� cup butter', '1 onion, chopped', '1 clove garlic, crushed', '1 (10 ounce) package frozen chopped spinach, thawed and drained', '8 ounces Monterey Jack cheese, shredded', '8 ounces fontina cheese, shredded', '8 ounces mozzarella cheese, shredded', '� cup milk', '2 teaspoons salt, or to taste', '1 teaspoon ground black pepper', '2 tablespoons fine bread crumbs']", false, "https://www.allrecipes.com/recipe/12801/rockin-oysters-rockefeller/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Rotisserie Chicken and Stuffing Casserole", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F4282347.jpg", "'cooking spray', '� cups water', '� cup butter', '1 (6 ounce) package quick-cooking stuffing mix (such as Stove Top), or more to taste', '1 tablespoon butter', '1 onion, diced', '3 stalks celery, diced, or more to taste', '1 (10.75 ounce) can  cream of chicken soup', '1 (8 ounce) container sour cream', '� (10.5 ounce) can cream of mushroom soup', '1 whole cooked rotisserie chicken - skinned, boned, and meat shredded', 'salt and ground black pepper to taste']", false, "https://www.allrecipes.com/recipe/240220/rotisserie-chicken-and-stuffing-casserole/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Russian Honey Cake", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F7287365.jpg", "'� cup wildflower honey', '3 tablespoons cold water', '14 tablespoons unsalted butter, cut into slices', '1 cup white sugar', '� cup wildflower honey', '6 large cold eggs', '� teaspoons baking soda', '� teaspoon fine salt', '1 teaspoon ground cinnamon', '� cups all-purpose flour', '4 cups cold heavy whipping cream', '� cup sour cream']", false, "https://www.allrecipes.com/recipe/277220/russian-honey-cake/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Roasted Cauliflower Soup", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F1012540.jpg", "'2 heads   cauliflower, broken into florets', 'olive oil cooking spray', '� cup olive oil', '1 large onion, chopped', '4 cloves garlic, chopped', '6 cups water', 'salt and ground black pepper to taste']", false, "https://www.allrecipes.com/recipe/216950/roasted-cauliflower-soup/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Salisbury Steak", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F376047.jpg", "'1 (10.5 ounce) can condensed French onion soup', '� pounds ground beef', '� cup dry bread crumbs', '1 egg', '� teaspoon salt', ' teaspoon ground black pepper', '1 tablespoon all-purpose flour', '� cup ketchup', '� cup water', '1 tablespoon Worcestershire sauce', '� teaspoon mustard powder']", false, "https://www.allrecipes.com/recipe/14595/salisbury-steak/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Salsa Chicken Rice Casserole", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F4463602.jpg", "' cups uncooked white rice', ' cups water', '4 skinless, boneless chicken breast halves', '2 cups shredded Monterey Jack cheese', '2 cups shredded Cheddar cheese', '1 (10.75 ounce) can  condensed cream of chicken soup', '1 (10.75 ounce) can  condensed cream of mushroom soup', '1 onion, chopped', '� cups mild salsa']", false, "https://www.allrecipes.com/recipe/17952/salsa-chicken-rice-casserole/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Salted Caramel Chocolate Pecan Cookies", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F1074269.jpg", "'� cups unsalted butter, softened', '1 cup white sugar', '� teaspoons vanilla extract', '� cups all-purpose flour', '� teaspoon salt', '2 large eggs, lightly beaten', '� cup chopped toasted pecans', '44 caramel candies', '6 tablespoons heavy whipping cream', 'coarse sea salt', '1 (6 ounce) bag semisweet chocolate chips', '1 tablespoon vegetable oil']", false, "https://www.allrecipes.com/recipe/260908/salted-caramel-chocolate-pecan-cookies/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Salted Chocolate Cookies", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F7521860.jpg", "'nonstick cooking spray', '1 cup all-purpose flour', '� cup unsweetened cocoa powder', '1 teaspoon baking powder', '� teaspoon sea salt', '� cup butter, cut into chunks', '� cup semisweet chocolate chips', ' cup brown sugar', '� cup white sugar', '2 eggs', '1 teaspoon vanilla extract', '1 tablespoon sea salt, or as needed']", false, "https://www.allrecipes.com/recipe/277919/salted-chocolate-cookies/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Sarah's Applesauce", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F25840.jpg", "'4 apples - peeled, cored and chopped', '� cup water', '� cup white sugar', '� teaspoon ground cinnamon']", false, "https://www.allrecipes.com/recipe/51301/sarahs-applesauce/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Sausage Balls", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F466969.jpg", "'1 pound ground pork sausage', '2 cups biscuit baking mix', '1 pound sharp Cheddar cheese, shredded']", false, "https://www.allrecipes.com/recipe/21649/sausage-balls/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Sausage Crescent Rolls", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F11644.jpg", "'1 pound fresh, ground spicy pork sausage', '1 (8 ounce) package cream cheese', '2 (8 ounce) packages refrigerated crescent rolls', '1 egg white, lightly beaten', '1 tablespoon poppy seeds']", false, "https://www.allrecipes.com/recipe/21746/sausage-crescent-rolls/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Sausage, Peppers, Onions, and Potato Bake", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fcf-images.us-east-1.prod.boltdns.net%2Fv1%2Fstatic%2F1033249144001%2F76da7e90-7870-4ae6-80a8-0e028b5f18ba%2F69d6da0a-ec66-4acf-9e3e-a4880a4eda42%2F640x360%2Fmatch%2Fimage.jpg", "'2 teaspoons olive oil', '2 pounds Italian sausage links, cut into 2-inch pieces', '� cup olive oil', '4 large potatoes, peeled and thickly sliced', '2 large green bell peppers, seeded and cut into wedges', '2 large red bell peppers, seeded and cut into wedges', '3 large onions, cut into wedges', '� cup white wine', '� cup chicken stock', '1 teaspoon Italian seasoning', 'salt and pepper to taste']", false, "https://www.allrecipes.com/recipe/214500/sausage-peppers-onions-and-potato-bake/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Sausage, Potato and Kale Soup", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F970170.jpg", "'1 pound bulk Italian sausage', '4 cups half-and-half', '3 cups cubed potatoes', '2 cups low-sodium chicken broth', '2 cups whole milk', '1 onion, chopped', '� teaspoon dried oregano', '� teaspoon red pepper flakes, or more to taste', '� teaspoon ground black pepper', '2 cups torn kale leaves (bite-size pieces)']", false, "https://www.allrecipes.com/recipe/231287/sausage-potato-and-kale-soup/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Savory Pumpkin Hummus", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F1526126.jpg", "'2 tablespoons lemon juice', '2 tablespoons tahini', '3 cloves garlic', '� teaspoon salt', '2 (15 ounce) cans garbanzo beans, drained', '2 teaspoons extra-virgin olive oil', '1 (15 ounce) can pumpkin puree', '1 teaspoon ground cumin', '� teaspoon cayenne pepper', '� cup toasted pumpkin seed kernels, or more to taste', '1 pinch paprika']", false, "https://www.allrecipes.com/recipe/230466/savory-pumpkin-hummus/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Salmon Patties I", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F7697013.jpg", "'1 (14.75 ounce) can canned salmon', '1 egg', '� cup chopped onion', '� cup seasoned dry bread crumbs', '1 tablespoon olive oil']", false, "https://www.allrecipes.com/recipe/9401/salmon-patties-i/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Scones", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F5614372.jpg", "'3 cups all-purpose flour', '� cup white sugar', '5 teaspoons baking powder', '� teaspoon salt', '� cup butter', '1 egg, beaten', '1 cup milk']", false, "https://www.allrecipes.com/recipe/20175/scones/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Roasted Brussels Sprouts", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F812447.jpg", "'� pounds Brussels sprouts, ends trimmed and yellow leaves removed', '3 tablespoons olive oil', '1 teaspoon kosher salt', '� teaspoon freshly ground black pepper']", false, "https://www.allrecipes.com/recipe/67952/roasted-brussels-sprouts/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Roasted Asparagus Salad with Feta Cheese", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F3239590.jpg", "'1 bunch fresh asparagus, trimmed and cut into bite-size pieces', '2 tablespoons olive oil', '1 pinch garlic powder, or to taste', '4 cups lettuce leaves, cut into bite-size pieces', '1 cup grape tomatoes, halved', '� cup crumbled feta cheese']", false, "https://www.allrecipes.com/recipe/237217/roasted-asparagus-salad-with-feta-cheese/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Quick and Easy Tater Tot Casserole", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F3107518.jpg", "'1 pound ground beef', '1 pinch garlic powder', 'salt and pepper to taste', '1 (32 ounce) package tater tots, thawed', '1 (10.75 ounce) can  condensed cream of mushroom soup', '1 (10.75 ounce) can  condensed cream of celery soup', '1 (10.75 ounce) can  milk', '1 pinch garlic powder']", false, "https://www.allrecipes.com/recipe/24520/quick-and-easy-tater-tot-casserole/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Quick and Easy Tuna Casserole", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F632652.jpg", "'1 (12 ounce) package egg noodles', '2 cups frozen green peas', '2 (10.75 ounce) cans  condensed cream of mushroom soup', '2 (5 ounce) cans tuna, drained', '1 onion, chopped', '10 slices American processed cheese', 'ground black pepper to taste']", false, "https://www.allrecipes.com/recipe/16964/quick-and-easy-tuna-casserole/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Quick and Easy Yorkshire Pudding", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F3911287.jpg", "'3 eggs', '1 cup milk', '1 cup all-purpose flour', '2 tablespoons butter']", false, "https://www.allrecipes.com/recipe/22539/quick-and-easy-yorkshire-pudding/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Quick Beef Stir-Fry", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F6263320.jpg", "'2 tablespoons vegetable oil', '1 pound beef sirloin, cut into 2-inch strips', '� cups fresh broccoli florets', '1 red bell pepper, cut into matchsticks', '2 carrots, thinly sliced', '1 green onion, chopped', '1 teaspoon minced garlic', '2 tablespoons soy sauce', '2 tablespoons sesame seeds, toasted']", false, "https://www.allrecipes.com/recipe/228823/quick-beef-stir-fry/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Quick Cinnamon Rolls", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F7535189.jpg", "'� cup butter, divided', '2 cups all-purpose flour', '2 tablespoons white sugar', '2 teaspoons baking powder', '1 teaspoon salt', '3 tablespoons butter, softened', '� cup milk', '1 egg', '� cup white sugar', '� cup brown sugar', '1 tablespoon ground cinnamon', \"1 cup confectioners' sugar\", '4 ounces cream cheese, softened', '� cup butter, softened', '� teaspoon vanilla extract']", false, "https://www.allrecipes.com/recipe/241917/quick-cinnamon-rolls/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Quick Italian Pasta Salad", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F2272781.jpg", "'1 (12 ounce) package tri-color rotini pasta', '� pound Italian salami, finely diced', '� green bell pepper, sliced', '� red bell pepper, sliced', '� red onion, chopped', '1 cup Italian-style salad dressing', '1 (6 ounce) can sliced black olives', '8 ounces small fresh mozzarella balls (ciliegine)', '3 (.7 ounce) packages dry Italian-style salad dressing mix, or to taste', '� cup shredded Parmesan cheese']", false, "https://www.allrecipes.com/recipe/222750/quick-italian-pasta-salad/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Quick Tartar Sauce", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F423175.jpg", "'1 cup mayonnaise', '2 teaspoons sweet pickle relish', '1 teaspoon prepared yellow mustard', '1 teaspoon lemon juice']", false, "https://www.allrecipes.com/recipe/183835/quick-tartar-sauce/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Quick Turkey Taco Salad", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F3793734.jpg", "'� pound ground turkey', '1 (1 ounce) packet taco seasoning mix', '� cup chopped green bell pepper', '4 cups mixed salad greens and fresh herbs', '2 cups tortilla chips', '� cup shredded Mexican cheese blend', ' cup chopped onion', '� cup fresh salsa', '1 tablespoon sour cream']", false, "https://www.allrecipes.com/recipe/232245/quick-turkey-taco-salad/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Real Poutine", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F153593.jpg", "'1 quart vegetable oil for frying', '1 (10.25 ounce) can beef gravy', '5 medium potatoes, cut into fries', '2 cups cheese curds']", false, "https://www.allrecipes.com/recipe/79300/real-poutine/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Roasted Beet Salad", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F6423602.jpg", "'6 medium beets, trimmed and scrubbed', '2 tablespoons aged balsamic vinegar', '2 teaspoons real maple syrup', 'salt and ground black pepper to taste']", false, "https://www.allrecipes.com/recipe/270850/roasted-beet-salad/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Red Lentil Soup with Lemon-Mint Yogurt", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F7724141.jpg", "'2 tablespoons butter', '1 large yellow onion, diced', '1 teaspoon kosher salt, or more to taste', '3 tablespoons tomato paste, or more to taste', '4 cloves garlic, crushed', '2 teaspoons ground cumin', ' teaspoon cayenne pepper', '1 quart chicken broth', '1 cup red lentils', '1 rib celery, diced', '1 large carrot, diced', '6 leaves fresh mint, thinly sliced', '1 pinch salt', '� teaspoon lemon zest', '� lemon, juiced', '3 tablespoons plain Greek yogurt, or more to taste']", false, "https://www.allrecipes.com/recipe/278763/red-lentil-soup-with-lemon-mint-yogurt/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Red Skinned Potato Salad", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F96575.jpg", "'2 pounds clean, scrubbed new red potatoes', '6 eggs', '1 pound bacon', '1 onion, finely chopped', '1 stalk celery, finely chopped', '2 cups mayonnaise', 'salt and pepper to taste']", false, "https://www.allrecipes.com/recipe/25155/red-skinned-potato-salad/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Red Velvet Cupcakes", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F5789703.jpg", "'� cups flour', '� cup unsweetened cocoa powder', '1 teaspoon baking soda', '� teaspoon salt', '1 cup butter, softened', '2 cups sugar', '4 eggs', '1 cup sour cream', '� cup milk', '1 (1 ounce) bottle McCormick Red Food Color', '2 teaspoons McCormick Pure Vanilla Extract', '1 (8 ounce) package cream cheese, softened', '� cup butter, softened', '2 tablespoons sour cream', '2 teaspoons McCormick Pure Vanilla Extract', \"1 (16 ounce) box confectioners' sugar\"]", false, "https://www.allrecipes.com/recipe/212429/red-velvet-cupcakes/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Refreshing Lentil Salad", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F691198.jpg", "'4 cups water', 'salt', '� cups dry lentils', '2 large cloves garlic, minced', '2 large roma (plum) tomatoes, seeded and chopped', '� cup chopped red onion', '� cup chopped green bell pepper', '1 small green chile pepper, seeded and chopped', '1 lemon, juiced', '1 teaspoon lemon zest', '1 small carrot, shredded', '� cup oil-cured black olives', '� cup chopped fresh cilantro', 'salt and ground black pepper to taste', '� cup extra-virgin olive oil', '2 hard-cooked eggs, cut in half lengthwise']", false, "https://www.allrecipes.com/recipe/215280/refreshing-lentil-salad/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Refrigerator Cookies III", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F1055677.jpg", "'1 cup shortening', '1 cup white sugar', '2 eggs', '� teaspoons vanilla extract', '3 cups all-purpose flour', '1 teaspoon salt', '� teaspoon baking soda', ' cup colored sugar for decoration']", false, "https://www.allrecipes.com/recipe/10833/refrigerator-cookies-iii/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Restaurant Style Mac and Cheese", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F794691.jpg", "'� cups macaroni', '6 ounces processed cheese, shredded', '� cup shredded Cheddar cheese', '2 tablespoons heavy cream', 'salt to taste']", false, "https://www.allrecipes.com/recipe/23026/restaurant-style-mac-and-cheese/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Restaurant-Style Buffalo Chicken Wings", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F445293.jpg", "'� cup all-purpose flour', '� teaspoon paprika', '� teaspoon cayenne pepper', '� teaspoon salt', '10 chicken wings', 'oil for deep frying', '� cup butter', '� cup hot sauce', '1 dash ground black pepper', '1 dash garlic powder']", false, "https://www.allrecipes.com/recipe/24087/restaurant-style-buffalo-chicken-wings/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Reuben Sandwich II", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F1340290.jpg", "'2 tablespoons butter', '8 slices rye bread', '8 slices deli sliced corned beef', '8 slices Swiss cheese', '1 cup sauerkraut, drained', '� cup Thousand Island dressing']", false, "https://www.allrecipes.com/recipe/47717/reuben-sandwich-ii/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Rich and Simple French Onion Soup", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F1081318.jpg", "'� cup unsalted butter', '2 tablespoons olive oil', '4 cups sliced onions', '4 (10.5 ounce) cans beef broth', '2 tablespoons dry sherry', '1 teaspoon dried thyme', 'salt and pepper to taste', '4 slices French bread', '4 slices provolone cheese', '2 slices Swiss cheese, diced', '� cup grated Parmesan cheese']", false, "https://www.allrecipes.com/recipe/13309/rich-and-simple-french-onion-soup/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Rigatoni alla Genovese", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F3489951.jpg", "'1 tablespoon olive oil', '6 ounces pancetta or salt pork, diced', '� pounds beef chuck', '2 teaspoons kosher salt', '� cup diced celery', '� cup diced carrot', '1 teaspoon kosher salt', '1 teaspoon freshly ground black pepper', '1 tablespoon tomato paste', '1 bay leaf', ' cup white wine', '4 pounds yellow onions, sliced', '2 pounds red onions, sliced', 'salt to taste', '2 (16 ounce) boxes uncooked rigatoni', '1 tablespoon chopped fresh marjoram leaves', '1 pinch cayenne pepper', '2 tablespoons freshly grated Parmigiano-Reggiano cheese']", false, "https://www.allrecipes.com/recipe/246866/rigatoni-alla-genovese/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Red Lobster Cheddar Biscuits", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F4571413.jpg", "'2 cups all-purpose flour', '1 cup shredded Cheddar cheese', '1 tablespoon baking powder', '1 teaspoon salt', '� teaspoon garlic powder', ' cup milk', ' cup butter', '1 large egg', '2 tablespoons melted butter']", false, "https://www.allrecipes.com/recipe/260622/red-lobster-cheddar-biscuits/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Southern Macaroni and Cheese Pie", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F4010816.jpg", "'cooking spray', '2 cups uncooked elbow macaroni', '� cup butter', '2 (12 ounce) cans evaporated milk', '1 tablespoon ground black pepper', '3 eggs', '1 teaspoon salt', '4 cups shredded Cheddar cheese', '1 pinch paprika, or to taste']", false, "https://www.allrecipes.com/recipe/220376/southern-macaroni-and-cheese-pie/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Scott Ure's Clams And Garlic", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F93489.jpg", "'50 small clams in shell, scrubbed', '2 tablespoons extra virgin olive oil', '6 cloves garlic, minced', '1 cup white wine', '2 tablespoons butter', '� cup chopped fresh parsley']", false, "https://www.allrecipes.com/recipe/12737/scott-ures-clams-and-garlic/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Seared Ahi Tuna Steaks", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F762704.jpg", "'2 (5 ounce) ahi tuna steaks', '1 teaspoon kosher salt', '� teaspoon cayenne pepper', '� tablespoon butter', '2 tablespoons olive oil', '1 teaspoon whole peppercorns']", false, "https://www.allrecipes.com/recipe/160099/seared-ahi-tuna-steaks/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Simple White Cake", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F1437162.jpg", "'1 cup white sugar', '� cup butter', '2 eggs', '2 teaspoons vanilla extract', '� cups all-purpose flour', '� teaspoons baking powder', '� cup milk']", false, "https://www.allrecipes.com/recipe/17481/simple-white-cake/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Simple Whole Wheat Bread", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F1012491.jpg", "'3 cups warm water (110 degrees F/45 degrees C)', '2 (.25 ounce) packages active dry yeast', ' cup honey', '5 cups bread flour', '3 tablespoons butter, melted', ' cup honey', '1 tablespoon salt', '� cups whole wheat flour', '2 tablespoons butter, melted']", false, "https://www.allrecipes.com/recipe/6773/simple-whole-wheat-bread/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Skillet-Braised Brussels Sprouts", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F7923937.jpg", "'4 slices thick-cut bacon, sliced into 1/4-inch strips, or more to taste', '1 pound Brussels sprouts, trimmed and halved, or more to taste', '1 clove garlic, thinly sliced, or more to taste', '� cup chicken stock, or more as needed', '1 tablespoon butter, or to taste', '1 tablespoon balsamic vinegar, or more to taste', 'salt and ground black pepper to taste']", false, "https://www.allrecipes.com/recipe/235449/skillet-braised-brussels-sprouts/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Sloppy Joes II", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F747244.jpg", "'1 pound lean ground beef', '� cup chopped onion', '� cup chopped green bell pepper', '� teaspoon garlic powder', '1 teaspoon prepared yellow mustard', '� cup ketchup', '3 teaspoons brown sugar', 'salt to taste', 'ground black pepper to taste']", false, "https://www.allrecipes.com/recipe/24264/sloppy-joes-ii/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Slow Cooker 3-Bean Chili", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F1095436.jpg", "'1 (20 ounce) package 93%-lean ground turkey', '1 (28 ounce) can diced fire-roasted tomatoes', '1 (16 ounce) can tomato sauce', '1 (15.5 ounce) can pinto beans, rinsed and drained', '1 (15.5 ounce) can kidney beans, rinsed and drained', '1 (15 ounce) can reduced-sodium black beans, rinsed and drained', '1 small onion, chopped', '1 (4.5 ounce) can chopped green chiles', '2 tablespoons chili powder', '1 tablespoon minced garlic', '1 teaspoon oregano', '1 pinch ground cumin']", false, "https://www.allrecipes.com/recipe/236091/slow-cooker-3-bean-chili/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Slow Cooker Beef Stew I", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F276397.jpg", "'2 pounds beef stew meat, cut into 1-inch pieces', '� cup all-purpose flour', '� teaspoon salt', '� teaspoon ground black pepper', '1 clove garlic, minced', '1 bay leaf', '1 teaspoon paprika', '1 teaspoon Worcestershire sauce', '1 onion, chopped', '� cups beef broth', '3 potatoes, diced', '4 carrots, sliced', '1 stalk celery, chopped']", false, "https://www.allrecipes.com/recipe/14685/slow-cooker-beef-stew-i/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Slow Cooker Carnitas", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F5369243.jpg", "'1 teaspoon salt', '1 teaspoon garlic powder', '1 teaspoon ground cumin', '� teaspoon crumbled dried oregano', '� teaspoon ground coriander', '� teaspoon ground cinnamon', '1 (4 pound) boneless pork shoulder roast', '2 bay leaves', '2 cups chicken broth']", false, "https://www.allrecipes.com/recipe/139603/slow-cooker-carnitas/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Slow Cooker Chicken and Dumplings", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F806223.jpg", "'4 skinless, boneless chicken breast halves', '2 tablespoons butter', '2 (10.75 ounce) cans  condensed cream of chicken soup', '1 onion, finely diced', '2 (10 ounce) packages refrigerated biscuit dough, torn into pieces']", false, "https://www.allrecipes.com/recipe/8941/slow-cooker-chicken-and-dumplings/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Slow Cooker Creamy Chicken and Dumplings", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F1590982.jpg", "'4 skinless, boneless chicken breast halves', '2 (10.75 ounce) cans  condensed cream of mushroom soup', '1 onion, minced', '2 tablespoons butter', '2 tablespoons rosemary', 'ground black pepper to taste', '1 cup vegetable broth, or as needed', '2 (10 ounce) packages refrigerated biscuit dough, torn into pieces']", false, "https://www.allrecipes.com/recipe/239305/slow-cooker-creamy-chicken-and-dumplings/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Simple Turkey Chili", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F3531035.jpg", "'� teaspoons olive oil', '1 pound ground turkey', '1 onion, chopped', '2 cups water', '1 (28 ounce) can canned crushed tomatoes', '1 (16 ounce) can canned kidney beans - drained, rinsed, and mashed', '1 tablespoon garlic, minced', '2 tablespoons chili powder', '� teaspoon paprika', '� teaspoon dried oregano', '� teaspoon ground cayenne pepper', '� teaspoon ground cumin', '� teaspoon salt', '� teaspoon ground black pepper']", false, "https://www.allrecipes.com/recipe/80969/simple-turkey-chili/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Slow Cooker Italian Beef for Sandwiches", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F178087.jpg", "'3 cups water', '1 teaspoon salt', '1 teaspoon ground black pepper', '1 teaspoon dried oregano', '1 teaspoon dried basil', '1 teaspoon onion salt', '1 teaspoon dried parsley', '1 teaspoon garlic powder', '1 bay leaf', '1 (.7 ounce) package dry Italian-style salad dressing mix', '1 (5 pound) rump roast']", false, "https://www.allrecipes.com/recipe/16427/slow-cooker-italian-beef-for-sandwiches/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Slow Cooker Pineapple-Teriyaki Pork Chops", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F8026172.jpg", "'1 tablespoon olive oil, or more as needed', '4 (8 ounce) bone-in pork loin chops', '1 cup unsweetened pineapple juice', '� cup teriyaki sauce', '1 teaspoon dried crushed rosemary', '1 teaspoon garlic powder', '� teaspoon salt', '� teaspoon ground black pepper']", false, "https://www.allrecipes.com/recipe/279593/slow-cooker-pineapple-teriyaki-pork-chops/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Slow Cooker Taco Soup", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F5941186.jpg", "'1 pound ground beef', '1 onion, chopped', '1 (16 ounce) can chili beans, with liquid', '1 (15 ounce) can kidney beans with liquid', '1 (15 ounce) can whole kernel corn, with liquid', '1 (8 ounce) can tomato sauce', '2 cups water', '2 (14.5 ounce) cans peeled and diced tomatoes', '1 (4 ounce) can diced green chile peppers', '1 (1.25 ounce) package taco seasoning mix']", false, "https://www.allrecipes.com/recipe/16678/slow-cooker-taco-soup/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Slow Cooker Texas Pulled Pork", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F4560053.jpg", "'1 teaspoon vegetable oil', '1 (4 pound) pork shoulder roast ', '1 cup barbeque sauce', '� cup apple cider vinegar', '� cup chicken broth', '� cup light brown sugar', '1 tablespoon prepared yellow mustard', '1 tablespoon Worcestershire sauce', '1 tablespoon chili powder', '1 extra large onion, chopped', '2 large cloves garlic, crushed', '� teaspoons dried thyme', '8 hamburger buns, split', '2 tablespoons butter, or as needed']", false, "https://www.allrecipes.com/recipe/92462/slow-cooker-texas-pulled-pork/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Slow Cooker Turkey Breast", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F2596444.jpg", "'1 (6 pound) bone-in turkey breast', '1 (1 ounce) envelope dry onion soup mix']", false, "https://www.allrecipes.com/recipe/92528/slow-cooker-turkey-breast/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Smoked Gouda Mac and Cheese", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F1120705.jpg", "'1 (16 ounce) package seashell pasta', '� tablespoons butter', '2 tablespoons all-purpose flour', '� cups milk', '� teaspoon salt', '� teaspoon ground white pepper', '4 ounces smoked Gouda cheese, shredded']", false, "https://www.allrecipes.com/recipe/27074/smoked-gouda-mac-and-cheese/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Soft Oatmeal Cookies", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F3779973.jpg", "'1 cup butter, softened', '1 cup white sugar', '1 cup packed brown sugar', '2 eggs', '1 teaspoon vanilla extract', '2 cups all-purpose flour', '1 teaspoon baking soda', '1 teaspoon salt', '� teaspoons ground cinnamon', '3 cups quick cooking oats']", false, "https://www.allrecipes.com/recipe/19247/soft-oatmeal-cookies/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Sopapilla Cheesecake Pie", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F453301.jpg", "'2 (8 ounce) packages cream cheese, softened', '� cups white sugar, divided', '1 teaspoon Mexican vanilla extract', '2 (8 ounce) cans refrigerated crescent rolls', '1 teaspoon ground cinnamon', '� cup butter, room temperature', '� cup honey']", false, "https://www.allrecipes.com/recipe/169305/sopapilla-cheesecake-pie/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Southern Fried Apples", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F1049390.jpg", "'� cup butter', '� cup white sugar', '2 tablespoons ground cinnamon', '4 Granny Smith apples - peeled, cored, and sliced']", false, "https://www.allrecipes.com/recipe/230907/southern-fried-apples/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Southern Fried Cabbage with Bacon, Mushrooms, and Onions", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F1003056.jpg", "'1 pound bacon', '1 large head cabbage, chopped', '1 large onion, chopped', '1 (8 ounce) package sliced fresh mushrooms', 'salt and ground black pepper to taste']", false, "https://www.allrecipes.com/recipe/223549/southern-fried-cabbage-with-bacon-mushrooms-and-onions/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Slow Cooker Mac and Cheese", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F7710190.jpg", "'1 (16 ounce) package elbow macaroni', '� cup butter', 'salt and ground black pepper to taste', '1 (16 ounce) package shredded Cheddar cheese, divided', '1 (5 ounce) can evaporated milk', '2 eggs, well beaten', '2 cups whole milk', \"1 (10.75 ounce) can  condensed Cheddar cheese soup (such as Campbell's)\", '1 pinch paprika, or as desired']", false, "https://www.allrecipes.com/recipe/237311/slow-cooker-mac-and-cheese/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Seafood Pasta Salad", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F8002081.jpg", "'� (8 ounce) packages tri-color pasta', '3 stalks celery', '1 pound imitation crabmeat', '1 cup frozen green peas', '1 cup mayonnaise', '� tablespoons white sugar', '2 tablespoons white vinegar', '3 tablespoons milk', '1 teaspoon salt', '� teaspoon ground black pepper']", false, "https://www.allrecipes.com/recipe/24814/seafood-pasta-salad/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Simple Tuna Melts", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F15649.jpg", "'1 (5 ounce) can tuna, drained', '� small onion, minced', 'pepper to taste', '12 slices pickled jalapeno', '2 English muffins, split', '4 slices Cheddar cheese']", false, "https://www.allrecipes.com/recipe/52822/simple-tuna-melts/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Simple Syrup", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F662780.jpg", "'1 cup white sugar', '1 cup water']", false, "https://www.allrecipes.com/recipe/20216/simple-syrup/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Seared Scallops with Jalapeno Vinaigrette", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F4524598.jpg", "'1 large jalapeno pepper, seeded and membranes removed', '� cup rice vinegar', '� cup olive oil', '� teaspoon Dijon mustard', 'salt and freshly ground black pepper to taste', '1 tablespoon vegetable oil', '12 large fresh sea scallops', '1 pinch sea salt', '1 pinch cayenne pepper', '2 oranges, peeled and cut in between sections as segments']", false, "https://www.allrecipes.com/recipe/222400/seared-scallops-with-jalapeno-vinaigrette/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Sesame Noodle Salad", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F699335.jpg", "'1 (16 ounce) package angel hair pasta', '� cup sesame oil', '� cup soy sauce', '� cup balsamic vinegar', '1 tablespoon hot chili oil', '� cup white sugar', '1 teaspoon sesame seeds, or more if desired', '1 green onion, chopped', '1 red bell pepper, diced']", false, "https://www.allrecipes.com/recipe/214921/sesame-noodle-salad/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Sesame Seared Tuna", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F3496846.jpg", "'� cup soy sauce', '1 tablespoon mirin (Japanese sweet wine)', '1 tablespoon honey', '2 tablespoons sesame oil', '1 tablespoon rice wine vinegar', '4 (6 ounce) tuna steaks', '� cup sesame seeds', 'wasabi paste', '1 tablespoon olive oil']", false, "https://www.allrecipes.com/recipe/71698/sesame-seared-tuna/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Seven Layer Salad", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F2226974.jpg", "'1 pound bacon', '1 large head iceberg lettuce - rinsed, dried, and chopped', '1 red onion, chopped', '1 (10 ounce) package frozen green peas, thawed', '10 ounces shredded Cheddar cheese', '1 cup chopped cauliflower', '� cups mayonnaise', '2 tablespoons white sugar', ' cup grated Parmesan cheese']", false, "https://www.allrecipes.com/recipe/14295/seven-layer-salad/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Shannon's Smoky Macaroni and Cheese", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F2151920.jpg", "'1 (16 ounce) package elbow macaroni', '6 tablespoons butter', '� cup all-purpose flour', '5\\u2009� cups milk, divided', '� cups shredded smoked Gouda cheese', '� cups shredded Cheddar cheese', '� cups shredded Swiss cheese', '1 cup grated Parmesan cheese', '� cup grated Parmesan cheese', '� cup dry bread crumbs', '1 teaspoon ground cayenne pepper', 'olive oil']", false, "https://www.allrecipes.com/recipe/161869/shannons-smoky-macaroni-and-cheese/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Sheet Pan Roasted Mediterranean Vegetables", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F6512193.jpg", "'12 cherry tomatoes, halved', '1 red bell pepper, chopped', '1 yellow bell pepper, chopped', '1 green bell pepper, chopped', '2 zucchini, sliced', '2 red onions, quartered', '2 cloves garlic, crushed and peeled', '2 tablespoons olive oil', '1 teaspoon chopped fresh basil', 'ground black pepper to taste']", false, "https://www.allrecipes.com/recipe/269330/sheet-pan-roasted-mediterranean-vegetables/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Sheet Pan Sweet and Sour Chicken", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F8046982.jpg", "'2 (8 ounce) cans pineapple tidbits in juice', '1 red bell pepper, seeded and cut into 1-inch pieces', '1 green bell pepper, seeded and cut into 1-inch pieces', '1 carrot, peeled and sliced diagonally', '� red onion, cut into 1-inch pieces', '3 tablespoons avocado oil', 'salt and ground black pepper to taste', '� pounds skinless, boneless chicken breast, cut into 1-inch pieces', 'water as needed', '2 tablespoons cornstarch', '� cup light brown sugar', ' cup rice vinegar', '3 tablespoons ketchup', '3 tablespoons soy sauce', '1 tablespoon chile-garlic sauce', '1 tablespoon ginger-garlic paste', ' teaspoon ground white pepper']", false, "https://www.allrecipes.com/recipe/279987/sheet-pan-sweet-and-sour-chicken/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Shipwreck Dinner", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F7643211.jpg", "'1 pound lean ground beef', '1 (7.25 ounce) package macaroni and cheese mix ', '1 (14.5 ounce) can diced tomatoes', '1 cup milk', '1 cup frozen peas', '1 cup frozen corn', \"1 teaspoon seasoned salt (such as LAWRY'S), or to taste\", '1 cup shredded Cheddar cheese, divided']", false, "https://www.allrecipes.com/recipe/240605/shipwreck-dinner/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Shrimp and Pasta Shell Salad", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F1052615.jpg", "'� cups mayonnaise, or more if needed', '2 teaspoons Dijon mustard', '2 teaspoons ketchup', '� teaspoon Worcestershire sauce', '1 teaspoon salt, or to taste', '1 pinch cayenne pepper, or to taste', '1 lemon, juiced', ' cup chopped fresh dill', '1 (12 ounce) package small pasta shells', '1 pound cooked, peeled, and deveined small shrimp - cut in half', '� cup finely diced red bell pepper', '� cup diced celery', 'salt and ground black pepper to taste', '1 pinch paprika, for garnish', '3 sprigs fresh dill, or as desired']", false, "https://www.allrecipes.com/recipe/233397/shrimp-and-pasta-shell-salad/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Simple Teriyaki Sauce", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F4553894.jpg", "'1 cup water', '� cup soy sauce', '5 teaspoons packed brown sugar', '1 tablespoon honey, or more to taste', '� teaspoon ground ginger', '� teaspoon garlic powder', '2 tablespoons cornstarch', '� cup cold water']", false, "https://www.allrecipes.com/recipe/259887/simple-teriyaki-sauce/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Shrimp Fra Diavolo", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F224094.jpg", "'1 (16 ounce) package linguini pasta', '1 pound cooked and peeled shrimp', '8 cloves crushed garlic', '2 (14.5 ounce) cans diced tomatoes', '1 (28 ounce) can crushed tomatoes with garlic', '2 teaspoons crushed red pepper flakes', '2 fluid ounces red wine']", false, "https://www.allrecipes.com/recipe/11731/shrimp-fra-diavolo/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Simple Beef Stroganoff", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F2283712.jpg", "'1 (8 ounce) package egg noodles', '1 pound ground beef', '1 (10.75 ounce) can  fat free condensed cream of mushroom soup', '1 tablespoon garlic powder', '� cup sour cream', 'salt and pepper to taste']", false, "https://www.allrecipes.com/recipe/16311/simple-beef-stroganoff/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Simple Cake Pops", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F5343925.jpg", "'1 (15.25 ounce) package yellow cake mix (such as Betty Crocker)', '1 cup water', '3 eggs', '� cup vegetable oil', '1 (16 ounce) package prepared chocolate frosting', '18 lollipop sticks', '1 (14 ounce) bag chocolate candy melts', '1 (.75 ounce) tube decorating icing']", false, "https://www.allrecipes.com/recipe/244964/simple-cake-pops/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Simple Chicken Brine", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F316214.jpg", "'1 gallon warm water', '� cup kosher salt', ' cup sugar', '� cup soy sauce', '� cup olive oil']", false, "https://www.allrecipes.com/recipe/170656/simple-chicken-brine/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Simple Deep Fried Turkey", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F925836.jpg", "'� gallons peanut oil for frying', '1 (10 pound) whole turkey, neck and giblets removed', '1 tablespoon salt, or to taste', '1 tablespoon ground black pepper, or to taste']", false, "https://www.allrecipes.com/recipe/215412/simple-deep-fried-turkey/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Simple Garlic Shrimp", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F1330843.jpg", "'� tablespoons olive oil', '1 pound shrimp, peeled and deveined', 'salt to taste', '6 cloves garlic, finely minced', '� teaspoon red pepper flakes', '3 tablespoons lemon juice', '1 tablespoon caper brine', '� teaspoons cold butter', ' cup chopped Italian flat leaf parsley, divided', '� tablespoons cold butter', 'water, as needed']", false, "https://www.allrecipes.com/recipe/220597/simple-garlic-shrimp/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Simple Macaroni and Cheese", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F5445825.jpg", "'1 (8 ounce) box elbow macaroni', '� cup butter', '� cup all-purpose flour', '� teaspoon salt', 'ground black pepper to taste', '2 cups milk', '2 cups shredded Cheddar cheese']", false, "https://www.allrecipes.com/recipe/238691/simple-macaroni-and-cheese/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Simple Pasta Salad", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F408109.jpg", "'1 (16 ounce) package uncooked rotini pasta', '1 (16 ounce) bottle Italian salad dressing', '2 cucumbers, chopped', '6 tomatoes, chopped', '1 bunch green onions, chopped', '4 ounces grated Parmesan cheese', '1 tablespoon Italian seasoning']", false, "https://www.allrecipes.com/recipe/86353/simple-pasta-salad/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Simple Pumpkin Pie", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F965227.jpg", "'2 eggs', '1 (16 ounce) can pumpkin puree', '1 (14 ounce) can sweetened condensed milk', '1 teaspoon pumpkin pie spice', '1 (9 inch) unbaked pie crust']", false, "https://www.allrecipes.com/recipe/229932/simple-pumpkin-pie/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Simple Roasted Butternut Squash", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F957758.jpg", "'1 butternut squash - peeled, seeded, and cut into 1-inch cubes', '2 tablespoons olive oil', '2 cloves garlic, minced', 'salt and ground black pepper to taste']", false, "https://www.allrecipes.com/recipe/229733/simple-roasted-butternut-squash/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Shrimp Scampi with Pasta", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F2606852.jpg", "'1 (16 ounce) package linguine pasta', '2 tablespoons butter', '2 tablespoons extra-virgin olive oil', '2 shallots, finely diced', '2 cloves garlic, minced', '1 pinch red pepper flakes', '1 pound shrimp, peeled and deveined', '1 pinch kosher salt and freshly ground pepper', '� cup dry white wine', '1 lemon, juiced', '2 tablespoons butter', '2 tablespoons extra-virgin olive oil', '� cup finely chopped fresh parsley leaves', '1 teaspoon extra-virgin olive oil, or to taste']", false, "https://www.allrecipes.com/recipe/229960/shrimp-scampi-with-pasta/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Homemade Catalina Dressing", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F2204992.jpg", "'� cup white sugar', '� cup red wine vinegar', '� cup canola oil', '� cup ketchup', '1 teaspoon paprika', '� teaspoon onion powder', '� teaspoon dried celery flakes', '� teaspoon salt-free Italian seasoning blend (such as Mrs. Dash Italian Medley)']", false, "https://www.allrecipes.com/recipe/241848/homemade-catalina-dressing/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Homemade Banana Pudding Pie", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F3138228.jpg", "'2 cups vanilla wafer crumbs', '3 bananas, sliced into 1/4 inch slices', '� cups white sugar', '� cup all-purpose flour', '2 cups milk', '3 egg yolks', '2 teaspoons butter', '2 teaspoons vanilla extract', '3 egg whites', '� cup white sugar']", false, "https://www.allrecipes.com/recipe/16875/homemade-banana-pudding-pie/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Home-Style Macaroni and Cheese", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F2144907.jpg", "'7 ounces elbow macaroni', '� cup butter', '3 tablespoons all-purpose flour', '2 cups milk', '1 (8 ounce) package cream cheese', '4 slices canned jalapeno peppers, chopped', '2 teaspoons Dijon mustard', '� teaspoon ground black pepper', 'salt to taste', '3 dashes hot sauce, or to taste', '2 cups shredded Cheddar cheese', '1 cup dry bread crumbs', '2 tablespoons butter', '2 tablespoons chopped fresh parsley']", false, "https://www.allrecipes.com/recipe/241462/home-style-macaroni-and-cheese/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Blueberry Pie", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F202488.jpg", "'� cup white sugar', '3 tablespoons cornstarch', '� teaspoon salt', '� teaspoon ground cinnamon', '4 cups fresh blueberries', '1 recipe pastry for a 9 inch double crust pie', '1 tablespoon butter']", false, "https://www.allrecipes.com/recipe/12196/blueberry-pie/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Blueberry Sauce", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F4543526.jpg", "'2 cups fresh or frozen blueberries', '� cup water', '1 cup orange juice', '� cup white sugar', '� cup cold water', '3 tablespoons cornstarch', '� teaspoon almond extract', ' teaspoon ground cinnamon']", false, "https://www.allrecipes.com/recipe/70112/blueberry-sauce/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Bourbon Whiskey BBQ Sauce", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F2327755.jpg", "'� onion, minced', '4 cloves garlic, minced', '� cup bourbon whiskey', '� teaspoon ground black pepper', '� tablespoon salt', '2 cups ketchup', '� cup tomato paste', ' cup cider vinegar', '2 tablespoons liquid smoke flavoring', '� cup Worcestershire sauce', '� cup packed brown sugar', ' teaspoon hot pepper sauce, or to taste']", false, "https://www.allrecipes.com/recipe/16115/bourbon-whiskey-bbq-sauce/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Bread Pudding II", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F5941077.jpg", "'6 slices day-old bread', '2 tablespoons butter, melted', '� cup raisins', '4 eggs, beaten', '2 cups milk', '� cup white sugar', '1 teaspoon ground cinnamon', '1 teaspoon vanilla extract']", false, "https://www.allrecipes.com/recipe/7177/bread-pudding-ii/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Breakfast Cups", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F3210666.jpg", "'cooking spray', '18 refrigerated biscuits (unbaked)', '8 ounces breakfast sausage', '7 large eggs', '� cup milk', 'salt and ground black pepper to taste', '1 cup mild shredded Cheddar cheese']", false, "https://www.allrecipes.com/recipe/233747/breakfast-cups/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Broccoli Cheese Soup", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F306621.jpg", "'� cup butter', '1 onion, chopped', '1 (16 ounce) package frozen chopped broccoli', '4 (14.5 ounce) cans chicken broth', '1 (1 pound) loaf processed cheese food, cubed', '2 cups milk', '1 tablespoon garlic powder', ' cup cornstarch', '1 cup water']", false, "https://www.allrecipes.com/recipe/13045/broccoli-cheese-soup/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Broccoli Chicken Divan", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F2204020.jpg", "'1 pound chopped fresh broccoli', '� cups cubed, cooked chicken meat', '1 (10.75 ounce) can  condensed cream of broccoli soup', ' cup milk', '� cup shredded Cheddar cheese', '1 tablespoon butter, melted', '2 tablespoons dried bread crumbs']", false, "https://www.allrecipes.com/recipe/8854/broccoli-chicken-divan/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Broccoli, Rice, Cheese, and Chicken Casserole", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F3878110.jpg", "'2 cups water', '2 cups uncooked instant rice', '2 (10 ounce) cans chunk chicken, drained', '1 (10.75 ounce) can  condensed cream of mushroom soup', '1 (10.75 ounce) can  condensed cream of chicken soup', '� cup butter', '1 cup milk', '1 (16 ounce) package frozen chopped broccoli', '1 small white onion, chopped', '1 pound processed cheese food']", false, "https://www.allrecipes.com/recipe/25490/broccoli-rice-cheese-and-chicken-casserole/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Broiled Paprika and Lemon-Pepper Chicken Breasts", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F8089393.jpg", "'� tablespoons extra-virgin olive oil, divided', '2 skinless, boneless chicken breast halves', '2 tablespoons paprika', '1 tablespoon lemon-pepper seasoning', '1 tablespoon kosher salt', '2 cloves garlic, smashed and finely chopped', '� medium onion, chopped']", false, "https://www.allrecipes.com/recipe/279909/broiled-paprika-and-lemon-pepper-chicken-breasts/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Black Bean and Couscous Salad", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F3359485.jpg", "'1 cup uncooked couscous', '� cups chicken broth', '3 tablespoons extra virgin olive oil', '2 tablespoons fresh lime juice', '1 teaspoon red wine vinegar', '� teaspoon ground cumin', '8 green onions, chopped', '1 red bell pepper, seeded and chopped', '� cup chopped fresh cilantro', '1 cup frozen corn kernels, thawed', '2 (15 ounce) cans black beans, drained', 'salt and pepper to taste']", false, "https://www.allrecipes.com/recipe/24833/black-bean-and-couscous-salad/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Brown Butter Pineapple Corn Muffins", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F862424.jpg", "'� cup unsalted butter', '� cup chopped dried sweetened pineapple', '1 cup all-purpose flour', '1 cup yellow cornmeal', '� teaspoon baking soda', '� teaspoon salt', '1 cup buttermilk', '2 large eggs']", false, "https://www.allrecipes.com/recipe/222337/brown-butter-pineapple-corn-muffins/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Bucatini All'Amatriciana", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F3926130.jpg", "'5 ounces bucatini pasta', '� cup extra-virgin olive oil', '3 crushed garlic cloves', '� ounces guanciale (cured pork cheek), sliced', '� cup sliced red onion', '1 pinch red pepper flakes', '� (8 ounce) can crushed San Marzano tomatoes', 'salt and ground black pepper to taste', '1 ounce freshly grated Pecorino Romano cheese']", false, "https://www.allrecipes.com/recipe/245774/bucatini-allamatriciana/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Buffalo Chicken Dip", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F3095600.jpg", "'2 (10 ounce) cans chunk chicken, drained', '2 (8 ounce) packages cream cheese, softened', '1 cup Ranch dressing', \"� cup pepper sauce (such as Frank's Red Hot)\", '� cups shredded Cheddar cheese', '1 bunch celery, cleaned and cut into 4 inch pieces', '1 (8 ounce) box chicken-flavored crackers']", false, "https://www.allrecipes.com/recipe/68461/buffalo-chicken-dip/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Buffalo Chicken Mac and Cheese", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F4540851.jpg", "'1 (16 ounce) package elbow macaroni', '1 rotisserie-roasted chicken', '6 tablespoons butter', '6 tablespoons all-purpose flour', '3 cups milk', '1 pinch ground black pepper', '2 cups shredded Cheddar cheese', '2 cups shredded Monterey Jack cheese', \"� cup hot sauce (such as Frank's Redhot), or more to taste\", '� cup crumbled gorgonzola cheese']", false, "https://www.allrecipes.com/recipe/245764/buffalo-chicken-mac-and-cheese/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Buffalo Chicken Stuffed Shells", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F3326978.jpg", "'1 pound ground chicken', '� cup butter', \"1 cup cayenne pepper sauce (such as Frank's RedHot)\", '1 (16 ounce) container whipped ricotta cheese', 'cooking spray', '1 (16 ounce) package jumbo pasta shells', '1 (8 ounce) package shredded Cheddar-Monterey Jack cheese blend', 'salt and ground black pepper to taste']", false, "https://www.allrecipes.com/recipe/234592/buffalo-chicken-stuffed-shells/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Buffalo Chicken Wing Sauce", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F5931512.jpg", "\" cup hot pepper sauce (such as Frank's RedHot)\", '� cup cold unsalted butter', '� tablespoons white vinegar', '� teaspoon Worcestershire sauce', '� teaspoon cayenne pepper', ' teaspoon garlic powder', 'salt to taste']", false, "https://www.allrecipes.com/recipe/219109/buffalo-chicken-wing-sauce/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Burger or Hot Dog Buns", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F1106883.jpg", "'1 cup milk', '� cup water', '� cup butter', '4\\u2009� cups all-purpose flour', '1 (.25 ounce) package instant yeast', '2 tablespoons white sugar', '� teaspoons salt', '1 egg']", false, "https://www.allrecipes.com/recipe/6833/burger-or-hot-dog-buns/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Butter Flaky Pie Crust", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F296508.jpg", "'� cups all-purpose flour', '� teaspoon salt', '� cup butter, chilled and diced', '� cup ice water']", false, "https://www.allrecipes.com/recipe/24094/butter-flaky-pie-crust/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Buttered Noodles", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F2518260.jpg", "'1 (16 ounce) package fettuccine noodles', '6 tablespoons butter', ' cup grated Parmesan cheese', 'salt and ground black pepper to taste']", false, "https://www.allrecipes.com/recipe/244458/buttered-noodles/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Buttermilk Pie", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F4534599.jpg", "'3 eggs', '� cup butter, softened', '� cups white sugar', '3 tablespoons all-purpose flour', '1 cup buttermilk', '1 teaspoon vanilla extract', '1 tablespoon lemon juice', ' teaspoon freshly grated nutmeg', '1 (9 inch) unbaked pie crust']", false, "https://www.allrecipes.com/recipe/13802/buttermilk-pie/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Brussels Sprouts with Bacon and Balsamic", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F4068605.jpg", "'2 pounds Brussels sprouts, trimmed and halved lengthwise', '6 slices bacon, or more to taste, thinly sliced', '1 pinch salt and ground black pepper to taste', ' cup reduced balsamic vinegar, divided']", false, "https://www.allrecipes.com/recipe/255721/brussels-sprouts-with-bacon-and-balsamic/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Butternut Squash and Turkey Chili", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F1590851.jpg", "'2 tablespoons olive oil', '1 onion, chopped', '2 cloves garlic, minced', '1 pound ground turkey breast', '1 pound butternut squash - peeled, seeded and cut into 1-inch dice', '� cup chicken broth', '1 (4.5 ounce) can chopped green chilies', '2 (14.5 ounce) cans petite diced tomatoes ', '1 (15 ounce) can kidney beans with liquid', '1 (15.5 ounce) can white hominy, drained', '1 (8 ounce) can tomato sauce', '1 tablespoon chili powder', '1 tablespoon ground cumin', '1 teaspoon garlic salt']", false, "https://www.allrecipes.com/recipe/131107/butternut-squash-and-turkey-chili/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Black Bean and Corn Salad II", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F226330.jpg", "' cup fresh lime juice', '� cup olive oil', '1 clove garlic, minced', '1 teaspoon salt', ' teaspoon ground cayenne pepper', '2 (15 ounce) cans black beans, rinsed and drained', '� cups frozen corn kernels', '1 avocado - peeled, pitted and diced', '1 red bell pepper, chopped', '2 tomatoes, chopped', '6 green onions, thinly sliced', '� cup chopped fresh cilantro']", false, "https://www.allrecipes.com/recipe/13933/black-bean-and-corn-salad-ii/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Bill's Blue Cheese Dressing", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F881723.jpg", "'� cup sour cream', ' cups mayonnaise', '1 teaspoon Worcestershire sauce', '� teaspoon dry mustard', '� teaspoon garlic powder', '� teaspoon salt', '� teaspoon ground black pepper', '4 ounces blue cheese, crumbled']", false, "https://www.allrecipes.com/recipe/16459/bills-blue-cheese-dressing/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Beer Brats", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F5941169.jpg", "'4 (12 ounce) cans beer', '1 large onion, diced', '10 bratwurst', '2 teaspoons red pepper flakes', '1 teaspoon garlic powder', '1 teaspoon salt', '� teaspoon ground black pepper']", false, "https://www.allrecipes.com/recipe/149975/beer-brats/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Beet Salad with Goat Cheese", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F864231.jpg", "'4 medium beets - scrubbed, trimmed and cut in half', ' cup chopped walnuts', '3 tablespoons maple syrup', '1 (10 ounce) package mixed baby salad greens', '� cup frozen orange juice concentrate', '� cup balsamic vinegar', '� cup extra-virgin olive oil', '2 ounces goat cheese']", false, "https://www.allrecipes.com/recipe/90500/beet-salad-with-goat-cheese/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Best Big, Fat, Chewy Chocolate Chip Cookie", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F1107530.jpg", "'2 cups all-purpose flour', '� teaspoon baking soda', '� teaspoon salt', '� cup unsalted butter, melted', '1 cup packed brown sugar', '� cup white sugar', '1 tablespoon vanilla extract', '1 egg', '1 egg yolk', '2 cups semisweet chocolate chips']", false, "https://www.allrecipes.com/recipe/25037/best-big-fat-chewy-chocolate-chip-cookie/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Best Bread Machine Bread", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F5506039.jpg", "'1 cup warm water (110 degrees F/45 degrees C)', '2 tablespoons white sugar', '1 (.25 ounce) package bread machine yeast', '� cup vegetable oil', '3 cups bread flour', '1 teaspoon salt']", false, "https://www.allrecipes.com/recipe/17215/best-bread-machine-bread/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Best Brownies", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fcf-images.us-east-1.prod.boltdns.net%2Fv1%2Fstatic%2F1033249144001%2F1f376888-d624-403a-abdf-35491dab7075%2Ffa38d776-07ea-4f87-936d-6a251fe2006a%2F1280x720%2Fmatch%2Fimage.jpg", "'� cup butter', '1 cup white sugar', '2 eggs', '1 teaspoon vanilla extract', ' cup unsweetened cocoa powder', '� cup all-purpose flour', '� teaspoon salt', '� teaspoon baking powder', '3 tablespoons butter, softened', '3 tablespoons unsweetened cocoa powder', '1 tablespoon honey', '1 teaspoon vanilla extract', \"1 cup confectioners' sugar\"]", false, "https://www.allrecipes.com/recipe/10549/best-brownies/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Best Carrot Cake Ever", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F3605684.jpg", "'6 cups grated carrots', '1 cup brown sugar', '1 cup raisins', '4 eggs', '� cups white sugar', '1 cup vegetable oil', '2 teaspoons vanilla extract', '1 cup crushed pineapple, drained', '3 cups all-purpose flour', '� teaspoons baking soda', '1 teaspoon salt', '4 teaspoons ground cinnamon', '1 cup chopped walnuts']", false, "https://www.allrecipes.com/recipe/17393/best-carrot-cake-ever/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Best Chocolate Chip Cookies", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fcf-images.us-east-1.prod.boltdns.net%2Fv1%2Fstatic%2F1033249144001%2F903056c9-3215-407c-920a-d8eb13c1500e%2Fd73859ee-a517-4956-b9a6-970a9cde1e4f%2F1280x720%2Fmatch%2Fimage.jpg", "'1 cup butter, softened', '1 cup white sugar', '1 cup packed brown sugar', '2 eggs', '2 teaspoons vanilla extract', '1 teaspoon baking soda', '2 teaspoons hot water', '� teaspoon salt', '3 cups all-purpose flour', '2 cups semisweet chocolate chips', '1 cup chopped walnuts']", false, "https://www.allrecipes.com/recipe/10813/best-chocolate-chip-cookies/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Best Cream Of Broccoli Soup", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F4223268.jpg", "'5 tablespoons butter, divided', '1 onion, chopped', '1 stalk celery, chopped', '3 cups chicken broth', '8 cups broccoli florets', '3 tablespoons all-purpose flour', '2 cups milk', 'ground black pepper to taste']", false, "https://www.allrecipes.com/recipe/13313/best-cream-of-broccoli-soup/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Best Damn Chili", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F1060867.jpg", "'4 tablespoons olive oil', '1 yellow onion, chopped', '1 red bell pepper, chopped', '1 Anaheim chile pepper, chopped', '2 red jalapeno pepper, chopped', '4 garlic cloves, minced', '� pounds lean ground beef', '� cup Worcestershire sauce', '1 pinch garlic powder, or to taste', '2 beef bouillon cubes', '1 (12 fluid ounce) can or bottle light beer (such as Coors)', '1 (28 ounce) can crushed San Marzano tomatoes', '1 (14.5 ounce) can fire-roasted diced tomatoes', '1 (12 ounce) can tomato paste', '� cup white wine', '2 tablespoons chili powder', '2 tablespoons ground cumin', '1 tablespoon brown sugar', '1 tablespoon chipotle pepper sauce', '� teaspoons dried basil', '� teaspoons smoked paprika', '1 teaspoon salt', '� teaspoon dried oregano', '� teaspoon ground black pepper', \"2 (16 ounce) cans dark red kidney beans (such as Bush's)\", '1 cup sour cream', '3 tablespoons chopped fresh cilantro', '� teaspoon ground cumin']", false, "https://www.allrecipes.com/recipe/233613/best-damn-chili/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Bill's Sausage Gravy", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F1075781.jpg", "'1 (12 ounce) package maple flavored sausage', '3 tablespoons butter', '� cup all-purpose flour', '3 cups whole milk', 'salt and pepper to taste']", false, "https://www.allrecipes.com/recipe/51304/bills-sausage-gravy/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Best Ever Crab Cakes", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F5103019.jpg", "'1 egg', '3 tablespoons mayonnaise', '4 teaspoons lemon juice', ' teaspoon red pepper flakes', '1 teaspoon dried tarragon', '1 tablespoon minced green onions', '8 ounces crabmeat', '� cup crushed buttery round crackers', '1 tablespoon butter']", false, "https://www.allrecipes.com/recipe/82347/best-ever-crab-cakes/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Best Fried Green Tomatoes", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F888769.jpg", "'4 large green tomatoes', '2 eggs', '� cup milk', '1 cup all-purpose flour', '� cup cornmeal', '� cup bread crumbs', '2 teaspoons coarse kosher salt', '� teaspoon ground black pepper', '1 quart vegetable oil for frying']", false, "https://www.allrecipes.com/recipe/16760/best-fried-green-tomatoes/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Best Green Bean Casserole", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F1656932.jpg", "'2 (14.5 ounce) cans green beans, drained', '1 (10.75 ounce) can  condensed cream of mushroom soup', '1 (6 ounce) can French fried onions', '1 cup shredded Cheddar cheese']", false, "https://www.allrecipes.com/recipe/18379/best-green-bean-casserole/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Best Hot Crab Dip", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F1097189.jpg", "'2 cups crabmeat', '1 cup sour cream', '1 (8 ounce) package cream cheese, softened', '1 cup buttermilk', '1 cup mayonnaise', '1 cup shredded Monterey Jack cheese', '1 cup white Cheddar cheese', '� cup capers, drained', '2 (8 ounce) cans artichoke hearts, drained and chopped', '2 tablespoons minced garlic', '� teaspoon ground black pepper, or to taste', '� teaspoon dried dill, or to taste', '� cup grated Parmesan cheese', '� teaspoon Old Bay Seasoning TM, or to taste', '1 (8 ounce) round loaf sourdough bread']", false, "https://www.allrecipes.com/recipe/20368/best-hot-crab-dip/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Best Spinach Dip Ever", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F748478.jpg", "'1 cup mayonnaise', '1 (16 ounce) container sour cream', '1 (1.8 ounce) package dry leek soup mix', '1 (4 ounce) can water chestnuts, drained and chopped', '� (10 ounce) package frozen chopped spinach, thawed and drained', '1 (1 pound) loaf round sourdough bread']", false, "https://www.allrecipes.com/recipe/22617/best-spinach-dip-ever/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Best Steak Marinade in Existence", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F4537368.jpg", "' cup soy sauce', '� cup olive oil', ' cup fresh lemon juice', '� cup Worcestershire sauce', '� tablespoons garlic powder', '3 tablespoons dried basil', '� tablespoons dried parsley flakes', '1 teaspoon ground white pepper', '� teaspoon hot pepper sauce', '1 teaspoon dried minced garlic']", false, "https://www.allrecipes.com/recipe/143809/best-steak-marinade-in-existence/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Best Tuna Casserole", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F2615015.jpg", "'1 (12 ounce) package egg noodles', '� cup chopped onion', '2 cups shredded Cheddar cheese', '1 cup frozen green peas', '2 (5 ounce) cans tuna, drained', '2 (10.75 ounce) cans  condensed cream of mushroom soup', '� (4.5 ounce) can sliced mushrooms', '1 cup crushed potato chips']", false, "https://www.allrecipes.com/recipe/17219/best-tuna-casserole/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Best Turkey Meatloaf", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F5791617.jpg", "'� pounds ground turkey', '� cup crushed buttery round crackers', '� cup milk', '1 small onion, chopped', '1 egg', '� teaspoons salt', '2 cloves garlic, minced', '� teaspoon ground black pepper', '� cup ketchup', '� cup brown sugar', '1 tablespoon Worcestershire sauce']", false, "https://www.allrecipes.com/recipe/231380/best-turkey-meatloaf/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Better Than Sex Cake II", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F229313.jpg", "\"1 (18.25 ounce) package devil's food cake mix\", '� (14 ounce) can sweetened condensed milk', '6 ounces caramel ice cream topping', '3 (1.4 ounce) bars chocolate covered toffee, chopped', '1 (8 ounce) container frozen whipped topping, thawed']", false, "https://www.allrecipes.com/recipe/7515/better-than-sex-cake-ii/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Big Al's K.C. Bar-B-Q Sauce", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F780532.jpg", "'2 cups ketchup', '2 cups tomato sauce', '� cups brown sugar', '� cups red wine vinegar', '� cup unsulfured molasses', '4 teaspoons hickory-flavored liquid smoke', '2 tablespoons butter', '� teaspoon garlic powder', '� teaspoon onion powder', '� teaspoon chili powder', '1 teaspoon paprika', '� teaspoon celery seed', '� teaspoon ground cinnamon', '� teaspoon cayenne pepper', '1 teaspoon salt', '1 teaspoon coarsely ground black pepper']", false, "https://www.allrecipes.com/recipe/44491/big-als-kc-bar-b-q-sauce/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Best Ever Muffins", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F5671166.jpg", "'2 cups all-purpose flour', '3 teaspoons baking powder', '� teaspoon salt', '� cup white sugar', '1 egg', '1 cup milk', '� cup vegetable oil']", false, "https://www.allrecipes.com/recipe/6874/best-ever-muffins/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Beer Batter Fish Made Great", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F2433719.jpg", "'2 quarts vegetable oil for frying', '8 (4 ounce) fillets cod', 'salt and pepper to taste', '1 cup all-purpose flour', '2 tablespoons garlic powder', '2 tablespoons paprika', '2 teaspoons salt', '2 teaspoons ground black pepper', '1 egg, beaten', '1 (12 fluid ounce) can or bottle beer']", false, "https://www.allrecipes.com/recipe/20107/beer-batter-fish-made-great/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Butternut Squash Soup II", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F964341.jpg", "'2 tablespoons butter', '1 small onion, chopped', '1 stalk celery, chopped', '1 medium carrot, chopped', '2 medium potatoes, cubed', '1 medium butternut squash - peeled, seeded, and cubed', '1 (32 fluid ounce) container chicken stock', 'salt and freshly ground black pepper to taste']", false, "https://www.allrecipes.com/recipe/77981/butternut-squash-soup-ii/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Cabbage and Dumplings", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F5315955.jpg", "'� cup butter', '1 onion, chopped', '1 head green cabbage, chopped', '1 cup flour', '� cup water', 'salt to taste']", false, "https://www.allrecipes.com/recipe/155190/cabbage-and-dumplings/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Cheesy Meatloaf", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F3685939.jpg", "'1 pound ground beef', '1 pound ground pork', '1 (1 ounce) envelope dry onion soup mix', '2 eggs, beaten', '� cups dry bread crumbs', 'ground black pepper to taste', '� cup water', '2 cups shredded mozzarella cheese, divided']", false, "https://www.allrecipes.com/recipe/24807/cheesy-meatloaf/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Cheesy Potato Casserole from Ore-Ida", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F6508534.jpg", "'1 (10.5 ounce) can condensed cream of chicken soup*', '2 cups sour cream', '1 teaspoon salt', '� teaspoon ground black pepper', '2 cups shredded Cheddar cheese', ' cup sliced green onions', '1 (30 ounce) package Ore-Ida Shredded Hash Brown Potatoes', '2 cups crushed corn flakes cereal', '� cup butter, melted']", false, "https://www.allrecipes.com/recipe/241797/cheesy-potato-casserole-from-ore-ida/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Cheesy Scalloped Potatoes with Ham", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F6178632.jpg", "'4 cups peeled and sliced potatoes', '2 cups diced ham', '� onion, chopped', '2 cups milk', '1 cup frozen peas', '3 tablespoons all-purpose flour', '2 tablespoons butter', '� teaspoon salt', '� teaspoon ground black pepper', ' teaspoon garlic powder', ' teaspoon onion powder', '1 teaspoon dried parsley', '� pound Cheddar cheese, diced', '1 pinch paprika, or to taste']", false, "https://www.allrecipes.com/recipe/221004/cheesy-scalloped-potatoes-with-ham/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Chef John's Baked Lemon Pepper Salmon", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F1040202.jpg", "'2 tablespoons lemon juice', '1 tablespoon ground black pepper', '� tablespoons mayonnaise', '1 tablespoon yellow miso paste', '2 teaspoons Dijon mustard', '1 pinch cayenne pepper, or to taste', '2 (8 ounce) center-cut salmon fillets, boned, skin on', 'sea salt to taste']", false, "https://www.allrecipes.com/recipe/231702/chef-johns-baked-lemon-pepper-salmon/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Chef John's Baked Mushroom Risotto", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F1207574.jpg", "'3 tablespoons butter', '3 cups diced mushrooms', 'salt to taste', '� yellow onion, diced', 'ground black pepper to taste', '1 pinch cayenne pepper', '1 cup carnaroli rice', '2 cups chicken broth, divided', '� cup heavy whipping cream', '� cup chicken broth', '2 tablespoons heavy whipping cream', '� cup finely grated Parmigiano-Reggiano cheese', '2 tablespoons chopped fresh chives']", false, "https://www.allrecipes.com/recipe/231713/chef-johns-baked-mushroom-risotto/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Chef John's Buttermilk Biscuits", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F5909221.jpg", "'2 cups all-purpose flour', '2 teaspoons baking powder', '1 teaspoon salt', '� teaspoon baking soda', '7 tablespoons unsalted butter, chilled in freezer and cut into thin slices', '� cup cold buttermilk', '2 tablespoons buttermilk for brushing']", false, "https://www.allrecipes.com/recipe/220943/chef-johns-buttermilk-biscuits/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Chef John's Chimichurri Sauce", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F7070829.jpg", "'� cup olive oil', '4 cloves garlic, chopped, or more to taste', '3 tablespoons white wine vinegar, or more to taste', '� teaspoon salt, or to taste', '� teaspoon ground cumin', '� teaspoon red pepper flakes', '� teaspoon freshly ground black pepper', '� cup fresh cilantro leaves', '� cup fresh oregano leaves', '1 bunch flat-leaf Italian parsley, stems removed']", false, "https://www.allrecipes.com/recipe/236375/chef-johns-chimichurri-sauce/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Chef John's Classic Macaroni Salad", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F2343032.jpg", "'1 cup mayonnaise', '� cup white vinegar', '2 tablespoons Dijon mustard', '2 teaspoons kosher salt, or more to taste', '� teaspoon ground black pepper', ' teaspoon cayenne pepper', '1 tablespoon white sugar, or more to taste', '1 cup finely diced celery', '� cup diced red bell pepper', '� cup grated carrot', '� cup chopped green onions, white and light parts', '� cup diced jalapeno pepper', '� cup diced poblano pepper', '1 (16 ounce) package uncooked elbow macaroni', '1 tablespoon mayonnaise', '1 tablespoon water']", false, "https://www.allrecipes.com/recipe/244305/chef-johns-classic-macaroni-salad/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Chef John's Creamy Mushroom Soup", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F1072703.jpg", "'� cup unsalted butter', '2 pounds sliced fresh mushrooms', '1 pinch salt', '1 yellow onion, diced', '� tablespoons all-purpose flour', '6 sprigs fresh thyme', '2 cloves garlic, peeled', '4 cups chicken broth', '1 cup water', '1 cup heavy whipping cream', '1 pinch salt and freshly ground black pepper to taste', '1 teaspoon fresh thyme leaves for garnish, or to taste']", false, "https://www.allrecipes.com/recipe/235589/chef-johns-creamy-mushroom-soup/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Cheesy Macaroni and Hamburger Casserole", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F7289121.jpg", "'� cups elbow macaroni', '1 (8 ounce) package processed cheese (such as Velveeta), cubed ', '1 pound ground beef', '1 teaspoon garlic powder', '� teaspoon onion powder', '1 pinch salt and ground black pepper to taste', \"1 (10.75 ounce) can  condensed Cheddar cheese soup (such as Campbell's)\", '1 (8 ounce) carton sour cream', '� cup grated Parmesan cheese', '� cup chopped onion', '� cup milk', '8 slices American cheese (such as Kraft)', '1 (8 ounce) package buttery round crackers (such as Ritz), crushed']", false, "https://www.allrecipes.com/recipe/230284/cheesy-macaroni-and-hamburger-casserole/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Chef John's Homemade Chicken Noodle Soup", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F1052488.jpg", "'1 tablespoon butter', '� cup diced carrot', '� cup diced onion', '� cup diced celery', '1 pinch salt', '� teaspoon fresh thyme leaves', '2 tablespoons melted chicken fat', '2 quarts roasted chicken broth (see footnote for recipe link)', '4 ounces uncooked wide egg noodles', '2 cooked boneless chicken breast halves, cubed', '1 pinch cayenne pepper', '1 pinch salt and ground black pepper to taste']", false, "https://www.allrecipes.com/recipe/220416/chef-johns-homemade-chicken-noodle-soup/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Chef John's Macaroni and Cheese", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F969050.jpg", "'1 (16 ounce) package elbow macaroni', '� cup butter', '� cup all-purpose flour', '� teaspoon dried thyme', '� teaspoon cayenne pepper', ' teaspoon white pepper', '3 cups milk', '1 pinch ground nutmeg', '� teaspoon Worcestershire sauce', '1 teaspoon salt', '3 cups shredded sharp Cheddar cheese, divided', '1 teaspoon Dijon mustard', '� cup panko bread crumbs', '1 tablespoon butter, melted']", false, "https://www.allrecipes.com/recipe/219166/chef-johns-macaroni-and-cheese/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Chef John's Perfect Prime Rib", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F4886145.jpg", "'4 pounds prime rib roast', '� cup unsalted butter, softened', '1 tablespoon freshly ground black pepper', '1 teaspoon herbes de Provence', 'kosher salt']", false, "https://www.allrecipes.com/recipe/221958/chef-johns-perfect-prime-rib/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Chef John's Pita Bread", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F5679240.jpg", "'1 (.25 ounce) package active dry yeast', '1 cup warm water (90 to 100 degrees F/32 to 38 degrees C)', '1 cup all-purpose flour', '� tablespoons olive oil', '� teaspoons salt', '� cups all-purpose flour, or more as needed', '1 teaspoon olive oil, divided']", false, "https://www.allrecipes.com/recipe/232719/chef-johns-pita-bread/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Chef John's Pumpkin Pie", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F1749711.jpg", "'1 (15 ounce) can pumpkin puree', '3 egg yolks', '1 large egg', '1 (14 ounce) can sweetened condensed milk', '1 teaspoon ground cinnamon', '� teaspoon ground ginger', '� teaspoon fine salt', '� teaspoon freshly grated nutmeg', ' teaspoon Chinese 5-spice powder', '1 9-inch unbaked pie crust (see footnote for recipe link)']", false, "https://www.allrecipes.com/recipe/230132/chef-johns-pumpkin-pie/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Chef John's Salmon Cakes", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F3375812.jpg", "'1 (14.75 ounce) can red salmon, skin and bone removed, drained and flaked', '2 eggs', '� lemon, juiced', '1 tablespoon chopped capers', '� teaspoon salt', '� teaspoon ground black pepper', '� teaspoon cayenne pepper', '12 saltine crackers', '1 tablespoon bread crumbs, or as needed', '1 tablespoon butter', '1 tablespoon olive oil']", false, "https://www.allrecipes.com/recipe/237827/chef-johns-salmon-cakes/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Chef John's Sourdough Bread", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F6103033.jpg", "'100 grams sourdough starter', '250 grams water', '8 grams kosher salt', '394 grams bread flour', 'rice flour for bread form (banneton)', '1 10-inch banneton (proofing basket)']", false, "https://www.allrecipes.com/recipe/260540/chef-johns-sourdough-bread/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Chef John's Turkey Noodle Casserole", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F855816.jpg", "'12 ounces egg noodles', '3 tablespoons butter', '3 tablespoons flour', '� cups cold milk', '1 (10 ounce) can condensed cream of mushroom soup', '� cup diced red bell pepper', '� cup diced green bell pepper', '� cup chopped green onions', '1 teaspoon garam masala', '1 teaspoon dried tarragon', '1 cup shredded pepperjack cheese', '1 teaspoon salt, or to taste', '3 cups cubed skinless cooked turkey', '5 ounces crushed potato chips']", false, "https://www.allrecipes.com/recipe/222238/chef-johns-turkey-noodle-casserole/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Chef John's Turkey Sloppy Joes", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F1259534.jpg", "'2 tablespoons butter', '1 onion, diced', 'salt and ground black pepper to taste', '� pounds ground turkey', '� cup cold water', '� cup ketchup', '� tablespoons brown sugar', '� teaspoon cayenne pepper, or to taste', '� teaspoon Worcestershire sauce', '� teaspoon unsweetened cocoa powder', '1 cup water, or as needed', '6 hamburger buns, split', ' cup chopped green onions', '� cup shredded white Cheddar cheese']", false, "https://www.allrecipes.com/recipe/223050/chef-johns-turkey-sloppy-joes/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Chewy Chocolate Chip Oatmeal Cookies", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F493502.jpg", "'1 cup butter, softened', '1 cup packed light brown sugar', '� cup white sugar', '2 eggs', '2 teaspoons vanilla extract', '� cups all-purpose flour', '� teaspoon baking soda', '1 teaspoon salt', '3 cups quick-cooking oats', '1 cup chopped walnuts', '1 cup semisweet chocolate chips']", false, "https://www.allrecipes.com/recipe/24445/chewy-chocolate-chip-oatmeal-cookies/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Chef John's Italian Meatballs", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F4531471.jpg", "' cup plain bread crumbs', '� cup milk', '2 tablespoons olive oil', '1 onion, diced', '1 pound ground beef', '1 pound ground pork', '2 eggs', '� bunch fresh parsley, chopped', '3 cloves garlic, crushed', '2 teaspoons salt', '1 teaspoon ground black pepper', '� teaspoon red pepper flakes', '1 teaspoon dried Italian herb seasoning', '2 tablespoons grated Parmesan cheese']", false, "https://www.allrecipes.com/recipe/220854/chef-johns-italian-meatballs/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Buttery Garlic Green Beans", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F6487180.jpg", "'1 pound fresh green beans, trimmed and snapped in half', '3 tablespoons butter', '3 cloves garlic, minced', '2 pinches lemon pepper', 'salt to taste']", false, "https://www.allrecipes.com/recipe/230103/buttery-garlic-green-beans/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Cheesy Ham and Corn Chowder", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F1930316.jpg", "'2 (15 ounce) cans chicken broth', '� cup sliced carrots', '2 tablespoons chicken bouillon granules', '3 bay leaves', '� teaspoon sea salt', '� teaspoon ground black pepper', '� teaspoon ground thyme', '� teaspoon dried marjoram', '� teaspoon garlic powder', '1 cup peeled and diced potatoes', '� cup chopped onion', '� cup sliced celery', '3 tablespoons butter', '3 tablespoons all-purpose flour', '� cups milk', '1 (15 ounce) can cream-style corn', '1 (8 ounce) package shredded sharp Cheddar cheese', '1 cup diced cooked ham']", false, "https://www.allrecipes.com/recipe/240583/cheesy-ham-and-corn-chowder/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Cheesecake with Cranberry Glaze and Sugared Cranberries", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F6074192.jpg", "\"10 digestive biscuits (such as McVitie's)\", '5 tablespoons butter, melted', \"2 tablespoons confectioners' sugar\", ' teaspoon salt', '2 (8 ounce) packages cream cheese, softened', '� cup white sugar', '3 large eggs', '� cup sour cream', '2 teaspoons vanilla extract', '1 orange, zested', ' cup white sugar', '� cup water', '1 cup fresh cranberries', '� cup white sugar', '1 cup fresh cranberries', '� cup water', '2 tablespoons white sugar', \"� cup confectioners' sugar\", '1 tablespoon orange juice', '� teaspoons light corn syrup', '� teaspoon vanilla extract', '� teaspoon salt']", false, "https://www.allrecipes.com/recipe/269467/cheesecake-with-cranberry-glaze-and-sugared-cranberries/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Cabbage Fat-Burning Soup", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F3086983.jpg", "'5 carrots, chopped', '3 onions, chopped', '2 (16 ounce) cans whole peeled tomatoes, with liquid', '1 large head cabbage, chopped', '1 (1 ounce) envelope dry onion soup mix', '1 (15 ounce) can cut green beans, drained', '2 quarts tomato juice', '2 green bell peppers, diced', '10 stalks celery, chopped', '1 (14 ounce) can beef broth']", false, "https://www.allrecipes.com/recipe/13116/cabbage-fat-burning-soup/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Cabbage Roll Casserole", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F1109345.jpg", "'2 pounds ground beef', '1 cup chopped onion', '1 (29 ounce) can tomato sauce', '� pounds chopped cabbage', '1 cup uncooked white rice', '1 teaspoon salt', '2 (14 ounce) cans beef broth']", false, "https://www.allrecipes.com/recipe/14690/cabbage-roll-casserole/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Caesar Salad Supreme", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F4523712.jpg", "'6 cloves garlic, peeled, divided', '� cup mayonnaise', '5 anchovy fillets, minced', '6 tablespoons grated Parmesan cheese, divided', '1 teaspoon Worcestershire sauce', '1 teaspoon Dijon mustard', '1 tablespoon lemon juice, or more to taste', 'salt to taste', 'ground black pepper to taste', '� cup olive oil', '4 cups day-old bread, cubed', '1 head romaine lettuce, torn into bite-size pieces']", false, "https://www.allrecipes.com/recipe/14172/caesar-salad-supreme/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Cameron's Ground Turkey Salsa Ranchera for Tacos and Burritos", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F5204476.jpg", "'1 teaspoon canola oil', '� pounds lean ground turkey', '1 (7 ounce) can salsa ranchera (such as HERDEZ)']", false, "https://www.allrecipes.com/recipe/262536/camerons-ground-turkey-salsa-ranchera-for-tacos-and-burritos/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Campbell's Tuna Noodle Casserole", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F8196559.jpg", "\"2 (10.75 ounce) cans  Campbell's Condensed Cream of Mushroom Soup (regular or 25% Lower Sodium)\", '1 cup milk', '2 cups frozen peas', '2 (10 ounce) cans tuna, drained', '4 cups hot cooked medium egg noodles', '2 tablespoons dry bread crumbs', '1 tablespoon butter, melted']", false, "https://www.allrecipes.com/recipe/151593/campbells-tuna-noodle-casserole/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Candied Pecans", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F965865.jpg", "'1 cup white sugar', '1 teaspoon ground cinnamon', '1 teaspoon salt', '1 egg white', '1 tablespoon water', '1 pound pecan halves']", false, "https://www.allrecipes.com/recipe/230557/candied-pecans/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Candied Yams", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F4147269.jpg", "'1 (29 ounce) can sweet potatoes', '� cup butter, cut into pieces', '� cup brown sugar', '� cups miniature marshmallows']", false, "https://www.allrecipes.com/recipe/26482/candied-yams/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Canned Apple Pie Filling", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F1455885.jpg", "'4\\u2009� cups white sugar', '1 cup cornstarch', '2 teaspoons ground cinnamon', '� teaspoon ground nutmeg', '2 teaspoons salt', '10 cups water', '3 tablespoons lemon juice', '2 drops yellow food coloring', '6 pounds apples']", false, "https://www.allrecipes.com/recipe/15942/canned-apple-pie-filling/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Caprese Salad with Balsamic Reduction", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F1018869.jpg", "'1 cup balsamic vinegar', '� cup honey', '3 large tomatoes, cut into 1/2-inch slices', '1 (16 ounce) package fresh mozzarella cheese, cut into 1/4-inch slices', '� teaspoon salt', '� teaspoon ground black pepper', '� cup fresh basil leaves', '� cup extra-virgin olive oil']", false, "https://www.allrecipes.com/recipe/228126/caprese-salad-with-balsamic-reduction/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Cheesy Amish Breakfast Casserole", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F8087783.jpg", "'1 pound sliced bacon, diced', '1 sweet onion, chopped', '4 cups frozen shredded hash brown potatoes, thawed', '9 eggs, lightly beaten', '2 cups shredded Cheddar cheese', '� cups small curd cottage cheese', '� cups shredded Swiss cheese']", false, "https://www.allrecipes.com/recipe/229150/cheesy-amish-breakfast-casserole/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Captain's Seafood Crab Dip", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F970590.jpg", "'� cups mayonnaise', '1 cup fresh crabmeat', '1 cup shredded Cheddar cheese', '� cup French salad dressing', '� lemon, juiced', '2 teaspoons prepared horseradish']", false, "https://www.allrecipes.com/recipe/222288/captains-seafood-crab-dip/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Cardamom Maple Salmon", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F1122495.jpg", "'� teaspoons salt', '1 teaspoon paprika', '1 teaspoon ground cardamom', '1 teaspoon ground coriander', '� teaspoon ground black pepper', '� cup grapeseed oil', '2 tablespoons maple syrup', '1 (2 pound) salmon fillet, cut into 3-inch pieces']", false, "https://www.allrecipes.com/recipe/237297/cardamom-maple-salmon/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Carne Asada Breakfast Burrito", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F4340194.jpg", "'2 pounds beef skirt steak, cut into thin strips', '2 tablespoons carne asada seasoning', '1 tablespoon garlic powder', '1 tablespoon vegetable oil', '� sweet onion, diced', '1 red bell pepper, seeded and chopped', '1 jalapeno pepper, seeded and diced', \"1 (14.5 ounce) can Hunt's Diced Tomatoes, drained\", '2 cups frozen diced potatoes', 'salt and pepper to taste', '3 tablespoons butter, divided', '6 eggs, whisked', '2 cups shredded Mexican cheese blend', '4 (12 inch) flour tortillas']", false, "https://www.allrecipes.com/recipe/256301/carne-asada-breakfast-burrito/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Carrot Cake III", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fcf-images.us-east-1.prod.boltdns.net%2Fv1%2Fstatic%2F1033249144001%2F97c20d8b-0600-48a4-bc26-fbd56d09a553%2F12ca0c5d-327c-46bf-a923-c415c0d7eaa3%2F1280x720%2Fmatch%2Fimage.jpg", "'4 eggs', '� cups vegetable oil', '2 cups white sugar', '2 teaspoons vanilla extract', '2 cups all-purpose flour', '2 teaspoons baking soda', '2 teaspoons baking powder', '� teaspoon salt', '2 teaspoons ground cinnamon', '3 cups grated carrots', '1 cup chopped pecans', '� cup butter, softened', '8 ounces cream cheese, softened', \"4 cups confectioners' sugar\", '1 teaspoon vanilla extract', '1 cup chopped pecans']", false, "https://www.allrecipes.com/recipe/7402/carrot-cake-iii/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Cast Iron Pan-Seared Steak (Oven-Finished)", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F7557288.jpg", "'2 (6 ounce) beef top sirloin steaks', '2 cups orange juice', '1 cup apple cider vinegar', '� cup Worcestershire sauce', '2 teaspoons olive oil', \"� tablespoons steak seasoning (such as Fiesta Brand Uncle Chris'), or to taste\", 'freshly ground black pepper to taste', 'sea salt to taste']", false, "https://www.allrecipes.com/recipe/262181/cast-iron-pan-seared-steak-oven-finished/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Cauliflower Mac-N-Cheese", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F4144892.jpg", "'� cups elbow macaroni', '� cup cauliflower florets', 'cooking spray', '1 tablespoon olive oil', '1 tablespoon all-purpose flour', '� cup milk', '� cups shredded Cheddar cheese', '� (8 ounce) package cream cheese', '� teaspoon salt', ' teaspoon ground black pepper']", false, "https://www.allrecipes.com/recipe/254511/cauliflower-mac-n-cheese/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Cheddar Cheese Muffins", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F5080080.jpg", "'2 cups all-purpose flour', '� cup white sugar', '1 tablespoon baking powder', '1 teaspoon salt', '� teaspoon baking soda', '� cups shredded Cheddar cheese', '1 cup plain yogurt', '2 eggs, beaten', '� cup butter, melted']", false, "https://www.allrecipes.com/recipe/239856/cheddar-cheese-muffins/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Cheddar-Bacon Mac and Cheese", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F978111.jpg", "'� cups elbow macaroni, uncooked', '3 tablespoons butter or margarine', '2 tablespoons flour', '2 cups milk', '2 cups KRAFT Shredded Sharp Cheddar Cheese, divided', '3 slices OSCAR MAYER Center Cut Bacon, cooked, crumbled']", false, "https://www.allrecipes.com/recipe/217193/cheddar-bacon-mac-and-cheese/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Cheese and Hamburger Macaroni", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F1020197.jpg", "'� pound lean ground beef, or more to taste', '� small onion, minced', '1 teaspoon garlic powder', '1 teaspoon onion powder', '1 pinch salt and ground black pepper to taste', '2 cups water', '2 cups elbow macaroni', '8 ounces reduced-fat processed cheese food (such as Velveeta), cut into small pieces', '2 tablespoons reduced-fat sour cream, or more to taste']", false, "https://www.allrecipes.com/recipe/232850/cheese-and-hamburger-macaroni/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Cheese Sauce for Broccoli and Cauliflower", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F5541328.jpg", "'2 tablespoons butter', '2 tablespoons all-purpose flour', '1 cup milk', '� cups shredded Cheddar cheese', '1 pinch salt and ground black pepper to taste']", false, "https://www.allrecipes.com/recipe/233481/cheese-sauce-for-broccoli-and-cauliflower/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Caramel Bars", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F18081.jpg", "'32 individually wrapped caramels, unwrapped', '5 tablespoons heavy cream', '1 cup all-purpose flour', '1 cup rolled oats', '� cup brown sugar', '� teaspoon baking soda', '� teaspoon salt', '� cup butter, melted', '� cup semisweet chocolate chips', '� cup chopped walnuts']", false, "https://www.allrecipes.com/recipe/25030/caramel-bars/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Chewy Chocolate Cookies II", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F4028922.jpg", "'� cups margarine, softened', '2 cups white sugar', '2 eggs', '2 teaspoons vanilla extract', '2 cups all-purpose flour', '� cup unsweetened cocoa powder', '1 teaspoon baking soda', ' teaspoon salt', '1 cup chopped walnuts']", false, "https://www.allrecipes.com/recipe/10281/chewy-chocolate-cookies-ii/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Beef Stroganoff with Ground Beef", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F7323467.jpg", "'2 tablespoons butter', '1 cup sliced fresh mushrooms', ' cup chopped onion', '1 pound lean ground beef', '2 tablespoons all-purpose flour', '1 teaspoon garlic powder', '1 teaspoon seasoning salt', '� teaspoon ground paprika', '� teaspoon ground black pepper', '1 (10.75 ounce) can  condensed cream of mushroom soup', '� cup sour cream, or more to taste', '1 tablespoon liquid smoke, or to taste', '1 tablespoon Worcestershire sauce']", false, "https://www.allrecipes.com/recipe/276859/beef-stroganoff-with-ground-beef/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Beef Stew VI", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F729310.jpg", "'2 pounds cubed beef stew meat', '3 tablespoons vegetable oil', '4 cubes beef bouillon, crumbled', '4 cups water', '1 teaspoon dried rosemary', '1 teaspoon dried parsley', '� teaspoon ground black pepper', '3 large potatoes, peeled and cubed', '4 carrots, cut into 1 inch pieces', '4 stalks celery, cut into 1 inch pieces', '1 large onion, chopped', '2 teaspoons cornstarch', '2 teaspoons cold water']", false, "https://www.allrecipes.com/recipe/25678/beef-stew-vi/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Amazingly Easy Irish Soda Bread", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F995189.jpg", "'4 cups all-purpose flour', '4 tablespoons white sugar', '1 teaspoon baking soda', '1 tablespoon baking powder', '� teaspoon salt', '� cup margarine, softened', '1 cup buttermilk', '1 egg', '� cup butter, melted', '� cup buttermilk']", false, "https://www.allrecipes.com/recipe/16947/amazingly-easy-irish-soda-bread/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Amelia's Tuna Macaroni Salad", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F3591151.jpg", "'1 (12 ounce) package elbow macaroni', '1 (5 ounce) can tuna, drained', '2 stalks celery, chopped', '2 tablespoons chopped sweet onion', '1 (10 ounce) can baby peas, drained', '1 cup mayonnaise', '2 tablespoons sweet pickle relish', 'salt and pepper to taste', '3 hard-cooked eggs, quartered', '1 pinch paprika, for garnish']", false, "https://www.allrecipes.com/recipe/70208/amelias-tuna-macaroni-salad/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Amish Macaroni Salad", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F410845.jpg", "'2 cups uncooked elbow macaroni', '3 hard-cooked eggs, chopped', '1 small onion, chopped', '3 stalks celery, chopped', '1 small red bell pepper, seeded and chopped', '2 tablespoons dill pickle relish', '2 cups creamy salad dressing (e.g. Miracle Whip)', '3 tablespoons prepared yellow mustard', '� cup white sugar', '� teaspoons white vinegar', '� teaspoon salt', '� teaspoon celery seed']", false, "https://www.allrecipes.com/recipe/74915/amish-macaroni-salad/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Anne's Chicken Chilaquiles Rojas", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F1098038.jpg", "'1 (28 ounce) can whole peeled tomatoes, drained', '2 chipotle chiles in adobo sauce, or more to taste', '� tablespoons vegetable oil', '1 large white onion, thinly sliced', '3 cloves garlic, minced', '� cups chicken broth', '1 dash roasted ground cumin', '1 dash dried oregano', 'salt and ground black pepper to taste', '1 (16 ounce) package tortilla chips', '1 (8 ounce) package shredded Mexican cheese blend', '5 ounces crumbled cotija cheese', '1 whole cooked chicken, deboned and shredded', ' cup chopped green onions, divided', '1 cup chopped cilantro, divided', '1 (8 ounce) carton sour cream, divided']", false, "https://www.allrecipes.com/recipe/279677/annes-chicken-chilaquiles-rojas/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Antipasto Pasta Salad", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F2341472.jpg", "'1 pound seashell pasta', '� pound Genoa salami, chopped', '� pound pepperoni sausage, chopped', '� pound Asiago cheese, diced', '1 (6 ounce) can black olives, drained and chopped', '1 red bell pepper, diced', '1 green bell pepper, chopped', '3 tomatoes, chopped', '1 (.7 ounce) package dry Italian-style salad dressing mix', '� cup extra virgin olive oil', '� cup balsamic vinegar', '2 tablespoons dried oregano', '1 tablespoon dried parsley', '1 tablespoon grated Parmesan cheese', 'salt and ground black pepper to taste']", false, "https://www.allrecipes.com/recipe/14278/antipasto-pasta-salad/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Apple Cinnamon White Cake", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F1336585.jpg", "' cup brown sugar', '1 teaspoon ground cinnamon', ' cup white sugar', '� cup butter, softened', '2 eggs', '� teaspoons vanilla extract', '� cups all-purpose flour', '� teaspoons baking powder', '� cup milk', '1 apple, peeled and chopped']", false, "https://www.allrecipes.com/recipe/232922/apple-cinnamon-white-cake/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Apple Crisp II", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F277929.jpg", "'10 cups all-purpose apples, peeled, cored and sliced', '1 cup white sugar', '1 tablespoon all-purpose flour', '1 teaspoon ground cinnamon', '� cup water', '1 cup quick-cooking oats', '1 cup all-purpose flour', '1 cup packed brown sugar', '� teaspoon baking powder', '� teaspoon baking soda', '� cup butter, melted']", false, "https://www.allrecipes.com/recipe/12409/apple-crisp-ii/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Apple Crisp with Oat Topping", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F2604006.jpg", "'6 apples - peeled, cored, and sliced', '2 tablespoons white sugar', '� teaspoon ground cinnamon', '1 cup brown sugar', '� cup old-fashioned oats', '� cup all-purpose flour', '1 teaspoon ground cinnamon', '� cup cold butter']", false, "https://www.allrecipes.com/recipe/229088/apple-crisp-with-oat-topping/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Apple Crumb Pie", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F4233406.jpg", "'1 (9 inch) pie shell', '6 cups thinly sliced apples', '1 tablespoon lemon juice', '� cup white sugar', '2 tablespoons all-purpose flour', '� teaspoon ground cinnamon', ' teaspoon ground nutmeg', '� cup raisins', '� cup chopped walnuts', '� cup all-purpose flour', '� cup packed brown sugar', '3 tablespoons butter']", false, "https://www.allrecipes.com/recipe/15587/apple-crumb-pie/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Amazing Pork Tenderloin in the Slow Cooker", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F305103.jpg", "'1 (2 pound) pork tenderloin', '1 (1 ounce) envelope dry onion soup mix', '1 cup water', '� cup red wine', '3 tablespoons minced garlic', '3 tablespoons soy sauce', 'freshly ground black pepper to taste']", false, "https://www.allrecipes.com/recipe/75861/amazing-pork-tenderloin-in-the-slow-cooker/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Apple Crumble Coffee Cake", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F8090709.jpg", "'2 teaspoons unsalted butter', '2 cups all-purpose flour', '� teaspoon fine sea salt', '1 teaspoon baking powder', '� teaspoon baking soda', '� cups finely chopped toasted walnuts', ' cup packed light brown sugar', ' cup white sugar', '� teaspoon salt', '1 teaspoon ground cinnamon', '3 tablespoons unsalted butter, melted', '� cup unsalted butter, at room temperature ', '1 cup white sugar', '2 large eggs', '� teaspoons vanilla extract', '1 cup plain yogurt', '2 Honeycrisp apples']", false, "https://www.allrecipes.com/recipe/280118/apple-crumble-coffee-cake/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Apple Hand Pies", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F5220623.jpg", "'1 pound prepared pie dough, cut into 4 pieces', '2 large green apples, peeled and cored', '2 tablespoons butter', '� teaspoon salt', '� cup white sugar', '2 tablespoons brown sugar', '� teaspoons ground cinnamon, or to taste', '1 teaspoon water, or more if needed', '1 egg', '2 teaspoons milk', '1 teaspoon white sugar, or as needed - divided']", false, "https://www.allrecipes.com/recipe/234374/apple-hand-pies/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Apple Pie by Grandma Ople", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F736203.jpg", "'1 recipe pastry for a 9 inch double crust pie', '� cup unsalted butter', '3 tablespoons all-purpose flour', '� cup water', '� cup white sugar', '� cup packed brown sugar', '8 Granny Smith apples - peeled, cored and sliced']", false, "https://www.allrecipes.com/recipe/12682/apple-pie-by-grandma-ople/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Apple Pie Cake-Mix Cake", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F8623361.jpg", "'2 (21 ounce) cans apple pie filling', '1 (15.25 ounce) package yellow cake mix', '� cup butter, melted']", false, "https://www.allrecipes.com/recipe/244777/apple-pie-cake-mix-cake/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Apple Pie Filling", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F999587.jpg", "'18 cups thinly sliced apples', '3 tablespoons lemon juice', '10 cups water', '4\\u2009� cups white sugar', '1 cup cornstarch', '2 teaspoons ground cinnamon', '1 teaspoon salt', '� teaspoon ground nutmeg']", false, "https://www.allrecipes.com/recipe/12681/apple-pie-filling/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Apple Pie I", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F3821774.jpg", "'6 cups thinly sliced apples', '� cup white sugar', '1 tablespoon butter', '1 teaspoon ground cinnamon', '1 recipe pastry for a 9-inch double-crust pie']", false, "https://www.allrecipes.com/recipe/12324/apple-pie-i/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Apple Pie", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F7285482.jpg", "'� cup white sugar', '2 tablespoons all-purpose flour', '� teaspoon ground cinnamon', '� teaspoon ground nutmeg', '� teaspoon lemon zest', '7 cups thinly sliced apples', '2 teaspoons lemon juice', '1 tablespoon butter', '1 recipe pastry for a 9 inch double crust pie', '4 tablespoons milk']", false, "https://www.allrecipes.com/recipe/16268/apple-pie/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Apple Squares", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F556599.jpg", "'1 cup sifted all-purpose flour', '1 teaspoon baking powder', '� teaspoon salt', '� teaspoon ground cinnamon', '� cup butter or margarine, melted', '� cup packed brown sugar', '� cup white sugar', '1 egg', '1 teaspoon vanilla extract', '� cup chopped apple', '� cup finely chopped walnuts', '2 tablespoons white sugar', '2 teaspoons ground cinnamon']", false, "https://www.allrecipes.com/recipe/15067/apple-squares/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Apple Strudel Muffins", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F173362.jpg", "'2 cups all-purpose flour', '1 teaspoon baking powder', '� teaspoon baking soda', '� teaspoon salt', '� cup butter', '1 cup white sugar', '2 eggs', '� teaspoons vanilla', '� cups chopped apples', ' cup packed brown sugar', '1 tablespoon all-purpose flour', ' teaspoon ground cinnamon', '1 tablespoon butter']", false, "https://www.allrecipes.com/recipe/33157/apple-strudel-muffins/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Apple Upside-Down Cake", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F8580804.jpg", "'� cups brown sugar, or more to taste', '3 tablespoons ground cinnamon, divided', '5 medium apples - peeled, cored, and sliced', '4 cups all-purpose flour', '� cups unsweetened apple juice', '� cups white sugar', '1 cup butter, softened', '4 eggs', '� cup milk', '1 tablespoon vanilla extract', '2 teaspoons baking powder', '2 teaspoons salt']", false, "https://www.allrecipes.com/recipe/269362/apple-upside-down-cake/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Apple Crumble Pie", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F486512.jpg", "'1 (9 inch) deep dish pie crust', '5 cups apples - peeled, cored and thinly sliced', '� cup white sugar', '� teaspoon ground cinnamon', ' cup white sugar', '� cup all-purpose flour', '6 tablespoons butter']", false, "https://www.allrecipes.com/recipe/12298/apple-crumble-pie/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Artichoke Chicken Casserole", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F881877.jpg", "'1 cup grated Parmesan cheese', '1 cup light mayonnaise', '1 pinch garlic powder, or to taste', '4 (4 ounce) skinless, boneless chicken breast halves', '1 (14 ounce) can artichoke hearts, drained', '1 (8 ounce) package crimini mushrooms, sliced']", false, "https://www.allrecipes.com/recipe/228451/artichoke-chicken-casserole/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Amazing No Cook Spinach Artichoke Dip", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F1060887.jpg", "'1 sweet onion, cut into quarters', '8 cloves garlic, or more to taste', '1 (14 ounce) can artichoke hearts, drained and chopped', '1 (10 ounce) package frozen chopped spinach, thawed and drained', '1 (8 ounce) package shredded Parmesan cheese', '1 (1.4 ounce) package dry vegetable soup mix (such as Knorr)', '1 (8 ounce) package reduced-fat cream cheese, softened', '1 cup reduced-fat mayonnaise', '1 (8 ounce) container reduced-fat sour cream']", false, "https://www.allrecipes.com/recipe/223012/amazing-no-cook-spinach-artichoke-dip/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "All-American Loaded Baked Potato Salad", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F3774804.jpg", "'6 cups cubed russet potatoes', '1 teaspoon salt', '1 cup sour cream', '1 cup creamy salad dressing (such as Miracle Whip)', '� teaspoon coarse ground black pepper', '1 cup shredded Cheddar cheese', '� cup chopped green onions', '� cup real bacon bits']", false, "https://www.allrecipes.com/recipe/254568/all-american-loaded-baked-potato-salad/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "4-Ingredient Keto Peanut Butter Cookies", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F6723979.jpg", "'1 cup peanut butter', '� cup low-calorie natural sweetener (such as Swerve)', '1 egg', '1 teaspoon sugar-free vanilla extract']", false, "https://www.allrecipes.com/recipe/261181/4-ingredient-keto-peanut-butter-cookies/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "A Minnesotan's Beef and Macaroni Hotdish", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F5051887.jpg", "'1 pound ground beef', '2 cups elbow macaroni', '� large green bell pepper, coarsely chopped', '� large onion, chopped', '1 (16 ounce) can tomato sauce', '1 pound tomatoes, coarsely chopped', '2 teaspoons Worcestershire sauce', '1 teaspoon soy sauce', '1 teaspoon salt', '� teaspoon dried basil', '� teaspoon dried oregano', '� teaspoon ground black pepper', '� teaspoon chili powder', '� teaspoon garlic powder', ' teaspoon hot pepper sauce (such as Tabasco)', '1 cup beef broth']", false, "https://www.allrecipes.com/recipe/262326/a-minnesotans-beef-and-macaroni-hotdish/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "A Simply Perfect Roast Turkey", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fcf-images.us-east-1.prod.boltdns.net%2Fv1%2Fstatic%2F1033249144001%2Fdd1cb159-f6dd-48ff-89d3-1382cfd8c7de%2F627cedfb-8517-49f3-9311-76ada1953297%2F1280x720%2Fmatch%2Fimage.jpg", "'1 (18 pound) whole turkey', '� cup unsalted butter, softened', 'salt and freshly ground black pepper to taste', '� quarts turkey stock', '8 cups prepared stuffing']", false, "https://www.allrecipes.com/recipe/56348/a-simply-perfect-roast-turkey/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "A Very Popular BBQ Sauce", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F72682.jpg", "'� cups brown sugar', '� cups ketchup', '� cup red wine vinegar', '� cup water', '1 tablespoon Worcestershire sauce', '� tablespoons dry mustard', '2 teaspoons paprika', '2 teaspoons salt', '� teaspoons black pepper', '2 dashes hot pepper sauce']", false, "https://www.allrecipes.com/recipe/51226/a-very-popular-bbq-sauce/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "A-Number-1 Banana Cake", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F18540.jpg", "'� cups all-purpose flour', '1 tablespoon baking soda', '1 pinch salt', '� cup unsalted butter', '1 cup white sugar', '� cup light brown sugar', '2 eggs', '4 ripe bananas, mashed', ' cup buttermilk', '� cup chopped walnuts']", false, "https://www.allrecipes.com/recipe/7754/a-number-1-banana-cake/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Absolute Best Liver and Onions", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F4461119.jpg", "'2 pounds sliced beef liver', '� cups milk, or as needed', '� cup butter, divided', '2 large Vidalia onions, sliced into rings', '2 cups all-purpose flour, or as needed', 'salt and pepper to taste']", false, "https://www.allrecipes.com/recipe/58942/absolute-best-liver-and-onions/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Absolutely Ultimate Potato Soup", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F168555.jpg", "'1 pound bacon, chopped', '2 stalks celery, diced', '1 onion, chopped', '3 cloves garlic, minced', '8 potatoes, peeled and cubed', '4 cups chicken stock, or enough to cover potatoes', '3 tablespoons butter', '� cup all-purpose flour', '1 cup heavy cream', '1 teaspoon dried tarragon', '3 teaspoons chopped fresh cilantro', 'salt and pepper to taste']", false, "https://www.allrecipes.com/recipe/13218/absolutely-ultimate-potato-soup/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Abuela's Picadillo", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F4030820.jpg", "'2 pounds lean ground beef', '� cup olive oil', '� onion, chopped', '� green bell pepper, chopped', '2 tablespoons minced garlic', '2 (8 ounce) cans tomato sauce', '2 cups water', '� cup red cooking wine', '3 tablespoons hot sauce (such as Louisiana)', '1 (1.41 ounce) package sazon seasoning (such as Badia Tropical)', '1 tablespoon chopped fresh parsley', '� teaspoon garlic powder', '� teaspoon onion powder', '� teaspoon ground cumin', '� teaspoon ground black pepper', '� teaspoon ground bay leaf', '3 ounces Spanish-style olives', '1 teaspoon salt, or to taste', '1 small butternut squash, peeled and cut into cubes']", false, "https://www.allrecipes.com/recipe/255660/abuelas-picadillo/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Acini di Pepe Salad", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F3834178.jpg", "'1 cup acini di pepe pasta', '1 (20 ounce) can crushed pineapple, drained with juice reserved', '1 (15 ounce) can mandarin oranges, drained with liquid reserved', '1 (8 ounce) container frozen whipped topping, thawed', '7 ounces miniature marshmallows', '1 cup white sugar', '2 eggs, beaten', '� teaspoon salt', '3 tablespoons all-purpose flour', '1 (10 ounce) jar maraschino cherries, drained']", false, "https://www.allrecipes.com/recipe/15294/acini-di-pepe-salad/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Almond Milk Chocolate Pudding", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F3292643.jpg", "'1 cup white sugar, or to taste', '� cup unsweetened cocoa powder', ' cup cornstarch', '� teaspoon salt', '3 cups unsweetened almond milk', '1 teaspoon butter', '1 teaspoon vanilla extract']", false, "https://www.allrecipes.com/recipe/246265/almond-milk-chocolate-pudding/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Acorn Squash", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F1403075.jpg", "'1 medium acorn squash, halved and seeded', '1 tablespoon butter', '2 tablespoons brown sugar']", false, "https://www.allrecipes.com/recipe/16796/acorn-squash/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Ahi Poke Basic", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F5267924.jpg", "'2 pounds fresh tuna steaks, cubed', '1 cup soy sauce', '� cup chopped green onions', '2 tablespoons sesame oil', '1 tablespoon toasted sesame seeds', '1 tablespoon crushed red pepper', '2 tablespoons finely chopped macadamia nuts']", false, "https://www.allrecipes.com/recipe/12870/ahi-poke-basic/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Air Fryer Apple Pies", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F6696219.jpg", "'4 tablespoons butter', '6 tablespoons brown sugar', '1 teaspoon ground cinnamon', '2 medium Granny Smith apples, diced', '1 teaspoon cornstarch', '2 teaspoons cold water', '� (14 ounce) package pastry for a 9-inch double crust pie', 'cooking spray', '� tablespoon grapeseed oil', '� cup powdered sugar', '1 teaspoon milk, or more as needed']", false, "https://www.allrecipes.com/recipe/274026/air-fryer-apple-pies/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Air Fryer Apricot-Glazed Chicken Breasts", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F8031915.jpg", "'3 tablespoons apricot preserves', '1 teaspoon fresh ginger paste (such as Gourmet Garden�)', '� teaspoon minced fresh rosemary', '2 (8 ounce) boneless, skinless chicken breasts', '1 teaspoon vegetable oil', 'salt and ground black pepper to taste']", false, "https://www.allrecipes.com/recipe/279934/air-fryer-apricot-glazed-chicken-breasts/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Air Fryer Chicken Thighs", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fstatic.onecms.io%2Fwp-content%2Fuploads%2Fsites%2F43%2F2020%2F10%2F07%2F272858.jpg", "'4 skin-on, boneless chicken thighs', '2 teaspoons extra-virgin olive oil', '1 teaspoon smoked paprika', '� teaspoon garlic powder', '� teaspoon salt', '� teaspoon ground black pepper']", false, "https://www.allrecipes.com/recipe/272858/air-fryer-chicken-thighs/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Air Fryer Coconut Shrimp", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F6896653.jpg", "'� cup all-purpose flour', '� teaspoons ground black pepper', '2 large eggs', ' cup unsweetened flaked coconut', ' cup panko bread crumbs', '12 ounces uncooked medium shrimp, peeled and deveined', 'cooking spray', '� teaspoon kosher salt, divided', '� cup honey', '� cup lime juice', '1 serrano chile, thinly sliced', '2 teaspoons chopped fresh cilantro']", false, "https://www.allrecipes.com/recipe/270712/air-fryer-coconut-shrimp/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Air Fryer Stuffed Mushrooms", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F7638987.jpg", "'1 (16 ounce) package whole white button mushrooms', '2 scallions', '4 ounces cream cheese, softened', '� cup finely shredded sharp Cheddar cheese', '� teaspoon ground paprika', '1 pinch salt', 'cooking spray']", false, "https://www.allrecipes.com/recipe/278271/air-fryer-stuffed-mushrooms/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Al's Burmese Chicken Curry", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F7062050.jpg", "'1 teaspoon butter, or as needed', '8 shallots, thinly sliced', '3 tablespoons red curry paste, or more to taste', '2 tablespoons hot curry powder', '1 tablespoon ground red chile pepper', '� pounds chicken thighs', '1 lemongrass, smashed and cut into 1-inch pieces', \"10 bird's eye chile peppers, chopped, or to taste\", '1 tablespoon ground coriander', '2 kaffir lime leaves, or to taste', '3 tablespoons fish sauce', 'water to cover', '1 (14 ounce) can coconut milk', '4 tomatoes, quartered', '� small bunch fresh cilantro, chopped, or to taste']", false, "https://www.allrecipes.com/recipe/276989/als-burmese-chicken-curry/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Alfredo Sauce", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F672690.jpg", "'� cup butter', '1 cup heavy cream', '1 clove garlic, crushed', '� cups freshly grated Parmesan cheese', '� cup chopped fresh parsley']", false, "https://www.allrecipes.com/recipe/22831/alfredo-sauce/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "All Kale Caesar", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F6308326.jpg", "'� cup lemon juice', '2 anchovy fillets', '2 cloves garlic, peeled', '� teaspoon Dijon mustard', '� cup olive oil', '� teaspoon salt', 'ground black pepper to taste', '6 cups kale leaves', '1 cup croutons', '� cup grated Parmesan cheese']", false, "https://www.allrecipes.com/recipe/269287/all-kale-caesar/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Actually Delicious Turkey Burgers", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F7818569.jpg", "'3 pounds ground turkey', '� cup seasoned bread crumbs', '� cup finely diced onion', '2 egg whites, lightly beaten', '� cup chopped fresh parsley', '1 clove garlic, peeled and minced', '1 teaspoon salt', '� teaspoon ground black pepper']", false, "https://www.allrecipes.com/recipe/39748/actually-delicious-turkey-burgers/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Beef Stroganoff for Instant Pot", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F6472891.jpg", "'2 tablespoons canola oil', '� onion, diced', '2 teaspoons salt, divided', '2 pounds beef stew meat, cut into 1-inch cubes', '1 teaspoon freshly ground black pepper', '3 cloves garlic, minced', '� teaspoon dried thyme', '2 tablespoons soy sauce', '3 cups chopped mushrooms', '2 tablespoons all-purpose flour', '3 cups chicken broth', '1 (16 ounce) package wide egg noodles', '� cup sour cream, or to taste']", false, "https://www.allrecipes.com/recipe/258468/beef-stroganoff-for-instant-pot/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Artichoke Stuffed Mushrooms", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F550260.jpg", "'1 tablespoon olive oil', '1 onion, chopped', '24 mushrooms, stems removed and chopped', 'salt and ground black pepper to taste', '1 (12 ounce) jar marinated artichoke hearts, drained and chopped', '1 (8 ounce) package cream cheese, softened', '2 tablespoons sour cream', '1 cup shredded Italian cheese blend', '2 tablespoons grated Parmesan cheese', '� teaspoon garlic salt, or to taste']", false, "https://www.allrecipes.com/recipe/175989/artichoke-stuffed-mushrooms/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Authentic German Potato Salad", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F586962.jpg", "'3 cups diced peeled potatoes', '4 slices bacon', '1 small onion, diced', '� cup white vinegar', '2 tablespoons water', '3 tablespoons white sugar', '1 teaspoon salt', ' teaspoon ground black pepper', '1 tablespoon chopped fresh parsley']", false, "https://www.allrecipes.com/recipe/83097/authentic-german-potato-salad/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Baked Potato Soup I", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F5867379.jpg", "'12 slices bacon', ' cup margarine', ' cup all-purpose flour', '7 cups milk', '4 large baked potatoes, peeled and cubed', '4 green onions, chopped', '� cups shredded Cheddar cheese', '1 cup sour cream', '1 teaspoon salt', '1 teaspoon ground black pepper']", false, "https://www.allrecipes.com/recipe/12997/baked-potato-soup-i/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Baked Spaghetti I", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F41166.jpg", "'12 ounces spaghetti', '1 cup chopped onions', '1 cup chopped green bell peppers', '1 pound lean ground beef', '1 (16 ounce) can diced tomatoes', '1 (4.5 ounce) can mushrooms, drained', '1 teaspoon dried oregano', '2 cups shredded mild Cheddar cheese', '1 (10.75 ounce) can  condensed cream of mushroom soup', '� cup water', '� cup grated Parmesan cheese']", false, "https://www.allrecipes.com/recipe/11905/baked-spaghetti-i/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Baked Spaghetti", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F1578406.jpg", "'1 (16 ounce) package spaghetti', '1 pound ground beef', '1 onion, chopped', '1 (32 ounce) jar meatless spaghetti sauce', '� teaspoon seasoned salt', '2 eggs', ' cup grated Parmesan cheese', '5 tablespoons butter, melted', '2 cups small curd cottage cheese, divided', '4 cups shredded mozzarella cheese, divided']", false, "https://www.allrecipes.com/recipe/222582/baked-spaghetti/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Baked Ziti Casserole", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F891954.jpg", "'1 (16 ounce) package ziti', '1 (15 ounce) container ricotta cheese', '� cups tomato sauce', '1 (8 ounce) package shredded mozzarella cheese', '1 egg, slightly beaten', '1 teaspoon salt, or to taste', '� teaspoon ground black pepper, or to taste', '2 cups tomato sauce, divided', '� cup grated Parmesan cheese']", false, "https://www.allrecipes.com/recipe/228411/baked-ziti-casserole/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Baked Ziti I", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F4557541.jpg", "'1 pound dry ziti pasta', '1 onion, chopped', '1 pound lean ground beef', '2 (26 ounce) jars spaghetti sauce', '6 ounces provolone cheese, sliced', '� cups sour cream', '6 ounces mozzarella cheese, shredded', '2 tablespoons grated Parmesan cheese']", false, "https://www.allrecipes.com/recipe/11758/baked-ziti-i/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Balsamic Bruschetta", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F866248.jpg", "'8 roma (plum) tomatoes, diced', ' cup chopped fresh basil', '� cup shredded Parmesan cheese', '2 cloves garlic, minced', '1 tablespoon balsamic vinegar', '1 teaspoon olive oil', '� teaspoon kosher salt', '� teaspoon freshly ground black pepper', '1 loaf French bread, toasted and sliced']", false, "https://www.allrecipes.com/recipe/54165/balsamic-bruschetta/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Banana Banana Bread", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fcf-images.us-east-1.prod.boltdns.net%2Fv1%2Fstatic%2F1033249144001%2F0ebabff6-3872-4b38-ad70-898e0c409522%2F7df60bf0-b98a-4f9a-9936-8bf1a6a4b885%2F1280x720%2Fmatch%2Fimage.jpg", "'2 cups all-purpose flour', '1 teaspoon baking soda', '� teaspoon salt', '� cup butter', '� cup brown sugar', '2 eggs, beaten', ' cups mashed overripe bananas']", false, "https://www.allrecipes.com/recipe/20144/banana-banana-bread/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Banana Chocolate Chip Bread", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F4516795.jpg", "'2 cups all-purpose flour', '1 teaspoon baking powder', '1 teaspoon baking soda', '1 teaspoon salt', '3 ripe bananas, mashed', '1 tablespoon milk', '1 teaspoon ground cinnamon, or to taste', '� cup butter, softened', '1 cup white sugar', '2 eggs', '1 cup semisweet chocolate chips']", false, "https://www.allrecipes.com/recipe/230482/banana-chocolate-chip-bread/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Banana Cream Pie I", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F3355919.jpg", "'� cup white sugar', ' cup all-purpose flour', '� teaspoon salt', '2 cups milk', '3 egg yolks, beaten', '2 tablespoons butter', '� teaspoons vanilla extract', '1 (9 inch) baked pastry shell, cooled', '4 bananas, sliced']", false, "https://www.allrecipes.com/recipe/12151/banana-cream-pie-i/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Baked Macaroni and Cheese", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F964194.jpg", "'1 (12 ounce) package macaroni', '1 egg', '2 cups milk', '2 tablespoons butter, melted', '� cups shredded Cheddar cheese', 'salt and pepper to taste']", false, "https://www.allrecipes.com/recipe/14140/baked-macaroni-and-cheese/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Banana Muffins II", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F187952.jpg", "'� cups all-purpose flour', '1 teaspoon baking powder', '1 teaspoon baking soda', '� teaspoon salt', '3 large bananas, mashed', '� cup white sugar', '1 egg', ' cup butter, melted']", false, "https://www.allrecipes.com/recipe/42719/banana-muffins-ii/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Banh Mi", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F1039590.jpg", "'� cup rice vinegar', '� cup water', '� cup white sugar', '� cup carrot, cut into 1/16-inch-thick matchsticks', '� cup white (daikon) radish, cut into 1/16-inch-thick matchsticks', '� cup thinly sliced white onion', '1 skinless, boneless chicken breast half', 'garlic salt to taste', 'ground black pepper to taste', '1 (12 inch) French baguette', '4 tablespoons mayonnaise', '� cup thinly sliced cucumber ', '1 tablespoon fresh cilantro leaves', '1 small jalapeno pepper - seeded and cut into 1/16-inch-thick matchsticks', '1 wedge lime']", false, "https://www.allrecipes.com/recipe/187342/banh-mi/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Barbie's Tuna Salad", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fcf-images.us-east-1.prod.boltdns.net%2Fv1%2Fstatic%2F1033249144001%2Ffa383c3f-bfcc-47d0-87e5-f197595b5cd7%2Fb77f7b21-3718-4917-bd9d-80f8daf18061%2F1280x720%2Fmatch%2Fimage.jpg", "'1 (7 ounce) can white tuna, drained and flaked', '6 tablespoons mayonnaise or salad dressing', '3 tablespoons sweet pickle relish', '1 tablespoon Parmesan cheese', ' teaspoon dried minced onion flakes', '1 tablespoon dried parsley', '1 teaspoon dried dill weed', '� teaspoon curry powder', '1 pinch garlic powder']", false, "https://www.allrecipes.com/recipe/98579/barbies-tuna-salad/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Basic Biscuits", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F4471846.jpg", "'2 cups all-purpose flour', '1 tablespoon baking powder', '� teaspoon salt', '� cup shortening', '� cup milk']", false, "https://www.allrecipes.com/recipe/20075/basic-biscuits/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Basic Chicken Salad", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F1105316.jpg", "'� cup mayonnaise', '1 tablespoon lemon juice', '� teaspoon ground black pepper', '2 cups chopped, cooked chicken meat', '� cup blanched slivered almonds', '1 stalk celery, chopped']", false, "https://www.allrecipes.com/recipe/8499/basic-chicken-salad/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Basic Cream Cheese Frosting", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F5348159.jpg", "'� cup butter, softened', '8 ounces cream cheese', \"4 cups confectioners' sugar\", '2 teaspoons vanilla extract']", false, "https://www.allrecipes.com/recipe/8379/basic-cream-cheese-frosting/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Basic Crepes", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F1266.jpg", "'1 cup all-purpose flour', '2 eggs', '� cup milk', '� cup water', '� teaspoon salt', '2 tablespoons butter, melted']", false, "https://www.allrecipes.com/recipe/16383/basic-crepes/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Basic Italian Bean Soup", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F1938306.jpg", "'olive oil', '1 large onion, diced', '2 cloves garlic, or more to taste', '2 cups tomato sauce', '24 ounces prepared cannellini beans', '1 tablespoon dried basil', '� teaspoon oregano', 'salt and ground black pepper to taste']", false, "https://www.allrecipes.com/recipe/237568/basic-italian-bean-soup/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Basic Mashed Potatoes", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F5294868.jpg", "'2 pounds baking potatoes, peeled and quartered', '2 tablespoons butter', '1 cup milk', 'salt and pepper to taste']", false, "https://www.allrecipes.com/recipe/24771/basic-mashed-potatoes/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Beef Au Jus", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F875885.jpg", "'� cup beef fat drippings from a prime rib or other roast beef (see footnote)', '� tablespoons all-purpose flour', '2 cups beef broth', 'salt and ground black pepper to taste']", false, "https://www.allrecipes.com/recipe/221957/beef-au-jus/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Banana Pancakes I", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F708583.jpg", "'1 cup all-purpose flour', '1 tablespoon white sugar', '2 teaspoons baking powder', '� teaspoon salt', '1 egg, beaten', '1 cup milk', '2 tablespoons vegetable oil', '2 ripe bananas, mashed']", false, "https://www.allrecipes.com/recipe/20334/banana-pancakes-i/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Asian Salad", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F1655196.jpg", "'2 (3 ounce) packages ramen noodles, crushed', '1 cup blanched slivered almonds', '2 teaspoons sesame seeds', '� cup butter, melted', '1 head napa cabbage, shredded', '1 bunch green onions, chopped', '� cup vegetable oil', '� cup distilled white vinegar', '� cup white sugar', '2 tablespoons soy sauce']", false, "https://www.allrecipes.com/recipe/11925/asian-salad/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Baked Mac and Cheese with Sour Cream and Cottage Cheese", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F8006918.jpg", "'cooking spray', '1 (16 ounce) package elbow macaroni', '2 (8 ounce) packages mild Cheddar cheese, shredded, divided', '1 (8 ounce) package sharp Cheddar cheese, shredded', '� cup sour cream', '� cup cottage cheese', '1 egg', 'salt and ground black pepper to taste']", false, "https://www.allrecipes.com/recipe/229815/baked-mac-and-cheese-with-sour-cream-and-cottage-cheese/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Baked Kale Chips", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F7736175.jpg", "'1 bunch kale', '1 tablespoon olive oil', '1 teaspoon seasoned salt']", false, "https://www.allrecipes.com/recipe/176957/baked-kale-chips/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Authentic Italian Rice Pudding", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F1827006.jpg", "'6 cups whole milk', '� cup Arborio rice', '� cup white sugar, divided', '1 teaspoon vanilla extract', '� teaspoon salt', '2 eggs', '2 egg yolks', '1 cup heavy whipping cream']", false, "https://www.allrecipes.com/recipe/262724/authentic-italian-rice-pudding/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Authentic Louisiana Red Beans and Rice", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F6277719.jpg", "'1 pound dry kidney beans', '� cup olive oil', '1 large onion, chopped', '1 green bell pepper, chopped', '2 tablespoons minced garlic', '2 stalks celery, chopped', '6 cups water', '2 bay leaves', '� teaspoon cayenne pepper', '1 teaspoon dried thyme', '� teaspoon dried sage', '1 tablespoon dried parsley', '1 teaspoon Cajun seasoning', '1 pound andouille sausage, sliced', '4 cups water', '2 cups long grain white rice']", false, "https://www.allrecipes.com/recipe/58211/authentic-louisiana-red-beans-and-rice/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Authentic Pho", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F1120315.jpg", "'4 pounds beef soup bones', '1 onion, unpeeled and cut in half', '5 slices fresh ginger', '1 tablespoon salt', '2 pods star anise', '� tablespoons fish sauce', '4 quarts water', '1 (8 ounce) package dried rice noodles', '� pounds beef top sirloin, thinly sliced', '� cup chopped cilantro', '1 tablespoon chopped green onion', '� cups bean sprouts', '1 bunch Thai basil', '1 lime, cut into 4 wedges', '� cup hoisin sauce', '� cup chile-garlic sauce (such as Sriracha)']", false, "https://www.allrecipes.com/recipe/228443/authentic-pho/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Avocado Soup with Chicken and Lime", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F368123.jpg", "'4 (6 inch) corn tortillas, julienned', '� tablespoons olive oil', '1 white onion, sliced thinly', '8 cloves garlic, thinly sliced', '4 fresh jalapeno peppers, sliced', '8 ounces skinless, boneless chicken breast halves - cut into thin strips', '1 quart chicken broth', '� cup fresh lime juice', '1 tomato, seeded and diced', 'salt and ground black pepper to taste', '1 avocado - peeled, pitted and diced', '� cup chopped fresh cilantro']", false, "https://www.allrecipes.com/recipe/20809/avocado-soup-with-chicken-and-lime/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Awesome Pasta Salad", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F1282511.jpg", "'1 (16 ounce) package fusilli (spiral) pasta', '3 cups cherry tomatoes, halved', '� pound provolone cheese, cubed', '� pound salami, cubed', '� pound sliced pepperoni, cut in half', '1 large green bell pepper, cut into 1 inch pieces', '1 (10 ounce) can black olives, drained', '1 (4 ounce) jar pimentos, drained', '1 (8 ounce) bottle Italian salad dressing']", false, "https://www.allrecipes.com/recipe/52734/awesome-pasta-salad/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Awesome Red Wine Pot Roast", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F597886.jpg", "'3 pounds boneless beef chuck roast', '2 tablespoons all-purpose flour', '2 tablespoons canola oil', '� cup water', '� cup red wine', '1 teaspoon dried basil', '� teaspoon dried marjoram', '� teaspoon dried thyme', '1 teaspoon salt', '� teaspoon ground black pepper', '1 onion, sliced', '6 red potatoes, washed and halved', '6 carrot, peeled and cut into 2-inch lengths', '8 pearl onions, peeled and halved ']", false, "https://www.allrecipes.com/recipe/162091/awesome-red-wine-pot-roast/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Awesome Sausage, Apple and Cranberry Stuffing", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F764614.jpg", "'� cups cubed whole wheat bread', '� cups cubed white bread', '1 pound ground turkey sausage', '1 cup chopped onion', '� cup chopped celery', '� teaspoons dried sage', '� teaspoons dried rosemary', '� teaspoon dried thyme', '1 Golden Delicious apple, cored and chopped', '� cup dried cranberries', ' cup minced fresh parsley', '1 cooked turkey liver, finely chopped', '� cup turkey stock', '4 tablespoons unsalted butter, melted']", false, "https://www.allrecipes.com/recipe/13651/awesome-sausage-apple-and-cranberry-stuffing/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Bacon and Date Appetizer", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F695887.jpg", "'1 (8 ounce) package pitted dates', '4 ounces almonds', '1 pound sliced bacon']", false, "https://www.allrecipes.com/recipe/22694/bacon-and-date-appetizer/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Bacon and Egg Tacos", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F4484963.jpg", "'6 eggs', '� cup crumbled cooked bacon', '2 tablespoons butter', '3 slices American cheese, diced', '� teaspoon salt', '� teaspoon ground black pepper', '6 flour tortillas', '1 cup salsa']", false, "https://www.allrecipes.com/recipe/245713/bacon-and-egg-tacos/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Baked Mac and Cheese for One", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F4516736.jpg", "'3 tablespoons uncooked macaroni pasta', '1 tablespoon butter', '1 tablespoon all-purpose flour', '� teaspoon salt', '1 pinch pepper', ' teaspoon onion powder', '� cup milk', ' cup shredded Cheddar cheese', ' teaspoon ground mustard', '1 dash Worcestershire sauce', '1 dash hot sauce', '1 teaspoon bread crumbs', '1 tablespoon shredded Cheddar cheese']", false, "https://www.allrecipes.com/recipe/70012/baked-mac-and-cheese-for-one/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Bacon for the Family or a Crowd", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F666312.jpg", "'1 pound thick sliced bacon']", false, "https://www.allrecipes.com/recipe/158727/bacon-for-the-family-or-a-crowd/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Bacon-Wrapped Jalapeno Poppers", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F1126580.jpg", "'� cup cream cheese', '� cup shredded sharp Cheddar cheese', '12 jalapeno peppers, halved lengthwise, seeds and membranes removed', '12 slices bacon']", false, "https://www.allrecipes.com/recipe/233603/bacon-wrapped-jalapeno-poppers/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Bacon-Wrapped Turkey Meatballs", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F8580220.jpg", "'cooking spray', '1 pound ground turkey', '� cup bread crumbs', '1 large egg', '� cup finely chopped onion', '2 cloves garlic, minced', '� teaspoon salt', '� teaspoon ground black pepper', '8 slices bacon, cut in half', '16 toothpicks', '� cup teriyaki sauce, or more to taste']", false, "https://www.allrecipes.com/recipe/281724/bacon-wrapped-turkey-meatballs/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Baked BBQ Baby Back Ribs", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F3789556.jpg", "'� cup ancho chile powder', '� cup white sugar', '� cup brown sugar', '� cup salt', '2 tablespoons freshly ground black pepper', '1 tablespoon ground cumin', '1 teaspoon dry mustard', '1 teaspoon ground cayenne pepper', '� teaspoon ground dried chipotle pepper', '1 rack baby back pork ribs', '1 cup barbeque sauce']", false, "https://www.allrecipes.com/recipe/220987/baked-bbq-baby-back-ribs/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Baked Butternut Squash", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F1070738.jpg", "'1 butternut squash, halved lengthwise and seeded', 'water', '1 tablespoon butter, divided', 'salt and ground black pepper to taste']", false, "https://www.allrecipes.com/recipe/159433/baked-butternut-squash/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Baked Chicken Wings", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F4496634.jpg", "'3 tablespoons olive oil', '3 cloves garlic, pressed', '2 teaspoons chili powder', '1 teaspoon garlic powder', 'salt and ground black pepper to taste', '10 chicken wings']", false, "https://www.allrecipes.com/recipe/187822/baked-chicken-wings/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Baked Garlic Parmesan Chicken", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F618489.jpg", "'2 tablespoons olive oil', '1 clove garlic, minced', '1 cup dry bread crumbs', ' cup grated Parmesan cheese', '1 teaspoon dried basil leaves', '� teaspoon ground black pepper', '6 skinless, boneless chicken breast halves']", false, "https://www.allrecipes.com/recipe/55860/baked-garlic-parmesan-chicken/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Baked Haddock", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F5406263.jpg", "'� cup milk', '2 teaspoons salt', '� cup bread crumbs', '� cup grated Parmesan cheese', '� teaspoon ground dried thyme', '4 haddock fillets', '� cup butter, melted']", false, "https://www.allrecipes.com/recipe/100195/baked-haddock/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Baked Ham and Cheese Party Sandwiches", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F4502246.jpg", "'� cup melted butter', '� tablespoons Dijon mustard', '� teaspoons Worcestershire sauce', '� tablespoons poppy seeds', '1 tablespoon dried minced onion', '24 mini sandwich rolls', '1 pound thinly sliced cooked deli ham', '1 pound thinly sliced Swiss cheese']", false, "https://www.allrecipes.com/recipe/216756/baked-ham-and-cheese-party-sandwiches/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Baked Homemade Macaroni and Cheese", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F2588250.jpg", "'� cups elbow macaroni', '� cup butter', '� cup all-purpose flour', '� teaspoon salt', '4 cups milk', '1 pound shredded Cheddar cheese', '� cup butter, melted', '1 sleeve buttery round crackers, crushed']", false, "https://www.allrecipes.com/recipe/102393/baked-homemade-macaroni-and-cheese/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Bacon Ranch Pasta Salad", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F580466.jpg", "'1 (12 ounce) package uncooked tri-color rotini pasta', '10 slices bacon', '1 cup mayonnaise', '3 tablespoons dry ranch salad dressing mix', '� teaspoon garlic powder', '� teaspoon garlic pepper', '� cup milk, or as needed', '1 large tomato, chopped', '1 (4.25 ounce) can sliced black olives', '1 cup shredded sharp Cheddar cheese']", false, "https://www.allrecipes.com/recipe/69226/bacon-ranch-pasta-salad/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Chewy Peanut Butter Brownies", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F3210808.jpg", "'� cup peanut butter', ' cup margarine, softened', ' cup white sugar', '� cup packed brown sugar', '2 egg', '� teaspoon vanilla extract', '1 cup all-purpose flour', '1 teaspoon baking powder', '� teaspoon salt']", false, "https://www.allrecipes.com/recipe/11504/chewy-peanut-butter-brownies/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Chewy Peanut Butter Chocolate Chip Cookies", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F46624.jpg", "'� cup butter, softened', '� cup peanut butter', '1 cup packed brown sugar', '� cup white sugar', '2 eggs', '2 tablespoons light corn syrup', '2 tablespoons water', '2 teaspoons vanilla extract', '� cups all-purpose flour', '1 teaspoon baking soda', '� teaspoon salt', '2 cups chopped semisweet chocolate']", false, "https://www.allrecipes.com/recipe/9996/chewy-peanut-butter-chocolate-chip-cookies/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Chicago-Inspired Italian Beef Sandwich", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F1100724.jpg", "'� pounds boneless beef chuck, cut into 2-inch pieces', 'salt and ground black pepper to taste', '1 tablespoon vegetable oil', '6 cloves garlic, sliced', '2 tablespoons white vinegar', '1 tablespoon dried oregano', '� teaspoons salt, or to taste', '1 teaspoon dried thyme', '1 teaspoon dried rosemary', '1 teaspoon freshly ground black pepper', '1 bay leaf', '� teaspoon red pepper flakes, or to taste', '3 cups chicken broth, or as needed', '4 ciabatta rolls, sliced in half', '1 cup chopped giardiniera (pickled Italian vegetables)', '2 teaspoons chopped fresh flat-leaf parsley']", false, "https://www.allrecipes.com/recipe/236322/chicago-inspired-italian-beef-sandwich/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Freekeh Salad with Tahini Dressing", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F6286290.jpg", "'1 cup freekeh', '2 cups chicken broth', '3 tablespoons apple cider vinegar', '1 tablespoon tahini', '1 teaspoon honey', '2 tablespoons olive oil', 'salt and ground black pepper to taste', '� cup pomegranate seeds', '� cup red onion, minced', '2 tablespoons minced fresh mint', '2 tablespoons minced fresh parsley', '� cup crushed pistachios']", false, "https://www.allrecipes.com/recipe/270199/freekeh-salad-with-tahini-dressing/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "French Onion-Breaded Baked Chicken", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F8125095.jpg", "'1 cup bread crumbs', '1 (1 ounce) package dry French onion soup mix', ' cup mayonnaise', '1 tablespoon garlic paste', '4 skinless, boneless chicken breasts']", false, "https://www.allrecipes.com/recipe/280018/french-onion-breaded-baked-chicken/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "French Pastry Pie Crust", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F117975.jpg", "'3 cups all-purpose flour', '� teaspoons salt', '3 tablespoons white sugar', '1 cup shortening', '1 egg', '1 teaspoon distilled white vinegar', '5 tablespoons water']", false, "https://www.allrecipes.com/recipe/15075/french-pastry-pie-crust/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "French Spring Soup", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F579198.jpg", "'� cup butter', '1 pound leeks, chopped', '1 onion, chopped', '2 quarts water', '3 large potatoes, chopped', '2 large carrots, chopped', '1 bunch fresh asparagus, trimmed and cut into 1 inch pieces', ' cup uncooked long-grain white rice', '4 teaspoons salt', '� pound fresh spinach', '1 cup heavy cream']", false, "https://www.allrecipes.com/recipe/50030/french-spring-soup/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "French Toast I", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F234562.jpg", "'6 thick slices bread', '2 eggs', ' cup milk', '� teaspoon ground cinnamon', '� teaspoon ground nutmeg', '1 teaspoon vanilla extract', 'salt to taste']", false, "https://www.allrecipes.com/recipe/7016/french-toast-i/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Fresh Broccoli Salad", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F4550791.jpg", "'2 heads fresh broccoli', '1 red onion', '� pound bacon', '� cup raisins', '� cup sliced almonds', '1 cup mayonnaise', '� cup white sugar', '2 tablespoons white wine vinegar']", false, "https://www.allrecipes.com/recipe/14280/fresh-broccoli-salad/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Fried Cabbage with Bacon, Onion, and Garlic", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F230003.jpg", "'6 slices bacon, chopped', '1 large onion, diced', '2 cloves garlic, minced', '1 large head cabbage, cored and sliced', '1 tablespoon salt, or to taste', '1 teaspoon ground black pepper', '� teaspoon onion powder', '� teaspoon garlic powder', ' teaspoon paprika']", false, "https://www.allrecipes.com/recipe/196732/fried-cabbage-with-bacon-onion-and-garlic/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Fried Mac and Cheese Balls", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F231432.jpg", "'1 (7.25 ounce) package macaroni and cheese mix ', '2 tablespoons butter', '� cup milk', '1 cup shredded Cheddar cheese', '� cup pimento cheese spread', '1 cup shredded Italian cheese blend', '2 cups Italian seasoned bread crumbs', '� teaspoon paprika', '� teaspoon chili powder', '� teaspoon ground black pepper', '� teaspoon white sugar', '� teaspoon salt', '1 pinch cayenne pepper, or to taste', '4 eggs', '3 tablespoons milk', '4 cups peanut oil for frying, or as needed']", false, "https://www.allrecipes.com/recipe/186033/fried-mac-and-cheese-balls/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Fried Mozzarella Cheese Sticks", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F462522.jpg", "'2 eggs, beaten', '� cup water', '� cups Italian seasoned bread crumbs', '� teaspoon garlic salt', ' cup all-purpose flour', ' cup cornstarch', '1 quart oil for deep frying', '1 (16 ounce) package mozzarella cheese sticks']", false, "https://www.allrecipes.com/recipe/23596/fried-mozzarella-cheese-sticks/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Four-Cheese Truffled Macaroni and Cheese", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F1490044.jpg", "'1 (16 ounce) package cavatappi (corkscrew macaroni)', '6 tablespoons butter', '� cup flour', '5\\u2009� cups milk, divided', '� cups shredded smoked Gouda cheese', '2 cups shredded sharp Cheddar cheese', '� cups shredded Swiss cheese', '� cups grated Parmesan cheese, divided', '� cup dry bread crumbs', '1 tablespoon truffle oil']", false, "https://www.allrecipes.com/recipe/239287/four-cheese-truffled-macaroni-and-cheese/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Fried Rice Restaurant Style", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F3770230.jpg", "'2 cups enriched white rice', '4 cups water', ' cup chopped baby carrots', '� cup frozen green peas', '2 tablespoons vegetable oil', '2 eggs', 'soy sauce to taste', '2 tablespoons sesame oil, to taste']", false, "https://www.allrecipes.com/recipe/79543/fried-rice-restaurant-style/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Garden Fresh Tomato Soup", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F1869714.jpg", "'4 cups chopped fresh tomatoes', '1 slice onion', '4 whole cloves', '2 cups chicken broth', '2 tablespoons butter', '2 tablespoons all-purpose flour', '1 teaspoon salt', '2 teaspoons white sugar, or to taste']", false, "https://www.allrecipes.com/recipe/39544/garden-fresh-tomato-soup/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Garlic Aioli", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F1353706.jpg", "'� cup mayonnaise', '3 cloves garlic, minced', '� tablespoons lemon juice', '� teaspoon salt', '� teaspoon ground black pepper']", false, "https://www.allrecipes.com/recipe/213608/garlic-aioli/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Garlic Butter", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F5221403.jpg", "'1 cup butter, softened', '1 tablespoon minced garlic', '� cup grated Parmesan cheese', '1 tablespoon garlic salt', '1 teaspoon Italian seasoning', '� teaspoon ground black pepper', '� teaspoon ground paprika']", false, "https://www.allrecipes.com/recipe/36925/garlic-butter/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Garlic Mashed Cauliflower", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F1014180.jpg", "'1 head cauliflower, cut into florets', '1 tablespoon olive oil', '1 clove garlic, smashed', '� cup grated Parmesan cheese', '1 tablespoon reduced-fat cream cheese', '� teaspoon kosher salt', ' teaspoon freshly ground black pepper']", false, "https://www.allrecipes.com/recipe/230816/garlic-mashed-cauliflower/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Garlic Naan", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F6703829.jpg", "'� cup warm water', '1 teaspoon white sugar', '1 (.25 ounce) package active dry yeast', '� cup butter', '2 cloves garlic, minced', '� cup plain yogurt', '2 cups bread flour, or more as needed', '1 teaspoon kosher salt', '� cup chopped cilantro']", false, "https://www.allrecipes.com/recipe/270860/garlic-naan/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Garlicky Appetizer Shrimp Scampi", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F945189.jpg", "'6 tablespoons unsalted butter, softened', '� cup olive oil', '1 tablespoon minced garlic', '1 tablespoon minced shallots', '2 tablespoons minced fresh chives', 'salt and freshly ground black pepper to taste', '� teaspoon paprika', '2 pounds large shrimp - peeled and deveined']", false, "https://www.allrecipes.com/recipe/16679/garlicky-appetizer-shrimp-scampi/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Gemelli Pasta with Roasted Pumpkin and Pancetta", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F7167605.jpg", "'2 cups peeled, cubed pumpkin', '2 tablespoons extra-virgin olive oil, divided', '1 teaspoon fresh thyme', '� teaspoon salt', ' teaspoon ground black pepper', '� (16 ounce) package gemelli pasta', '1 (4 ounce) package diced pancetta', '1 cup chicken broth', '� cup grated Parmigiano-Reggiano cheese  ']", false, "https://www.allrecipes.com/recipe/276904/gemelli-pasta-with-roasted-pumpkin-and-pancetta/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "German Apple Cake I", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F2327614.jpg", "'2 eggs', '1 cup vegetable oil', '2 cups white sugar', '2 teaspoons ground cinnamon', '� teaspoon salt', '1 teaspoon vanilla extract', '2 cups all-purpose flour', '1 teaspoon baking soda', '4 cups apples - peeled, cored and diced']", false, "https://www.allrecipes.com/recipe/7915/german-apple-cake-i/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "German Spaetzle Dumplings", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F1658933.jpg", "'1 cup all-purpose flour', '� cup milk', '2 eggs', '� teaspoon ground nutmeg', '1 pinch freshly ground white pepper', '� teaspoon salt', '1 gallon hot water', '2 tablespoons butter', '2 tablespoons chopped fresh parsley']", false, "https://www.allrecipes.com/recipe/11793/german-spaetzle-dumplings/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Frog Eye Salad", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F194018.jpg", "'1 cup white sugar', '2 tablespoons all-purpose flour', '� teaspoons salt', '� cups unsweetened pineapple juice', '2 eggs, beaten', '1 tablespoon lemon juice', '3 quarts water', '1 tablespoon vegetable oil', '1 (16 ounce) package acini di pepe pasta', '3 (11 ounce) cans mandarin oranges, drained', '2 (20 ounce) cans pineapple tidbits, drained', '1 (20 ounce) can crushed pineapple, drained', '1 (8 ounce) container frozen whipped topping, thawed', '1 cup miniature marshmallows', '1 cup shredded coconut']", false, "https://www.allrecipes.com/recipe/14439/frog-eye-salad/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Gina's Italian Butter Cookies", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F2061923.jpg", "'� cups cake flour', '� cups all-purpose flour', '� teaspoons baking powder', '1 teaspoon salt', '1 cup unsalted butter, softened', '1 cup white sugar', '� cup vegetable shortening', '4 ounces almond paste', '2 large eggs', '2 teaspoons vanilla extract', '1 teaspoon lemon juice', '� teaspoon almond extract']", false, "https://www.allrecipes.com/recipe/279153/ginas-italian-butter-cookies/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Fondant Potatoes", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F7186573.jpg", "'3 large whole russet potatoes', '2 tablespoons high-heat-resistant vegetable oil, such as grapeseed oil', 'salt and ground black pepper to taste', '3 tablespoons butter', '4 sprigs thyme, plus more for garnish', '� cup chicken broth, or more as needed']", false, "https://www.allrecipes.com/recipe/233295/fondant-potatoes/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Favorite Old Fashioned Gingerbread", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F4558051.jpg", "'� cup white sugar', '� cup butter', '1 egg', '1 cup molasses', '� cups all-purpose flour', '� teaspoons baking soda', '1 teaspoon ground cinnamon', '1 teaspoon ground ginger', '� teaspoon ground cloves', '� teaspoon salt', '1 cup hot water']", false, "https://www.allrecipes.com/recipe/7322/favorite-old-fashioned-gingerbread/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Easy Sausage Gravy and Biscuits", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F571726.jpg", "'1 (16 ounce) can refrigerated jumbo buttermilk biscuits', '1 (9.6 ounce) package Jimmy Dean Original Hearty Pork Sausage Crumbles', '� cup flour', '� cups milk', 'Salt and ground black pepper to taste']", false, "https://www.allrecipes.com/recipe/216391/easy-sausage-gravy-and-biscuits/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Easy Shakshuka", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F405109.jpg", "'1 tablespoon olive oil', '2 cloves garlic, minced', '1 onion, cut into 2 inch pieces', '1 green bell pepper, cut into 2 inch pieces', '1 (28 ounce) can whole peeled plum tomatoes with juice', '1 teaspoon paprika, or to taste', '2 slices pickled jalapeno pepper, finely chopped', '4 eggs', '4 (6 inch) pita bread']", false, "https://www.allrecipes.com/recipe/190276/easy-shakshuka/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Easy Slow Cooker French Dip", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F10316.jpg", "'4 pounds rump roast', '1 (10.5 ounce) can beef broth', '1 (10.5 ounce) can condensed French onion soup', '1 (12 fluid ounce) can or bottle beer', '6 French rolls', '2 tablespoons butter']", false, "https://www.allrecipes.com/recipe/16239/easy-slow-cooker-french-dip/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Easy Sugar Cookies", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fcf-images.us-east-1.prod.boltdns.net%2Fv1%2Fstatic%2F1033249144001%2F92613e3b-5dc0-4beb-a92e-ef11b46d0c37%2F798d87b1-055c-4394-aa01-a67a2d8c63d0%2F1280x720%2Fmatch%2Fimage.jpg", "'� cups all-purpose flour', '1 teaspoon baking soda', '� teaspoon baking powder', '1 cup butter, softened', '� cups white sugar', '1 egg', '1 teaspoon vanilla extract']", false, "https://www.allrecipes.com/recipe/9870/easy-sugar-cookies/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Easy Tamale Casserole", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F1929986.jpg", "'1 pound ground beef', '� teaspoon salt', '� teaspoon ground black pepper', '1 small onion, chopped', '2 (15 ounce) cans pinto beans, rinsed and drained', '2 (15 ounce) cans crushed tomatoes', '1 (15 ounce) can cream-style corn', '1 (6 ounce) box cornbread mix', '1 egg, lightly beaten', '1 cup shredded Cheddar cheese']", false, "https://www.allrecipes.com/recipe/237983/easy-tamale-casserole/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Easy Tuna Casserole", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F4560684.jpg", "'3 cups cooked macaroni', '1 (5 ounce) can tuna, drained', '1 (10.75 ounce) can  condensed cream of chicken soup', '1 cup shredded Cheddar cheese', '� cups French fried onions']", false, "https://www.allrecipes.com/recipe/18871/easy-tuna-casserole/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Easy Tuna Pasta Salad", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F8023490.jpg", "'1 (16 ounce) package cavatappi (corkscrew macaroni)', '1 cup mayonnaise', '3 tablespoons lemon juice', '2 tablespoons honey', '� tablespoon garlic powder', 'salt and ground black pepper to taste', '2 (8 ounce) cans tuna, drained', '3 stalks celery, sliced', '1 red onion, diced', '1 cup peas', '� cup chopped fresh parsley', '� cup chopped green olives', '1 teaspoon lemon juice, or to taste', '4 hard-boiled eggs, halved']", false, "https://www.allrecipes.com/recipe/279892/easy-tuna-pasta-salad/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Easy Tuna Patties", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F1031128.jpg", "'2 eggs', '2 teaspoons lemon juice', '3 tablespoons grated Parmesan cheese', '10 tablespoons Italian-seasoned bread crumbs', '3 (5 ounce) cans tuna, drained', '3 tablespoons diced onion', '1 pinch ground black pepper', '3 tablespoons vegetable oil']", false, "https://www.allrecipes.com/recipe/230857/easy-tuna-patties/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Easy Turkey Tetrazzini", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F3510581.jpg", "'1 (8 ounce) package cooked egg noodles', '2 tablespoons butter', '1 (6 ounce) can sliced mushrooms', '1 teaspoon salt', ' teaspoon pepper', '2 cups chopped cooked turkey', '1 (10.75 ounce) can  condensed cream of celery soup', '1 cup sour cream', '� cup grated Parmesan cheese']", false, "https://www.allrecipes.com/recipe/37784/easy-turkey-tetrazzini/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Fluffy Pancakes", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F5079227.jpg", "'� cup milk', '2 tablespoons white vinegar', '1 cup all-purpose flour', '2 tablespoons white sugar', '1 teaspoon baking powder', '� teaspoon baking soda', '� teaspoon salt', '1 egg', '2 tablespoons butter, melted', 'cooking spray']", false, "https://www.allrecipes.com/recipe/162760/fluffy-pancakes/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Easy, Chewy Flourless Peanut Butter Cookies", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F2271991.jpg", "'1 cup peanut butter', '� cup white sugar', ' cup packed brown sugar', '1 egg', '1 teaspoon vanilla extract', '� teaspoon baking soda', '� cup semisweet chocolate chips']", false, "https://www.allrecipes.com/recipe/242366/easy-chewy-flourless-peanut-butter-cookies/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Egg Noodles", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F1989796.jpg", "'� cups all-purpose flour', '1 pinch salt', '2 eggs, beaten', '� cup milk', '1 tablespoon butter']", false, "https://www.allrecipes.com/recipe/11991/egg-noodles/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Eggplant Parmesan II", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F5068161.jpg", "'3 eggplant, peeled and thinly sliced', '2 eggs, beaten', '4 cups Italian seasoned bread crumbs', '6 cups spaghetti sauce, divided', '1 (16 ounce) package mozzarella cheese, shredded and divided', '� cup grated Parmesan cheese, divided', '� teaspoon dried basil']", false, "https://www.allrecipes.com/recipe/25321/eggplant-parmesan-ii/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Eggs Benedict Casserole", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F3518037.jpg", "'cooking spray', '8 large eggs', '2 cups milk', '3 green onions, chopped', '1 teaspoon onion powder', '1 teaspoon salt', '� pound Canadian bacon, cut into 1/2-inch dice', '6 English muffins, cut into 1/2-inch dice', '� teaspoon paprika', '1 (.9 ounce) package hollandaise sauce mix', '1 cup milk', '� cup margarine']", false, "https://www.allrecipes.com/recipe/221988/eggs-benedict-casserole/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Emily's Excellent Taco Casserole", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F1411575.jpg", "'6 cups corn tortilla chips', '2 cups vegetarian chili with beans', '1 cup shredded Cheddar cheese', '2 cups shredded lettuce', '2 roma (plum) tomatoes, chopped', '� cup salsa', '� cup sour cream']", false, "https://www.allrecipes.com/recipe/71179/emilys-excellent-taco-casserole/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Emily's Famous Hash Browns", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F801447.jpg", "'2 medium russet potatoes, shredded', '� medium onion, finely chopped', '� cup all-purpose flour', '1 egg', '1 cup oil for frying, or as needed', 'salt and pepper to taste']", false, "https://www.allrecipes.com/recipe/57783/emilys-famous-hash-browns/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Extreme Banana Nut Bread 'EBNB'", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F1392234.jpg", "'2 cups all-purpose flour', '1 teaspoon salt', '2 teaspoons baking soda', '1 cup butter or margarine', '2 cups white sugar', '2 cups mashed overripe bananas', '4 eggs, beaten', '1 cup chopped walnuts']", false, "https://www.allrecipes.com/recipe/67937/extreme-banana-nut-bread-ebnb/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Extreme Chocolate Cake", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F693494.jpg", "'2 cups white sugar', '� cups all-purpose flour', '� cup unsweetened cocoa powder', '� teaspoons baking soda', '� teaspoons baking powder', '1 teaspoon salt', '2 eggs', '1 cup milk', '� cup vegetable oil', '2 teaspoons vanilla extract', '1 cup boiling water', '� cup butter', '� cups unsweetened cocoa powder', \"5\\u2009 cups confectioners' sugar\", ' cup milk', '1 teaspoon vanilla extract']", false, "https://www.allrecipes.com/recipe/17528/extreme-chocolate-cake/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Fantastic Black Bean Chili", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F1192710.jpg", "'1 tablespoon vegetable oil', '1 onion, diced', '2 cloves garlic, minced', '1 pound ground turkey', '3 (15 ounce) cans black beans, undrained', '1 (14.5 ounce) can crushed tomatoes', '� tablespoons chili powder', '1 tablespoon dried oregano', '1 tablespoon dried basil leaves', '1 tablespoon red wine vinegar']", false, "https://www.allrecipes.com/recipe/23336/fantastic-black-bean-chili/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Farm Fresh Zucchini Cranberry Nut Muffins", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F1029468.jpg", "'6 tablespoons all-purpose flour', '� cup brown sugar', '2 tablespoons butter', '� cup margarine, softened', '1 cup white sugar', '1 egg', '� teaspoons vanilla extract', '� cups all-purpose flour', '� teaspoons baking powder', '� teaspoon baking soda', '� teaspoon salt', '1 cup grated zucchini', '1 cup cranberries', '� cup walnut pieces']", false, "https://www.allrecipes.com/recipe/233429/farm-fresh-zucchini-cranberry-nut-muffins/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Egg Drop Soup (Better than Restaurant Quality!)", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F972459.jpg", "'1 cup chicken broth', '� teaspoon soy sauce', '� teaspoon sesame oil', '1 teaspoon cornstarch', '2 teaspoons water', '1 egg, beaten', '1 drop yellow food coloring', '1 teaspoon chopped fresh chives', ' teaspoon salt', '� teaspoon ground white pepper']", false, "https://www.allrecipes.com/recipe/115965/egg-drop-soup-better-than-restaurant-quality/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Easy Quiche", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F1672261.jpg", "'2 cups milk', '4 eggs', '� cup biscuit baking mix', '� cup butter, softened', '1 cup grated Parmesan cheese', '1 (10 ounce) package chopped frozen broccoli, thawed and drained', '1 cup cubed cooked ham', '8 ounces shredded Cheddar cheese']", false, "https://www.allrecipes.com/recipe/23389/easy-quiche/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Gluten-Free Mac-n-Cheese", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F3603056.jpg", "'12 ounces gluten-free pasta (such as Barilla)', '6 tablespoons butter', '� onion, chopped', '� cup potato starch', '1 (12 fluid ounce) can evaporated milk', '2 cups shredded Cheddar cheese', ' cup mascarpone cheese', '3 dashes hot sauce (such as Tabasco)']", false, "https://www.allrecipes.com/recipe/246771/gluten-free-mac-n-cheese/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Gnocchi I", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F1070416.jpg", "'2 potatoes', '2 cups all-purpose flour', '1 egg']", false, "https://www.allrecipes.com/recipe/18465/gnocchi-i/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Grilled Cheese Sandwich", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F2206436.jpg", "'4 slices white bread', '3 tablespoons butter, divided', '2 slices Cheddar cheese']", false, "https://www.allrecipes.com/recipe/23891/grilled-cheese-sandwich/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Grilled Chicken Salad Sandwich", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F1313977.jpg", "'1 cup mayonnaise', ' teaspoon ground black pepper', ' teaspoon garlic powder', ' teaspoon celery salt', '4 cups chopped leftover grilled chicken', '2 celery stalks, sliced', '� cup sweetened dried cranberries', ' cup salted cashews', '8 slices bread, toasted', '4 tablespoons mayonnaise', '4 large red leaf lettuce leaves', '1 ripe tomato, sliced']", false, "https://www.allrecipes.com/recipe/143587/grilled-chicken-salad-sandwich/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Grilled Chicken Teriyaki Skewers with Miso Ranch", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F6691068.jpg", "'12 bamboo skewers', '2 pounds skinless, boneless chicken thighs', '� cup soy sauce', '� cup sake', ' cup mirin (Japanese sweet wine)', '2 teaspoons finely grated ginger', '2 tablespoons minced green onions', '� cup brown sugar', '1 tablespoon vegetable oil', '� cup mayonnaise', '� cup sour cream', ' cup buttermilk', '1 tablespoon white miso paste, or to taste', '1 tablespoon minced green onion', '1 clove garlic, crushed', '1 tablespoon finely chopped fresh tarragon', '1 tablespoon finely chopped fresh dill', '1 tablespoon finely chopped fresh chives ', 'freshly ground black pepper to taste', '1 pinch cayenne pepper']", false, "https://www.allrecipes.com/recipe/273940/grilled-chicken-teriyaki-skewers-with-miso-ranch/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Grilled Fish Steaks", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F822185.jpg", "'1 clove garlic, minced', '6 tablespoons olive oil', '1 teaspoon dried basil', '1 teaspoon salt', '1 teaspoon ground black pepper', '1 tablespoon fresh lemon juice', '1 tablespoon chopped fresh parsley', '2 (6 ounce) fillets halibut']", false, "https://www.allrecipes.com/recipe/25871/grilled-fish-steaks/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Grilled Salmon I", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F800839.jpg", "'� pounds salmon fillets', 'lemon pepper to taste', 'garlic powder to taste', 'salt to taste', ' cup soy sauce', ' cup brown sugar', ' cup water', '� cup vegetable oil']", false, "https://www.allrecipes.com/recipe/12720/grilled-salmon-i/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Grilled Salmon With Pesto Crust", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F2610671.jpg", "'� cup pine nuts', '� cup coarsely chopped fresh basil', '� cup grated Parmesan cheese', '1 clove garlic, minced', '3 tablespoons extra-virgin olive oil', 'salt and freshly ground black pepper to taste', '1 pound salmon fillet']", false, "https://www.allrecipes.com/recipe/242145/grilled-salmon-with-pesto-crust/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Grilled Steak Tips with Chimichurri", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F3372675.jpg", "'1 pound beef tips, or more to taste', '1 tablespoon canola oil', 'salt and ground black pepper to taste', '1 cup minced flat-leaf parsley', '� cup olive oil', '� cup red wine vinegar', '1 small red onion, minced', '3 cloves garlic, minced', '2 tablespoons pureed chipotle peppers in adobo sauce', '2 tablespoons smoked paprika', '1 tablespoon dried oregano']", false, "https://www.allrecipes.com/recipe/246548/grilled-steak-tips-with-chimichurri/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Ground Turkey Noodle Bake", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F870953.jpg", "'3 cups wide egg noodles', '1 pound ground turkey', '1 onion, chopped', '1 (15 ounce) can tomato sauce', '1 teaspoon Italian seasoning', '� cup milk', '4 ounces cream cheese', '1 tablespoon minced fresh parsley', '1 clove garlic, minced', '� cups shredded part-skim mozzarella cheese']", false, "https://www.allrecipes.com/recipe/222635/ground-turkey-noodle-bake/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Ground Turkey Taco Meat", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F3996791.jpg", "'� tablespoons chili powder', '2 teaspoons ground cumin', '1 teaspoon ground paprika', '1 teaspoon salt', '� teaspoon garlic powder', '� teaspoon onion powder', '� teaspoon dried oregano', '� teaspoon cayenne pepper', '1 (12 ounce) package ground turkey', '� cup water', '1 tablespoon cider vinegar', '� teaspoons brown sugar']", false, "https://www.allrecipes.com/recipe/255545/ground-turkey-taco-meat/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Green Tomato Relish", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F4554361.jpg", "'24 large green tomatoes', '3 red bell peppers, halved and seeded', '3 green bell peppers, halved and seeded', '12 large onions', '3 tablespoons celery seed', '3 tablespoons mustard seed', '1 tablespoon salt', '5 cups white sugar', '2 cups cider vinegar']", false, "https://www.allrecipes.com/recipe/19584/green-tomato-relish/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Guacamole", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F4521556.jpg", "'3 avocados - peeled, pitted, and mashed', '1 lime, juiced', '1 teaspoon salt', '� cup diced onion', '3 tablespoons chopped fresh cilantro', '2 roma (plum) tomatoes, diced', '1 teaspoon minced garlic', '1 pinch ground cayenne pepper']", false, "https://www.allrecipes.com/recipe/14231/guacamole/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Ham and Shell Salad", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F1209491.jpg", "'1 (8 ounce) package medium pasta shells', '1 (10 ounce) package frozen peas, thawed', '� pound deli ham, diced', '1 cup diced Cheddar cheese', '� cup chopped onion', '3 tablespoons mayonnaise', '2 tablespoons vegetable oil', '1 tablespoon lemon juice', '� teaspoon salt', '� teaspoon pepper']", false, "https://www.allrecipes.com/recipe/148470/ham-and-shell-salad/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Ham and Split Pea Soup Recipe - A Great Soup", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F1508123.jpg", "'2 tablespoons butter', '� onion, diced', '2 ribs celery, diced', '3 cloves garlic, sliced', '1 pound ham, diced', '1 bay leaf', '1 pound dried split peas', '1 quart chicken stock', '� cups water', 'salt and ground black pepper to taste']", false, "https://www.allrecipes.com/recipe/219170/ham-and-split-pea-soup-recipe-a-great-soup/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Hamburger Potato Casserole", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F419304.jpg", "'1 pound lean ground beef', '3 cups peeled and thinly sliced potatoes', '1 (10.75 ounce) can  condensed cream of mushroom soup', '� cup chopped onion', '� cup milk', 'salt to taste', 'freshly ground pepper, to taste', '1 cup shredded Cheddar cheese']", false, "https://www.allrecipes.com/recipe/26609/hamburger-potato-casserole/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Hamburger Steak with Onions and Gravy", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F5938981.jpg", "'1 pound ground beef', '1 egg', '� cup bread crumbs', ' teaspoon ground black pepper', '� teaspoon seasoned salt', '� teaspoon onion powder', '� teaspoon garlic powder', '1 teaspoon Worcestershire sauce', '1 tablespoon vegetable oil', '1 cup thinly sliced onion', '2 tablespoons all-purpose flour', '1 cup beef broth', '1 tablespoon cooking sherry', '� teaspoon seasoned salt']", false, "https://www.allrecipes.com/recipe/78370/hamburger-steak-with-onions-and-gravy/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Harvest Walnut Pumpkin Pie", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F7309761.jpg", "'1 (15 ounce) can plain pumpkin puree', '1 (14 ounce) can sweetened condensed milk', '2 eggs', '1 teaspoon maple-flavored extract', '� teaspoon ground cinnamon', '� teaspoon salt', '� teaspoon ground ginger', '� teaspoon ground nutmeg', '1 (9 inch) prepared graham cracker crust', ' cup packed brown sugar', ' cup all-purpose flour', '� teaspoon ground cinnamon', '3 tablespoons butter, cubed', '� cup chopped walnuts']", false, "https://www.allrecipes.com/recipe/268384/harvest-walnut-pumpkin-pie/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Hash Brown and Egg Casserole", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F2331971.jpg", "'1 (2 pound) package frozen hash brown potatoes, thawed', '1 pound pork sausage', '1 small onion, diced', '5 eggs', '� cup milk', '� teaspoon onion powder', ' teaspoon garlic powder', 'salt and ground black pepper to taste', '12 ounces shredded Cheddar cheese']", false, "https://www.allrecipes.com/recipe/87013/hash-brown-and-egg-casserole/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Hasselback Potatoes", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F2918307.jpg", "'4 (8 ounce) baking potatoes', '2 tablespoons butter, melted', 'salt and pepper to taste', '2 tablespoons finely grated fresh Romano cheese', '1 tablespoon seasoned dry bread crumbs']", false, "https://www.allrecipes.com/recipe/79518/hasselback-potatoes/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Healthy Shepherd's Pie with Cauliflower Mash", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F7097339.jpg", "'1 tablespoon avocado oil', '5 cups diced celery', '5 cups finely chopped mushrooms', '� medium onion, diced', '3 pounds lean ground turkey', '1 tablespoon dried parsley', '1 tablespoon dried thyme', '2 teaspoons garlic powder', '1 teaspoon ground black pepper', '� teaspoon crushed red pepper flakes, or to taste', '� teaspoon sea salt', '� cup almond flour', '1 (8 ounce) can low-sodium tomato sauce', '2 medium zucchini, cut into 1/4-inch slices', '4 (10 ounce) packages frozen cauliflower rice (such as Green Giant)', ' cup milk', '2 tablespoons butter, divided', '� teaspoon paprika']", false, "https://www.allrecipes.com/recipe/275901/healthy-shepherds-pie-with-cauliflower-mash/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Heavenly Halibut", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F3767197.jpg", "'� cup grated Parmesan cheese', '� cup butter, softened', '3 tablespoons mayonnaise', '2 tablespoons lemon juice', '3 tablespoons chopped green onions', '� teaspoon salt', '1 dash hot pepper sauce', '2 pounds skinless halibut fillets']", false, "https://www.allrecipes.com/recipe/76659/heavenly-halibut/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Guluptsie (Cabbage Rolls)", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F2023850.jpg", "'2 large heads  cabbage', '2 pounds ground beef', '1 pound sage pork sausage', '� pounds lean ground venison or beef', '2 tablespoons minced garlic, or to taste', '2 large onions, coarsely chopped', '2 cups uncooked white rice', '1 teaspoon red pepper flakes', '2 teaspoons dried dill', 'Salt and pepper to taste', '2 (14.4 ounce) cans whole tomatoes with juice', '2 (15 ounce) cans tomato sauce', '2 cups chicken broth']", false, "https://www.allrecipes.com/recipe/132833/guluptsie-cabbage-rolls/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Gluten-Free Magic Cookie Bars", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F356281.jpg", "'2 cups gluten-free graham cracker crumbs', '� cup butter, melted', '1 (14 ounce) can sweetened condensed milk', '1 (12 ounce) bag semisweet chocolate chips', '1 cup shredded coconut', '� cup chopped pecans']", false, "https://www.allrecipes.com/recipe/261865/gluten-free-magic-cookie-bars/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Greek-Style Lemon Roasted Potatoes", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F1439519.jpg", "'3 pounds potatoes, peeled and cut into thick wedges', ' cup olive oil', '2 lemons, juiced', '2 teaspoons salt', '1 teaspoon oregano', '� teaspoon ground black pepper', '3 cups chicken broth']", false, "https://www.allrecipes.com/recipe/239180/greek-style-lemon-roasted-potatoes/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Greek Pasta Salad I", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F3712162.jpg", "'� cup olive oil', '� cup red wine vinegar', '� teaspoons garlic powder', '� teaspoons dried basil', '� teaspoons dried oregano', '� teaspoon ground black pepper', '� teaspoon white sugar', '� cups cooked elbow macaroni', '3 cups fresh sliced mushrooms', '15 cherry tomatoes, halved', '1 cup sliced red bell peppers', '� cup crumbled feta cheese', '� cup chopped green onions', '1 (4 ounce) can whole black olives', '� cup sliced pepperoni sausage, cut into strips']", false, "https://www.allrecipes.com/recipe/11689/greek-pasta-salad-i/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Golden Sweet Cornbread", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F307059.jpg", "'1 cup all-purpose flour', '1 cup yellow cornmeal', ' cup white sugar', '1 teaspoon salt', '� teaspoons baking powder', '1 egg', '1 cup milk', ' cup vegetable oil']", false, "https://www.allrecipes.com/recipe/17891/golden-sweet-cornbread/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Good New Orleans Creole Gumbo", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F4559744.jpg", "'1 cup all-purpose flour', '� cup bacon drippings', '1 cup coarsely chopped celery', '1 large onion, coarsely chopped', '1 large green bell pepper, coarsely chopped', '2 cloves garlic, minced', '1 pound andouille sausage, sliced', '3 quarts water', '6 cubes beef bouillon', '1 tablespoon white sugar', 'salt to taste', '2 tablespoons hot pepper sauce (such as Tabasco), or to taste', \"� teaspoon Cajun seasoning blend (such as Tony Chachere's), or to taste\", '4 bay leaves', '� teaspoon dried thyme leaves', '1 (14.5 ounce) can stewed tomatoes', '1 (6 ounce) can tomato sauce', '2 teaspoons gumbo file powder', '2 tablespoons bacon drippings', '2 (10 ounce) packages frozen cut okra, thawed', '2 tablespoons distilled white vinegar', '1 pound lump crabmeat', '3 pounds uncooked medium shrimp, peeled and deveined', '2 tablespoons Worcestershire sauce', '2 teaspoons gumbo file powder']", false, "https://www.allrecipes.com/recipe/216888/good-new-orleans-creole-gumbo/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Good Old Fashioned Pancakes", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fcf-images.us-east-1.prod.boltdns.net%2Fv1%2Fstatic%2F1033249144001%2F89f0e8b6-f8aa-42e2-9406-d09467f7cc8b%2Fe5950d79-e79f-44d7-aef3-1eac2e92dad1%2F1280x720%2Fmatch%2Fimage.jpg", "'� cups all-purpose flour', '� teaspoons baking powder', '1 teaspoon salt', '1 tablespoon white sugar', '� cups milk', '1 egg', '3 tablespoons butter, melted']", false, "https://www.allrecipes.com/recipe/21014/good-old-fashioned-pancakes/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Gooey Butter Cake III", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F1105575.jpg", "'1 (18.25 ounce) package yellow cake mix', '� cup butter, melted', '2 eggs', '1 teaspoon vanilla extract', '1 (8 ounce) package cream cheese', '2 eggs', '1 teaspoon vanilla extract', \"4 cups confectioners' sugar\"]", false, "https://www.allrecipes.com/recipe/8088/gooey-butter-cake-iii/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Gourmet Mushroom Risotto", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F246711.jpg", "'6 cups chicken broth, divided', '3 tablespoons olive oil, divided', '1 pound portobello mushrooms, thinly sliced', '1 pound white mushrooms, thinly sliced', '2 shallots, diced', '� cups Arborio rice', '� cup dry white wine', 'sea salt to taste', 'freshly ground black pepper to taste', '3 tablespoons finely chopped chives', '4 tablespoons butter', ' cup freshly grated Parmesan cheese']", false, "https://www.allrecipes.com/recipe/85389/gourmet-mushroom-risotto/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Graham Cracker Crust I", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F3181898.jpg", "'� cups finely ground graham cracker crumbs', ' cup white sugar', '6 tablespoons butter, melted', '� teaspoon ground cinnamon']", false, "https://www.allrecipes.com/recipe/12254/graham-cracker-crust-i/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Grandma's Chocolate Texas Sheet Cake", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F2341793.jpg", "'1 cup salted butter', '1 cup water', '3 tablespoons cocoa powder ', '2 cups all-purpose flour', '2 cups white sugar', '� teaspoon salt', '� cup buttermilk', '2 large eggs', '1 teaspoon baking soda', '1 teaspoon vanilla extract', '� cup unsalted butter', '6 tablespoons milk', '3 tablespoons cocoa powder ', '1 teaspoon vanilla extract', \"2 cups confectioners' sugar\"]", false, "https://www.allrecipes.com/recipe/278981/grandmas-chocolate-texas-sheet-cake/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Grandma's Corn Pudding", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F6033726.jpg", "'5 eggs', ' cup butter, melted', '� cup white sugar', '� cup milk', '4 tablespoons cornstarch', '1 (15.25 ounce) can whole kernel corn', '2 (14.75 ounce) cans cream-style corn']", false, "https://www.allrecipes.com/recipe/15985/grandmas-corn-pudding/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Grandma's Famous Salmon Cakes", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F785713.jpg", "'1 (14.75 ounce) can salmon, drained and flaked', '2 eggs, beaten', '1 small onion, diced', '1 teaspoon ground black pepper', '3 tablespoons vegetable oil']", false, "https://www.allrecipes.com/recipe/24509/grandmas-famous-salmon-cakes/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Greek Pasta Salad", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F1016228.jpg", "'2 cups penne pasta', '� cup red wine vinegar', '1 tablespoon lemon juice', '2 cloves garlic, crushed', '2 teaspoons dried oregano', 'salt and pepper to taste', ' cup extra-virgin olive oil', '10 cherry tomatoes, halved', '1 small red onion, chopped', '1 green bell pepper, chopped', '1 red bell pepper, chopped', '� cucumber, sliced', '� cup sliced black olives', '� cup crumbled feta cheese']", false, "https://www.allrecipes.com/recipe/176650/greek-pasta-salad/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Grandma's Favorite Chicken", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F2310093.jpg", "'8 chicken legs', '5 large white potatoes', '1 (8 ounce) package baby carrots', '5 cloves garlic', '2 yellow squash, quartered lengthwise and cut crosswise into 1/2-inch slices', '1 large onion, peeled and sliced', '1 tablespoon dried parsley flakes', '� tablespoon garlic powder', 'salt to taste', 'black pepper to taste', '4 tablespoons butter, divided', '2 cups water, or as needed']", false, "https://www.allrecipes.com/recipe/109642/grandmas-favorite-chicken/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Grandma's Ground Beef Casserole", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F996886.jpg", "'1 pound ground beef', '1 teaspoon white sugar', '1 teaspoon salt', '1 teaspoon garlic salt', '2 (15 ounce) cans tomato sauce', '1 (8 ounce) package egg noodles', '1 cup sour cream', '1 (3 ounce) package cream cheese', '1 large white onion, diced', '� cup shredded sharp Cheddar cheese, or more to taste']", false, "https://www.allrecipes.com/recipe/231808/grandmas-ground-beef-casserole/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Grandma's Iron Skillet Apple Pie", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F4573341.jpg", "'� cup butter', '1 cup brown sugar', '5 Granny Smith apples -- peeled, cored, quartered, and thinly sliced', '3 (9 inch) refrigerated prerolled pie crusts', '1 cup white sugar, divided', '2 teaspoons ground cinnamon, divided', '� cup white sugar', '1 tablespoon butter, cut into small chunks']", false, "https://www.allrecipes.com/recipe/213569/grandmas-iron-skillet-apple-pie/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Grandma's Lemon Meringue Pie", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F672049.jpg", "'1 cup white sugar', '2 tablespoons all-purpose flour', '3 tablespoons cornstarch', '� teaspoon salt', '� cups water', '2 lemons, juiced and zested', '2 tablespoons butter', '4 egg yolks, beaten', '1 (9 inch) pie crust, baked', '4 egg whites', '6 tablespoons white sugar']", false, "https://www.allrecipes.com/recipe/15093/grandmas-lemon-meringue-pie/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Grandma's Meat and Tater Hotdish", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F7732955.jpg", "'1 pound ground beef', '1 onion, chopped', '1 (10.75 ounce) can  condensed cream of mushroom soup', '� cup sour cream', '1 (15 ounce) can green beans, drained and liquid reserved, divided', '1 processed cheese (such as Velveeta), sliced', '1 pound frozen bite-sized potato nuggets (such as Tater Tots)']", false, "https://www.allrecipes.com/recipe/278479/grandmas-meat-and-tater-hotdish/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Grandma's Skillet Pineapple Upside-Down Cake", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F6696344.jpg", "'1 stick butter', '� cups packed brown sugar', '1 (20 ounce) can sliced pineapple', '1 (4 ounce) jar cherries', '� cups all-purpose flour', '� teaspoons baking powder', '� teaspoon salt', '� cups white sugar', '� cup butter', '2 eggs', '1 cup milk', '2 teaspoons vanilla extract']", false, "https://www.allrecipes.com/recipe/273774/grandmas-skillet-pineapple-upside-down-cake/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Grandmother's Buttermilk Cornbread", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fcf-images.us-east-1.prod.boltdns.net%2Fv1%2Fstatic%2F1033249144001%2Fb89ef78f-919b-400c-a03d-b205b5a352ac%2F886fcf07-43c1-44d5-8991-1d0151fa7393%2F1280x720%2Fmatch%2Fimage.jpg", "'� cup butter', ' cup white sugar', '2 large eggs', '1 cup buttermilk', '� teaspoon baking soda', '1 cup cornmeal', '1 cup all-purpose flour', '� teaspoon salt']", false, "https://www.allrecipes.com/recipe/76594/grandmothers-buttermilk-cornbread/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Greek Chicken Skewers", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F6705859.jpg", "'� cup lemon juice', '� cup wok oil', ' cup red wine vinegar', '1 tablespoon onion flakes', '1 tablespoon minced garlic', '1 lemon, zested', '1 teaspoon Greek seasoning', '1 teaspoon poultry seasoning', '1 teaspoon dried oregano', '1 teaspoon ground black pepper', '� teaspoon dried thyme', '3 skinless, boneless chicken breasts, or as needed, cut into 1-inch pieces', '8 bamboo skewers, or as needed, soaked in water for 30 minutes']", false, "https://www.allrecipes.com/recipe/273864/greek-chicken-skewers/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Greek Lemon Chicken and Potatoes", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F4539284.jpg", "'4 pounds skin-on, bone-in chicken thighs', '1 tablespoon kosher salt', '1 tablespoon dried oregano', '1 teaspoon freshly ground black pepper', '1 teaspoon dried rosemary', '1 pinch cayenne pepper', '� cup fresh lemon juice', '� cup olive oil', '6 cloves garlic, minced', '3 russet potatoes, peeled and quartered', ' cup chicken broth, plus splash to deglaze pan', 'chopped fresh oregano for garnish']", false, "https://www.allrecipes.com/recipe/242352/greek-lemon-chicken-and-potatoes/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Greek Orzo Salad", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F676733.jpg", "'� cups uncooked orzo pasta', '2 (6 ounce) cans marinated artichoke hearts', '1 tomato, seeded and chopped', '1 cucumber, seeded and chopped', '1 red onion, chopped', '1 cup crumbled feta cheese', '1 (2 ounce) can black olives, drained', '� cup chopped fresh parsley', '1 tablespoon lemon juice', '� teaspoon dried oregano', '� teaspoon lemon pepper']", false, "https://www.allrecipes.com/recipe/19389/greek-orzo-salad/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Grandma's Gingersnap Cookies", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F7330579.jpg", "'2 cups sifted all-purpose flour', '1 tablespoon ground ginger', '2 teaspoons baking soda', '1 teaspoon ground cinnamon', '� teaspoon salt', '� cup shortening', '1 cup white sugar', '1 egg', '� cup dark molasses', ' cup cinnamon sugar']", false, "https://www.allrecipes.com/recipe/10365/grandmas-gingersnap-cookies/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Easy Pork Chops for the Slow Cooker", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F7280253.jpg", "'1 large onion, sliced into rings', '10 center-cut boneless pork chops, trimmed', '1 (10.75 ounce) can  cream of onion soup', '1 (10.75 ounce) can  cream of mushroom soup', '5 fluid ounces water', '1 (1 ounce) package ranch dressing mix', '1 (1 ounce) package dry onion soup mix', 'salt and ground black pepper to taste']", false, "https://www.allrecipes.com/recipe/237411/easy-pork-chops-for-the-slow-cooker/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Easy Pancakes", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F2361199.jpg", "'1 cup all-purpose flour', '2 tablespoons white sugar', '2 teaspoons baking powder', '1 teaspoon salt', '1 egg, beaten', '1 cup milk', '2 tablespoons vegetable oil']", false, "https://www.allrecipes.com/recipe/45396/easy-pancakes/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Easy Paella", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F886465.jpg", "'2 tablespoons olive oil', '1 tablespoon paprika', '2 teaspoons dried oregano', 'salt and black pepper to taste', '2 pounds skinless, boneless chicken breasts, cut into 2 inch pieces', '2 tablespoons olive oil, divided', '3 cloves garlic, crushed', '1 teaspoon crushed red pepper flakes', '2 cups uncooked short-grain white rice', '1 pinch saffron threads', '1 bay leaf', '� bunch Italian flat leaf parsley, chopped', '1 quart chicken stock', '2 lemons, zested', '2 tablespoons olive oil', '1 Spanish onion, chopped', '1 red bell pepper, coarsely chopped', '1 pound chorizo sausage, casings removed and crumbled', '1 pound shrimp, peeled and deveined']", false, "https://www.allrecipes.com/recipe/84137/easy-paella/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Cinnamon Toast Pumpkin Seeds", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F1518409.jpg", "'3 tablespoons butter, melted', '1 teaspoon ground cinnamon', '� teaspoon salt', '� cups pumpkin seeds', '2 tablespoons white sugar']", false, "https://www.allrecipes.com/recipe/239621/cinnamon-toast-pumpkin-seeds/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Classic and Simple Meat Lasagna", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F994958.jpg", "'12 whole wheat lasagna noodles', '1 pound lean ground beef', '2 cloves garlic, chopped', '� teaspoon garlic powder', '1 teaspoon dried oregano, or to taste', 'salt and ground black pepper to taste', '1 (16 ounce) package cottage cheese', '2 eggs', '� cup shredded Parmesan cheese', '� (25 ounce) jars tomato-basil pasta sauce', '2 cups shredded mozzarella cheese']", false, "https://www.allrecipes.com/recipe/218091/classic-and-simple-meat-lasagna/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Classic Dinner Rolls", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F1024104.jpg", "'2 cups all-purpose flour, or more if needed', \"1 envelope Fleischmann's RapidRise Yeast\", '2 tablespoons sugar', '� teaspoon salt', '� cup milk', '� cup water', '2 tablespoons butter OR margarine']", false, "https://www.allrecipes.com/recipe/215378/classic-dinner-rolls/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Classic Fish and Chips", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F970421.jpg", "'4 large potatoes, peeled and cut into strips', '1 cup all-purpose flour', '1 teaspoon baking powder', '1 teaspoon salt', '1 teaspoon ground black pepper', '1 cup milk', '1 egg', '1 quart vegetable oil for frying', '� pounds cod fillets']", false, "https://www.allrecipes.com/recipe/16580/classic-fish-and-chips/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Classic Goulash", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F1108799.jpg", "'2 pounds lean ground beef', '2 large yellow onions, chopped', '3 cloves garlic, chopped', '3 cups water', '2 (15 ounce) cans tomato sauce', '2 (14.5 ounce) cans diced tomatoes', '3 tablespoons soy sauce', '2 tablespoons dried Italian herb seasoning', '3 bay leaves', '1 tablespoon seasoned salt, or to taste', '2 cups uncooked elbow macaroni']", false, "https://www.allrecipes.com/recipe/213268/classic-goulash/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Classic Hash Browns", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F5466502.jpg", "'2 russet potatoes, peeled', '3 tablespoons clarified butter', 'salt and ground black pepper to taste', '1 pinch cayenne pepper, or to taste', '1 pinch paprika, or to taste']", false, "https://www.allrecipes.com/recipe/220520/classic-hash-browns/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Classic Macaroni and Cheese", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F3593667.jpg", "'1 (16 ounce) package macaroni', '1 pound sharp Cheddar cheese, sliced', '1 tablespoon butter', 'salt and pepper to taste', '1 (12 fluid ounce) can evaporated milk']", false, "https://www.allrecipes.com/recipe/19423/classic-macaroni-and-cheese/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Classic Macaroni Salad", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F878056.jpg", "'4 cups uncooked elbow macaroni', '1 cup mayonnaise', '� cup distilled white vinegar', ' cup white sugar', '� tablespoons prepared yellow mustard', '� teaspoons salt', '� teaspoon ground black pepper', '1 large onion, chopped', '2 stalks celery, chopped', '1 green bell pepper, seeded and chopped', '� cup grated carrot', '2 tablespoons chopped pimento peppers']", false, "https://www.allrecipes.com/recipe/81108/classic-macaroni-salad/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Classic Peanut Butter Cookies", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F1078651.jpg", "'1 cup unsalted butter', '1 cup crunchy peanut butter', '1 cup white sugar', '1 cup packed brown sugar', '2 eggs', '� cups all-purpose flour', '1 teaspoon baking powder', '� teaspoon salt', '� teaspoons baking soda']", false, "https://www.allrecipes.com/recipe/10275/classic-peanut-butter-cookies/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Cilantro-Lime Dressing", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F971844.jpg", "'1 jalapeno pepper, seeded and coarsely chopped', '1 clove garlic', '� teaspoon minced fresh ginger root', '� cup lime juice', ' cup honey', '2 teaspoons balsamic vinegar', '� teaspoon salt, or to taste', '� cup packed cilantro leaves', '� cup extra-virgin olive oil']", false, "https://www.allrecipes.com/recipe/167260/cilantro-lime-dressing/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Classic Savory Deviled Eggs", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F3275386.jpg", "'6 hard-cooked eggs, halved', '� cup mayonnaise', '1 teaspoon rice wine vinegar', '� teaspoon chopped fresh dill', '1 teaspoon Dijon mustard', '� teaspoon garlic powder', ' teaspoon salt', '12 sprigs fresh dill']", false, "https://www.allrecipes.com/recipe/228129/classic-savory-deviled-eggs/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Cobb Salad", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F2369484.jpg", "'6 slices bacon', '3 eggs', '1 head iceberg lettuce, shredded', '3 cups chopped, cooked chicken meat', '2 tomatoes, seeded and chopped', '� cup blue cheese, crumbled', '1 avocado - peeled, pitted and diced', '3 green onions, chopped', '1 (8 ounce) bottle Ranch-style salad dressing']", false, "https://www.allrecipes.com/recipe/14415/cobb-salad/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Coconut Shrimp I", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F3494547.jpg", "'1 egg', '� cup all-purpose flour', ' cup beer', '� teaspoons baking powder', '� cup all-purpose flour', '2 cups flaked coconut', '24 shrimp', '3 cups oil for frying']", false, "https://www.allrecipes.com/recipe/17753/coconut-shrimp-i/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Comforting Turkey Cobbler", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F7002207.jpg", "'1 tablespoon butter', '1 tablespoon all-purpose flour', '1 cup water', '� cup milk', '1 teaspoon garlic base (such as Better Than Bouillon Roasted Garlic Base)', '� cups cubed cooked turkey', '� cup chopped carrots', '� cup chopped celery', '� cup chopped onion', '� teaspoon dried oregano', '� teaspoon ground thyme', '� teaspoon dried parsley', 'salt and ground black pepper to taste', 'nonstick cooking spray', '1 cup all-purpose flour', '� teaspoons baking powder', '� teaspoon salt', '3 tablespoons butter', '� cup milk', '1 pinch Italian seasoning', '1 pinch garlic granules']", false, "https://www.allrecipes.com/recipe/275706/comforting-turkey-cobbler/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Concord Grape Pie I", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F4584645.jpg", "'1 recipe pastry for a 9 inch double crust pie', '5 cups Concord grapes', '� cups white sugar', '� cup all-purpose flour', '1 pinch salt', '� teaspoon lemon juice', '� tablespoons butter']", false, "https://www.allrecipes.com/recipe/12289/concord-grape-pie-i/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Copycat Fried Chicken Sandwich", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F7219742.jpg", "'1 cup buttermilk', '2 teaspoons kosher salt', '1 dash hot sauce, or to taste', '1 tablespoon dry ranch dressing mix (such as Hidden Valley Ranch)', '4 (5 ounce) skinless, boneless chicken breast halves', ' cups all-purpose flour', '2 tablespoons cornstarch', '2 teaspoons kosher salt', '� teaspoon freshly ground black pepper', '� teaspoons cayenne pepper', '1 tablespoon dry ranch dressing mix (such as Hidden Valley Ranch)', '1 large egg, beaten', '� cup buttermilk', '� cup milk', 'canola oil for frying', '4 soft hamburger buns, toasted and buttered', '6 tablespoons mayonnaise, or to taste', '12 dill pickle slices, or to taste']", false, "https://www.allrecipes.com/recipe/276887/copycat-fried-chicken-sandwich/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Copycat Panera Broccoli Cheddar Soup", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F1087142.jpg", "'1 tablespoon butter', '� onion, chopped', '� cup melted butter', '� cup flour', '2 cups milk', '2 cups chicken stock', '� cups coarsely chopped broccoli florets', '1 cup matchstick-cut carrots', '1 stalk celery, thinly sliced', '� cups shredded sharp Cheddar cheese', 'salt and ground black pepper to taste']", false, "https://www.allrecipes.com/recipe/235874/copycat-panera-broccoli-cheddar-soup/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Corn Dogs", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F730146.jpg", "'1 cup yellow cornmeal', '1 cup all-purpose flour', '� teaspoon salt', ' teaspoon black pepper', '� cup white sugar', '4 teaspoons baking powder', '1 egg', '1 cup milk', '1 quart vegetable oil for frying', '2 (16 ounce) packages beef frankfurters', '16 wooden skewers']", false, "https://www.allrecipes.com/recipe/35149/corn-dogs/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Crab Legs with Garlic Butter Sauce", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F2027161.jpg", "'1 pound Snow Crab clusters, thawed if necessary', '� cup butter', '1 clove garlic, minced', '� teaspoons dried parsley', ' teaspoon salt', '� teaspoon fresh-ground black pepper']", false, "https://www.allrecipes.com/recipe/155375/crab-legs-with-garlic-butter-sauce/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Cranberry Apple Pie II", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F1080413.jpg", "'6 apples', '1 (16 ounce) can whole cranberry sauce', '� cup packed brown sugar', ' cup all-purpose flour', '� teaspoons ground cinnamon', '� teaspoon ground nutmeg', '1 recipe pastry for a 9 inch double crust pie']", false, "https://www.allrecipes.com/recipe/12383/cranberry-apple-pie-ii/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Classic Waffles", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F34761.jpg", "'2 cups all-purpose flour', '1 teaspoon salt', '4 teaspoons baking powder', '2 tablespoons white sugar', '2 eggs', '� cups warm milk', ' cup butter, melted', '1 teaspoon vanilla extract']", false, "https://www.allrecipes.com/recipe/20513/classic-waffles/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Cranberry Salsa", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F525441.jpg", "'1 (12 ounce) bag cranberries, fresh or frozen', '1 bunch cilantro, chopped', '1 bunch green onions, cut into 3 inch lengths', '1 jalapeno pepper, seeded and minced', '2 limes, juiced', '� cup white sugar', '1 pinch salt']", false, "https://www.allrecipes.com/recipe/141135/cranberry-salsa/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Churros", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F392145.jpg", "'1 cup water', '� tablespoons white sugar', '� teaspoon salt', '2 tablespoons vegetable oil', '1 cup all-purpose flour', '2 quarts oil for frying', '� cup white sugar, or to taste', '1 teaspoon ground cinnamon']", false, "https://www.allrecipes.com/recipe/24700/churros/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Chocolate Cupcakes", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F1007622.jpg", "' cups all-purpose flour', '� teaspoon baking soda', '2 teaspoons baking powder', '� cup unsweetened cocoa powder', ' teaspoon salt', '3 tablespoons butter, softened', '� cups white sugar', '2 eggs', '� teaspoon vanilla extract', '1 cup milk']", false, "https://www.allrecipes.com/recipe/17377/chocolate-cupcakes/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Chicken and Pasta Casserole with Mixed Vegetables", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F846633.jpg", "'1 cup dry fusilli pasta', '3 tablespoons olive oil', '6 chicken tenderloins, cut into chunks', '1 tablespoon dried minced onion', 'salt and pepper to taste', 'garlic powder to taste', '1 tablespoon dried basil', '1 tablespoon dried parsley', '1 (10.75 ounce) can  condensed cream of chicken soup', '1 (10.75 ounce) can  condensed cream of mushroom soup', '2 cups frozen mixed vegetables', '1 cup dry bread crumbs', '2 tablespoons grated Parmesan cheese', '2 tablespoons butter, melted']", false, "https://www.allrecipes.com/recipe/69193/chicken-and-pasta-casserole-with-mixed-vegetables/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Chicken Club Pasta Salad", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F1113624.jpg", "'8 ounces corkscrew-shaped pasta', '� cup Italian-style salad dressing', '� cup mayonnaise', '2 cups chopped, cooked rotisserie chicken', '12 slices crispy cooked bacon, crumbled', '1 cup cubed Muenster cheese', '1 cup chopped celery', '1 cup chopped green bell pepper', '8 ounces cherry tomatoes, halved', '1 avocado - peeled, pitted, and chopped']", false, "https://www.allrecipes.com/recipe/236198/chicken-club-pasta-salad/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Chicken Cordon Bleu I", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F3508202.jpg", "'4 skinless, boneless chicken breast halves', '� teaspoon salt', ' teaspoon ground black pepper', '6 slices Swiss cheese', '4 slices cooked ham', '� cup seasoned bread crumbs']", false, "https://www.allrecipes.com/recipe/8495/chicken-cordon-bleu-i/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Chicken Divan", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F864872.jpg", "'� cups cooked chopped broccoli', '2 cups shredded, cooked chicken meat', '2 (4.5 ounce) cans mushrooms, drained', '1 (8 ounce) can water chestnuts, drained', '2 (10.75 ounce) cans  condensed cream of chicken soup', '1 cup mayonnaise', '1 teaspoon lemon juice', '� teaspoon curry powder', '1 tablespoon melted butter', '� cup shredded Cheddar cheese']", false, "https://www.allrecipes.com/recipe/8894/chicken-divan/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Chicken Katsu", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F5816671.jpg", "'4 skinless, boneless chicken breast halves - pounded to 1/2 inch thickness', 'salt and pepper to taste', '2 tablespoons all-purpose flour', '1 egg, beaten', '1 cup panko bread crumbs', '1 cup oil for frying, or as needed']", false, "https://www.allrecipes.com/recipe/72068/chicken-katsu/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Chicken Marsala", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F5107151.jpg", "'� cup all-purpose flour for coating', '� teaspoon salt', '� teaspoon ground black pepper', '� teaspoon dried oregano', '4 skinless, boneless chicken breast halves - pounded 1/4 inch thick', '4 tablespoons butter', '4 tablespoons olive oil', '1 cup sliced mushrooms', '� cup Marsala wine', '� cup cooking sherry']", false, "https://www.allrecipes.com/recipe/8887/chicken-marsala/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Chicken Noodle Casserole I", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F4565560.jpg", "'4 skinless, boneless chicken breast halves', '6 ounces egg noodles', '1 (10.75 ounce) can  condensed cream of mushroom soup', '1 (10.75 ounce) can  condensed cream of chicken soup', '1 cup sour cream', 'salt to taste', 'ground black pepper to taste', '1 cup crumbled buttery round crackers', '� cup butter']", false, "https://www.allrecipes.com/recipe/11864/chicken-noodle-casserole-i/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Chicken Parmesan", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F6635156.jpg", "'4 skinless, boneless chicken breast halves', 'salt and freshly ground black pepper to taste', '2 eggs', '1 cup panko bread crumbs, or more as needed', '� cup grated Parmesan cheese', '2 tablespoons all-purpose flour, or more if needed', '1 cup olive oil for frying', '� cup prepared tomato sauce', '� cup fresh mozzarella, cut into small cubes ', '� cup chopped fresh basil', '� cup grated provolone cheese', '� cup grated Parmesan cheese', '1 tablespoon olive oil']", false, "https://www.allrecipes.com/recipe/223042/chicken-parmesan/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Chicken Penne Italiano", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F685186.jpg", "'8 ounces dry penne pasta', '1 tablespoon cornstarch', '1 (15 ounce) can chicken broth', '2 tablespoons olive oil', '1 tablespoon garlic, minced', '4 skinless, boneless chicken breast halves - cut into cubes', '1 onion, sliced', '� green bell pepper, seeded and thinly sliced', '� red bell pepper, seeded and thinly sliced', '1 (16 ounce) can diced tomatoes', '1 teaspoon dried oregano', '1 teaspoon dried basil', '� cup  medium-dry white wine', '� cup freshly grated Parmesan cheese']", false, "https://www.allrecipes.com/recipe/88745/chicken-penne-italiano/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Chuck's Favorite Mac and Cheese", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F231415.jpg", "'1 (8 ounce) package elbow macaroni', '1 (8 ounce) package shredded sharp Cheddar cheese', '1 (12 ounce) container small curd cottage cheese', '1 (8 ounce) container sour cream', '� cup grated Parmesan cheese', 'salt and pepper to taste', '1 cup dry bread crumbs', '� cup butter, melted']", false, "https://www.allrecipes.com/recipe/19368/chucks-favorite-mac-and-cheese/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Chicken Potato Soup", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F6504547.jpg", "'2 skinless, boneless chicken breasts, diced', '1 pinch seasoned salt, or to taste', 'ground black pepper to taste', '2 tablespoons vegetable oil', '� onion, chopped', '� teaspoon minced garlic', '4 cups chicken broth', '2 cups water', '2 stalks celery, chopped', '2 carrots, chopped', '2 large russet potatoes, quartered and thinly sliced', '1 pinch cayenne pepper, or to taste']", false, "https://www.allrecipes.com/recipe/272232/chicken-potato-soup/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Chicken Savoy", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F387545.jpg", "'1 (2 to 3 pound) whole chicken, cut into pieces', ' cup extra virgin olive oil', '1 cup chicken stock', '1 clove garlic, crushed', '1 teaspoon dried oregano', 'salt and pepper to taste', '� cup grated Romano cheese', '3 tablespoons balsamic vinegar']", false, "https://www.allrecipes.com/recipe/24790/chicken-savoy/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Chicken Stir-Fry", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F973101.jpg", "'2 cups white rice', '4 cups water', ' cup soy sauce', '� cup brown sugar', '1 tablespoon cornstarch', '1 tablespoon minced fresh ginger', '1 tablespoon minced garlic', '� teaspoon red pepper flakes', '3 skinless, boneless chicken breast halves, thinly sliced', '1 tablespoon sesame oil', '1 green bell pepper, cut into matchsticks', '1 (8 ounce) can sliced water chestnuts, drained', '1 head broccoli, broken into florets', '1 cup sliced carrots', '1 onion, cut into large chunks', '1 tablespoon sesame oil']", false, "https://www.allrecipes.com/recipe/223382/chicken-stir-fry/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Chicken Taco Soup for Two", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F7812428.jpg", "'2 teaspoons olive oil', '� cup chopped onion', '3 tablespoons taco seasoning, divided', '� (14 ounce) can fire-roasted diced tomatoes, with juice', '1 cup chicken broth', ' cup frozen corn', '1 (5 ounce) boneless, skinless chicken breast, thinly sliced on the diagonal', '� cup tortilla chips', '� avocado, sliced', '� cup shredded Oaxaca cheese, or to taste', '2 tablespoons sour cream, or to taste']", false, "https://www.allrecipes.com/recipe/279294/chicken-taco-soup-for-two/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Chicken Tortilla Soup I", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F7160159.jpg", "'1 onion, chopped', '3 cloves garlic, minced', '1 tablespoon olive oil', '2 teaspoons chili powder', '1 teaspoon dried oregano', '1 (28 ounce) can crushed tomatoes', '1 (10.5 ounce) can condensed chicken broth', '� cups water', '1 cup whole corn kernels, cooked', '1 cup white hominy', '1 (4 ounce) can chopped green chile peppers', '1 (15 ounce) can black beans, rinsed and drained', '� cup chopped fresh cilantro', '2 boneless chicken breast halves, cooked and cut into bite-sized pieces', 'crushed tortilla chips', 'sliced avocado', 'shredded Monterey Jack cheese', 'chopped green onions']", false, "https://www.allrecipes.com/recipe/13351/chicken-tortilla-soup-i/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Chicken With Mushrooms", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F1081972.jpg", "'3 cups sliced mushrooms', '4 skinless, boneless chicken breast halves', '2 eggs, beaten', '1 cup seasoned bread crumbs', '2 tablespoons butter', '6 ounces mozzarella cheese, sliced', '� cup chicken broth']", false, "https://www.allrecipes.com/recipe/8493/chicken-with-mushrooms/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Chili Rellenos Casserole", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F634160.jpg", "'2 (7 ounce) cans whole green chile peppers, drained', '8 ounces Monterey Jack cheese, shredded', '8 ounces Longhorn or Cheddar cheese, shredded', '2 eggs, beaten', '1 (5 ounce) can evaporated milk', '2 tablespoons all-purpose flour', '� cup milk', '1 (8 ounce) can tomato sauce']", false, "https://www.allrecipes.com/recipe/47247/chili-rellenos-casserole/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Chocolate Chip Muffins", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F4470819.jpg", "'2 cups all-purpose flour', '� cup white sugar', '3 teaspoons baking powder', '� teaspoon salt', '� cup milk', ' cup vegetable oil', '1 egg', '� cup mini semi-sweet chocolate chips', '3 tablespoons white sugar', '2 tablespoons brown sugar']", false, "https://www.allrecipes.com/recipe/7906/chocolate-chip-muffins/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Chocolate Chocolate Chip Cookies I", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F480783.jpg", "'1 cup butter, softened', '� cups white sugar', '2 eggs', '2 teaspoons vanilla extract', '2 cups all-purpose flour', ' cup cocoa powder', '� teaspoon baking soda', '� teaspoon salt', '2 cups semisweet chocolate chips', '� cup chopped walnuts']", false, "https://www.allrecipes.com/recipe/9827/chocolate-chocolate-chip-cookies-i/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Chocolate Crinkles II", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F430444.jpg", "'1 cup unsweetened cocoa powder', '2 cups white sugar', '� cup vegetable oil', '4 eggs', '2 teaspoons vanilla extract', '2 cups all-purpose flour', '2 teaspoons baking powder', '� teaspoon salt', \"� cup confectioners' sugar\"]", false, "https://www.allrecipes.com/recipe/9861/chocolate-crinkles-ii/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Chicken Salad with Apples, Grapes, and Walnuts", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F4536333.jpg", "'4 cooked chicken breasts, shredded', '2 Granny Smith apples, cut into small chunks', '2 cups chopped walnuts, or to taste', '� red onion, chopped', '3 stalks celery, chopped', '3 tablespoons lemon juice', '� cup vanilla yogurt', '5 tablespoons creamy salad dressing (such as Miracle Whip)', '5 tablespoons mayonnaise', '25 seedless red grapes, halved']", false, "https://www.allrecipes.com/recipe/222912/chicken-salad-with-apples-grapes-and-walnuts/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Cranberry Sauce", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F743657.jpg", "'12 ounces cranberries', '1 cup white sugar', '1 cup orange juice']", false, "https://www.allrecipes.com/recipe/9111/cranberry-sauce/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Cranberry Sour Cream Kuchen", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F4570136.jpg", "'� cup butter', '1 cup white sugar', '1 teaspoon vanilla extract', '3 eggs', '2 cups all-purpose flour', '2 teaspoons baking powder', '� teaspoon baking soda', '� teaspoon salt', '� cups sour cream', '2 cups chopped fresh cranberries', '� cup white sugar', '� cup brown sugar', '2 tablespoons all-purpose flour', '2 tablespoons chopped almonds', '1 tablespoon butter', '� teaspoon ground cinnamon']", false, "https://www.allrecipes.com/recipe/232005/cranberry-sour-cream-kuchen/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Cranberry Upside-Down Sour Cream Cake", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F735351.jpg", "'� cup butter', '2 cups white sugar', '2 tablespoons water', '1 teaspoon ground cinnamon', '1 (12 ounce) bag fresh or frozen cranberries', '� cups cake flour', '� teaspoon baking soda', '� teaspoon salt', '6 tablespoons butter, softened', '� cup white sugar', '� cup brown sugar', '2 eggs', '1 teaspoon vanilla extract', '� cup sour cream']", false, "https://www.allrecipes.com/recipe/27021/cranberry-upside-down-sour-cream-cake/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Easy Bake Fish", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F2415472.jpg", "'3 tablespoons honey', '3 tablespoons Dijon mustard', '1 teaspoon lemon juice', '4 (6 ounce) salmon steaks', '� teaspoon pepper']", false, "https://www.allrecipes.com/recipe/45361/easy-bake-fish/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Easy Baked Turkey Wings", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F5688056.jpg", "'5 turkey wings', '1 small onion, chopped', '1 teaspoon seasoned salt', '1 teaspoon poultry seasoning', '1 teaspoon ground black pepper', '1 teaspoon minced garlic', '� cups water, divided', '1 (10.75 ounce) can  cream of mushroom soup']", false, "https://www.allrecipes.com/recipe/234510/easy-baked-turkey-wings/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Easy Baking Powder Drop Biscuits", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F6054694.jpg", "'2 cups all-purpose flour', '� teaspoons baking powder', '� teaspoon salt', '1 tablespoon white sugar', '� cup chilled butter, diced', '� cups whole milk']", false, "https://www.allrecipes.com/recipe/102151/easy-baking-powder-drop-biscuits/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Easy Broccoli Bacon Salad", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F2264735.jpg", "'1 large head broccoli, cut into florets', '1 small red onion, chopped', '12 slices cooked bacon, crumbled', '1 cup raisins', '� cup sunflower seeds', '� cup mayonnaise', ' cup white sugar', '3 tablespoons red wine vinegar']", false, "https://www.allrecipes.com/recipe/242291/easy-broccoli-bacon-salad/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Easy Cold Pasta Salad", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F851693.jpg", "'14 ounces uncooked rotini pasta', '2 cucumbers, chopped', '� onion, finely chopped', '10 cherry tomatoes, quartered', '� cup pitted black olives, sliced', '1 cup Italian-style salad dressing']", false, "https://www.allrecipes.com/recipe/149799/easy-cold-pasta-salad/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Easy Coleslaw Dressing", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F1967016.jpg", "'� cup mayonnaise', '2 tablespoons white sugar', '� tablespoons lemon juice', '1 tablespoon vinegar', '� teaspoon ground black pepper', '� teaspoon salt']", false, "https://www.allrecipes.com/recipe/240784/easy-coleslaw-dressing/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Easy Corn Pudding", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F1091271.jpg", "'1 (15 ounce) can creamed corn', '1 (15.25 ounce) can whole kernel corn', '� pound butter, softened', '1 (8.5 ounce) package corn bread mix', '1 (8 ounce) container sour cream']", false, "https://www.allrecipes.com/recipe/13684/easy-corn-pudding/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Easy French Toast Casserole", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F2124965.jpg", "'1 cup brown sugar', '� cup butter', '1 (8 ounce) loaf crusty French bread, cut into bite-size pieces, or as needed', '2 cups milk', '6 eggs', '2 teaspoons vanilla extract', '1 pinch ground cinnamon, or to taste', '1 tablespoon brown sugar, or as needed']", false, "https://www.allrecipes.com/recipe/240502/easy-french-toast-casserole/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Easy Garlic Kale", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F2094708.jpg", "'1 bunch kale', '1 tablespoon olive oil', '1 teaspoon minced garlic']", false, "https://www.allrecipes.com/recipe/241074/easy-garlic-kale/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Easy Apple Coleslaw", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F1037964.jpg", "'3 cups chopped cabbage', '1 unpeeled red apple, cored and chopped', '1 unpeeled Granny Smith apple, cored and chopped', '1 carrot, grated', '� cup finely chopped red bell pepper', '2 green onions, finely chopped', ' cup mayonnaise', ' cup brown sugar', '1 tablespoon lemon juice, or to taste']", false, "https://www.allrecipes.com/recipe/34615/easy-apple-coleslaw/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Easy Garlic-Lemon Scallops", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F5916120.jpg", "'� cup butter', '3 tablespoons minced garlic', '2 pounds large sea scallops', '1 teaspoon salt', ' teaspoon pepper', '2 tablespoons fresh lemon juice']", false, "https://www.allrecipes.com/recipe/132358/easy-garlic-lemon-scallops/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Easy Guacamole", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F1488197.jpg", "'2 avocados', '1 small onion, finely chopped', '1 clove garlic, minced', '1 ripe tomato, chopped', '1 lime, juiced', 'salt and pepper to taste']", false, "https://www.allrecipes.com/recipe/14064/easy-guacamole/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Easy Herb-Roasted Turkey", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fcf-images.us-east-1.prod.boltdns.net%2Fv1%2Fstatic%2F1033249144001%2F4cb0a35b-b833-4a26-a67c-0399aa93cb9b%2F385fca87-b08f-42f6-aa16-36141501d9de%2F1280x720%2Fmatch%2Fimage.jpg", "'1 (12 pound) whole turkey', '� cup olive oil', '2 tablespoons garlic powder', '2 teaspoons dried basil', '1 teaspoon ground sage', '1 teaspoon salt', '� teaspoon black pepper', '2 cups water']", false, "https://www.allrecipes.com/recipe/41393/easy-herb-roasted-turkey/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Easy Homemade Chili", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F2905812.jpg", "'1 pound ground beef', '1 onion, chopped', '1 (14.5 ounce) can stewed tomatoes', '1 (15 ounce) can tomato sauce', '1 (15 ounce) can kidney beans', '� cups water', '1 pinch chili powder', '1 pinch garlic powder', 'salt and pepper to taste']", false, "https://www.allrecipes.com/recipe/16248/easy-homemade-chili/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Easy Homemade Pie Crust", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F965240.jpg", "'� cups all-purpose flour', '1 cup unsalted butter - chilled, cut into tablespoon-size pieces', '� teaspoon salt', '7 tablespoons ice water', '1 tablespoon cider vinegar']", false, "https://www.allrecipes.com/recipe/220996/easy-homemade-pie-crust/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Easy Lasagna II", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F4511968.jpg", "'1 pound lean ground beef', '1 (32 ounce) jar spaghetti sauce', '32 ounces cottage cheese', '3 cups shredded mozzarella cheese', '2 eggs', '� cup grated Parmesan cheese', '2 teaspoons dried parsley', 'salt to taste', 'ground black pepper to taste', '9 lasagna noodles', '� cup water']", false, "https://www.allrecipes.com/recipe/12011/easy-lasagna-ii/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Easy Mac and Cheese Muffins", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F3557771.jpg", "'2 cups uncooked elbow macaroni', '1 tablespoon butter', '1 egg, beaten', '1 cup milk', '� cups shredded sharp Cheddar cheese', '� cups shredded mozzarella cheese', '� cup seasoned dry bread crumbs', '2 teaspoons olive oil', '� teaspoon salt']", false, "https://www.allrecipes.com/recipe/111361/easy-mac-and-cheese-muffins/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Easy Maple Bacon Monkey Bread", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F4541031.jpg", "'cooking spray', '� cup white sugar', '2 tablespoons caramel instant pudding mix, uncooked ', '2 teaspoons ground cinnamon', '2 (16.3 ounce) cans refrigerated biscuit dough, separated and cut into quarters', '12 slices bacon strips, cooked and crumbled', '� cup butter', '� cup packed dark brown sugar', '� cup maple syrup', '1 pinch salt']", false, "https://www.allrecipes.com/recipe/261472/easy-maple-bacon-monkey-bread/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Easy Meatloaf", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fcf-images.us-east-1.prod.boltdns.net%2Fv1%2Fstatic%2F1033249144001%2F570cb8ee-6cda-4ff7-9019-ae8a2c26467e%2F651df116-74a4-4d74-8ea2-814634999166%2F1280x720%2Fmatch%2Fimage.jpg", "'� pounds ground beef', '1 egg', '1 onion, chopped', '1 cup milk', '1 cup dried bread crumbs', 'salt and pepper to taste', '2 tablespoons brown sugar', '2 tablespoons prepared mustard', ' cup ketchup']", false, "https://www.allrecipes.com/recipe/16354/easy-meatloaf/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Easy Mexican Casserole", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F5670908.jpg", "'1 pound lean ground beef', '2 cups salsa', '1 (16 ounce) can chili beans, drained', '3 cups tortilla chips, crushed', '2 cups sour cream', '1 (2 ounce) can sliced black olives, drained', '� cup chopped green onion', '� cup chopped fresh tomato', '2 cups shredded Cheddar cheese']", false, "https://www.allrecipes.com/recipe/20680/easy-mexican-casserole/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Easy Gluten-Free Macaroni and Cheese", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F2285304.jpg", "'10 ounces gluten-free elbow pasta', '� cup butter', '� teaspoons salt', '� teaspoon mustard powder', '4 cups milk', '� cup cornstarch', '4 cups shredded Cheddar cheese, divided', '2 gluten-free bread slices, toasted and broken into crumbs', '1 teaspoon butter, softened', '� teaspoon paprika']", false, "https://www.allrecipes.com/recipe/242268/easy-gluten-free-macaroni-and-cheese/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Dutch Apple Berry Pie", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F1566907.jpg", "'2 cups sliced green apples', '� cup raspberries', '� cup fresh blueberries', '1 (9 inch) deep dish pie crust', ' cup all-purpose flour', ' cup packed brown sugar', ' cup butter', '� teaspoon ground cinnamon', '� teaspoon ground allspice', '1 pinch ground nutmeg']", false, "https://www.allrecipes.com/recipe/12635/dutch-apple-berry-pie/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Dumplings", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F5011529.jpg", "'1 cup all-purpose flour', '2 teaspoons baking powder', '1 teaspoon white sugar', '� teaspoon salt', '1 tablespoon margarine', '� cup milk']", false, "https://www.allrecipes.com/recipe/6900/dumplings/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Drunken Shrimp", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F1088683.jpg", "'2 tablespoons canola oil', '1 onion, chopped', '6 cloves garlic, chopped', '2 tablespoons minced fresh ginger root', '2 pounds large shrimp, peeled and deveined', '1 pinch salt', '� teaspoon ground black pepper', '1 tablespoon red pepper flakes, or to taste', '� cup beer', '� cup ketchup', '1 tablespoon white sugar', '1 tablespoon cornstarch', '1 tablespoon water', '1 tablespoon toasted sesame oil', '3 green onions, chopped']", false, "https://www.allrecipes.com/recipe/188957/drunken-shrimp/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Cream Cheese Frosting II", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F2164995.jpg", "'2 (8 ounce) packages cream cheese, softened', '� cup butter, softened', \"2 cups sifted confectioners' sugar\", '1 teaspoon vanilla extract']", false, "https://www.allrecipes.com/recipe/9926/cream-cheese-frosting-ii/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Cream Cheese Penguins", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F580469.jpg", "'18 jumbo black olives, pitted', '1 (8 ounce) package cream cheese, softened', '18 small black olives', '1 carrot']", false, "https://www.allrecipes.com/recipe/19687/cream-cheese-penguins/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Cream Corn Like No Other", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F745492.jpg", "'2 (10 ounce) packages frozen corn kernels, thawed', '1 cup heavy cream', '1 teaspoon salt', '2 tablespoons granulated sugar', '� teaspoon freshly ground black pepper', '2 tablespoons butter', '1 cup whole milk', '2 tablespoons all-purpose flour', '� cup freshly grated Parmesan cheese']", false, "https://www.allrecipes.com/recipe/53304/cream-corn-like-no-other/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Creamed Cabbage", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F2284428.jpg", "'4 slices bacon', '� cup butter', '1 tablespoon all-purpose flour', '1 teaspoon salt', '1 large head cabbage, cored and shredded', '� cup sour cream']", false, "https://www.allrecipes.com/recipe/163145/creamed-cabbage/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Creamy Au Gratin Potatoes", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F738814.jpg", "'4 russet potatoes, sliced into 1/4 inch slices', '1 onion, sliced into rings', 'salt and pepper to taste', '3 tablespoons butter', '3 tablespoons all-purpose flour', '� teaspoon salt', '2 cups milk', '� cups shredded Cheddar cheese']", false, "https://www.allrecipes.com/recipe/15925/creamy-au-gratin-potatoes/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Creamy Chicken and Wild Rice Soup", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F7335554.jpg", "'4 cups chicken broth', '2 cups water', '2 cooked, boneless chicken breast halves, shredded', '1 (4.5 ounce) package quick cooking long grain and wild rice with seasoning packet', '� teaspoon salt', '� teaspoon ground black pepper', '� cup all-purpose flour', '� cup butter', '2 cups heavy cream']", false, "https://www.allrecipes.com/recipe/23852/creamy-chicken-and-wild-rice-soup/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Creamy Crab and Pasta Salad", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F3800828.jpg", "'1 (12 ounce) package uncooked pasta shells', '� cup light sour cream', '� cup light mayonnaise', '1 tablespoon lemon juice', '1 tablespoon honey mustard', '1 tablespoon chopped fresh dill', '� teaspoon salt', '� teaspoon ground black pepper', '1 pound cooked crabmeat', '� cup diced red bell pepper', '� cup diced green bell pepper', '� cup chopped green onions']", false, "https://www.allrecipes.com/recipe/50896/creamy-crab-and-pasta-salad/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Creamy Macaroni Salad", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F844002.jpg", "'1 teaspoon salt', '1 teaspoon dry mustard powder', '� teaspoon garlic powder', '� teaspoon paprika', '� teaspoon onion powder', '� teaspoon ground white pepper', '� teaspoon ground black pepper', '3 cups elbow macaroni', '� cups mayonnaise', '� cup sour cream', '1 (5 ounce) can evaporated milk', '� cup finely chopped onion', '3 tablespoons finely chopped green bell pepper', '3 tablespoons finely chopped red bell pepper', '2 tablespoons finely chopped yellow bell pepper', '� cup finely chopped celery', '� cup finely chopped carrots']", false, "https://www.allrecipes.com/recipe/222214/creamy-macaroni-salad/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Creamy Pasta Bake with Cherry Tomatoes and Basil", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F4573350.jpg", "'1 (16 ounce) package penne pasta', '1 tablespoon olive oil', '1 onion, finely chopped', '3 cloves garlic, minced', '3 (6 ounce) cans tomato sauce', '2 tablespoons tomato paste', '� cup heavy whipping cream', '� cup grated Parmesan cheese', 'salt and freshly ground black pepper', '1 pinch white sugar', '1 pound cherry tomatoes, halved', '� cups shredded mozzarella cheese', '1 small bunch fresh basil, finely chopped']", false, "https://www.allrecipes.com/recipe/261148/creamy-pasta-bake-with-cherry-tomatoes-and-basil/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Creamy White Chicken Chili with Salsa Verde", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F5197437.jpg", "'1 (2 pound) rotisserie chicken, skinned and boned, meat pulled into large chunks ', '1 (8 ounce) package cream cheese, softened', '� cup half-and-half', '1 tablespoon olive oil', '2 medium green bell peppers, chopped', '2 medium jalapeno peppers, diced', '3 cloves garlic, chopped', '1 tablespoon dried minced shallots', '� teaspoon cayenne pepper', 'salt and ground black pepper to taste', '8 cups chicken stock', '1 (16 ounce) jar salsa verde', '1 tablespoon ground cumin', '2 teaspoons dried oregano']", false, "https://www.allrecipes.com/recipe/281802/creamy-white-chicken-chili-with-salsa-verde/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Creepy Halloween Eyeballs", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F4565167.jpg", "'� cup strawberry jam', '1 (11 ounce) can lychees, drained', '� (6 ounce) container fresh blueberries', 'toothpicks']", false, "https://www.allrecipes.com/recipe/260637/creepy-halloween-eyeballs/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Cucumber Chicken Salad with Spicy Peanut Dressing", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F5541266.jpg", "'� cup chunky peanut butter', '1 tablespoon sambal oelek (chile paste)', '1 tablespoon low-sodium soy sauce', '1 teaspoon toasted sesame oil', '4 tablespoons water, or more as needed', '1 cucumber, peeled and sliced into thin strips', '1 cooked chicken breast, shredded into thin strands', '2 tablespoons chopped peanuts']", false, "https://www.allrecipes.com/recipe/266401/cucumber-chicken-salad-with-spicy-peanut-dressing/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Cucumber-Carrot Salad", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F814066.jpg", "'� cup seasoned rice vinegar', '1 teaspoon white sugar', '� teaspoon vegetable oil', '� teaspoon grated peeled ginger', '� teaspoon salt', '1 cup sliced carrot', '2 tablespoons sliced green onion', '2 tablespoons minced red bell pepper', '� cucumber - halved lengthwise, seeded, and sliced']", false, "https://www.allrecipes.com/recipe/220840/cucumber-carrot-salad/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Curried Carrot Soup", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F4573347.jpg", "'2 tablespoons vegetable oil', '1 onion, chopped', '1 tablespoon curry powder', '2 pounds carrots, chopped', '4 cups vegetable broth', '2 cups water, or as needed']", false, "https://www.allrecipes.com/recipe/12965/curried-carrot-soup/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Dad's Leftover Turkey Pot Pie", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F603186.jpg", "'2 cups frozen peas and carrots', '2 cups frozen green beans', '1 cup sliced celery', ' cup butter', ' cup chopped onion', ' cup all-purpose flour', '1 teaspoon salt', '1 teaspoon ground black pepper', '� teaspoon celery seed', '� teaspoon onion powder', '� teaspoon Italian seasoning', '� cups chicken broth', ' cups milk', '4 cups cubed cooked turkey meat - light and dark meat mixed', '4 (9 inch)  unbaked pie crusts']", false, "https://www.allrecipes.com/recipe/215447/dads-leftover-turkey-pot-pie/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Debbie's Amazing Apple Bread", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F1052046.jpg", "'2 eggs', '2 cups white sugar', '� cup vegetable oil', '2 teaspoons vanilla extract', '2 cups apples, peeled and diced', '2 cups all-purpose flour', '� teaspoons salt', '1 teaspoon baking powder', '� teaspoon ground cinnamon, or more to taste']", false, "https://www.allrecipes.com/recipe/231288/debbies-amazing-apple-bread/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Delicious Egg Salad for Sandwiches", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F191517.jpg", "'8 eggs', '� cup mayonnaise', '1 teaspoon prepared yellow mustard', '� cup chopped green onion', 'salt and pepper to taste', '� teaspoon paprika']", false, "https://www.allrecipes.com/recipe/147103/delicious-egg-salad-for-sandwiches/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Delicious Ham and Potato Soup", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fcf-images.us-east-1.prod.boltdns.net%2Fv1%2Fstatic%2F1033249144001%2F57320dd4-73c7-44c1-b6a8-fc2bf82e127a%2Ffb4b9643-8c51-457f-a553-10042d578db2%2F1280x720%2Fmatch%2Fimage.jpg", "'� cups peeled and diced potatoes', ' cup diced celery', ' cup finely chopped onion', '� cup diced cooked ham', '� cups water', '2 tablespoons chicken bouillon granules', '� teaspoon salt, or to taste', '1 teaspoon ground white or black pepper, or to taste', '5 tablespoons butter', '5 tablespoons all-purpose flour', '2 cups milk']", false, "https://www.allrecipes.com/recipe/56927/delicious-ham-and-potato-soup/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Dessert Crepes", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F4511555.jpg", "'4 eggs, lightly beaten', ' cups milk', '2 tablespoons butter, melted', '1 cup all-purpose flour', '2 tablespoons white sugar', '� teaspoon salt']", false, "https://www.allrecipes.com/recipe/19037/dessert-crepes/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Dinah's Baked Scallops", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F38388.jpg", "'20 buttery round crackers, crushed', 'black pepper to taste', '1 teaspoon garlic powder', '1 pound sea scallops, rinsed and drained', '� cup butter, melted', '� cup dry white wine', '� lemon, juiced', '1 tablespoon chopped fresh parsley, for garnish']", false, "https://www.allrecipes.com/recipe/18262/dinahs-baked-scallops/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Dirt Cake I", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F1073531.jpg", "'� cup butter, softened', '1 (8 ounce) package cream cheese, softened', \"� cup confectioners' sugar\", '2 (3.5 ounce) packages instant vanilla pudding mix', '� cups milk', '1 (12 ounce) container frozen whipped topping, thawed', '32 ounces chocolate sandwich cookies with creme filling']", false, "https://www.allrecipes.com/recipe/7255/dirt-cake-i/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Zesty Quinoa Salad", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F1005880.jpg", "'1 cup quinoa', '2 cups water', '� cup extra-virgin olive oil', '2 limes, juiced', '2 teaspoons ground cumin', '1 teaspoon salt', '� teaspoon red pepper flakes, or more to taste', '� cups halved cherry tomatoes', '1 (15 ounce) can black beans, drained and rinsed', '5 green onions, finely chopped', '� cup chopped fresh cilantro', 'salt and ground black pepper to taste']", false, "https://www.allrecipes.com/recipe/229156/zesty-quinoa-salad/" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Name", "ImagePath", "Ingredients", "IsDrink", "URL" },
                values: new object[] { "Zippy and Tangy Turkey Rice Soup", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F967037.jpg", "'1 leftover turkey carcass, broken into pieces', '1 large onion, chopped', '1 tablespoon chopped celery leaves, or to taste', '2 bay leaves', '1 tablespoon butter', '28 baby carrots, quartered', '3 stalks celery, chopped', '2 (14.5 ounce) cans stewed tomatoes with juice', '1 cup long-grain rice', '10 green beans, cut into bite-size pieces', '2 cubes  chicken bouillon', '1 tablespoon dried marjoram', '1 teaspoon dried thyme', '2 sprigs fresh rosemary', '� teaspoon ground ginger', '� teaspoon cayenne pepper', 'salt and ground black pepper to taste', '1 (15.25 ounce) can whole kernel corn, drained']", false, "https://www.allrecipes.com/recipe/229431/zippy-and-tangy-turkey-rice-soup/" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Recipes");
        }
    }
}
