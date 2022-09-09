using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class CantDisparos : MonoBehaviour
{
    public Transform CantidadDisparos;
    public TMP_Text textoDisparos;
    public int Disparos = 10;
    public Disparos CantDisparosSO;
    // Start is called before the first frame update
    void Start()
    {
        CantidadDisparos = GameObject.Find("Disparos").transform;
        textoDisparos = CantidadDisparos.GetComponent<TMP_Text>();
       
    }

    //private void FixedUpdate()
    //{
    //    CantDisparosSO.disparos = 10;
    //}

    // Update is called once per frame
    void Update()
    {
        //textoDisparos.text = $"Disparos: { CantDisparosSO.disparos}";
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    Disparos = Disparos - 1;
        //}

        textoDisparos.text = $"Disparos: {Disparos}";
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Disparos = Disparos - 1;
        }
        if(Disparos <= 0)
        {
            Disparos = 0;
        }
    }
}
