# Adapter (Structural)

## Intent
Convert the interface of a class into another interface clients expect. Adapter lets classes work together that otherwise couldn't because of incompatible interfaces.

## Problem it solves
Your client code is written against one interface, but the type you actually have exposes a different, incompatible one. Rather than rewriting the client or the existing class, you wrap the existing class in an adapter that translates calls into the interface the client expects. This lets you reuse code you cannot (or don't want to) change.

## Participants
- **Target** — `Interface/IDuck.cs`: the interface the client expects (`Name`, `Quack`, `Fly`).
- **Adaptee** — `Interface/ITurkey.cs` (implemented by `WildTurkey.cs`): the existing, incompatible interface (`Fly`, `Gobble`).
- **Adapter** — `DuckAdapter.cs`: implements `IDuck` and forwards each call to a wrapped `ITurkey`, translating the interface.
- **Client** — `Program.cs`: works only with `IDuck`, unaware that one of the "ducks" is really a turkey.

## How this example demonstrates it
The client (`Run` in `Program.cs`) only knows how to talk to `IDuck`. A `MallardDuck` already implements `IDuck`, so it goes straight into the list. A `WildTurkey` implements the unrelated `ITurkey`, so it is wrapped in a `DuckAdapter`. When the client calls the `IDuck` methods on the adapter, the adapter translates them onto the turkey: `Quack()` becomes the turkey's `Gobble()`, and `Fly()` flaps five times because a turkey only flies short distances, approximating a duck's longer flight. The client treats both items uniformly through `IDuck`.

## Run it
```bash
dotnet run --project Adapter
```

Sample output:
```
Mallard Duck
I'm flying !!
Quack
WildTurkey
I'm flying a Short distance
I'm flying a Short distance
I'm flying a Short distance
I'm flying a Short distance
I'm flying a Short distance
Gobble gobble..
```

## Things to try
- Add a `GooseAdapter` that adapts a `Goose` (with a `Honk()` method) to `IDuck`, and drop it into the same list.
- Change the adapter's `Fly()` loop count and observe how only the adapter's behavior changes, not the client.
- Implement a two-way adapter that also lets a duck be used where an `ITurkey` is expected.
```
