using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Quit : MonoBehaviour
{
    // Start is called before the first frame update
    // This method is called when the button is clicked
    public void OnButtonClick()
    {
        SceneManager.LoadScene("IntroScene"); // Load the scene again to quit the game
    }
}
