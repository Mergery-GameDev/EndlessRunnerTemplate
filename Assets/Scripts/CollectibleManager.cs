using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleManager : MonoBehaviour
{
    public int collectiblesCount;

    [Header("SCRIPTS")]
    [SerializeField] private UIManager uiManagerScript;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AddCollectible()
    {
        collectiblesCount+=1;
        uiManagerScript.UpdateCollectibleUI(collectiblesCount);
    }
}
