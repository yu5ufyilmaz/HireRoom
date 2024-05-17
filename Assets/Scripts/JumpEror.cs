using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpEror : MonoBehaviour
{
    public GameObject jumpEror;
private void OnTriggerEnter(Collider other)
{
    if(other.tag == "Player")
    {
        OpenUI();
    }
}

void OpenUI()
{
    jumpEror.SetActive(true);
    Cursor.visible = true;
    Cursor.lockState = CursorLockMode.None;
}
public void CloseJumpEror()
{
    jumpEror.SetActive(false);
    Destroy(this);
    Cursor.visible = false;
    Cursor.lockState = CursorLockMode.Locked;
}
}
