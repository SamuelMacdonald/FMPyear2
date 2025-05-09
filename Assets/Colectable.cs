using UnityEngine;

public class Colectable : MonoBehaviour
{
    public float Objects;

    void Start()
    {
        Objects = 0; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Object")
        {
            Objects++;
            other.gameObject.SetActive(false);
            Debug.Log("Hit");
        }
    }
}
