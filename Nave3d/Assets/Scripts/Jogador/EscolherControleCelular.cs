using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EscolherControleCelular : MonoBehaviour
{
    public void MudarDeCena(string NomeDaCena)
    {
        SceneManager.LoadScene(NomeDaCena);
       
    }
   
    public void Controle()
    {
        ControleJogador.modoDeJogo = false;
    }
}
