using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timerValue = 0;
    public float timerMaxValue = 11;

    public Slider timerSlider; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timerSlider.value = timerValue; 
        timerSlider.maxValue = timerMaxValue;
    }

    // Update is called once per frame
    void Update()
    {
        timerValue += Time.deltaTime;

        //whatever trigger effect when timer reaches max value 
        if (timerValue > timerMaxValue)
        {
            timerValue = 0;
        }

        //location of timer value calculation does not matter (as long as its in update), though its good etiquette to put at the end
        timerSlider.value = timerValue;

    }
}
