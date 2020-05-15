import Categories.Cheese;
import Categories.Sauce;
import Categories.Veggie;

public interface IngredientsFactory {
	Cheese createCheese();
	Sauce[] createSauce();
	Veggie[] createVeggie();
}
