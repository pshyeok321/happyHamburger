using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFood : MonoBehaviour {
    public GameObject bacon;
    public GameObject bell;
    public GameObject cheese;
    public GameObject cow;
    public GameObject lettuce;
    public GameObject pickle;
    public GameObject egg;
    public GameObject mushroom;
    public GameObject onion;
    public GameObject tomato;
    public GameObject gas;
    
    
    //public GameObject onion;
    //public GameObject NonFood;
    public PlayerMove player;
    public FourH1 player2;
    public int RandomItem;
    private void OnEnable()
    {
        player = GameObject.FindWithTag("Player").GetComponent<PlayerMove>();
        player2 = GameObject.FindWithTag("Player").GetComponent<FourH1>();
    }
    public void Foods()
    {
      
        float RandomX = Random.Range(-0.14f, 0.74f);
        float RandomY = Random.Range(-3f, -2f);
        if (RandomItem == 1)
        {
            
          Instantiate(bacon, new Vector3(RandomX, RandomY, 0f), bacon.transform.rotation);
           // temp.GetComponent<FoodControl>().player = this.player;
            
        }
        else if(RandomItem == 2)
        {
            Instantiate(bell, new Vector3(RandomX, RandomY, 0f), bell.transform.rotation);
          //  temp.GetComponent<FoodControl>().player = this.player;
        }
        else if (RandomItem == 3)
        {
           Instantiate(cheese, new Vector3(RandomX, RandomY, 0f), cheese.transform.rotation);
           // temp.GetComponent<FoodControl>().player = this.player;
        }
        else if (RandomItem == 4)
        {
            Instantiate(cow, new Vector3(RandomX, RandomY, 0f), cow.transform.rotation);
         //   temp.GetComponent<FoodControl>().player = this.player;
        }
        if (RandomItem == 5)
        {
            Instantiate(lettuce, new Vector3(RandomX, RandomY, 0f), lettuce.transform.rotation);
            // temp.GetComponent<FoodControl>().player = this.player;
        }
        else if (RandomItem == 6)
        {
            Instantiate(pickle, new Vector3(RandomX, RandomY, 0f), pickle.transform.rotation);
            //  temp.GetComponent<FoodControl>().player = this.player;
        }
        else if (RandomItem == 7)
        {
            Instantiate(egg, new Vector3(RandomX, RandomY, 0f), egg.transform.rotation);
            // temp.GetComponent<FoodControl>().player = this.player;
        }
        else if (RandomItem == 8)
        {
            Instantiate(mushroom, new Vector3(RandomX, RandomY, 0f), mushroom.transform.rotation);
            //   temp.GetComponent<FoodControl>().player = this.player;
        }
        else if (RandomItem == 9)
        {
            Instantiate(onion, new Vector3(RandomX, RandomY, 0f), onion.transform.rotation);
            // temp.GetComponent<FoodControl>().player = this.player;
        }
        else if (RandomItem == 10)
        {
            Instantiate(tomato, new Vector3(RandomX, RandomY, 0f), tomato.transform.rotation);
            //   temp.GetComponent<FoodControl>().player = this.player;
        }
    }
    public void NonFoods()
    {
        float RandomX = Random.Range(-0.14f, 0.74f);
        float RandomY = Random.Range(-3f, -2f);
        Instantiate(gas, new Vector3(RandomX, RandomY, 0f), gas.transform.rotation);

    }

    //}
    // Use this for initialization
    void Start () {
        InvokeRepeating("NonFoods", 5, 5);
        InvokeRepeating("Foods", 2, 1.3f);
    }

    // Update is called once per frame
    void Update () {
        RandomItem = Random.Range(0, 11);

    }
}
