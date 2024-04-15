using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class IntroScreenController : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //if the user hits spacebar, load game scene
        if(Input.GetKeyDown(KeyCode.Space)) 
        {
           // animator.SetTrigger("fadeOut");
            SceneManager.LoadScene("GameScene");
        }
    }
}
