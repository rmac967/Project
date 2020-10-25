using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ToggleChat : MonoBehaviour
{
    public GameObject ChatBar;
    public GameObject ChatBox;

    public void Toggle_Changed(bool newValue)
    {
        ChatBox.SetActive(newValue);
        ChatBar.SetActive(newValue);
    }

}

