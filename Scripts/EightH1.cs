using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EightH1 : MonoBehaviour
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
    public MeshRenderer m1, m2;
    
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
            list[88].SetActive(true);
            StartCoroutine("Ending");
        }


    }
    public bool first = false;
    public bool second, third, forth, fifth, sixth, seventh, eighth, nighth = true;




    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Gas")
        {
            list[89].SetActive(false);           
        }
        if (col.gameObject.tag == "Patty")
        {
            Destroy(gameObject);
            SceneManager.LoadScene("S2");
        }


        // 1층 바닥 베이컨 피망 치즈 소고기 계란 양상추 버섯 양파 피클 토마토
        if (col.gameObject.tag == "Bacon" && second && third && forth & fifth && sixth && seventh && eighth && nighth)
        {
            Destroy(col.gameObject);
            list[0].SetActive(false); list[1].SetActive(true); //list[5].SetActive(true);
            box[1].enabled = true; first = true; second = false; nighth = false;
                        StartCoroutine("Fifthing"); _score += 10;       
        }
        if (col.gameObject.tag == "Bell" && second && third && forth & fifth && sixth && seventh && eighth && nighth)
        {
            Destroy(col.gameObject);
            list[0].SetActive(false); list[2].SetActive(true); //list[5].SetActive(true);
            box[1].enabled = true; first = true; second = false; nighth = false;
                        StartCoroutine("Fifthing"); _score += 10;       
        }
        if (col.gameObject.tag == "Cheese" && second && third && forth & fifth && sixth && seventh && eighth && nighth)
        {
            Destroy(col.gameObject);
            list[0].SetActive(false); list[3].SetActive(true); //list[5].SetActive(true);
            box[1].enabled = true; first = true; second = false; nighth = false;
                        StartCoroutine("Fifthing"); _score += 10;       
        }
        if (col.gameObject.tag == "Cow" && second && third && forth && fifth && sixth && seventh && eighth && nighth)
        {
            Destroy(col.gameObject);
            list[0].SetActive(false); list[4].SetActive(true); //list[5].SetActive(true);
            box[1].enabled = true; first = true; second = false; nighth = false;
                        StartCoroutine("Fifthing"); _score += 10;       
 
        }
        else if (col.gameObject.tag == "Egg" && second && third && forth && fifth && sixth && seventh && eighth && nighth)
        {
            Destroy(col.gameObject);
            list[0].SetActive(false); list[5].SetActive(true);// list[5].SetActive(true);
            box[1].enabled = true; first = true; second = false; nighth = false;
                        StartCoroutine("Fifthing"); _score += 10;       
        }
        else if (col.gameObject.tag == "Lett" && second && third && forth && fifth && sixth && seventh && eighth && nighth)
        {
            Destroy(col.gameObject);
            list[0].SetActive(false); list[6].SetActive(true); //list[5].SetActive(true);
            box[1].enabled = true; first = true; second = false; nighth = false;
                        StartCoroutine("Fifthing"); _score += 10;       
        }
        else if (col.gameObject.tag == "Mushroom" && second && third && forth && fifth && sixth && seventh && eighth && nighth)
        {
            Destroy(col.gameObject);
            list[0].SetActive(false); list[7].SetActive(true); //list[5].SetActive(true);
            box[1].enabled = true; first = true; second = false; nighth = false;
                        StartCoroutine("Fifthing"); _score += 10;       
        }
        else if (col.gameObject.tag == "Onion" && second && third && forth & fifth && sixth && seventh && eighth && nighth)
        {
            Destroy(col.gameObject);
            list[0].SetActive(false); list[8].SetActive(true); //list[5].SetActive(true);
            box[1].enabled = true; first = true; second = false; nighth = false;
                        StartCoroutine("Fifthing"); _score += 10;       
        }
        else if (col.gameObject.tag == "Pickle" && second && third && forth && fifth && sixth && seventh && eighth && nighth)
        {
            Destroy(col.gameObject);
            list[0].SetActive(false); list[9].SetActive(true);// list[5].SetActive(true);
            box[1].enabled = true; first = true; second = false; nighth = false;
                        StartCoroutine("Fifthing"); _score += 10;       
        }
        else if (col.gameObject.tag == "Tomato" && second && third && forth & fifth && sixth && seventh && eighth && nighth)
        {
            Destroy(col.gameObject);
            list[0].SetActive(false); list[10].SetActive(true);// list[5].SetActive(true);
            box[1].enabled = true; first = true; second = false; nighth = false;
                        StartCoroutine("Fifthing"); _score += 10;       
        }


        ////////////////////////////////////////////////////////////////////////// 2층
        if (col.gameObject.tag == "Bacon" && first && !second && third && forth && fifth && sixth && seventh && eighth && nighth)
        {
            Destroy(col.gameObject);
            list[11].SetActive(false); list[12].SetActive(true); //list[5].SetActive(true);
            box[1].enabled = false; box[2].enabled = true; second = true; third = false; nighth = false;
                        StartCoroutine("Fifthing"); _score += 10;       
        }
        if (col.gameObject.tag == "Bell" && first && !second && third && forth && fifth && sixth && seventh && eighth && nighth)
        {
            Destroy(col.gameObject);
            list[11].SetActive(false); list[13].SetActive(true); //list[5].SetActive(true);
            box[1].enabled = false; box[2].enabled = true; second = true; third = false; nighth = false;
                        StartCoroutine("Fifthing"); _score += 10;       
        }
        if (col.gameObject.tag == "Cheese" && first && !second && third && forth && fifth && sixth && seventh && eighth && nighth)
        {
            Destroy(col.gameObject);
            list[11].SetActive(false); list[14].SetActive(true); //list[5].SetActive(true);
            box[1].enabled = false; box[2].enabled = true; second = true; third = false; nighth = false;
                        StartCoroutine("Fifthing"); _score += 10;       
        }
        if (col.gameObject.tag == "Cow" && first && !second && third && forth && fifth && sixth && seventh && eighth && nighth)
        {
            Destroy(col.gameObject);
            list[11].SetActive(false); list[15].SetActive(true); //list[5].SetActive(true);
            box[1].enabled = false; box[2].enabled = true; second = true; third = false; nighth = false;
                        StartCoroutine("Fifthing"); _score += 10;       
        }
        else if (col.gameObject.tag == "Egg" && first && !second && third && forth && fifth && sixth && seventh && eighth && nighth)
        {
            Destroy(col.gameObject);
            list[11].SetActive(false); list[16].SetActive(true);// list[5].SetActive(true);
            box[1].enabled = false; box[2].enabled = true; second = true; third = false; nighth = false;
                        StartCoroutine("Fifthing"); _score += 10;       
        }
        else if (col.gameObject.tag == "Lett" && first && !second && third && forth && fifth && sixth && seventh && eighth && nighth)
        {
            Destroy(col.gameObject);
            list[11].SetActive(false); list[17].SetActive(true); //list[5].SetActive(true);
            box[1].enabled = false; box[2].enabled = true; second = true; third = false; nighth = false;
                        StartCoroutine("Fifthing"); _score += 10;       
 
        }
        else if (col.gameObject.tag == "Mushroom" && first && !second && third && forth && fifth && sixth && seventh && eighth && nighth)
        {
            Destroy(col.gameObject);
            list[11].SetActive(false); list[18].SetActive(true); //list[5].SetActive(true);
            box[1].enabled = false; box[2].enabled = true; second = true; third = false; nighth = false;
                        StartCoroutine("Fifthing"); _score += 10;       
        }
        else if (col.gameObject.tag == "Onion" && first && !second && third && forth && fifth && sixth && seventh && eighth && nighth)
        {
            Destroy(col.gameObject);
            list[11].SetActive(false); list[19].SetActive(true); //list[5].SetActive(true);
            box[1].enabled = false; box[2].enabled = true; second = true; third = false; nighth = false;
                        StartCoroutine("Fifthing"); _score += 10;       
        }
        else if (col.gameObject.tag == "Pickle" && first && !second && third && forth && fifth && sixth && seventh && eighth && nighth)
        {
            Destroy(col.gameObject);
            list[11].SetActive(false); list[20].SetActive(true);// list[5].SetActive(true);
            box[1].enabled = false; box[2].enabled = true; second = true; third = false; nighth = false;
                        StartCoroutine("Fifthing"); _score += 10;       
        }
        else if (col.gameObject.tag == "Tomato" && first && !second && third && forth && fifth && sixth && seventh && eighth && nighth)
        {
            Destroy(col.gameObject);
            list[11].SetActive(false); list[21].SetActive(true);// list[5].SetActive(true);
            box[1].enabled = false; box[2].enabled = true; second = true; third = false; nighth = false;
                        StartCoroutine("Fifthing"); _score += 10;       
        }
        ////////////////////////////////////////////
        if (col.gameObject.tag == "Bacon" && first && second && !third && forth && fifth && sixth && seventh && eighth && nighth)
        {
            Destroy(col.gameObject);
            list[22].SetActive(false); list[23].SetActive(true); //list[5].SetActive(true);
            box[2].enabled = false; box[3].enabled = true; third = true; forth = false; nighth = false;
                        StartCoroutine("Fifthing"); _score += 10;       
        }
        if (col.gameObject.tag == "Bell" && first && second && !third && forth && fifth && sixth && seventh && eighth && nighth)
        {
            Destroy(col.gameObject);
            list[22].SetActive(false); list[24].SetActive(true); //list[5].SetActive(true);
            box[2].enabled = false; box[3].enabled = true; third = true; forth = false; nighth = false;
                        StartCoroutine("Fifthing"); _score += 10;       
        }
        if (col.gameObject.tag == "Cheese" && first && second && !third && forth && fifth && sixth && seventh && eighth && nighth)
        {
            Destroy(col.gameObject);
            list[22].SetActive(false); list[25].SetActive(true); //list[5].SetActive(true);
            box[2].enabled = false; box[3].enabled = true; third = true; forth = false; nighth = false;
                        StartCoroutine("Fifthing"); _score += 10;       
        }
        if (col.gameObject.tag == "Cow" && first && second && !third && forth && fifth && sixth && seventh && eighth && nighth)
        {
            Destroy(col.gameObject);
            list[22].SetActive(false); list[26].SetActive(true); //list[5].SetActive(true);
            box[2].enabled = false; box[3].enabled = true; third = true; forth = false; nighth = false;
                        StartCoroutine("Fifthing"); _score += 10;       
        }
        else if (col.gameObject.tag == "Egg" && first && second && !third && forth && fifth && sixth && seventh && eighth && nighth)
        {
            Destroy(col.gameObject);
            list[22].SetActive(false); list[27].SetActive(true);// list[5].SetActive(true);
            box[2].enabled = false; box[3].enabled = true; third = true; forth = false; nighth = false;
                        StartCoroutine("Fifthing"); _score += 10;       
 
        }
        else if (col.gameObject.tag == "Lett" && first && second && !third && forth && fifth && sixth && seventh && eighth && nighth)
        {
            Destroy(col.gameObject);
            list[22].SetActive(false); list[28].SetActive(true); //list[5].SetActive(true);
            box[2].enabled = false; box[3].enabled = true; third = true; forth = false; nighth = false;
                        StartCoroutine("Fifthing"); _score += 10;       
        }
        else if (col.gameObject.tag == "Mushroom" && first && second && !third && forth & fifth && sixth && seventh && eighth && nighth)
        {
            Destroy(col.gameObject);
            list[22].SetActive(false); list[29].SetActive(true); //list[5].SetActive(true);
            box[2].enabled = false; box[3].enabled = true; third = true; forth = false; nighth = false;
                        StartCoroutine("Fifthing"); _score += 10;       
        }
        else if (col.gameObject.tag == "Onion" && first && second && !third && forth && fifth && sixth && seventh && eighth && nighth)
        {
            Destroy(col.gameObject);
            list[22].SetActive(false); list[30].SetActive(true); //list[5].SetActive(true);
            box[2].enabled = false; box[3].enabled = true; third = true; forth = false; nighth = false;
                        StartCoroutine("Fifthing"); _score += 10;       
        }
        else if (col.gameObject.tag == "Pickle" && first && second && !third && forth && fifth && sixth && seventh && eighth && nighth)
        {
            Destroy(col.gameObject);
            list[22].SetActive(false); list[31].SetActive(true);// list[5].SetActive(true);
            box[2].enabled = false; box[3].enabled = true; third = true; forth = false; nighth = false;
                        StartCoroutine("Fifthing"); _score += 10;       
        }
        else if (col.gameObject.tag == "Tomato" && first && second && !third && forth && fifth && sixth && seventh && eighth && nighth)
        {
            Destroy(col.gameObject);
            list[22].SetActive(false); list[32].SetActive(true);// list[5].SetActive(true);
            box[2].enabled = false; box[3].enabled = true; third = true; forth = false; nighth = false;
                        StartCoroutine("Fifthing"); _score += 10;       
        }
        /////////////////////////////////////////////////////////////////////////////////////////// 4층
        if (col.gameObject.tag == "Bacon" && first && second && third && !forth && fifth && sixth && seventh && eighth && nighth)
        {
            Destroy(col.gameObject);
            list[33].SetActive(false); list[34].SetActive(true); //list[5].SetActive(true);
            box[3].enabled = false; box[4].enabled = true; forth = true; fifth = false; nighth = false;
                        StartCoroutine("Fifthing"); _score += 10;       
        }
        if (col.gameObject.tag == "Bell" && first && second && third && !forth && fifth && sixth && seventh && eighth && nighth)
        {
            Destroy(col.gameObject);
            list[33].SetActive(false); list[35].SetActive(true); //list[5].SetActive(true);
            box[3].enabled = false; box[4].enabled = true; forth = true; fifth = false; nighth = false;
                        StartCoroutine("Fifthing"); _score += 10;       
        }
        if (col.gameObject.tag == "Cheese" && first && second && third && !forth && fifth && sixth && seventh && eighth && nighth)
        {
            Destroy(col.gameObject);
            list[33].SetActive(false); list[36].SetActive(true); //list[5].SetActive(true);
            box[3].enabled = false; box[4].enabled = true; forth = true; fifth = false; nighth = false;
                        StartCoroutine("Fifthing"); _score += 10;       
        }
        if (col.gameObject.tag == "Cow" && first && second && third && !forth && fifth && sixth && seventh && eighth && nighth)
        {
            Destroy(col.gameObject);
            list[33].SetActive(false); list[37].SetActive(true); //list[5].SetActive(true);
            box[3].enabled = false; box[4].enabled = true; forth = true; fifth = false; nighth = false;
                        StartCoroutine("Fifthing"); _score += 10;       
        }
        else if (col.gameObject.tag == "Egg" && first && second && third && !forth && fifth && sixth && seventh && eighth && nighth)
        {
            Destroy(col.gameObject);
            list[33].SetActive(false); list[38].SetActive(true);// list[5].SetActive(true);
            box[3].enabled = false; box[4].enabled = true; forth = true; fifth = false; nighth = false;
                        StartCoroutine("Fifthing"); _score += 10;       
        }
        else if (col.gameObject.tag == "Lett" && first && second && third && !forth && fifth && sixth && seventh && eighth && nighth)
        {
            Destroy(col.gameObject);
            list[33].SetActive(false); list[39].SetActive(true); //list[5].SetActive(true);
            box[3].enabled = false; box[4].enabled = true; forth = true; fifth = false; nighth = false;
                        StartCoroutine("Fifthing"); _score += 10;       
        }
        else if (col.gameObject.tag == "Mushroom" && first && second && third && !forth && fifth && sixth && seventh && eighth && nighth)
        {
            Destroy(col.gameObject);
            list[33].SetActive(false); list[40].SetActive(true); //list[5].SetActive(true);
            box[3].enabled = false; box[4].enabled = true; forth = true; fifth = false; nighth = false;
                        StartCoroutine("Fifthing"); _score += 10;       
        }
        else if (col.gameObject.tag == "Onion" && first && second && third && !forth && fifth && sixth && seventh && eighth && nighth)
        {
            Destroy(col.gameObject);
            list[33].SetActive(false); list[41].SetActive(true); //list[5].SetActive(true);
            box[3].enabled = false; box[4].enabled = true; forth = true; fifth = false; nighth = false;
                        StartCoroutine("Fifthing"); _score += 10;       
        }
        else if (col.gameObject.tag == "Pickle" && first && second && third && !forth && fifth && sixth && seventh && eighth && nighth)
        {
            Destroy(col.gameObject);
            list[33].SetActive(false); list[42].SetActive(true);// list[5].SetActive(true);
            box[3].enabled = false; box[4].enabled = true; forth = true; fifth = false; nighth = false;
                        StartCoroutine("Fifthing"); _score += 10;       
 
        }
        else if (col.gameObject.tag == "Tomato" && first && second && third && !forth && fifth && sixth && seventh && eighth && nighth)
        {
            Destroy(col.gameObject);
            list[33].SetActive(false); list[43].SetActive(true);// list[5].SetActive(true);
            box[3].enabled = false; box[4].enabled = true; forth = true; fifth = false; nighth = false;
                        StartCoroutine("Fifthing"); _score += 10;       
        }

        /////////////////////////////////////5층

        if (col.gameObject.tag == "Bacon" && first && second && third && forth && !fifth && sixth && seventh && eighth && nighth)
        {
            Destroy(col.gameObject);
            list[44].SetActive(false); list[45].SetActive(true); //list[5].SetActive(true);
            box[4].enabled = false; box[5].enabled = true; fifth = true; sixth = false; nighth = false;
                        StartCoroutine("Fifthing"); _score += 10;       
        }
        if (col.gameObject.tag == "Bell" && first && second && third && forth && !fifth && sixth && seventh && eighth && nighth)
        {
            Destroy(col.gameObject);
            list[44].SetActive(false); list[46].SetActive(true); //list[5].SetActive(true);
            box[4].enabled = false; box[5].enabled = true; fifth = true; sixth = false; nighth = false;
                        StartCoroutine("Fifthing"); _score += 10;       
        }
        if (col.gameObject.tag == "Cheese" && first && second && third && forth && !fifth && sixth && seventh && eighth && nighth)
        {
            Destroy(col.gameObject);
            list[44].SetActive(false); list[47].SetActive(true); //list[5].SetActive(true);
            box[4].enabled = false; box[5].enabled = true; fifth = true; sixth = false; nighth = false;
                        StartCoroutine("Fifthing"); _score += 10;       
        }
        if (col.gameObject.tag == "Cow" && first && second && third && forth && !fifth && sixth && seventh && eighth && nighth)
        {
            Destroy(col.gameObject);
            list[44].SetActive(false); list[48].SetActive(true); //list[5].SetActive(true);
            box[4].enabled = false; box[5].enabled = true; fifth = true; sixth = false; nighth = false;
                        StartCoroutine("Fifthing"); _score += 10;       
        }
        else if (col.gameObject.tag == "Egg" && first && second && third && forth && !fifth && sixth && seventh && eighth && nighth)
        {
            Destroy(col.gameObject);
            list[44].SetActive(false); list[49].SetActive(true);// list[5].SetActive(true);
            box[4].enabled = false; box[5].enabled = true; fifth = true; sixth = false; nighth = false;
                        StartCoroutine("Fifthing"); _score += 10;       
        }
        else if (col.gameObject.tag == "Lett" && first && second && third && forth && !fifth && sixth && seventh && eighth && nighth)
        {
            Destroy(col.gameObject);
            list[44].SetActive(false); list[50].SetActive(true); //list[5].SetActive(true);
            box[4].enabled = false; box[5].enabled = true; fifth = true; sixth = false; nighth = false;
                        StartCoroutine("Fifthing"); _score += 10;       
        }
        else if (col.gameObject.tag == "Mushroom" && first && second && third && forth && !fifth && sixth && seventh && eighth && nighth)
        {
            Destroy(col.gameObject);
            list[44].SetActive(false); list[51].SetActive(true); //list[5].SetActive(true);
            box[4].enabled = false; box[5].enabled = true; fifth = true; sixth = false; nighth = false;
                        StartCoroutine("Fifthing"); _score += 10;       
 
        }
        else if (col.gameObject.tag == "Onion" && first && second && third && forth && !fifth && sixth && seventh && eighth && nighth)
        {
            Destroy(col.gameObject);
            list[44].SetActive(false); list[52].SetActive(true); //list[5].SetActive(true);
            box[4].enabled = false; box[5].enabled = true; fifth = true; sixth = false; nighth = false;
                        StartCoroutine("Fifthing"); _score += 10;       
        }
        else if (col.gameObject.tag == "Pickle" && first && second && third && forth && @fifth && sixth && seventh && eighth && nighth)
        {
            Destroy(col.gameObject);
            list[44].SetActive(false); list[53].SetActive(true);// list[5].SetActive(true);
            box[4].enabled = false; box[5].enabled = true; fifth = true; sixth = false; nighth = false;
                        StartCoroutine("Fifthing"); _score += 10;       
        }
        else if (col.gameObject.tag == "Tomato" && first && second && third && forth && !fifth && sixth && seventh && eighth && nighth)
        {
            Destroy(col.gameObject);
            list[44].SetActive(false); list[54].SetActive(true);// list[5].SetActive(true);
            box[4].enabled = false; box[5].enabled = true; fifth = true; sixth = false; nighth = false;
                        StartCoroutine("Fifthing"); _score += 10;       
        }

        ///////////////////////////////////////6층

        if (col.gameObject.tag == "Bacon" && first && second && third && forth && fifth && !sixth && seventh && eighth && nighth)
        {
            Destroy(col.gameObject);
            list[55].SetActive(false); list[56].SetActive(true); //list[5].SetActive(true);
            box[5].enabled = false; box[6].enabled = true; sixth = true; seventh = false; nighth = false;
                        StartCoroutine("Fifthing"); _score += 10;       
        }
        if (col.gameObject.tag == "Bell" && first && second && third && forth && fifth && !sixth && seventh && eighth && nighth)
        {
            Destroy(col.gameObject);
            list[55].SetActive(false); list[57].SetActive(true); //list[5].SetActive(true);
            box[5].enabled = false; box[6].enabled = true; sixth = true; seventh = false; nighth = false;
                        StartCoroutine("Fifthing"); _score += 10;       
        }
        if (col.gameObject.tag == "Cheese" && first && second && third && forth && fifth && !sixth && seventh && eighth && nighth)
        {
            Destroy(col.gameObject);
            list[55].SetActive(false); list[58].SetActive(true); //list[5].SetActive(true);
            box[5].enabled = false; box[6].enabled = true; sixth = true; seventh = false; nighth = false;
                        StartCoroutine("Fifthing"); _score += 10;       
        }
        if (col.gameObject.tag == "Cow" && first && second && third && forth && fifth && !sixth && seventh && eighth && nighth)
        {
            Destroy(col.gameObject);
            list[55].SetActive(false); list[59].SetActive(true); //list[5].SetActive(true);
            box[5].enabled = false; box[6].enabled = true; sixth = true; seventh = false; nighth = false;
                        StartCoroutine("Fifthing"); _score += 10;       
        }
        else if (col.gameObject.tag == "Egg" && first && second && third && forth && fifth && !sixth && seventh && eighth && nighth)
        {
            Destroy(col.gameObject);
            list[55].SetActive(false); list[60].SetActive(true);// list[5].SetActive(true);
            box[5].enabled = false; box[6].enabled = true; sixth = true; seventh = false; nighth = false;
                        StartCoroutine("Fifthing"); _score += 10;       
        }
        else if (col.gameObject.tag == "Lett" && first && second && third && forth && fifth && !sixth && seventh && eighth && nighth)
        {
            Destroy(col.gameObject);
            list[55].SetActive(false); list[61].SetActive(true); //list[5].SetActive(true);
            box[5].enabled = false; box[6].enabled = true; sixth = true; seventh = false; nighth = false;
                        StartCoroutine("Fifthing"); _score += 10;       
        }
        else if (col.gameObject.tag == "Mushroom" && first && second && third && forth && fifth && !sixth && seventh && eighth && nighth)
        {
            Destroy(col.gameObject);
            list[55].SetActive(false); list[62].SetActive(true); //list[5].SetActive(true);
            box[5].enabled = false; box[6].enabled = true; sixth = true; seventh = false; nighth = false;
                        StartCoroutine("Fifthing"); _score += 10;       
        }
        else if (col.gameObject.tag == "Onion" && first && second && third && forth && fifth && !sixth && seventh && eighth && nighth)
        {
            Destroy(col.gameObject);
            list[55].SetActive(false); list[63].SetActive(true); //list[5].SetActive(true);
            box[5].enabled = false; box[6].enabled = true; sixth = true; seventh = false; nighth = false;
                        StartCoroutine("Fifthing"); _score += 10;       
        }
        else if (col.gameObject.tag == "Pickle" && first && second && third && forth && fifth && !sixth && seventh && eighth && nighth)
        {
            Destroy(col.gameObject);
            list[55].SetActive(false); list[64].SetActive(true);// list[5].SetActive(true);
            box[5].enabled = false; box[6].enabled = true; sixth = true; seventh = false; nighth = false;
                        StartCoroutine("Fifthing"); _score += 10;       
        }
        else if (col.gameObject.tag == "Tomato" && first && second && third && forth && fifth && !sixth && seventh && eighth && nighth)
        {
            Destroy(col.gameObject);
            list[55].SetActive(false); list[65].SetActive(true);// list[5].SetActive(true);
            box[5].enabled = false; box[6].enabled = true; sixth = true; seventh = false; nighth = false;
                        StartCoroutine("Fifthing"); _score += 10;       
 
        }

        ///////////////////////////////////////7층
        if (col.gameObject.tag == "Bacon" && first && second && third && forth && fifth && sixth && !seventh && eighth && nighth)
        {
            Destroy(col.gameObject);
            list[66].SetActive(false); list[67].SetActive(true); //list[5].SetActive(true);
            box[6].enabled = false; box[7].enabled = true; seventh = true; eighth = false; nighth = false;
                        StartCoroutine("Fifthing"); _score += 10;       
        }
        if (col.gameObject.tag == "Bell" && first && second && third && forth && fifth && sixth && !seventh && eighth && nighth)
        {
            Destroy(col.gameObject);
            list[66].SetActive(false); list[68].SetActive(true); //list[5].SetActive(true);
            box[6].enabled = false; box[7].enabled = true; seventh = true; eighth = false; nighth = false;
                        StartCoroutine("Fifthing"); _score += 10;       
        }
        if (col.gameObject.tag == "Cheese" && first && second && third && forth && fifth && sixth && !seventh && eighth && nighth)
        {
            Destroy(col.gameObject);
            list[66].SetActive(false); list[69].SetActive(true); //list[5].SetActive(true);
            box[6].enabled = false; box[7].enabled = true; seventh = true; eighth = false; nighth = false;
                        StartCoroutine("Fifthing"); _score += 10;       
        }
        if (col.gameObject.tag == "Cow" && first && second && third && forth && fifth && sixth && !seventh && eighth && nighth)
        {
            Destroy(col.gameObject);
            list[66].SetActive(false); list[70].SetActive(true); //list[5].SetActive(true);
            box[6].enabled = false; box[7].enabled = true; seventh = true; eighth = false; nighth = false;
                        StartCoroutine("Fifthing"); _score += 10;       
        }
        else if (col.gameObject.tag == "Egg" && first && second && third && forth && fifth && sixth && !seventh && eighth && nighth)
        {
            Destroy(col.gameObject);
            list[66].SetActive(false); list[71].SetActive(true);// list[5].SetActive(true);
            box[6].enabled = false; box[7].enabled = true; seventh = true; eighth = false; nighth = false;
                        StartCoroutine("Fifthing"); _score += 10;       
        }
        else if (col.gameObject.tag == "Lett" && first && second && third && forth && fifth && sixth && !seventh && eighth && nighth)
        {
            Destroy(col.gameObject);
            list[66].SetActive(false); list[72].SetActive(true); //list[5].SetActive(true);
            box[6].enabled = false; box[7].enabled = true; seventh = true; eighth = false; nighth = false;
                        StartCoroutine("Fifthing"); _score += 10;       
        }
        else if (col.gameObject.tag == "Mushroom" && first && second && third && forth && fifth && sixth && !seventh && eighth && nighth)
        {
            Destroy(col.gameObject);
            list[66].SetActive(false); list[73].SetActive(true); //list[5].SetActive(true);
            box[6].enabled = false; box[7].enabled = true; seventh = true; eighth = false; nighth = false;
                        StartCoroutine("Fifthing"); _score += 10;       
        }
        else if (col.gameObject.tag == "Onion" && first && second && third && forth && fifth && sixth && !seventh && eighth && nighth)
        {
            Destroy(col.gameObject);
            list[66].SetActive(false); list[74].SetActive(true); //list[5].SetActive(true);
            box[6].enabled = false; box[7].enabled = true; seventh = true; eighth = false; nighth = false;
                        StartCoroutine("Fifthing"); _score += 10;       
 
        }
        else if (col.gameObject.tag == "Pickle" && first && second && third && forth && fifth && sixth && !seventh && eighth && nighth)
        {
            Destroy(col.gameObject);
            list[66].SetActive(false); list[75].SetActive(true);// list[5].SetActive(true);
            box[6].enabled = false; box[7].enabled = true; seventh = true; eighth = false; nighth = false;
                        StartCoroutine("Fifthing"); _score += 10;       
        }
        else if (col.gameObject.tag == "Tomato" && first && second && third && forth && fifth && sixth && !seventh && eighth && nighth)
        {
            Destroy(col.gameObject);
            list[66].SetActive(false); list[76].SetActive(true);// list[5].SetActive(true);
            box[6].enabled = false; box[7].enabled = true; seventh = true; eighth = false; nighth = false;
                        StartCoroutine("Fifthing"); _score += 10;       
        }

        ////////////////////////////////////////////8층

        if (col.gameObject.tag == "Bacon" && first && second && third && forth && fifth && sixth && seventh && !eighth && nighth)
        {
            Destroy(col.gameObject);
            list[77].SetActive(false); list[78].SetActive(true); //list[5].SetActive(true);
            box[7].enabled = false; box[8].enabled = true; eighth = true; first = false;  nighth = false;
                        StartCoroutine("Fifthing"); _score += 10;        

        }
        if (col.gameObject.tag == "Bell" && first && second && third && forth && fifth && sixth && seventh && !eighth && nighth)
        {
            Destroy(col.gameObject);
            list[77].SetActive(false); list[79].SetActive(true); //list[5].SetActive(true);
            box[7].enabled = false; box[8].enabled = true; eighth = true; nighth = false;
                        StartCoroutine("Fifthing"); _score += 10;        _score += 10;       


        }
        if (col.gameObject.tag == "Cheese" && first && second && third && forth && fifth && sixth && seventh && !eighth && nighth)
        {
            Destroy(col.gameObject);
            list[77].SetActive(false); list[80].SetActive(true); //list[5].SetActive(true);
            box[7].enabled = false; box[8].enabled = true; eighth = true; nighth = false;
                        StartCoroutine("Fifthing"); _score += 10;        

        }
        if (col.gameObject.tag == "Cow" && first && second && third && forth && fifth && sixth && seventh && !eighth && nighth)
        {
            Destroy(col.gameObject);
            list[77].SetActive(false); list[81].SetActive(true); //list[5].SetActive(true);
            box[7].enabled = false; box[8].enabled = true; eighth = true; nighth = false;
                        StartCoroutine("Fifthing"); _score += 10;        

        }
        else if (col.gameObject.tag == "Egg" && first && second && third && forth && fifth && sixth && seventh && !eighth && nighth)
        {
            Destroy(col.gameObject);
            list[77].SetActive(false); list[82].SetActive(true);// list[5].SetActive(true);
            box[7].enabled = false; box[8].enabled = true; eighth = true; nighth = false;
                        StartCoroutine("Fifthing"); _score += 10;        

        }
        else if (col.gameObject.tag == "Lett" && first && second && third && forth && fifth && sixth && seventh && !eighth && nighth)
        {
            Destroy(col.gameObject);
            list[77].SetActive(false); list[83].SetActive(true); //list[5].SetActive(true);
            box[7].enabled = false; box[8].enabled = true; eighth = true; nighth = false;
                        StartCoroutine("Fifthing"); _score += 10;        

        }
        else if (col.gameObject.tag == "Mushroom" && first && second && third && forth && fifth && sixth && seventh && !eighth && nighth)
        {
            Destroy(col.gameObject);
            list[77].SetActive(false); list[84].SetActive(true); //list[5].SetActive(true);
            box[7].enabled = false; box[8].enabled = true; eighth = true; nighth = false;
                        StartCoroutine("Fifthing"); _score += 10;        

        }
        else if (col.gameObject.tag == "Onion" && first && second && third && forth && fifth && sixth && seventh && !eighth && nighth)
        {
            Destroy(col.gameObject);
            list[77].SetActive(false); list[85].SetActive(true); //list[5].SetActive(true);
            box[7].enabled = false; box[8].enabled = true; eighth = true; nighth = false;
                        StartCoroutine("Fifthing"); _score += 10;       

        }
        else if (col.gameObject.tag == "Pickle" && first && second && third && forth && fifth && sixth && seventh && !eighth && nighth)
        {
            Destroy(col.gameObject);
            list[77].SetActive(false); list[86].SetActive(true);// list[5].SetActive(true);
            box[7].enabled = false; box[8].enabled = true; eighth = true; nighth = false;
                        StartCoroutine("Fifthing"); _score += 10;        

        }
        else if (col.gameObject.tag == "Tomato" && first && second && third && forth && fifth && sixth && seventh && !eighth && nighth)
        {
            Destroy(col.gameObject);
            list[77].SetActive(false); list[87].SetActive(true);// list[5].SetActive(true);
            box[7].enabled = false; box[8].enabled = true; eighth = true; nighth = false;
                        StartCoroutine("Fifthing"); _score += 10;       
        }
    }  
    IEnumerator Ending()
    {
        list[88].SetActive(true);
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("S2");
    }
    private IEnumerator Fifthing()
    {
        yield return new WaitForSeconds(1f);
        nighth = true;         
    }    
}