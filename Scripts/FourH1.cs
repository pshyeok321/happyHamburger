using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FourH1 : MonoBehaviour
{

    
    public GameObject player;
    [SerializeField]
    private float _speed;
    public float Speed { get { return _speed; } }
    [SerializeField]
    private int _score;
    public int Score { get { return _score; } }
    public GameObject[] list;
    public BoxCollider[] box;
    MeshRenderer[] mesh;
    void Start()
    {
        box = gameObject.GetComponents<BoxCollider>();        

    }
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.Translate(Vector3.left * _speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.Translate(Vector3.right * _speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            list[20].SetActive(true);
            clear = true;
            Destroy(gameObject, 1f);
        }
    }
    public bool clear = false;
    public bool first = false;
    public bool second, third, forth = true;
    public bool fifth = true;

    private IEnumerator Fifthing()
    {
        yield return new WaitForSeconds(1f);
        fifth = true;
        if (first && !second)
            list[5].SetActive(true);
        if (second && !third)
            list[10].SetActive(true);
        if (third && !forth)
            list[15].SetActive(true);
    }


    private void OnCollisionEnter(Collision col)
    {
        //리스트 0 = 바닥 1 2 3 4 = 베이컨 계란 양상추 피클

        if (col.gameObject.tag == "Bacon" && second && third && forth & fifth)
        {
            Destroy(col.gameObject);
            list[0].SetActive(false); list[1].SetActive(true); //list[5].SetActive(true);
            box[1].enabled = true; first = true; second = false; fifth = false;
            StartCoroutine("Fifthing");
        }
        else if (col.gameObject.tag == "Lett" && second && third && forth & fifth)
        {
            Destroy(col.gameObject);
            list[0].SetActive(false); list[2].SetActive(true); //list[5].SetActive(true);
            box[1].enabled = true; first = true; second = false; fifth = false;
            StartCoroutine("Fifthing");
        }
        else if (col.gameObject.tag == "Egg" && second && third && forth & fifth)
        {
            Destroy(col.gameObject);
            list[0].SetActive(false); list[3].SetActive(true);// list[5].SetActive(true);
            box[1].enabled = true; first = true; second = false; fifth = false;
            StartCoroutine("Fifthing");
        }
        else if (col.gameObject.tag == "Pickle" && second && third && forth & fifth)
        {
            Destroy(col.gameObject);
            list[0].SetActive(false); list[4].SetActive(true);// list[5].SetActive(true);
            box[1].enabled = true; first = true; second = false; fifth = false;
            StartCoroutine("Fifthing");
        }

        //리스트 0 = 바닥 1 2 3 4 = 베이컨 계란 양상추 피클

        if (col.gameObject.tag == "Bacon" && first && !second && third && forth && fifth)
        {
            Destroy(col.gameObject);
            list[5].SetActive(false); list[6].SetActive(true); //list[10].SetActive(true);
            box[1].enabled = false; box[2].enabled = true; second = true; third = false; fifth = false;
            StartCoroutine("Fifthing");
        }
        else if (col.gameObject.tag == "Lett" && first && !second && third && forth && fifth)
        {
            Destroy(col.gameObject);
            list[5].SetActive(false); list[7].SetActive(true); //list[10].SetActive(true);
            box[1].enabled = false; box[2].enabled = true; second = true; third = false; fifth = false;
            StartCoroutine("Fifthing");
        }
        else if (col.gameObject.tag == "Egg" && first && !second && third && forth && fifth)
        {
            Destroy(col.gameObject);
            list[5].SetActive(false); list[8].SetActive(true); //list[10].SetActive(true);
            box[1].enabled = false; box[2].enabled = true; second = true; third = false; fifth = false;
            StartCoroutine("Fifthing");
        }
        else if (col.gameObject.tag == "Pickle" && first && !second && third && forth && fifth)
        {
            Destroy(col.gameObject);
            list[5].SetActive(false); list[9].SetActive(true); //list[10].SetActive(true);
            box[1].enabled = false; box[2].enabled = true; second = true; third = false; fifth = false;
            StartCoroutine("Fifthing");
        }

        //리스트 0 = 바닥 1 2 3 4 = 베이컨 계란 양상추 피클

        if (col.gameObject.tag == "Bacon" && first && second && !third && forth && fifth)
        {
            Destroy(col.gameObject);
            list[10].SetActive(false); list[11].SetActive(true); //list[15].SetActive(true);
            box[2].enabled = false; box[3].enabled = true; third = true; forth = false; fifth = false;
            StartCoroutine("Fifthing");
        }
        else if (col.gameObject.tag == "Lett" && first && second && !third && forth && fifth)
        {
            Destroy(col.gameObject);
            list[10].SetActive(false); list[12].SetActive(true); //list[15].SetActive(true);
            box[2].enabled = false; box[3].enabled = true; third = true; forth = false; fifth = false;
            StartCoroutine("Fifthing");
        }
        else if (col.gameObject.tag == "Egg" && first && second && !third && forth && fifth)
        {
            Destroy(col.gameObject);
            list[10].SetActive(false); list[13].SetActive(true); //list[15].SetActive(true);
            box[2].enabled = false; box[3].enabled = true; third = true; forth = false; fifth = false;
            StartCoroutine("Fifthing");
        }
        else if (col.gameObject.tag == "Pickle" && first && second && !third && forth && fifth)
        {
            Destroy(col.gameObject);
            list[10].SetActive(false); list[14].SetActive(true); //list[15].SetActive(true);
            box[2].enabled = false; box[3].enabled = true; third = true; forth = false; fifth = false;
            StartCoroutine("Fifthing");
        }

        //리스트 0 = 바닥 1 2 3 4 = 베이컨 계란 양상추 피클

        if (col.gameObject.tag == "Bacon" && first && second && third && !forth && fifth)
        {
            Destroy(col.gameObject);
            list[15].SetActive(false); list[16].SetActive(true); //list[0].SetActive(true);
            box[2].enabled = false; box[3].enabled = true; forth = true; fifth = false;
            StartCoroutine("Fifthing");
        }
        else if (col.gameObject.tag == "Lett" && first && second && third && !forth && fifth)
        {
            Destroy(col.gameObject);
            list[15].SetActive(false); list[17].SetActive(true); //list[0].SetActive(true);
            box[2].enabled = false; box[3].enabled = true; forth = true; fifth = false;
            StartCoroutine("Fifthing");
        }
        else if (col.gameObject.tag == "Egg" && first && second && third && !forth && fifth)
        {
            Destroy(col.gameObject);
            list[15].SetActive(false); list[18].SetActive(true); //list[0].SetActive(true);
            box[2].enabled = false; box[3].enabled = true; forth = true; fifth = false;
            StartCoroutine("Fifthing");
        }
        else if (col.gameObject.tag == "Pickle" && first && second && third && !forth && fifth)
        {
            Destroy(col.gameObject);
            list[15].SetActive(false); list[19].SetActive(true); //list[0].SetActive(true);
            box[2].enabled = false; box[3].enabled = true; forth = true; fifth = false;
            StartCoroutine("Fifthing");
        }
    }
}