using UnityEngine;
using UnityEngine.InputSystem;

public class SpriteButton : MonoBehaviour
{
    SpriteRenderer sr;
    public Color defaultColor;
    public Color highlightedColor;
    public Color pressedColor;


    void Start()
    {
       sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //check if mouse is over the sprite
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        if (sr.bounds.Contains(mousePos))
        {
            //mouse is over this sprite
            sr.color = highlightedColor;
            MouseIsOver();

            //check if mouse button was pressed this frame
            if (Mouse.current.leftButton.wasPressedThisFrame)
            {
                //do stuff for the initial press 
                sr.color = pressedColor;
                LeftButtonWasPressedThisFrame();
            }
            //check if the mouse button is pressed 
            if (Mouse.current.leftButton.isPressed)
            {
                //do stuff for the entire press
                sr.color = pressedColor;
                LeftButtonIsPressed();
            }
            //check if the mouse button was released this frame 
            if (Mouse.current.leftButton.wasReleasedThisFrame)
            {
                //do stuff for the release
                LeftButtonWasReleasedThisFrame();
            }
        }
        else
        {
            //do stuff for when the mouse is not over sprite 
            //mouse is not over this sprite 
            sr.color = defaultColor;
            MouseIsOver();


        }

    }
    void LeftButtonWasPressedThisFrame()
    {

    }

    void LeftButtonIsPressed()
    {

    }
    void LeftButtonWasReleasedThisFrame()
    {

    }

    void MouseIsOver()
    {

    }
    void MouseNotOver()
    {

    }

}
