using UnityEngine;

public class HouseEnter : MonoBehaviour
{
    public GameObject SpawnPoint;

    public void PlayerMove()
    {
        transform.position = SpawnPoint.transform.position;
    }
}
