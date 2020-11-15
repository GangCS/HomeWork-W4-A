using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/**
 * This component destroys its object whenever it triggers a 2D collider with the given tag.
 */
public class DestroyOnTrigger2D : MonoBehaviour {
    [Tooltip("Every object tagged with this tag will trigger the destruction of this object")]
    [SerializeField] string triggeringTag;
    [SerializeField] bool OneHitDestroy;
    [SerializeField] int hitsToDestroy;
    [SerializeField] string sceneName;
    [SerializeField] NumberField numberField;
    private int collisionCounter = 0; // fire dont destroy

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == triggeringTag && enabled) {
            Destroy(other.gameObject);
            if (OneHitDestroy)
            {
                Destroy(this.gameObject);
                if (sceneName != "isEnemy")
                    SceneManager.LoadScene(sceneName);
            }      
            else
            {
                collisionCounter++;
                if (collisionCounter == hitsToDestroy)
                {
                    Destroy(this.gameObject);
                    collisionCounter = 0;
                    if (sceneName != "isEnemy")
                        SceneManager.LoadScene(sceneName);
                }
            }

        }
    }
}
