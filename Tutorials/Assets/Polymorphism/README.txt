This shows off a case where polymorphism is used to implement different behaviors for an object/enemy spawner.

AbstractEnemySpawner - establishes the Spawn() method that all concrete classes must implement
SingleSpawner - implements Spawn() to spawn 1 object
MultiSpawner - implements Spawn() to spawn 3 objects
GameObjectSpawner - implements Spawn() to copy a GameObject
SpanwerController - Calls Spawn() on a list of AbstactEnemySpawners
DelayedDestroy - detroys objects its attached to after a delay.