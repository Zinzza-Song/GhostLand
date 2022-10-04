using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Unity.LEGO.Game;

public class Park3 : MonoBehaviour
{
    public Text pumpkin;
    public Text trophy;

    // Start is called before the first frame update
    void Start()
    {
        var app = GameObject.Find("App").GetComponent<App>();
        this.pumpkin.text = app.totalScore.ToString();
        this.trophy.text = app.trophyCount.ToString();

        LifeCount life = new LifeCount(app.lifeCount);
        EventManager.Broadcast(life);

        AnounceStageFail failEvt = new AnounceStageFail("Park3Lose");
        EventManager.Broadcast(failEvt);

        EventManager.AddListener<GameOverEvent>(GameOverEventHandler);
    }

    private void GameOverEventHandler(GameOverEvent evt)
    {
        if(evt.Win)
        {
            var app = GameObject.Find("App").GetComponent<App>();
            app.ScoreStroe(int.Parse(pumpkin.text.ToString()), int.Parse(trophy.text.ToString()));
        }
    }

    private void OnDestroy()
    {
        EventManager.RemoveListener<GameOverEvent>(GameOverEventHandler);
    }
}
