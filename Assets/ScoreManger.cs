using JetBrains.Annotations;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManger : MonoBehaviour
{

    public TMP_Text Amount;
    public TMP_Text Got;

    [SerializeField] private GameObject Cutscene;
    public playerMovement pub;
    public int ObjAmount;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Amount.text = ObjAmount.ToString();
    }

    // Update is called once per frame
    void Update()
    { 
        Got.text = pub.obj.ToString();
        
        CutsceneTrigger();
    }
    public void CutsceneTrigger()
    {
        if (pub.obj == ObjAmount)
        {
            Cutscene.SetActive(true);
            
        }
    }
}
