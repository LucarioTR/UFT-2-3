using UnityEngine;

public class TriggerDetector : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger!");
    }
}