
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Gaze : MonoBehaviour {
    List<InfoBeh> infos = new List<InfoBeh>();
    

    void Start() {
        infos = FindObjectsOfType<InfoBeh>().ToList();

    }

    void Update()
    {
        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.forward, out hit)) {
            GameObject go = hit.collider.gameObject;
            if (go.CompareTag("hasInfo")){
                OpenInfo(go.GetComponent<InfoBeh>());
            }
        }
        else
        {
            CloseAll();
        }
    }

    void OpenInfo(InfoBeh desiredInfo)
    {
        foreach (InfoBeh info in infos)
        {
            if (info == desiredInfo)
            {
                info.OpenInfo();
            }
            else
            {
                info.CloseInfo();
            }
        }
    }

    void CloseAll()
    {
        foreach (InfoBeh info in infos)
        {
            info.CloseInfo();
        }
    }
}
