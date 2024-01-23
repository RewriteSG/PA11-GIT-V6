using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnerscript : MonoBehaviour
{
    public GameObject[] SpawnObjects;
    float PositionY;
    public List<GameObject> SpawnedObjects = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        SpawnedObjects.Clear();
        InvokeRepeating("SpawningObjects", 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
       


    }
    int RandomBetweenObjects;
    void SpawningObjects()
    {
        PositionY = Random.Range(4, -4f);
        RandomBetweenObjects = Random.Range(0, SpawnObjects.Length);
        this.transform.position = new Vector3(transform.position.x, PositionY, transform.position.z);
        SpawnedObjects.Add(Instantiate(SpawnObjects[RandomBetweenObjects], transform.position, transform.rotation));
    }
}
