using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class border : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Border_right")
        {
            transform.position = new Vector3(0, 0, 0);
        }
        else if (collision.name == "Border_left")
        {
            transform.position = new Vector3(0, 0, 0);
        }
    }

}
