using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ChangeImage : MonoBehaviour {
    public Sprite[] foodObj = new Sprite[5];
    public Image foodImage;
    public PlayerMove player;
	// Use this for initialization
	void Start () {
        gameObject.GetComponent<Image>().sprite = foodObj[0];        
	}	
	// Update is called once per frame
	void Update () {
        if (player.Score == 100)
        {
            foodImage.sprite = foodObj[1];
        }
        if (player.Score == 200)
        {
            foodImage.sprite = foodObj[2];
        }
        if (player.Score == 300)
        {
            foodImage.sprite = foodObj[3];
        }
        if (player.Score == 400)
        {
            foodImage.sprite = foodObj[4];
        }
    }
    
    //private void OnEnable()
    //{
    //    player = GameObject.FindWithTag("Player").GetComponent<PlayerMove>();
    //}
}
