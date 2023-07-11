using UnityEngine;

public class InteractableObject : MonoBehaviour
{
    [SerializeField] GameObject text;
    [SerializeField] GameObject objetoJugador;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
            text.SetActive(true);
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
            text.SetActive(false);
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
            if (Input.GetKeyDown(KeyCode.E))
            {
                objetoJugador.SetActive(true);
                text.SetActive(false);
                Destroy(gameObject);
            }
    }
}
