using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class UIScrollbar : MonoBehaviour {
    private float timeRemaning;
    public float timerMax = 30f;
     
    public Slider slider;
    private void Start()
    {
        timeRemaning = timerMax;
    }

    // Update is called once per frame
    void Update () {
        timeRemaning = timeRemaning - Time.deltaTime;
        slider.value = CalculateSilderValue();
        if (timeRemaning <= 0)
        {
            SceneManager.LoadScene("S4");
            timeRemaning = timerMax;
        }

    }
    float CalculateSilderValue()
    {
        return timeRemaning / timerMax;
    }
}
