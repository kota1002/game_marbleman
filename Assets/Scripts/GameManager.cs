﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject gameOverText;
    [SerializeField] GameObject gameClearText;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void GameOver(){
        gameOverText.SetActive(true);
    }
    public void GameClear(){
        gameClearText.SetActive(true);
    }
}
