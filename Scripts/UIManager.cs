using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIManager : MonoBehaviour {
    public GameObject startUI;
    public GameObject startBT;
    public GameObject gameUI;    
    public GameObject objectList;
    public GameObject endUI;

    public EightH1 player;
  
    public void GameOver()
    {
        Time.timeScale = 0.1f;
        startUI.SetActive(false);
        objectList.SetActive(false);
        endUI.SetActive(true);

    }
    void Update()
    {
        //try
        //{
        //    if (player.pt && player.lt && player.ch && player.pk && player.on)
        //    {
        //        gameUI.SetActive(false);
        //        objectList.SetActive(false);
        //        endUI.SetActive(true);
        //        Time.timeScale = 0;
        //    }
        //}
        //catch (Exception ex)
        //{
        //    Debug.Log(ex);
        //}
        

    }
    private void Start()
    {
    }
}
