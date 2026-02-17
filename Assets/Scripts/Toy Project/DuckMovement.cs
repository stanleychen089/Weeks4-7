using UnityEditor.ShaderGraph.Internal;
using UnityEngine;

public class DuckMovement : MonoBehaviour
{
    //Need public reference to player position
    public GameObject playerObject;
    public float speed = 2; 

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Calculate direction between the object's current position and the player's position 
        //Normalize so direction does not include distance between positions 
        Vector3 direction = (playerObject.transform.position - transform.position).normalized;
        //manipulates object's position towards a direction at specified speeds 
        transform.position += direction * speed * Time.deltaTime;
    }
}
