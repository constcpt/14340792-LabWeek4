using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    private int i;
    public Renderer rend;
    private int randomNum;
    // Start is called before the first frame update
    void Start()
    {
        i = 3;
        randomNum = Random.Range(200, 251);
    }

    // Update is called once per frame
    void Update()
    {
        i++;
        Debug.Log($"{gameObject.name}:{i}");
        if (gameObject.CompareTag("Red") && i == 100)
        {
            gameObject.SetActive(false);
        }
        if (gameObject.CompareTag("Blue") && i == randomNum)
        {
            rend.enabled = false;
        }
    }
}
