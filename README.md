# DesignPatterns

A hands-on **learning repository** that showcases the classic
[Gang of Four](https://en.wikipedia.org/wiki/Design_Patterns) (GoF) design patterns in C#.
Each pattern lives in its own project with a tiny, **runnable** example (mostly the
*Head First Design Patterns* scenarios) and a short README explaining the intent, the
participants, and how the example demonstrates the pattern.

> **Purpose:** these projects are not a framework or a library to depend on — they exist to
> *show how each pattern works* and let you run, read, and tinker with a minimal example.

## Architecture / intent

- **One pattern per project.** Every project is a self-contained illustration of a single
  pattern. Most are console apps you can run directly; a few patterns are a small class
  **library** plus a console **driver** (or, for Visitor, an **MSTest** suite) that exercises it.
- **Consistent shape.** Each pattern folder has a `README.md` with the same sections:
  *Intent → Problem it solves → Participants (mapped to files) → How this example
  demonstrates it → Run it (with sample output) → Things to try.*
- **Modern baseline.** All projects target **.NET 10 / C# 14**, SDK-style, with nullable
  reference types and analyzers enabled (see `Directory.Build.props`). The build is
  warning-clean.

## The patterns

### Creational
| Pattern | What it does | Run |
|---|---|---|
| [Abstract Factory](FactoryDesignPattern/README.md) | Create families of related objects without naming concrete classes | `dotnet run --project FactoryDesignPattern` |
| [Factory Method](FactoryMethod/README.md) | Let a base class define an algorithm but defer object creation to subclasses | `dotnet run --project FactoryMethod` |
| [Singleton](Singelton/README.md) | Guarantee one instance with controlled, thread-safe access | `dotnet run --project Singelton` |

### Structural
| Pattern | What it does | Run |
|---|---|---|
| [Adapter](Adapter/README.md) | Make one interface usable where another is expected | `dotnet run --project Adapter` |
| [Decorator](Decorator/README.md) | Add responsibilities to an object dynamically by wrapping it | `dotnet run --project DecoratorTest` |
| [Facade](Facade/README.md) | Provide one simple entry point over a set of subsystems | `dotnet run --project Facade` |
| [Composite](TodoListComposite/README.md) | Treat individual objects and trees of objects uniformly | `dotnet run --project TodoListComposite` |

### Behavioral
| Pattern | What it does | Run |
|---|---|---|
| [Command](Command/README.md) | Encapsulate a request as an object (queue, log, undo) | `dotnet run --project Command` |
| [Observer](Observer/README.md) | Notify dependents automatically when subject state changes | `dotnet run --project ObserverTest` |
| [Strategy](Strategy/README.md) | Swap interchangeable algorithms at runtime | `dotnet run --project StrategyTest` |
| [Template Method](TemplateMethod/README.md) | Fix an algorithm's skeleton, let subclasses fill in steps | `dotnet run --project TemplateMethod` |
| [Visitor](Visitor/README.md) | Add operations over an object structure via double dispatch | `dotnet test VisitorTests` |

## Getting started

Requires the [.NET 10 SDK](https://dotnet.microsoft.com/download) (pinned in `global.json`).

```bash
# Build everything
dotnet build

# Run any single example (see the table above)
dotnet run --project Adapter

# Run the unit tests (Visitor)
dotnet test
```

## Repository layout

```
<Pattern>/            one project per pattern, each with its own README.md
  *.cs                the implementation + a console Main (or a test suite)
<Pattern>Test/        console driver or MSTest suite for library-style patterns
DesignPatterns.sln    the solution tying all projects together
Directory.Build.props shared .NET 10 / C# 14 build settings
```

## License

[MIT](LICENSE).
