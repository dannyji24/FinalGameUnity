using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldCollision : MonoBehaviour
{
    // Start is called before the first frame update
    private UIManager uiManager;

    void Start()
    {
        uiManager = GameObject.Find("Canvas").GetComponent<UIManager>();
        if (uiManager == null)
        {
            Debug.LogError("The UIManager is null");
        }
    }

    // Update is called once per frame
    void Update()
    {
        

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
            Destroy(gameObject);
            if (uiManager != null)
            {
                uiManager.UpdateScore(5);
            }

    }
}
