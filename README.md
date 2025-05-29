# Task Manager App

A simple task management application written in C#. This project demonstrates the use of key software design patterns (**Factory**, **State**, and **Facade**) to build a flexible, extensible task tracking system. Users can add tasks, change their state, and manage them easily through a unified interface.

## Features Planned

* Create different types of tasks - factory
* Change task states - state
* Simplified task operations  - facade
* Save and load tasks from file (future)
* Task filtering and sorting (future)
* Make into exe (future)
* GUI interface (future)

## Design Patterns Overview

This project uses the following software design patterns to promote clean, maintainable, and scalable architecture:

Factory Pattern:
Used to create different types of tasks (e.g., simple tasks, timed tasks, recurring tasks) without tightly coupling the code to specific classes. This makes it easy to extend the app with new task types in the future.

State Pattern:
Implements a flexible task lifecycle by allowing each task to change its behavior based on its current state. Tasks transition between states such as New, InProgress, and Completed. Each state encapsulates its behavior and knows how to transition to the next valid state. This separation ensures tasks are easy to extend or modify without modifying a central task controller.

## Getting Started

1. Clone this repository:

   ```bash
   git clone https://github.com/MikePerez2022/Task-Manager.git
   ```

2. Open in Visual Studio.

3. Build and run.

