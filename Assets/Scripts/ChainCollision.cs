using UnityEngine;

public class ChainCollision : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        chain.IsFired = false;

        if (collision.tag == "Ball")
        {
            Debug.Log("Split ball in two");
            collision.GetComponent<Ball>().Split();
        }
    }
}
