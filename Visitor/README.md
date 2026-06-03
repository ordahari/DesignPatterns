# Visitor (Behavioral)

## Intent
Represent an operation to be performed on the elements of an object structure. Visitor lets you define a new operation without changing the classes of the elements on which it operates.

## Problem it solves
You have a fixed set of element types (shopping-cart items) but keep needing new operations over them (different ways to compute tax). Putting every operation directly on the item classes would bloat them and force edits each time a rule changes. Visitor moves each operation into its own class, so you can add new behaviors (a new tax scheme) without touching the item types.

## Participants
- **Visitor** — `IVisitor.cs`: declares a `CalcPriceWithTax` overload (`Visit`) for each concrete item type.
- **ConcreteVisitor** — `TaxVisitor.cs`, `HolidayTaxVisitor.cs`: implement the operation, supplying the actual tax rules per item.
- **Element** — `IVisitable.cs`: declares `Accept(ITaxVisitor)` so an item can receive a visitor.
- **ConcreteElement** — `Items/LiquorItem.cs`, `Items/TobaccoItem.cs`, `Items/NecessityItem.cs`: implement `Accept` by calling back `visitor.CalcPriceWithTax(this)`.
- **ObjectStructure / Client** — the tests in `VisitorTests/`: create items, pick a visitor, and call `item.Accept(visitor)`.

## How this example demonstrates it
Each cart item (`LiquorItem`, `TobaccoItem`, `NecessityItem`) implements `IVisitable.Accept`. A client picks a tax strategy — the standard `TaxVisitor` or the discounted `HolidayTaxVisitor` — and calls `item.Accept(visitor)`.

Double dispatch happens in two hops:
1. The call `item.Accept(visitor)` is dispatched on the **item's** runtime type (e.g. `LiquorItem.Accept`).
2. Inside `Accept`, `visitor.CalcPriceWithTax(this)` is dispatched on the **visitor's** runtime type, and `this` is statically typed as `LiquorItem`, so the compiler binds the `LiquorItem` overload.

The combination of the item type and the visitor type selects exactly one method — e.g. a `LiquorItem` priced 70 yields 94 under `TaxVisitor` (35% tax) but 77 under `HolidayTaxVisitor` (10% tax), with no `if`/`switch` on type anywhere.

## Run it (unit tests)
```bash
dotnet test VisitorTests
```

Test result:
```
Passed!  - Failed:     0, Passed:     6, Skipped:     0, Total:     6
```

## Things to try
- Add a new visitor (e.g. `ExportTaxVisitor : ITaxVisitor`) and verify each item type routes to the right overload — no item classes change.
- Add a new item element (e.g. `ElectronicsItem : IVisitable`); notice you must add a `CalcPriceWithTax(ElectronicsItem)` overload to `ITaxVisitor` and every visitor (the Visitor pattern's known trade-off).
- Write a test that sums `Accept` results across a `List<IVisitable>` to tax a whole cart with one visitor.
