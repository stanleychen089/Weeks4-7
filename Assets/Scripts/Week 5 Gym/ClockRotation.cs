using UnityEngine;

public class ClockRotation : MonoBehaviour

{
    public float rotateSpeed; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newRot = transform.eulerAngles;
        newRot.z += rotateSpeed * Time.deltaTime; 
        transform.eulerAngles = newRot;
        Debug.Log(newRot.z);
    }
}
