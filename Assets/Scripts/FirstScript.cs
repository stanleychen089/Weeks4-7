using UnityEngine;

public class FirstScript : MonoBehaviour
{
    public float speed = 2f;

    Vector2 bottomLeft;
    Vector2 topRight;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //conversion of the screen's bottom left coordinate at (0,0) to the world's bottom left coordinate 
        //conversion of the screen's top right coordinate at the screen's width and height to the world's top right coordinate
        bottomLeft = Camera.main.ScreenToWorldPoint(Vector2.zero);
        topRight = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
    }

    // Update is called once per frame
    void Update()
    {
        //Move the gameObject
        Vector2 newPos = transform.position;
        newPos.x += speed * Time.deltaTime;

        //checks if the square is at the edge of the screen 
        Vector2 screenPos = Camera.main.WorldToScreenPoint(transform.position);

        //test for the left edge 
        if (screenPos.x < 0)
        {
            //set our position to be the world space position under pixel 0 in x 
            newPos.x = bottomLeft.x;
            speed = speed * -1; 

        }

        //test for right edge
        if (screenPos.x > Screen.width)
        {
            newPos.x = topRight.x;
            speed = speed * -1;
        }

        transform.position = newPos; 
    }
}