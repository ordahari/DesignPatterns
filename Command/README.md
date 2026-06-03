# Command (Behavioral)

## Intent
Encapsulate a request as an object, thereby letting you parameterize clients with different requests, queue or log requests, and support undoable operations.

## Problem it solves
You want to issue requests to objects without knowing anything about the operation being requested or the receiver of the request. A remote control button should be able to turn on a light or a stereo without being hard-wired to either device. By wrapping each request in its own object, the button (invoker) is decoupled from the device (receiver), and behavior can be swapped at runtime simply by assigning a different command to a slot.

## Participants
- **Command** — `Interface/ICommand.cs`: declares `Execute()`, the common interface for all requests.
- **ConcreteCommand** — `Commands/LightOnCommand.cs`, `Commands/LightOffCommand.cs`, `Commands/StereoOnCommand.cs`, `Commands/StereoOffCommand.cs`, `Commands/StereoVolumeUpCommand.cs`, `Commands/StereoVolumeDownCommand.cs`, `Commands/NoCommand.cs`: each binds a receiver to an action and implements `Execute()` by invoking that action.
- **Invoker** — `RemoteControl.cs`: holds command objects in on/off slots and triggers `Execute()` when a button is pushed, without knowing what the command does.
- **Receiver** — `Devices/Light.cs`, `Devices/Stereo.cs`: knows how to perform the actual work (`On`, `Off`, `VolumeUp`, `VolumeDown`).
- **Client** — `Program.cs`: creates the receivers and concrete commands and configures the invoker's slots.

## How this example demonstrates it
`Program` builds a `RemoteControl` (invoker) whose seven slots default to `NoCommand` (a null-object command). The client then assigns commands: slot 0 controls a `Light`, slot 1 turns a `Stereo` on/off, and slot 2 maps the on/off buttons to volume up/down. Pushing a button calls `onCommands[slot].Execute()` or `offCommands[slot].Execute()`; the command forwards the call to its receiver. Because the invoker only sees `ICommand`, the same button mechanism drives completely different devices, and unconfigured slots safely run `NoCommand` instead of crashing.

## Run it
```bash
dotnet run --project Command
```

Sample output:
```
Controls:
[slot:0] - [ON:LightOnCommand] - [OFF:LightOffCommand]
[slot:1] - [ON:StereoOnCommand] - [OFF:StereoOffCommand]
[slot:2] - [ON:StereoVolumeUpCommand] - [OFF:StereoVolumeDownCommand]
[slot:3] - [ON:NoCommand] - [OFF:NoCommand]
[slot:4] - [ON:NoCommand] - [OFF:NoCommand]
[slot:5] - [ON:NoCommand] - [OFF:NoCommand]
[slot:6] - [ON:NoCommand] - [OFF:NoCommand]
Light Is On 
Light Is Off 
--Stereo Is On !!
--Stereo Volume Is: 0
--Stereo Volume Is: 1
--Stereo Is Off !!
--Stereo Is OFF
--Stereo Is OFF
```

## Things to try
- Add an `Undo()` method to `ICommand` and have `RemoteControl` remember the last command pushed, then add an undo button.
- Create a `MacroCommand` that holds an array of `ICommand` and executes them in sequence (e.g. "party mode": light on + stereo on + volume up).
- Add a new receiver such as `CeilingFan` with its own commands and wire it into a free slot to confirm the invoker needs no changes.
