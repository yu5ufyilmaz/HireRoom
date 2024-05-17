using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Button2 : MonoBehaviour
{
    private bool isIn = false;
    public GameObject textE;
    public GameObject erorMessage;
    public GameObject door;
    public GameObject door2;
    public GameObject targetPos;
    public GameObject targetPos2;
    public AudioSource closeDoor;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            isIn = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            isIn = false;
        }
    }

    void Start()
    {
        erorMessage.SetActive(false);
    }
    void Update()
    {
        OpenUI();
        OpenDoor();
    }
    private void OpenUI()
    {
        if (isIn == true)
        {
            textE.SetActive(true);
        }
        else
        {
            textE.SetActive(false);
        }
    }
    private void OpenDoor()
    {
        if (Input.GetKeyDown(KeyCode.E) && isIn == true)
        {
            closeDoor.gameObject.SetActive(true);
            closeDoor.Play();
            door.transform.DOMove(targetPos.transform.position, 3f);
            door2.transform.DOMove(targetPos2.transform.position, 3f);

        }
    }

}
