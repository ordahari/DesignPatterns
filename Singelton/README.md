# Singleton (Creational)

## Intent
Ensure a class has only one instance, and provide a global point of access to it.

## Problem it solves
Some resources should exist exactly once in a program (a configuration store, a connection pool, or — here — a single physical chocolate boiler). If code could freely create new instances, multiple "boilers" would each track their own state and the program would lose a single source of truth. Singleton guarantees one shared instance and hands every caller the same object, even when several threads request it at the same time.

## Participants
- **Singleton** — `Singelton/ChocolateBoler.cs`: the `ChocolateBoler` class with a private constructor, a single static instance, and a public `Instance` accessor; models a boiler that can be filled, boiled, and drained.
- **Client** — `Singelton/Program.cs`: requests `ChocolateBoler.Instance` from two threads and drives the boiler through its fill/boil/drain lifecycle.

## How this example demonstrates it
`ChocolateBoler` has a `private` constructor, so no other code can `new` it. The only way in is the static `Instance` property. Thread-safety uses the classic **double-checked locking** idiom: the field is `volatile`, and `Instance` checks `instance == null` once without a lock (fast path), then locks `syncRoot` and checks again before constructing, so only one thread ever creates the object.

The client first grabs `ChocolateBoler.Instance` on the main thread, then starts a second thread (`SomeThread`) that also grabs `ChocolateBoler.Instance` and confirms with `ReferenceEquals` that it received the *same* object — proving the single-instance guarantee. After joining that thread, the main thread walks the shared boiler through its lifecycle: `Fill()` → `Boiled()` → `Drain()`, printing the empty/boiled state at each step.

## Run it
```bash
dotnet run --project Singelton
```

Sample output:
```
SomeThread got the same instance: True
fill the boiler with a milk / chocolate 
IsEmpty:False
IsBoiled:True
IsEmpty:False
IsBoiled:True
drain the boiled milk and chocolate
IsEmpty:True
IsBoiled:False
```

## Things to try
- Replace the double-checked locking in `Instance` with the idiomatic `private static readonly Lazy<ChocolateBoler>` approach and confirm the output is unchanged.
- Add more threads that each print `ReferenceEquals(ChocolateBoler.Instance, first)` to see that every thread shares one boiler.
- Make the constructor `public` temporarily and watch how the "single source of truth" guarantee breaks once callers can create their own boilers.
