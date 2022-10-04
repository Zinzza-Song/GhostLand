using UnityEngine;
using Unity.LEGO.Game;
public class Cage : MonoBehaviour
{
    public GameObject trophy;
    public GameObject monster;

    bool removeKey = false;

    //Start is called before the first frame update
    void Start()
    {
        EventManager.AddListener<CageEvent>(CageEventHandler);
    }

    private void CageEventHandler(CageEvent evt)
    {
        Debug.Log(evt);
        Debug.Log(evt.r);
        if (evt.r <= 40)
            Instantiate(trophy, this.transform);
        else
            Instantiate(monster, this.transform);
        evt = null;
        Debug.Log(evt);
        this.removeKey = true;
    }

    private void Update()
    {
        if(this.removeKey)
        {
            EventManager.RemoveListener<CageEvent>(CageEventHandler);
            this.removeKey = false;
        }
    }
}
