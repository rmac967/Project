
using UnityEngine;

public class InfoBeh2 : MonoBehaviour
{
    const float SPEED = 6f;
    [SerializeField]
    Transform GameObjectInfo2;

    Vector3 desiredScale = Vector3.zero;



    // Update is called once per frame
    void Update()
    {
        GameObjectInfo2.localScale = Vector3.Lerp(GameObjectInfo2.localScale, desiredScale, Time.deltaTime * SPEED);
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
