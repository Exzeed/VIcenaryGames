﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Reset()
    {
        SceneManager.LoadScene("Start");
    }

    public void OnStartButtonClick()
    {
 
        SceneManager.LoadScene("SampleScene");
    }

    public void OnRestartButtonClick()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
