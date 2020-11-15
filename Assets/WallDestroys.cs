using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/**
 * This component destroys the object that collided with a wall.
 */
public class WallDestroys : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(other.gameObject);
        if (other.tag == "Player")
            SceneManager.LoadScene(1);

    }
}
