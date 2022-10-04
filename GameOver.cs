using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameOver : MonoBehaviour
{
    public Button introBtn;

    // Start is called before the first frame update
    void Start()
    {
        introBtn.onClick.AddListener(() => 
        {
            var app = GameObject.Find("App").GetComponent<App>();

            app.ScoreStroe();
            app.lifeCount = 3;

            SceneManager.LoadScene("Intro");
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
