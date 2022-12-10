using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerMovement : MonoBehaviour
{

    public Rigidbody2D jerry;
    public float jumpAmount = 8f;


    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jerry.velocity = new Vector2(0, jumpAmount);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
