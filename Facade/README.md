# Facade (Structural)

## Intent
Provide a unified interface to a set of interfaces in a subsystem. Facade defines a higher-level interface that makes the subsystem easier to use.

## Problem it solves
Building a car requires coordinating several independent subsystems (assembly, quality control, delivery) in the right order. A client that talks to each subsystem directly becomes tightly coupled to their details and call sequence. The Facade hides this complexity behind a single, simple method so the client only needs to know "make me a car."

## Participants
- **Facade** — `CarFacade.cs`: exposes the single `CreateCar()` entry point and orchestrates the subsystems in order.
- **Subsystem** — `SubSystems/CarBuilder.cs`: assembles the car (`BuildCar`).
- **Subsystem** — `SubSystems/CarQC.cs`: runs quality control (`CarQualityControl`).
- **Subsystem** — `SubSystems/CarDelivery.cs`: ships the car to the client (`DeliverCar`).
- **Client** — `Program.cs`: uses only the facade, never the subsystems directly.

## How this example demonstrates it
The client constructs a `CarFacade` and calls `CreateCar()`. Internally the facade owns one instance of each subsystem and invokes them in the required sequence: `CarBuilder.BuildCar()` → `CarQC.CarQualityControl()` → `CarDelivery.DeliverCar()`. The client stays unaware of how many subsystems exist or in what order they must run.

## Run it
```bash
dotnet run --project Facade
```

Sample output:
```
---------Create Car---------
Build A New Car
Car in Quality Control
Car Is Delivering to client
-------------END--------------
```

## Things to try
- Add a `CarPainting` subsystem and wire it into `CreateCar()` between build and QC — notice the client code does not change.
- Add a parameterized overload `CreateCar(string model)` and thread the model through the subsystems.
- Make QC return a pass/fail result and have the facade skip delivery when QC fails.
