using UnityEngine;

public class Toggle : MonoBehaviour
{
    public void ToggleChecker()
    {
        //the short version of the entire block of code below 
        //call setActive and pass the opposite boolean of the gameObject's state 
        gameObject.SetActive(!gameObject.activeInHierarchy);


        ////if gameObject is active, turn it off and call setActive to pass false 
        //if (gameObject.activeInHierarchy == true)
        //{
        //     gameObject.SetActive(false);
        //}
        //else if (gameObject.activeInHierarchy == false) 
        //{
        //    //Otherwise the game object is inactive, turn if on and call setActive to pass true 
        //    gameObject.SetActive(true);
        //}
    }
}
