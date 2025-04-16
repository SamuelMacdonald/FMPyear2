using UnityEngine;

public abstract class interact : MonoBehaviour
{
    [SerializeField] private CanvasGroup interactableUI;
    private bool playerWithinRange;

    private void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Player"))
        {
            
            playerWithinRange = true;
        }
    }

    private void Update()
    {
        if (playerWithinRange && Input.GetKeyDown(KeyCode.E))
        {
            Activate();
        }
    }

    public virtual void Activate()
    {

    }
    public void deactivate()
    {

    }

    private void OnTriggerExit(Collider col)
    {
        if (col.CompareTag("Player"))
        {
            playerWithinRange = false;
        }
    }
}
