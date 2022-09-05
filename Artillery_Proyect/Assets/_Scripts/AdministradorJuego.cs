using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdministradorJuego : MonoBehaviour
{
    public static AdministradorJuego SingletonAdministradorJuego;
    public static int VelocidadBala = 30;
    public int DisparosPorJuego = 10;
    public static float VelocidadRotacion = 1;

    public void Awake()
    {
        if (SingletonAdministradorJuego == null)
        {
            SingletonAdministradorJuego = this;
        }
        else
        {
            Debug.Log("Ya existe una instancia de esta clase");
        }
    }
}
