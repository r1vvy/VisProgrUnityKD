using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SferasKontrole : MonoBehaviour
{
    public Text victoryText;
    // Start is called before the first frame update
    void Start()
    {
        victoryText.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Kapsula"))
        {
            victoryText.gameObject.SetActive(true);
            victoryText.text = "Tu uzvareji!";
        }
    }
}
