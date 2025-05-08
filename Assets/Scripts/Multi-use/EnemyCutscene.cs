using Unity.Cinemachine;
using UnityEngine;
using UnityEngine.AI;

public class EnemyCutscene : MonoBehaviour
{
    [SerializeField] private GameObject cutscenePlay;
    [SerializeField] private MovementZombie zom;
    [SerializeField] private NavMeshAgent agent;
    [SerializeField] private CinemachineCamera ZomCam;
    public void PlayerSpot()
    {
        cutscenePlay.SetActive(true);
        playerCutscene.instance.CSC.SetActive(true);
        playerCutscene.instance.FPC.SetActive(false);
        Debug.Log("worked");
        agent.speed = 0;
        ZomCam.enabled = (true);
        zom.enabled = (false);
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Player"))
        {
            PlayerSpot();
        }
    }
}
