using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Pakr3Lose : MonoBehaviour
{
    public Button tryAgainBtn;
    public Button introBtn;
    public Text message;

    // Start is called before the first frame update
    void Start()
    {
        var app = GameObject.Find("App").GetComponent<App>();

        tryAgainBtn.onClick.AddListener(() =>
        {
            LoadingScene.LoadScene("Park 3");
        });

        introBtn.onClick.AddListener(() =>
        {
            app.ScoreStroe();
            app.lifeCount = 3;

            SceneManager.LoadScene("Intro");
        });

        if (app.lifeCount == 2)
            message.text = "You Died...\nbut Nice to Meet You!!";
        else if (app.lifeCount == 1)
            message.text = "Good to See you again!\nIf you DIE Once more\nYou can be our Friend FOREVER!";
    }
}
