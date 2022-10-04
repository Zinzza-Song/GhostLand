using UnityEngine;

public class testRotate : MonoBehaviour
{
    public Transform player;
    private float time = 0.0f;

    void Update()
    {
        time += Time.deltaTime;

        var dir = Vector3.Distance(this.transform.position, player.position);

        if (dir <= 12.3f)
            this.gameObject.GetComponent<testRotate>().enabled = false;
        else
        {
            if(time >= 3.0f)
            {
                this.transform.LookAt(new Vector3(Random.Range(273.86f, 407.02f), this.transform.position.y, Random.Range(-200.70f, -98.58f)));

                time = 0.0f;
            }
        }
    }
}