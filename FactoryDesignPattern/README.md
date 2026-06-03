# Abstract Factory (Creational)

## Intent
Provide an interface for creating families of related or dependent objects without specifying their concrete classes.

## Problem it solves
You need to create products that belong together (a regional family of pizzas) and you want client code to work with any one of several interchangeable families without hard-coding which concrete classes it uses. Swapping the factory swaps the entire product family at once, while keeping every product consistent with its family.

## Participants
- **AbstractFactory** — `Factory/IPizzaFactory.cs`: declares `CreatePizza(PizzaType)` for producing a family of pizzas.
- **ConcreteFactory** — `Factory/NYPizzaFactory.cs`, `Factory/ChicagoPizzaFactory.cs`: each produces one regional family of concrete pizzas.
- **AbstractProduct** — `Pizza/IPizza.cs`: the product interface (`Prepare`, `Bake`, `Cut`, `Box`).
- **ConcreteProduct** — `Pizza/NYPizzaTypes/*.cs`, `Pizza/ChicagoPizzaTypes/*.cs`: the concrete pizzas (Cheese, Clam, Papperoni, Veggie) per region.
- **Client** — `PizzaStore/PizzaStore.cs` (with `NYPizzaStore.cs` / `ChicagoPizzaStore.cs` wiring a factory) and `Program.cs`: orders pizzas through the abstract factory without knowing concrete types.

## How this example demonstrates it
`Program` creates a `ChicagoPizzaStore` and an `NYPizzaStore`. Each store is constructed with its matching concrete factory (`ChicagoPizzaFactory` / `NYPizzaFactory`) and holds it as an `IPizzaFactory`. When `OrderPizza(PizzaType)` is called, the abstract `PizzaStore` asks its factory to `CreatePizza(...)`, then runs the same lifecycle on the returned `IPizza`: `Prepare → Bake → Cut → Box`. The store never references a concrete pizza class — switching from the Chicago factory to the NY factory swaps the whole product family, so the exact same client code prints the NY variants instead. An unknown `PizzaType` throws `ArgumentOutOfRangeException` rather than returning null.

## Run it
```bash
dotnet run --project FactoryDesignPattern
```

Sample output:
```
Chicago Pizza Store
Prepare Chicago Cheese Pizza !!
Bake Chicago Cheese Pizza !!
Cut Chicago Cheese Pizza !!
Box Chicago Cheese Pizza !!
Prepare Chicago Clam Pizza !!
Bake Chicago Clam Pizza !!
Cut Chicago Clam Pizza !!
Box Chicago Clam Pizza !!
Prepare Chicago Papperoni Pizza !!
Bake Chicago Papperoni Pizza !!
Cut Chicago Papperoni Pizza !!
Box Chicago Papperoni Pizza !!
Prepare Chicago Veggie Pizza !!
Bake Chicago Veggie Pizza !!
Cut Chicago Veggie Pizza !!
Box Chicago Veggie Pizza !!
NY Pizza Store
Prepare NY Cheese Pizza !!
Bake NY Cheese Pizza !!
Cut NY Cheese Pizza !!
Box NY Cheese Pizza !!
Prepare NY Clam Pizza !!
Bake NY Clam Pizza !!
Cut NY Clam Pizza !!
Box NY Clam Pizza !!
Prepare NY Papperoni Pizza !!
Bake NY Papperoni Pizza !!
Cut NY Papperoni Pizza !!
Box NY Papperoni Pizza !!
Prepare NY Veggie Pizza !!
Bake NY Veggie Pizza !!
Cut NY Veggie Pizza !!
Box NY Veggie Pizza !!
```

## Things to try
- Add a new region (e.g. a `CaliforniaPizzaFactory` + its concrete pizzas + a `CaliforniaPizzaStore`) and notice that `PizzaStore`/`Program` need no changes to the ordering logic.
- Add a new product to the family by extending `PizzaType` (e.g. `MargheritaPizza`) and implementing it in every concrete factory — the compiler/`ArgumentOutOfRangeException` will flag any factory you forget.
- Order an undefined `PizzaType` (e.g. `(PizzaType)99`) and observe the `ArgumentOutOfRangeException` instead of a null pizza.
