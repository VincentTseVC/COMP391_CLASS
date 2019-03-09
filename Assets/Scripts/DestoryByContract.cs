using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryByContract : MonoBehaviour
{
    public GameObject explosion;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Boundary") return;

        if (other.tag == "Player")
        {
            Destroy(other.gameObject);
            // show game over;
        }


        // Instantiate asteriod explosion animation
        Instantiate(explosion, this.transform.position, this.transform.rotation);

        Destroy(other.gameObject);
        Destroy(this.gameObject);
    }
}