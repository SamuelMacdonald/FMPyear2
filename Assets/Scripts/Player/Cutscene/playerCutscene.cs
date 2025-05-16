using UnityEngine;
using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.Collections;

public class playerCutscene : MonoBehaviour
{
    public static playerCutscene instance;
    [SerializeField] private playerMovement PM;
    [SerializeField] private ThirdPerson TPC;
    [SerializeField] private GameObject Player;
    [SerializeField] public GameObject[] extra;
    //private int currentActiveIndex = 0;

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
        CSPC.SetActive(false);
        Player.SetActive(true);
        
    }
    public void Deactivate()
    {
        PM.enabled = false;
        TPC.enabled = false;
        Player.SetActive(false);
        
        
    }
    public void DeactExtra()
    {
        for (int i = 0; i < extra.Length; i++)
        {
            extra[i].SetActive(false);
        }
    }
    public void ActExtra()
    {
        for (int i = 0; i < extra.Length; i++)
        {
            extra[i].SetActive(true);
        }
    }
}
