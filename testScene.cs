using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class testScene : MonoBehaviour
{
    public Button btn;

    // Start is called before the first frame update
    void Start()
    {
        this.btn.onClick.AddListener(() => {
            Debug.Log("Click");
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
