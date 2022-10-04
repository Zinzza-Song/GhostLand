using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.SceneManagement;
using Unity.LEGO.Game;

public abstract class SceneParam { }

public class App : MonoBehaviour
{
    public int totalScore;
    public int trophyCount;

    public int lifeCount = 3;

    // Start is called before the first frame update
    private void Start()
    {
        EventManager.AddListener<LifeLose>(LifeLoseHadler);

        DontDestroyOnLoad(this.gameObject);
        SceneManager.LoadScene("Intro");
    }

    private void LifeLoseHadler(LifeLose evt)
    {
        this.lifeCount = evt.lifeCount;
    }

    public void ScoreStroe(int pumpkin = 0, int trophy = 0)
    {
        this.totalScore = pumpkin;
        this.trophyCount = trophy;
    }

    public void LifeLost()
    {
        this.lifeCount--;
    }

    private void OnDestroy()
    {
        EventManager.RemoveListener<LifeLose>(LifeLoseHadler);
    }
}

