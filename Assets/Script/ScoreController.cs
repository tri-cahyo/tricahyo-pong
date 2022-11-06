using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public Text skorkiri;
    public Text skorkanan;

    public ScoreManager manager;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        skorkiri.text = manager.leftScore.ToString();
        skorkanan.text = manager.rightScore.ToString(); 
    }
}
