using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    // private void OnCollisionEnter2D(Collision2D other)
    // {
    //     Debug.Log("I bumped into something");
    // }

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "Package")
        {
            Debug.Log("I crossed a package");
        }
        else if (other.tag == "Customer")
        {
            Debug.Log("I crossed a customer");
        }
        else
        {
            Debug.Log("I crossed the line");
        }
    }
}
