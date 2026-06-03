# Composite (Structural)

## Intent
Compose objects into tree structures to represent part-whole hierarchies. Composite lets clients treat individual objects and compositions of objects uniformly.

## Problem it solves
You have data that is naturally a tree — a to-do list can contain plain items, but it can also contain nested sub-lists, which in turn contain more items or lists. Without Composite the client must constantly check "is this a single item or a group?" and branch its logic. Composite removes that distinction: every node, leaf or branch, exposes the same interface, so the client renders the whole tree with a single call on the root.

## Participants
- **Component** — `ITodoList.cs`: the shared interface (`GetHtml()`) implemented by both leaves and composites.
- **Leaf** — `Todo.cs`: a single to-do item with no children; returns its own text.
- **Composite** — `TodoList.cs`: a titled list that holds child `ITodoList` objects and renders them by calling `GetHtml()` on each child.
- **Client** — `Program.cs`: builds the tree and calls `GetHtml()` once on the root.

## How this example demonstrates it
`Program` builds a "Shopping" list containing a `Todo("Milk")` leaf and a nested `TodoList("Vegetables")` composite (which itself holds `Todo("Carrots")`), then adds a `Todo("Eggs")` leaf. The client calls `shopping.GetHtml()` exactly once. Inside `TodoList.GetHtml()`, the `foreach` loop calls `item.GetHtml()` on every child without knowing or caring whether that child is a `Todo` (leaf) or another `TodoList` (composite) — both satisfy `ITodoList`. When a child is itself a composite, the call recurses naturally, walking the whole tree. That uniform treatment of leaf and composite through the common `ITodoList` interface is the essence of the pattern.

## Run it
```bash
dotnet run --project TodoListComposite
```

Sample output:
```
<h1>Shopping</h1>
<ul>
<li>Milk</li>
<li><h1>Vegetables</h1>
<ul>
<li>Carrots</li>
</ul></li>
<li>Eggs</li>
</ul>
```

## Things to try
- Add a deeper nesting level (a `TodoList` inside the "Vegetables" list) and confirm the client code does not change at all.
- Add a new leaf type (e.g. a `DoneTodo` that wraps its text in `<s>...</s>`) implementing `ITodoList`, drop it into any list, and see it render uniformly.
- Add a `Count()` method to `ITodoList` where `Todo` returns 1 and `TodoList` sums its children, to total all items across the tree.
