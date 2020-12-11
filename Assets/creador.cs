using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class creador : MonoBehaviour
{
    public GameObject crown;
    Vector2 posicion;
    float randX;
    float randY;
    public float spawnRate = 5f;
    float nextSpawn = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            randX = Random.Range(-3.5f,3.5f);
            randY = Random.Range(0.5f,2f);
            posicion = new Vector2(randX,randY);
            Instantiate(crown,posicion, Quaternion.identity);
        }
    }
}
