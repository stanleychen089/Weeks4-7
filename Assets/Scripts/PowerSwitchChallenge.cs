using UnityEngine;

public class PowerSwitchChallenge : MonoBehaviour
{
    public float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 rotation = transform.eulerAngles;
        rotation.z += speed * Time.deltaTime;
        transform.eulerAngles = rotation;
    }

    public void StartSpin()
    {
        speed = 100;
    }
    public void StopSpin()
    {
        speed = 0;
    }
}
