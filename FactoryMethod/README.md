# Factory Method (Creational)

## Intent
Define an interface for creating an object, but let subclasses decide which class to instantiate. Factory Method lets a class defer instantiation to subclasses.

## Problem it solves
A class needs to create objects but should not be hard-wired to their concrete types. Here, every pizza store follows the same ordering steps (prepare, bake, cut, box), yet a New York store and a Chicago store must produce different regional pizzas. Instead of scattering `new` statements and `if` branches through the ordering code, each store overrides a single creation method, so the shared workflow stays identical while the concrete pizza is chosen by the subclass.

## Participants
- **Creator** — `PizzaStore/IPizzaStore.cs` (abstract class `PizzaStore`): declares the `CreatePizza` factory method and the `OrderPizza` template operation that calls it.
- **ConcreteCreator** — `PizzaStore/NYPizzaStore.cs`, `PizzaStore/ChicagoPizzaStore.cs`: override `CreatePizza` to build region-specific products with the matching ingredient factory.
- **Product** — `Pizza/Pizza.cs` (abstract class `Pizza`): the common product type the creator returns and the workflow operates on.
- **ConcreteProduct** — `Pizza/CheesePizza.cs`, `Pizza/ClamPizza.cs`, `Pizza/PepperoniPizza.cs`, `Pizza/VeggiesPizza.cs`: concrete pizzas assembled in `Prepare()`.

## How this example demonstrates it
`Program.Main` creates a `ChicagoPizzaStore` and an `NYPizzaStore`, both typed as the abstract `PizzaStore` creator. For each `PizzaType` it calls `store.OrderPizza(type)`. `OrderPizza` is the creator's template operation: it calls the overridable `CreatePizza` factory method, then runs the fixed steps `Prepare()`, `Bake()`, `Cut()`, `Box()`. The factory method is where the subclasses diverge — `NYPizzaStore.CreatePizza` returns NY products wired to `NYIngredientsFactory`, while `ChicagoPizzaStore.CreatePizza` returns Chicago products wired to `ChicagoIngredientsFactory`. The creator code never names a concrete `Pizza` subclass; instantiation is deferred entirely to the subclass that overrides `CreatePizza`. An unknown `PizzaType` throws `ArgumentOutOfRangeException` rather than returning null.

## Run it
```bash
dotnet run --project FactoryMethod
```

Sample output:
```
Preparing Chicago CheesePizza
ThickCrustDough
PlumTomatoSauce
MozzarellaCheese
Bake For 25 Minuets at 350
Cutting the pizza into diagonal slices
Please Pizza in official PizzaStore box
--------------Reedy----------------
Preparing Chicago ClamPizza
ThickCrustDough
PlumTomatoSauce
MozzarellaCheese
FrozenClams
Bake For 25 Minuets at 350
Cutting the pizza into diagonal slices
Please Pizza in official PizzaStore box
--------------Reedy----------------
Preparing Chicago Pepperoni
ThickCrustDough
PlumTomatoSauce
MozzarellaCheese
SlicedPepperoni
Bake For 25 Minuets at 350
Cutting the pizza into diagonal slices
Please Pizza in official PizzaStore box
--------------Reedy----------------
Preparing Chicago Veggies
ThickCrustDough
PlumTomatoSauce
Veggies
Bake For 25 Minuets at 350
Cutting the pizza into diagonal slices
Please Pizza in official PizzaStore box
--------------Reedy----------------
Preparing NY CheesePizza
ThinCrustDough
MarinaraSauce
ReggianoCheese
Bake For 25 Minuets at 350
Cutting the pizza into diagonal slices
Please Pizza in official PizzaStore box
--------------Reedy----------------
Preparing NY ClamPizza
ThinCrustDough
MarinaraSauce
ReggianoCheese
FreshClams
Bake For 25 Minuets at 350
Cutting the pizza into diagonal slices
Please Pizza in official PizzaStore box
--------------Reedy----------------
Preparing NY Pepperoni
ThinCrustDough
MarinaraSauce
ReggianoCheese
SlicedPepperoni
Bake For 25 Minuets at 350
Cutting the pizza into diagonal slices
Please Pizza in official PizzaStore box
--------------Reedy----------------
Preparing NY Veggies
ThinCrustDough
MarinaraSauce
Veggies
Bake For 25 Minuets at 350
Cutting the pizza into diagonal slices
Please Pizza in official PizzaStore box
--------------Reedy----------------
```

## Things to try
- Add a `CaliforniaPizzaStore` ConcreteCreator with its own ingredient factory and override `CreatePizza` — notice you change no existing store or `OrderPizza` code.
- Add a new `PizzaType` (e.g. `BbqPizza`) plus a matching ConcreteProduct, and watch the `_ =>` arm guard the stores that have not handled it yet.
- Move a step (say, an optional `AddExtraCheese()`) into `OrderPizza` to see how the creator's template operation governs the shared workflow for every store at once.
