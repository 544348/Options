using UnityEngine;

public class TriggerAnimation : MonoBehaviour
{
    private bool isInTrigger = false;
    public Animator ani;  // Reference to the Animator component

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))  // Check if it's the player entering
        {
            Debug.Log("enter");
            isInTrigger = true;
            OpenDoor();
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))  // Check if it's the player exiting
        {
            Debug.Log("exit");
            isInTrigger = false;
            CloseDoor();
        }
    }

    void OpenDoor()
    {
        if (ani != null)
        {
            ani.SetBool("isOpen", true);  // Set the 'isOpen' parameter to true to open the door
        }
    }

    void CloseDoor()
    {
        if (ani != null)
        {
            ani.SetBool("isOpen", false);  // Set the 'isOpen' parameter to false to close the door
        }
    }
}
