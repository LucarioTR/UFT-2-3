using UnityEngine;

public class CollisionDetector : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        Debug.Log("Sòlid!");
    }
}