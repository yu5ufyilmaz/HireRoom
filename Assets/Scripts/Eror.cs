using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Eror : MonoBehaviour
{
    public GameObject erorImage1;

    public GameObject erorImage2;
    public GameObject jumpEror;
    [SerializeField]
    private GameObject kineticFalse;
    public GameObject level1Comp;
    public GameObject level2Comp;
    public GameObject level3Comp;
    // Start is called before the first frame update

    public void CloseEror()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        if (this == jumpEror)
            Destroy(jumpEror);

        if (this == kineticFalse)
            Destroy(kineticFalse);
        erorImage1.SetActive(false);
        erorImage2.SetActive(false);
        jumpEror.SetActive(false);
        kineticFalse.SetActive(false);
        level1Comp.SetActive(false);
        level2Comp.SetActive(false);
        level3Comp.SetActive(false);
    }

}
