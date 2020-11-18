# Unity week 4:

This project was done as part of the "Computer Game Development" course at Ariel University.
You can see the assignment at the following link: https://github.com/gamedev-at-ariel/gamedev-5781/blob/master/04-unity-triggers/homework.pdf 
The aim of the project was to get to know with:
* Prefabs for instantiating new objects;
* Colliders for triggering outcomes of actions;
* Coroutines for setting time-based rules.

## Q1

We had to build a game where the player operates a spaceship that he can move with his arrow keys in a two-dimensional space, the player can also shoot lasers and destroy enemies.
the extra tasks we choose were:
The ship can now be hit by 3 separate attacks before its game over.
https://github.com/GangCS/HomeWork-W4-A/blob/master/Assets/Scripts/3-collisions/DestroyOnTrigger2D.cs#L12-L37
The weapons has cooldown to control the fire rate.
https://github.com/GangCS/HomeWork-W4-A/blob/master/Assets/Scripts/2-spawners/KeyboardSpawner.cs#L31-L36
The creative task we choose to make was:
Lava walls that destroy all the objects that touch the walls.
<pre>
    <code>
    public class WallDestroys : MonoBehaviour
    {
    private void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(other.gameObject);
        if (other.tag == "Player")
            SceneManager.LoadScene(1); // Game Over!
    }
    </code>
</pre>
The game can be played by clicking the following link: https://shaharnik.itch.io/homework-w4-a


![alt text](https://i.imgur.com/jLYyIIj.png)


