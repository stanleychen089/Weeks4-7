using UnityEngine;
using UnityEngine.UI;

public class ColorChanger : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Slider rotationSlider;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 rotationValue = transform.eulerAngles;
        rotationValue.z = rotationSlider.value;
        transform.eulerAngles = rotationValue; 
    }

    public void ChangeRandomColor()
    {
        spriteRenderer.color = Random.ColorHSV(); 
    }
}
