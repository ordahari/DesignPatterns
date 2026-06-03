# Template Method (Behavioral)

## Intent
Define the skeleton of an algorithm in an operation, deferring some steps to subclasses. Template Method lets subclasses redefine certain steps of an algorithm without changing the algorithm's structure.

## Problem it solves
You have several variants of a procedure that share the same overall sequence of steps but differ in a few of those steps. Duplicating the whole sequence in each variant invites drift and bugs. Template Method puts the invariant sequence in one place (the base class) and lets each variant fill in only the steps that differ.

## Participants
- **AbstractClass** — `CoffeinBeveragecs.cs`: declares the template method `PrepareRecipe()` plus primitive operations (`Brew`, `AddCondiments`) and a hook (`CustomerWantsCondiments`).
- **ConcreteClass** — `Program.cs` (`Coffee`, `Tea`): implement the primitive operations, and `Tea` overrides the hook to alter the flow.

## How this example demonstrates it
The scenario prepares caffeine beverages. `CoffeinBeveragecs.PrepareRecipe()` is the **template method**: it fixes the algorithm as `BoilWater()` → `Brew()` → `PourInCup()` → (optionally) `AddCondiments()`. `BoilWater` and `PourInCup` are concrete shared steps. `Brew` and `AddCondiments` are abstract **primitive operations** that each subclass overrides. `CustomerWantsCondiments()` is a **hook** with a default of `true`.

Call flow: `Coffee` brews by dripping and adds sugar/milk (hook default keeps condiments). `Tea` steeps and would add lemon, but overrides the hook to return `false`, so `PrepareRecipe()` skips the `AddCondiments()` step — the algorithm's structure is unchanged, only a step is redefined.

## Run it
```bash
dotnet run --project TemplateMethod
```

Sample output:
```
Making coffee:
Boil the water..
Dripping coffee through filter..
Pour into cup..
Add sugar and milk..

Making tea (no condiments):
Boil the water..
Steep the tea..
Pour into cup..
```

## Things to try
- Add a new beverage (e.g. `HotChocolate`) by subclassing `CoffeinBeveragecs` and implementing only `Brew` and `AddCondiments` — notice you never touch the algorithm.
- Make `Tea` return `true` from `CustomerWantsCondiments()` and watch the lemon step reappear without editing `PrepareRecipe()`.
- Try to override `PrepareRecipe()` itself and observe why the pattern intentionally keeps the template method non-virtual.
