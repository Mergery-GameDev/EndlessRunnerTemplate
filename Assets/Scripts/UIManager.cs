using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    // Start is called before the first frame update
    [Header("TEXT")]
    [SerializeField] private TMP_Text scoreText;

    
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateCollectibleUI(int count)
    {
        scoreText.text=count.ToString("0");
    }
}
