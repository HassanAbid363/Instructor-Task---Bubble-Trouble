using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Vector2 startForce;
    public Rigidbody2D ballRb;
    public GameObject nextBall;

    // Start is called before the first frame update
    void Start()
    {
        ballRb.AddForce(startForce, ForceMode2D.Impulse);   
    }

    public void Split()
    {
        if (nextBall != null) 
        {
            GameObject ball1 = Instantiate(nextBall, ballRb.position + Vector2.right / 4f, Quaternion.identity);
            GameObject ball2 = Instantiate(nextBall, ballRb.position + Vector2.left / 4f, Quaternion.identity);

            ball1.GetComponent<Ball>().startForce = new Vector2(2f, 5f);
            ball2.GetComponent<Ball>().startForce = new Vector2(-2f, 5f);
        }

        Destroy(gameObject);
    }
}
