using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class UIDemo : MonoBehaviour
{
    SpriteRenderer sr;
    public Image duckieImage; //reference to the duckie IMAGE from UI canvas 
    public int clickCounter = 0;
    public TextMeshProUGUI scoreText;

    public Slider slider;
    public TextMeshProUGUI sliderDisplay; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();

        slider.wholeNumbers = true;
    }

    // Update is called once per frame
    void Update()
    {
        sliderDisplay.text = slider.value.ToString(); 
        if (Keyboard.current.anyKey.wasPressedThisFrame)
        {
            ChangeColor();
        }
    }

    public void ChangeColor()
    {
        sr.color = Random.ColorHSV();
        duckieImage.color = sr.color; 
    }

    public void SetSize(float size)
    {
        transform.localScale = Vector3.one * size;
    }

    public void countNumberOfClicks()
    {
        clickCounter += 1; 
        scoreText.text = clickCounter.ToString();
    }

}
