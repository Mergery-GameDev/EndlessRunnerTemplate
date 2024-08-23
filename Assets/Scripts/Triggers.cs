using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triggers : MonoBehaviour
{
    [Header("Scripts")]
    public CollectibleManager collectibleManagerScript;
    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Enemy")
        {
            Debug.Log("GAME OVER!!!");
        }

        if(other.tag=="Collectible")
        {
            Destroy(other.gameObject);
            collectibleManagerScript.AddCollectible();
        }
    }
}
