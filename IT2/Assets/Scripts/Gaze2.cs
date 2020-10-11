
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Gaze2 : MonoBehaviour
{
    List<InfoBeh2> infos = new List<InfoBeh2>();


    void Start()
    {
        infos = FindObjectsOfType<InfoBeh2>().ToList();

    }

    void Update()
    {
        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.forward, out hit))
        {
            GameObject go = hit.collider.gameObject;
            if (go.CompareTag("hasinfo2"))
            {
                OpenInfo(go.GetComponent<InfoBeh2>());
            }
        }
        else
        {
            CloseAll();
        }
    }

    void OpenInfo(InfoBeh2 desiredInfo)
    {
        foreach (InfoBeh2 info in infos)
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
        foreach (InfoBeh2 info in infos)
        {
            info.CloseInfo();
        }
    }
}
