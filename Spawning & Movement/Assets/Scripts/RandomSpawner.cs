using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    [SerializeField] public int count; //using this to make storage optimize and this value allows to change number of cubes
    [SerializeField]public GameObject cubePrefab;
    GameObject gameObj;
    
    // Update is called once per frame
    void Update()
    {
        
         if (Input.GetKeyDown(KeyCode.Space)) //using space as input to trigger cubes spawn
          {
            Vector3 randomSpawnPosition = new Vector3(Random.Range(-10, 11), 5, Random.Range(-10, 11)); // making cubes spawn randomly

            for (var i = 0; i < count; i++) // for loop to make fixed number cubes on runtime
            {
              gameObj = Instantiate(cubePrefab, randomSpawnPosition, Quaternion.identity);
              DestroyObjectDelayed();
            }
        }
    }
    void DestroyObjectDelayed() //function destroy cube clones
    {
        // using this to kill objects in 5secs
        Destroy(gameObj,2);
    }
}
