using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EscolherControleTela : MonoBehaviour
{
    public void MudarDeCena(string NomeDaCena)
    {
        SceneManager.LoadScene(NomeDaCena);
        
    }
    public void Controle()
    {
        ControleJogador.modoDeJogo = true;
    }
   
}
