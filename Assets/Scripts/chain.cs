using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chain : MonoBehaviour
{
    public static bool IsFired;
    public Transform player;
    public float chainSpeed = 2f;

    // Start is called before the first frame update
    void Start()
    {
        IsFired = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            IsFired = true;
        }

        if (IsFired)
        {
            transform.localScale = transform.localScale + Vector3.up * Time.deltaTime * chainSpeed;
        }
        else {
            transform.position = player.position;
            transform.localScale = new Vector3(1f, 0f, 1f);
        }
    }
}
