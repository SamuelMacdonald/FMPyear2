using UnityEngine;
using UnityEngine.Timeline;

[RequireComponent((typeof(BoxCollider)))]
[RequireComponent((typeof(SignalReceiver)))]
public class CutsceneStart : interact
{
    [SerializeField] private GameObject cutscenePlay;

    
    public override void Activate()
    {
        base.Activate();
    }
    public override void Deactivate()
    {
        base.Deactivate();
    }

}
