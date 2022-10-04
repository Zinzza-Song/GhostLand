using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Unity.LEGO.Game;

public class Pumpkin : MonoBehaviour
{
    private void Awake()
    {
        var obj = FindObjectsOfType<Pumpkin>();

        if (obj.Length == 1)
            DontDestroyOnLoad(this);
        else
            Destroy(this);

        //EventManager.AddListener<ScoreEvent>((evt) =>
        //{
        //    if (evt != null)
        //    {
        //        var pumpkin = this.gameObject.GetComponent<Text>();
        //        int score = int.Parse(pumpkin.text);
        //        score += evt.score;

        //        pumpkin.text = score.ToString();
        //    }
        //});
    }
}
