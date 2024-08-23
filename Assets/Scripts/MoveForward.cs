using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float forwardSpeed ;
    public GameState gameStateScript;

    // Start is called before the first frame update
    void Start()
    {
        gameStateScript= GameObject.FindWithTag("GameState").GetComponent<GameState>();
        forwardSpeed= gameStateScript.spawnSpeed;
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.back *forwardSpeed *Time.deltaTime);
        
    }
}
