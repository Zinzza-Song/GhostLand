using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Unity.LEGO.Game;

public class Trophy : MonoBehaviour
{
    private void Awake()
    {
        var obj = FindObjectsOfType<Trophy>();

        if (obj.Length == 1)
            DontDestroyOnLoad(this);
        else
            Destroy(this);

        EventManager.AddListener<MyTrophyEvent>((evt) =>
        {
            if (evt != null)
            {
                var trophy = this.gameObject.GetComponent<Text>();
                int count = int.Parse(trophy.text);
                count += evt.count;

                trophy.text = count.ToString();
            }
        });
    }
}
