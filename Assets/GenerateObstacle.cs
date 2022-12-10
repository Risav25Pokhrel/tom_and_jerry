using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateObstacle : MonoBehaviour
{
    public GameObject tomPrefab;
    public int generateRate = 100;


    private int timer;

    // Update is called once per frame
    void FixedUpdate()
    {
        timer++;
        if (timer > generateRate)
        {
            timer = 0;
            GameObject newObstacle = Instantiate(tomPrefab, new Vector2(tomPrefab.transform.position.x, tomPrefab.transform.position.y + Random.Range(-2f, 2f)), tomPrefab.transform.rotation);
            Destroy(newObstacle, 5f);
        }
    }
}
