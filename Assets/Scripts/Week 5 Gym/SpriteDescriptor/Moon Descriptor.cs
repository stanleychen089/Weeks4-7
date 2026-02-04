using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class MoonDescriptor : MonoBehaviour
{
    //public reference to text UI that will be changed 
    public TextMeshProUGUI descriptorText;
    public SpriteRenderer spriteObject;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //check if mouse is over sprite using bounds.Contains

        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        if (spriteObject.bounds.Contains(mousePos))
        {
            //y: descriptor changes to sprite's description 
            descriptorText.text = "The Moon Haunts you!";
        }
        

    }
}
