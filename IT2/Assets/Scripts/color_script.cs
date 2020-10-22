using System.Collections.Generic;
using UnityEngine;

public class Thermal : MonoBehaviour
{
    public Material matobject;
    int x = 66;
    public Color orange = new Color(0.2F, 0.3F, 0.4F);

    // Start is called before the first frame update
    void Start()
    {
        //x = Random.Range(30, 200);
        if (x >= 30 && x <= 60)
        {
            matobject.color = Color.yellow;
        }
        if (x > 60 && x <= 120)
        {
            matobject.color = new Color(1.0f, 0.64f, 0.0f);
        }
        if (x > 120 && x <= 200)
        {
            matobject.color = Color.red;
        }

    }

}