using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereSpawner : MonoBehaviour
{
    [SerializeField] GameObject SphereContainer; //to hold spawn objects as a parent/root node
    [SerializeField] public int count; // to get dynamic input switching
    [SerializeField] public GameObject spherePrefab;
    GameObject gameObj;
    

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 randomSpawnPosition = new Vector3(Random.Range(-10, 11),8, Random.Range(-10, 11)); //random range
            for (var i = 0; i < count; i++) //to spawn objects via user input
            {
                gameObj = Instantiate(spherePrefab, randomSpawnPosition, Quaternion.identity, SphereContainer.transform);
                DestroyObjectDelayed();
            }
        }
    }
    void DestroyObjectDelayed()
    {
        // using this to kill objects in 5secs
        Destroy(gameObj, 5);
    }
}
