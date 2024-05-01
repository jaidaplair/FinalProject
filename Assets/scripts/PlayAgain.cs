using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class PlayAgain : MonoBehaviour
{

    // This method is called when the button is clicked
    public void OnButtonClick()
    {
        SceneManager.LoadScene("GameScene"); // Load the scene again to restart the game
    }
}
