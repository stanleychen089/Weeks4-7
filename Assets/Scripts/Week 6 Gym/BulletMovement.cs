using UnityEngine;
using UnityEngine.InputSystem;

public class BulletMovement : MonoBehaviour
{
    public float speed = 7;
    public float timer = 0;
    public float destructionTime = 3;

    //spriteRenderer references
    public SpriteRenderer bulletSR;
    public SpriteRenderer duckSR;

    //Script reference
    public DuckSpawner duckSpawner; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //movement
        transform.position += transform.right * speed * Time.deltaTime;

        Destroy(gameObject, destructionTime);

        //get public reference to duck prefab and destroy bullet if they touch
        //get own spriterenderner component
        bulletSR = GetComponent<SpriteRenderer>();

        //set sprite renderer to the entire list of duckSpawns in DuckSpawner
        for (int i = 0; i < duckSpawner.duckSpawns.Count; i++)
        {
            //obtain the spriteRenderer from gameObject 
            GameObject duckObject = duckSpawner.duckSpawns[i]; 
            duckSR = duckObject.GetComponent<SpriteRenderer>();
        }

        //only check for duckSR if at least 1 duckSR exists
        if (duckSR != null && bulletSR.bounds.Contains(duckSR.transform.position))
        {
            //destroy both the duck and duck if they collide
            Destroy(gameObject);
            Destroy(duckSR);
        }

        //if (bulletSR.bounds.Contains(duckSR.transform.position))
        //{
        //    Destroy(gameObject);
        //}
        //testing

    }
}
