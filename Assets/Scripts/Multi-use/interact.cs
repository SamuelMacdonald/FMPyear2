using UnityEngine;

public abstract class interact : MonoBehaviour
{
    [SerializeField] private CanvasGroup interactableUI;
    private bool playerWithinRange;

    private void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Player"))
        {
            interactableUI.gameObject.SetActive(true);
            LeanTween.cancel(interactableUI.gameObject);
            LeanTween.alphaCanvas(interactableUI, 1, 1);
            playerWithinRange = true;
            Debug.Log("Player is here");
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
        interactableUI.gameObject.SetActive(false);
    }
    public virtual void Deactivate()
    {

    }

    private void OnTriggerExit(Collider col)
    {
        if (col.CompareTag("Player"))
        {
            playerWithinRange = false;
            LeanTween.alphaCanvas(interactableUI, 0, 1);
            //.setOnComplete(UIHide());
        }
    }

    private void UIHide()
    {
       return; 
    }
}
