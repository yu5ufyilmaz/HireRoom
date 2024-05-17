using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using Unity.VisualScripting;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public GameObject door;
    public GameObject door2;
    public GameObject closePos;
    public GameObject closePos2;
    public AudioSource closeDoor;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
            Closing();

    }
    public void Closing()
    {
        door.transform.DOMove(closePos.transform.position, 3.5f).OnComplete(() => closeDoor.gameObject.SetActive(false));
        door2.transform.DOMove(closePos2.transform.position, 3.5f).OnComplete(() => closeDoor.gameObject.SetActive(false));
        closeDoor.DOFlip();
        closeDoor.Play();
        if (this.name == "Door3")
        {
            EvntManager.TriggerEvent("StopTimer");
        }
    }
}
