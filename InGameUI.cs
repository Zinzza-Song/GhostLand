using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Unity.LEGO.Game;

public class InGameUI : MonoBehaviour
{
    public Text pumpkin;
    public Text trophy;
    public Image[] lives = new Image[3];

    private void Awake()
    {
        EventManager.AddListener<MyTrophyEvent>(MyTrophyEvetnHandler);
        EventManager.AddListener<ScoreEvent>(ScoreEventHandler);

        var app = GameObject.Find("App").GetComponent<App>();

        for(int i = 0; i < app.lifeCount; i++)
            this.lives[i].GetComponent<Image>().sprite = Resources.Load<Sprite>("Life");
    }

    private void ScoreEventHandler(ScoreEvent evt) 
    {
        if (evt != null)
        {
            int score = int.Parse(pumpkin.text);
            score += evt.score;

            pumpkin.text = score.ToString();
        }
    }

    private void MyTrophyEvetnHandler(MyTrophyEvent evt)
    {
        if (evt != null)
        {
            int count = int.Parse(trophy.text);
            count += evt.count;

            trophy.text = count.ToString();
        }
    }

    private void OnDestroy()
    {
        EventManager.RemoveListener<MyTrophyEvent>(MyTrophyEvetnHandler);
        EventManager.RemoveListener<ScoreEvent>(ScoreEventHandler);
    }
}
