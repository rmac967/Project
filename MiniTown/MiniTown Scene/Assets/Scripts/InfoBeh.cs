﻿
using UnityEngine;

public class InfoBeh : MonoBehaviour
{
    const float SPEED = 6f;
    [SerializeField]
    Transform GameObjectInfo;

    Vector3 desiredScale = Vector3.zero;
 
   

    // Update is called once per frame
    void Update()
    {
        GameObjectInfo.localScale = Vector3.Lerp(GameObjectInfo.localScale, desiredScale, Time.deltaTime * SPEED);
    }
    public void OpenInfo()
    {
        desiredScale = Vector3.one;
    }
    public void CloseInfo()
    {
        desiredScale = Vector3.zero;
    }
}
