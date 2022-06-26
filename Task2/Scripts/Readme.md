So you have to recreate the following game along with some changes. A gameplay clip is given for your reference.

https://user-images.githubusercontent.com/87766488/175813515-858ad13c-3dcc-4b34-9f0e-ca69d0938683.mp4

So you have to complete 5 subproblems:
1. Improve the jumping mechanism in movement script and make it bit more natural and snappy. In the template given the player does jump but it is just translating in the y direction rather than really jumping. 
2. Implement the enemy spawner system and the enemy destroyer system. The enemies have to spawn from left and right points of the ground and should die when reaching the opposite end of the ground.
3. Complete the camera follow system. The camera should follow the player as it moves. There's no point of keeping the camera static otherwise you would just lose your sight on your character.
4. Add the coin collection system. Whenever your character picks up a coin, total no. coins collected should be printed in the console. The output should be in this format: "Total coins collected : (no. of coins)"
5. Implement the enemy killing feature. 

    - This feature should be implemented using colliders and tags.
    - You also have to include a enemy squashing feature. When player lands on top of the enemy, the enemy should be squashed and then be destroyed after a delay of 1 sec. (A hint: you will need to use multiple colliders and multiple children empty gameobjects in player gameobject. You will also need to set some colliders as triggers.)
    - You can check out triggers and OnTriggerEnter2d(collider2d other) API over here: [LINK](https://docs.unity3d.com/ScriptReference/MonoBehaviour.OnTriggerEnter2D.html)
    - In Unity, colliders are components that allow the physics engine to handle the collisions. The physics engine simulates collisions using colliders. We can determine which objects will collide with each other, or how objects will behave under collisions using colliders.
    - On the other hand, triggers are special setups of colliders. The purpose of triggers is to trigger events when more than one objects overlap. If an object has a collider that is configured as a trigger, that object does not collide with any other object but overlap instead.
    - To activate a trigger just click on the trigger checkbox of the collider on any gameObject. 


https://user-images.githubusercontent.com/87766488/175814994-bfa06605-284d-41f6-90a4-ee83bdea4e80.mp4

Reference video to implement the squashing element. 

6. Some more important APIs and concepts:
  - Instantiate: Instantiate can be used to create new objects at runtime. Examples include objects used for projectiles, or particle systems for explosion effects. You can also specify the position and rotation of the cloned object.
  - Destroy: This would destroy a gameObject at runtime.
  - Coroutines: You can refer to this video : [VIDEO](https://www.youtube.com/watch?v=ZnQtgER3CLQ)
