using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    [Tooltip("Tiempo inicial en segundos")]
    public int tiempoInicial;

    [Tooltip("Escala del tiempo del Reloj")]
    [Range(-10.0f, 10.0f)]
    public float escaladeTiempo = 1;

    private Text myText;
    private float tiempoDelFrameConTimeScale = 0f;
    private float tiempoAMostrarEnSegundos = 0f;
    private float escalaDeTiempoAlPausar, escalaDeTiempoInicial;
    private bool isPaused = false;


    void Start()
    {
        // establecer la escala de tiempo inicial
        escalaDeTiempoInicial = escaladeTiempo;

        //get the text component
        myText = GetComponent<Text>();

        //inicializamos la variable que acumula los tiempos de cada frame con el tiempo inicial
        tiempoAMostrarEnSegundos = tiempoInicial;

        ActualizarReloj(tiempoInicial);
    }
    void Update()
    {
        //variable que representa el tiempo de cada frame considerando la escala de tiempo
        tiempoDelFrameConTimeScale = Time.deltaTime * escaladeTiempo;

        //la siguiente variable va acumulando el tiempo transcurrido para luego mostrarlo en el reloj
        tiempoAMostrarEnSegundos -= tiempoDelFrameConTimeScale;
        ActualizarReloj(tiempoAMostrarEnSegundos);
    }

    public void ActualizarReloj(float tiempoEnSegundos)
    {
        int minutos = 0;
        int segundos = 0;
        string textoDelReloj;

        //asegurar que el tiempo no sea negativo
        if (tiempoEnSegundos < 0) tiempoEnSegundos = 0;

        //calcular minutos y segundos
        minutos = (int)tiempoEnSegundos / 60;
        segundos = (int)tiempoEnSegundos % 60;

        // crear la cadena de caracteres con 2 digitos para los minutos y segundos, separados por ":"
        textoDelReloj = minutos.ToString("00") + ":" + segundos.ToString("00");

        //actualizar el elemetno del text de UI con la cadena de caracteres
        myText.text = textoDelReloj;
    }
}
