using UnityEngine;

public class TriggerScript : MonoBehaviour
{
    
    void OnTriggerEnter(Collider other)
    {
        print("Entered the " + gameObject.name);
    }

    void OnTriggerStay(Collider other)
    {
        print("Stayed at the " + gameObject.name);
    }

    void OnTriggerExit(Collider other)
    {
        print("Exited the " + gameObject.name);
    }

}
