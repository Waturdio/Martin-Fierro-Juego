using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
    [SerializeField] GameObject finishPanel;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            finishPanel.SetActive(true);
            GameObject.FindWithTag("MainCamera").transform.SetParent(null);
            Destroy(other.gameObject);

        }
    }

}
