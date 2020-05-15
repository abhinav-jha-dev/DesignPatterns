# Object Pool

> Simple singleton class instance for managing object creation.

## Example

Object pool pattern is similar to an office warehouse. When a new employee is hired, office manager has to prepare a work space for him. She figures whether or not there's a spare equipment in the office warehouse. If so, she uses it. If not, she places an order to purchase new equipment from Amazon. In case if an employee is fired, his equipment is moved to warehouse, where it could be taken when new work place will be needed.

## Check list

1. Create `ObjectPool` class with private array of `Objects` inside
2. Create `acquire` and `release` methods in ObjectPool class
3. Make sure that your ObjectPool is Singleton