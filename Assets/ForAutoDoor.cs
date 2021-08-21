using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForAutoDoor : MonoBehaviour
{
    public Animator autoDoor;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            OpenAutoDoor();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            CloseAutoDoor();
        }
    }

    public void OpenAutoDoor()
    {
        autoDoor.SetBool("isOpen", true);
    }

    public void CloseAutoDoor()
    {
        autoDoor.SetBool("isOpen", false);
    }

}
