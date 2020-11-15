using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRandomPlace : MonoBehaviour
{
    [Tooltip("Maximum distance in X between spawner and spawned objects, in meters")] [SerializeField] float maxXDistance = 5f;
    [Tooltip("Maximum distance in X between spawner and spawned objects, in meters")] [SerializeField] float maxYDistance = 5f;
    //Gathering camera bounds
    //float y = Camera.main.orthographicSize;
    //float x = Camera.main.aspect;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 positionOfSpawnedObject = new Vector3(
        transform.position.x + Random.Range(-maxXDistance, +maxXDistance),
        transform.position.y + Random.Range(-maxYDistance, +maxYDistance),
        transform.position.z);
        transform.position = positionOfSpawnedObject;
        Debug.Log("REACHED HERE!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
