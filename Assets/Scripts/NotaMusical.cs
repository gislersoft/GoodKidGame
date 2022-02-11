using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NotaMusical : MonoBehaviour
{
    public AudioSource fuenteAudio;
    public AudioClip sonidoNota;
    public int valor = 50;

    private Text textScoreRef;

    // Start is called before the first frame update
    void Start()
    {
        textScoreRef = GameObject.Find("score").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            fuenteAudio.PlayOneShot(sonidoNota);
            int total = (int.Parse(textScoreRef.text) + valor);
            Debug.Log(total);
            textScoreRef.text = total + "";
            Destroy(gameObject);
        }
    }
}

