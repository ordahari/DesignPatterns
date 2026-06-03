# Strategy (Behavioral)

## Intent
Define a family of algorithms, encapsulate each one, and make them interchangeable. Strategy lets the algorithm vary independently from clients that use it.

## Problem it solves
A duck can fly and quack, but different ducks do these differently — and the same duck might change how it behaves over its lifetime. Hard-coding the behavior into each duck subclass (or with `if`/`switch` ladders) leads to duplicated, rigid code. Strategy pulls each behavior out into its own swappable object, so behavior can be mixed, matched, and changed at runtime without touching the duck classes.

## Participants
- **Strategy** — `Stategy/Behaviors/IFlyBehavior.cs`, `Stategy/Behaviors/IQuackBehavior.cs`: interfaces declaring the interchangeable algorithms (`Fly()`, `Quack()`).
- **ConcreteStrategy** — `Stategy/Behaviors/FlyBehaviors/FlyWithWings.cs`, `Stategy/Behaviors/FlyBehaviors/FlyNoWay.cs`, `Stategy/Behaviors/QuackBehaviors/RegularQuacking.cs`, `Stategy/Behaviors/QuackBehaviors/Squeak.cs`, `Stategy/Behaviors/QuackBehaviors/MuteQuack.cs`: concrete implementations of each algorithm.
- **Context** — `Ducks/BaseDuck.cs`: holds a fly + quack strategy, delegates to them via `PerformFly()`/`PerformQuack()`, and exposes `SetFlyBehavior`/`SetQuackBehavior` to swap them at runtime. Subclasses (`MallardDuck`, `RedheadDuck`, `RubberDuck`, `DecoyDuck`) wire up their default strategies.
- **Client** — `../StrategyTest/Program.cs`: builds ducks, invokes their behaviors, and swaps a behavior at runtime.

## How this example demonstrates it
Each duck subclass composes a `IQuackBehavior` and `IFlyBehavior` through `BaseDuck`'s constructor instead of inheriting hard-coded behavior. When the client calls `duck.PerformFly()`, `BaseDuck` delegates to whichever `IFlyBehavior` it currently holds — a `MallardDuck` reports "flying" (`FlyWithWings`) while a `RubberDuck` reports "can't fly!" (`FlyNoWay`).

The runtime swap is the key demonstration: the client takes the `DecoyDuck` (which starts with `FlyNoWay` + `MuteQuack`) and calls `SetFlyBehavior(new FlyWithWings())` and `SetQuackBehavior(new RegularQuacking())`. Without changing the duck's type, its subsequent `PerformFly()`/`PerformQuack()` calls now produce "flying" and "quacking" — the algorithm varied independently of the object using it.

## Run it
```bash
dotnet run --project StrategyTest
```

Sample output:
```
I’m a real Mallard Duck
All ducks float, even decoys!
flying
quacking

I’m a real Redhead Duck
All ducks float, even decoys!
flying
quacking

I’m a Rubber Duck
All ducks float, even decoys!
can’t fly!
Squeak

I’m a Decoy Duck
All ducks float, even decoys!
can’t fly!
can’t quack!

Giving the decoy duck a rocket and a voice at runtime...
I’m a Decoy Duck
flying
quacking
```

## Things to try
- Add a new fly behavior, e.g. `FlyRocketPowered : IFlyBehavior` returning "flying with a rocket!", and swap it onto a duck at runtime via `SetFlyBehavior`.
- Add a new duck (e.g. `ModelDuck`) that starts grounded with `FlyNoWay`, then have the client upgrade its flight strategy.
- Give `BaseDuck` a new strategy axis (such as `ISwimBehavior`) to see how Strategy scales to additional interchangeable behaviors.
```
