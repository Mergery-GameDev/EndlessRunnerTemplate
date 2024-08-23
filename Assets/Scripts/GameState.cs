using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameState : MonoBehaviour
{
    public int blockPassed;
    int target = 10;

    public float spawnSpeed= 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(blockPassed> target)
        {
            spawnSpeed +=3;
            blockPassed= 0;
            target+=10;
            Debug.Log(spawnSpeed);
        }
        
    }
    private void OnTriggerEnter(Collider other)
    {
        
        if(other.tag == "Enemy")
        {
            blockPassed+=1;
        }
    }

}
