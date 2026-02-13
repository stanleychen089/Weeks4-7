using UnityEngine;

public class Strategies : MonoBehaviour
{
    public GameObject prefab;

    void Start()
    {
        //loop ten times
        for (int i = 0; i < 10; i++)
        {
            //instantiate prefab
            //at a x-pos that is increasing by 1
            //and at a y-pos that is increasing by 0.1
            //and 0 rotation in z

            float x = i;

            Debug.Log(i + "/" + 10 + " = " + i / 10); 
            float y = i / 10f;
            Debug.Log("y = " + y);
            float z = 0; 

            Instantiate(prefab, new Vector3 (x, y, z), Quaternion.identity);
        }
    }

}
