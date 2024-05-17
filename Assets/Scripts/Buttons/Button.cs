using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Button : MonoBehaviour
{
    private bool canOpen = false;
    public AudioSource doorEror;
    public AudioSource doorOpen;
    public AudioSource buttonTrue;
    private bool isIn = false;
    public GameObject textE;
    public GameObject erorMessage;
    public GameObject door;
    public GameObject door2;
    public GameObject targetPos;
    public GameObject targetPos2;


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
        EvntManager.StartListening("DoorCanOpen", DoorCanOpen);
        erorMessage.SetActive(false);
    }
    void Update()
    {
        OpenUI();
        OpenError();
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

    private void OpenError()
    {
        if (Input.GetKey(KeyCode.E) && isIn == true)
        {
            if (canOpen == true)
            {
                door.transform.DOMove(targetPos.transform.position, 3f);
                door2.transform.DOMove(targetPos2.transform.position, 3f);
                buttonTrue.Play();
                doorOpen.Play();
            }
            else
            {
                doorEror.Play();
                erorMessage.SetActive(true);
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
                textE.SetActive(false);
            }
        }
    }
    private void DoorCanOpen()
    {
        canOpen = true;
    }







}
