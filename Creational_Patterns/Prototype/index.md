# Prototype Pattern

> Prototype pattern can be used to clone an existing object with distinct values, rather creating `new` object.

## Intent

- Specify the kinds of objects to create using a prototypical instance, and create new objects by copying this prototype.
- Co-opt one instance of a class for use as a breeder of all future instances.
- The `new` operator considered harmful.

## How to use it?

There are three actors while implementing prototype pattern:

- **Prototype** : This is the prototype of actual object.
- **Prototype registry** : This is used as registry service to have all prototypes accessible using simple string parameters.
- **Client** : Client will be responsible for using registry service to access prototype instances.

## When to use this Pattern?

When a system should be independent of how its products are created, composed, and represented and
When the classes to instantiate are specified at run-time.
For example,
1) By dynamic loading or To avoid building a class hierarchy of factories that parallels the class hierarchy of products or

2) When instances of a class can have one of only a few different combinations of state. It may be more convenient to install a corresponding number of prototypes and clone them rather than instantiating the class manually, each time with the appropriate state.