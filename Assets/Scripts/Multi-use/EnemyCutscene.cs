using UnityEngine;

public class EnemyCutscene : MonoBehaviour
{
    [SerializeField] private GameObject cutscenePlay;
    public void PlayerSpot()
    {
        cutscenePlay.SetActive(true);
        playerCutscene.instance.CSC.SetActive(true);
        playerCutscene.instance.FPC.SetActive(false);
        Debug.Log("worked");
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Player"))
        {
            PlayerSpot();
        }
    }
}
