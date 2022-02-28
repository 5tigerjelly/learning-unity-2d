using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPackage;

    // private void OnCollisionEnter2D(Collision2D other)
    // {
    //     Debug.Log("I bumped into something");
    // }

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "Package")
        {
            Debug.Log("I crossed a package");
            hasPackage = true;
        }

        if (other.tag == "Customer")
        {
            if (hasPackage)
            {
                Debug.Log("Delivered package");
                hasPackage = false;
            }
            else
            {
                Debug.Log("Need to pickup package first");
            }
        }
    }
}
