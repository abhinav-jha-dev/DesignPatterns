import Categories.Cheese;
import Categories.Sauce;
import Categories.Veggie;
import Ingredients.CapsicumVeggie;
import Ingredients.MarinaraSauce;
import Ingredients.MozzarellaCheese;
import Ingredients.OnionVeggie;
import Ingredients.PlumTomatoSauce;

public class SmallTownIngredientFactory implements IngredientsFactory{

	@Override
	public Cheese createCheese() {
		return new MozzarellaCheese();
	}

	@Override
	public Sauce[] createSauce() {
		return new Sauce[] {new PlumTomatoSauce(), new MarinaraSauce()};
	}

	@Override
	public Veggie[] createVeggie() {
		return new Veggie[] {new CapsicumVeggie(), new OnionVeggie()};
	}

}
