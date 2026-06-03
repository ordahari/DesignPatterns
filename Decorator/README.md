# Decorator (Structural)

## Intent
Attach additional responsibilities to an object dynamically. Decorators provide a flexible alternative to subclassing for extending functionality.

## Problem it solves
You want to add behavior (and cost/description here) to individual objects at runtime without changing their class and without creating a combinatorial explosion of subclasses for every possible combination of features. A coffee shop can't realistically have a class for `DarkRoastWithMochaAndSoy`, `EspressoWithWhipAndMocha`, and so on — instead, condiments wrap a beverage and add to it.

## Participants
- **Component** — `Beverages/Base/IBeverage.cs`: common interface (`Cost`, `Description`) for objects that can be decorated.
- **ConcreteComponent** — `Beverages/DarkRoast.cs`, `Beverages/Espresso.cs`, `Beverages/Decaf.cs`, `Beverages/HouseBlend.cs` (base class `Beverages/Base/Beverage.cs`): the base beverages whose behavior can be extended.
- **Decorator** — `Decorators/Base/BeverageCondimentDecorator.cs`: abstract base that holds a wrapped `IBeverage` and forwards `Cost`/`Description` to it.
- **ConcreteDecorator** — `Decorators/MochaDecorator.cs`, `Decorators/SoyDecorator.cs`, `Decorators/WhipDecorator.cs`: each adds its own cost and appends its name to the description.
- **Client** — `../DecoratorTest/Program.cs`: builds beverages, wraps them with condiments, and queries the result.

## How this example demonstrates it
Start with a `DarkRoast` (a ConcreteComponent). Wrap it in a `MochaDecorator`, then wrap that in a `SoyDecorator`. Each decorator implements the same `IBeverage` interface and holds a reference to the beverage it wraps. When the client asks the outermost object for its `Cost` or `Description`, the call flows inward: `SoyDecorator` adds `0.32` to whatever `MochaDecorator` reports, which adds `0.20` to whatever `DarkRoast` reports (`0.99`), giving `1.51`. The same applies to `Description`, producing `"Dark Roast , Mocha , Soy"`. The wrapping order is decided at runtime by the client, not baked into class hierarchies.

## Run it
```bash
dotnet run --project DecoratorTest
```

Sample output:
```
Description:Dark Roast
Cost:0.99
Description:Dark Roast , Mocha
Cost:1.19
Description:Dark Roast , Mocha , Soy
Cost:1.51
Description:Espresso
Cost:1.99
Description:Espresso , Whip
Cost:2.76
Description:Espresso , Whip , Mocha
Cost:2.96
```

## Things to try
- Add a new condiment decorator (e.g. `CaramelDecorator`) by subclassing `BeverageCondimentDecorator` and overriding `Cost`/`Description`, then wrap a beverage with it in `Program.cs`.
- Wrap the same condiment twice (e.g. a double Mocha) to see the cost and description accumulate.
- Add a new base beverage (a ConcreteComponent) and verify every existing decorator works on it unchanged.
