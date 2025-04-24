using UnityEngine;

public class playerCutscene : MonoBehaviour
{
    public static playerCutscene instance;
    [SerializeField] private playerMovement PM;
    [SerializeField] private ThirdPerson TPC;
    [SerializeField] private GameObject Player;

    //cutscene
    public GameObject FPC;
    public GameObject CSC;
    public GameObject CSPC;

    private void Awake()
    {
        instance = this;
    }
    public void Activate()
    {
        PM.enabled = true;
        TPC.enabled = true;
        Player.SetActive(true);
    }
    public void Deactivate()
    {
        PM.enabled = false;
        TPC.enabled = false;
        Player.SetActive(false);
    }
}
