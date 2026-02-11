using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class TankControls : MonoBehaviour
{
    public SpriteRenderer tankSprite;

    public Slider speedSlider; 
    public float speed = 5;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        speed = speedSlider.value;

        if (Keyboard.current.aKey.isPressed)
        {
            transform.position -= transform.right * speed * Time.deltaTime; 
        }
        if (Keyboard.current.dKey.isPressed)
        {
            transform.position += transform.right * speed * Time.deltaTime;
        }
       
    }

    public void RandomColor()
    {
        tankSprite.color = Random.ColorHSV();
    }
}
