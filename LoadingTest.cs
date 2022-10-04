using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadingTest : MonoBehaviour
{
    public Button btn;
    // Start is called before the first frame update
    void Start()
    {
        btn.onClick.AddListener(() =>
        {
            LoadingScene.LoadScene("Park 3");
        });
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
