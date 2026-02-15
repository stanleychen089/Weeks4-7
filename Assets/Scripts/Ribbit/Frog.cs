using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class Frog : MonoBehaviour
{
    public Transform tongueTip;
    public Transform mouth; //start of the lerp
    public Transform destination; //end of the lerp 
    public float t;
    public bool timerIsRunning = false;
    public float speed = 1;
    public AnimationCurve curve; 

    public GameObject bugPrefab;
    public Bug spawnedBug;
    public bool needToRespawn = false;

    public GameObject gameOverScreen;
    public GameTimer gameTimer; 
    public TextMeshProUGUI scoreDisplay; 
    public int score = 0;
    public bool gameTimerIsRunning = true;

    public AudioSource eatSound; 
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        RespawnBug();
        scoreDisplay.text = score.ToString();
        gameOverScreen.SetActive(false); 
    }

    // Update is called once per frame
    void Update()
    {

        //'return' stops update function if gameTimerIsRunning == false
        if (!gameTimerIsRunning) return; 


        //wait until the player presses space: start the lerp timer using bool
        if (!timerIsRunning && Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            timerIsRunning = true; 
        }
        //t get bigger
        //we use lerp to set the position of the tongue tip

        if (timerIsRunning)
        {
            //do the lerp
            t += speed * Time.deltaTime; 
            if (t > 1)
            {
                //when lerp reaches final position, lerp back to start
                speed = speed * -1; 
            }
            //when lerp is back to start position, reset variables 
            if (t < 0)
            {
                //time is up
                //set the speed back to positive for next time
                speed = speed * -1;
                //stop the timer running
                timerIsRunning = false;
                //reset t to 0 for next time 
                t = 0;

                //check if bug needs to be respawned
                if (needToRespawn)
                {
                    RespawnBug();
                }
            }
            tongueTip.position = Vector2.Lerp(mouth.position, destination.position, curve.Evaluate(t));
            //check if tongue collides with bug 
            //only check if the bug is there. If needToRespawn is false, then bug is there
            if (needToRespawn == false && spawnedBug.sr.bounds.Contains(tongueTip.position) == true)
            {
                eatSound.Play(); 
                //eat bug if this is true
                Destroy(spawnedBug.gameObject);
                needToRespawn = true;
                score += 1;
                scoreDisplay.text = score.ToString();

      
            }
        }
        else
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
            destination.position = mousePos;
        }

    }

    void RespawnBug()
    {
        //instantiates new gameObjects of bugs using bug prefab at random location 
        GameObject bug = Instantiate(bugPrefab, Random.insideUnitCircle * 4, Quaternion.identity);
        //the new gameObject we instantiated will take the Bug script from the prefab 
        spawnedBug = bug.GetComponent<Bug>();
        needToRespawn = false; 
    }

    public void RestartGame()
    {
        //set the score to 0
        score = 0;
        //reset frog tongue 
        t = 0;
        timerIsRunning = false ;
        tongueTip.position = Vector2.Lerp(mouth.position, destination.position, curve.Evaluate(t));


        //check if we need to spawn a bug
        if (needToRespawn)
        {
            RespawnBug();
        }
        //hide the gameOverScreen
        gameOverScreen.SetActive(false);
        //restart the timer
        gameTimerIsRunning = true; 
        gameTimer.timerValue = gameTimer.timerVisuals.maxValue;

        //restart score display
        scoreDisplay.text = score.ToString();


    }
}
