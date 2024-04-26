using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;

public class GameManager : MonoBehaviour
{
    [SerializeField] TMP_Text ScoreUiText;
    public int score = 1;
    [SerializeField] GameObject fades;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //converty score to string
        ScoreUiText.text = score.ToString();
        
        //fades.gameObject.SetActive(true);
    }
}
