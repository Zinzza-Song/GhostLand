using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Intro : MonoBehaviour
{
    public UiIntro uiIntro;

    // Start is called before the first frame update
    void Start()
    {
        uiIntro.playBtn.onClick.AddListener(() => 
        {
            LoadingScene.LoadScene("Park 1");
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
