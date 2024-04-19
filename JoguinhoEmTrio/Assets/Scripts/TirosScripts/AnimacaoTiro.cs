using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimacaoTiro : MonoBehaviour
{
    public Animator animador;

    public void AnimarTiro(string nomeDaAnimacao)
    {
        animador.Play(nomeDaAnimacao);
    }
}
