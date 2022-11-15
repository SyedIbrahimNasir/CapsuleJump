using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            other.GetComponent<CollectCoin>().points++;
            other.GetComponent<CollectCoin>().UpdateScore();
            Destroy(gameObject);
        }
    }
}
