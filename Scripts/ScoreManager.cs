using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreManager : MonoBehaviour {

    //  public PlayerMove player;
    public EightH1 player;
    public Text scoreText;



    void Update () {
        try
        {
            scoreText.text = ""+player.Score;
        }
        catch (Exception ex)
        {
            Debug.Log(ex);
        }
    }
}
