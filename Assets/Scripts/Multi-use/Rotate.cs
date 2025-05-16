using UnityEngine;

public class Rotate : MonoBehaviour
{
    public GameObject SpawnPoint;

    public void PlayerMove()
    {
        transform.position = SpawnPoint.transform.position;
    }
}
