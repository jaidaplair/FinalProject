using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;

public class GameManager : MonoBehaviour
{
    [SerializeField] TMP_Text ScoreUiText;
    public int score = 1;
    Quaternion playerStartRotation;
    Vector3 playerStuffStartPosition;
    


    [SerializeField] GameObject player;
    [SerializeField] GameObject playerStuff;
    //[SerializeField] GameObject music;


    //reset playerstuff's position, and set players rotation
    // public int score2 = 0;

    // [SerializeField] GameObject fades;
    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        //DontDestroyOnLoad(gameObject);
        //DontDestroyOnLoad(ScoreUiText.gameObject);
 
        playerStartRotation = player.transform.rotation;
        playerStuffStartPosition = playerStuff.transform.position;
        audioSource = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        //converty score to string
        ScoreUiText.text = score.ToString();
       // score = score;
       
        
        //fades.gameObject.SetActive(true);
    }

    public void Restart()
    {

        //restore player stuff position
        // player.transform.position = playerStartTransform.position;
        //restore players rotation
        // player.transform.rotation = playerStartTransform.rotation;

        playerStuff.transform.position = playerStuffStartPosition;
        player.transform.rotation = playerStartRotation;

        //Debug.Log("restarted");

        //restart the music
        // Restart the background music

        audioSource.Stop();
        audioSource.Play();

    }
    
}
