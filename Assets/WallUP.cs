using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WallUP : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag != "Enemy")
            Destroy(other.gameObject);
        if (other.tag == "Player")
            SceneManager.LoadScene(1);
    }
}
