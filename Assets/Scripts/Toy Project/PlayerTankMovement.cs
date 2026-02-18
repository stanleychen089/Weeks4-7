using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class PlayerTankMovement : MonoBehaviour
{
    public float speed = 4;

    //heath bar reference
    public Slider healthBar;
    public int health = 10;

    //reference to spriterenders of player and ducks
    public SpriteRenderer SR;
    public SpriteRenderer duckSR; 
    public DuckSpawner duckSpawner;

    //heal button
    public GameObject healButton;
    public bool cooldown = false;
    public float timer;
    public float cooldownDuration = 10;
    public GameObject timerCode;

    //score
    public int score = 0;
    public TextMeshProUGUI scoreDisplay;

    //sound
    public AudioSource rewindSFX; 

    void Start()
    {
        //ensure we do not need to change int heath value in case we mess with inspector settings
        healthBar.maxValue = health;
        //ensures there is no accidental mismatch between slider value and health value
        healthBar.value = health; 
        //score set to a number instead of the word 'score'
        scoreDisplay.text = score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.wKey.isPressed)
        {
            moveUp();
        }
        if (Keyboard.current.aKey.isPressed)
        {
            moveLeft();
        }
        if (Keyboard.current.sKey.isPressed)
        {
            moveDown();
        }
        if (Keyboard.current.dKey.isPressed)
        {
            moveRight();
        }

        //collision and damage from ducks to HP
        
        //set duck sprite renderer to the entire list of duckSpawns in duckSpawner 
        for (int i = 0; i < duckSpawner.duckSpawns.Count; i++)
        {
            //obtain the sprite rendeer from gameObject 
            GameObject duckObject = duckSpawner.duckSpawns[i];
            duckSR = duckObject.GetComponent<SpriteRenderer>();
        }

        //only check for duckSR if at least 1 duckSR exists 
        if (duckSR != null && SR.bounds.Contains(duckSR.transform.position))
        {
            health -= 1; 
            Destroy(duckSR);
        }
        //update health slider to health variable
        healthBar.value = health; 

        //cooldown for heal button
        if (cooldown)
        {
            timerCode.SetActive(true);
            healButton.SetActive(false);
            timer += Time.deltaTime; 
            if(timer > cooldownDuration)
            {
                healButton.SetActive (true);
                timer = 0;
                cooldown = false; 
                timerCode.SetActive (false);
            }
        }

        //Death condition
        if(health < 0)
        {
            score -= 1; 
            rewindSFX.Play(); 
            health = (int)healthBar.maxValue;

        }
        scoreDisplay.text = score.ToString();


    }

    void moveUp()
    {
        transform.position += transform.up * speed * Time.deltaTime;
    }
    void moveLeft()
    {
        transform.position -= transform.right * speed * Time.deltaTime;

    }
    void moveDown()
    {
        transform.position -= transform.up * speed * Time.deltaTime;

    }
    void moveRight()
    {
        transform.position += transform.right * speed * Time.deltaTime;

    }

    public void Heal()
    {
        health = (int) healthBar.maxValue;
        cooldown = true;
        score += 1; 
    }

}
