using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    public float speed = 7;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //movement
        transform.position += transform.up * speed * Time.deltaTime;

    }
}
