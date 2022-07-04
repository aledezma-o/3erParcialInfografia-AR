using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class End : MonoBehaviour
{
    public GameObject winPanel;
    public GameObject winEffect;
    public float effectTime = 4;
    /*// Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }*/

    void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        StartCoroutine(Win());
    }
    IEnumerator Win()
    {
        gameObject.GetComponent<AudioSource>().Play();
        winPanel.SetActive(true);
        winEffect.SetActive(true);

        yield return new WaitForSeconds(effectTime);

        gameObject.GetComponent<AudioSource>().Stop();
        winPanel.SetActive(false);
        winEffect.SetActive(false);
    }
}
