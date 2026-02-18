using UnityEngine;
using UnityEngine.UI;

public class CooldownTimer : MonoBehaviour
{
    public float timerValue;
    public float timerMaxValue;

    public Slider CDSlider;
    public PlayerTankMovement playerScript; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //duration is whatever is set within the player script's inspector 
        timerMaxValue = playerScript.cooldownDuration; 
        CDSlider.value = timerValue;
        CDSlider.maxValue = timerMaxValue; 
    }

    // Update is called once per frame
    void Update()
    {
        timerValue += Time.deltaTime; 

        //trigger effect when timer goes off
        if (timerValue > timerMaxValue)
        {
            timerValue = 0;
            gameObject.SetActive(false); 
        }

        CDSlider.value = timerValue; 
    }
}
