using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Unity.LEGO.Game;

public class MainScript : MonoBehaviour
{
    public Text pumpkin;
    public Text Trophy;

    private void Start()
    {
        var app = GameObject.Find("App").GetComponent<App>();

        LifeCount life = new LifeCount(app.lifeCount);
        EventManager.Broadcast(life);

        EventManager.AddListener<GameOverEvent>(GameOverEventHandler);

        AnounceStageFail failEvt = new AnounceStageFail("Park1Lose");
        EventManager.Broadcast(failEvt);
    }

    private void GameOverEventHandler(GameOverEvent evt)
    {
        if(evt.Win)
        {
            var app = GameObject.Find("App").GetComponent<App>();
            app.ScoreStroe(int.Parse(pumpkin.text.ToString()), int.Parse(Trophy.text.ToString()));
        }    
    }

    private void OnDestroy()
    {
        EventManager.RemoveListener<GameOverEvent>(GameOverEventHandler);
    }
}
