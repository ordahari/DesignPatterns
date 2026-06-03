# Observer (Behavioral)

## Intent
Define a one-to-many dependency between objects so that when one object changes state, all its dependents are notified and updated automatically.

## Problem it solves
A subject holds state that several other objects care about, but you do not want the subject hard-wired to those objects. Observers should be able to come and go freely, and each should react to updates in its own way, without the subject knowing their concrete types.

## Participants
- **Subject** — `Observer/Observer/ISubject.cs`: declares register, remove, and notify operations for managing observers.
- **ConcreteSubject** — `Observer/WeatherData/WeatherStation.cs`: stores the weather measurements and notifies all registered observers whenever they change.
- **Observer** — `Observer/Observer/IObserver.cs`: declares the `Update` method the subject calls when its state changes.
- **ConcreteObserver** — `ObserverTest/Observers/CurrentConditionsDisplay.cs` and `ObserverTest/Observers/StatisticsDisplay.cs`: react to updates, one showing the latest reading and one showing running averages.

## How this example demonstrates it
`WeatherStation` is a weather subject. In `ObserverTest/Program.cs` two displays subscribe via `RegisterObserver`. Each loop iteration calls `SetMeasurements(...)`, which builds a new `WeatherDataResult`, then `MeasurementsChanged()` invokes `NotifyObservers()`. The station walks its observer list and calls `Update(data)` on each one. `CurrentConditionsDisplay` prints the new reading; `StatisticsDisplay` appends the reading and prints running averages. The station never references the display types directly — it only knows the `IObserver` contract — so observers can be added or removed (`RemoveObserver`) without changing the subject.

## Run it
```bash
dotnet run --project ObserverTest
```

Sample output (measurements are random, so values differ each run; one iteration shown):
```
Count :19
Current Conditions Display :
 Temperature :38
 Humidity :11
 Pressure :44
Statistics Display :
 Avg Temperature :3
 Avg Humidity : 49
 Avg Pressure : 30
```

## Things to try
- Add a new display (for example a `ForecastDisplay` implementing `IObserver, IDisplayElement`) and register it in `Program.cs` — the station notifies it with no other changes.
- Call `weather.RemoveObserver(...)` mid-loop and watch that display stop updating while the others continue.
- Add a `HeatIndexDisplay` that derives a value from temperature and humidity to see how observers can interpret the same data differently.
