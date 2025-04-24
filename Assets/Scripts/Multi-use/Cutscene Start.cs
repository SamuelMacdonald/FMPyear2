using UnityEngine;
using UnityEngine.Timeline;

[RequireComponent((typeof(BoxCollider)))]
[RequireComponent((typeof(SignalReceiver)))]
public class CutsceneStart : interact
{
    [SerializeField] private GameObject cutscenePlay;
    [SerializeField] private bool oneTimeOnly;



    public override void Activate()
    {
        base.Activate();
        cutscenePlay.SetActive(true);
        playerCutscene.instance.CSC.SetActive(true);
        playerCutscene.instance.FPC.SetActive(false);
        
    }
    public override void Deactivate()
    {
        base.Deactivate();
        playerCutscene.instance.CSC.SetActive(false);
        playerCutscene.instance.FPC.SetActive(true);

        if (oneTimeOnly)
        {
            Destroy(this.gameObject);
        }
    }

}
