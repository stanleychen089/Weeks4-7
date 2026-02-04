using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider healthBar;
    public SpriteRenderer player;
    public int health = 10; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //ensures we don't need to change the int health value incase we decide to change the max health value in slider
        healthBar.maxValue = health;
        //ensures there is not an accidental mismatch between slider value and health value 
        //happens if slider is not set to max health 
        healthBar.value = health;
    }

    // Update is called once per frame
    void Update()
    {
        //get mouse position 
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());

        //check if mouse position is inside sprite
        //check if mouse is clicking a button while inside 
        if (player.bounds.Contains(mousePos) == true && Mouse.current.leftButton.wasPressedThisFrame)
        {
            //if yes, take 1 off health
            health -= 1; 
            if (health < 0 )
            {
                gameObject.SetActive(false); 
            }

        }
        //update health bar slider with health variable 
        healthBar.value = health; 
    }

    public void HealButton()
    {
        //turn on the player game object 
        gameObject.SetActive(true);
        //set health back to health
        //set value pf tje slider to our health 
        health = (int)healthBar.maxValue;
        healthBar.value = health;

    }
}
