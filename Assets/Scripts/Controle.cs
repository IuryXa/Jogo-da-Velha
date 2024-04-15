using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;
using UnityEngine.EventSystems;

public class Controle : MonoBehaviour
{
    public TMP_Text xo1; //Variavel para inserir "x" ou "o"
    int xo1n = 0;   //Variavel para verificar se o espaço foi utilizado
    public TMP_Text xo2;
    int xo2n = 0;
    public TMP_Text xo3;
    int xo3n = 0;
    public TMP_Text xo4;
    int xo4n = 0;
    public TMP_Text xo5;
    int xo5n = 0;
    public TMP_Text xo6;
    int xo6n = 0;
    public TMP_Text xo7;
    int xo7n = 0;
    public TMP_Text xo8;
    int xo8n = 0;
    public TMP_Text xo9;
    int xo9n = 0;
    public GameObject vitoria; //usado para referenciar um "GameObject" na unity
    public TMP_Text textoVitoria; 
    public GameObject reiniciar;
    public GameObject jogoPrincipal;
    public GameObject escolha;
    public TMP_Text primeiro;
    private int number = 0; //Usado para armazenar quem vai primeiro
    public string jogdadorX;//Armazenar "x" ou "o" para o jogador
    public string CPU;//Armazenar "x" ou "o" para o computador
    bool turnoPLayer;//Verifica se é o turno do jogador
    bool escolheu =false;//Verifica se o jogador escolheu "x" ou "o"
    bool jogoTerminado=false;//Verifica se o jogo acabou

    void Start()
    {
        //Esconde o painel principal
        jogoPrincipal.SetActive(false);
        //Esconde o painel de Reiniciar
        reiniciar.SetActive(false);
        //Esconde o Painel de Vitoria
        vitoria.SetActive(false);
        //Aleatoriamente escolhe o primeiro jogador
        number = Random.Range(1, 10);
        //Debug.Log(number);//
        if (number <= 5)
        {
            turnoPLayer = true;
            primeiro.SetText("O jogador joga primeiro");
        }
        else
        {
            turnoPLayer = false;
            primeiro.SetText("O computador joga primeiro");
        }
    }

    void Update()
    {
		//Se o jogador escolheu "o" ou "x"
        if ((Input.GetButtonDown("Fire1") && EventSystem.current.currentSelectedGameObject.name == "Bolinha"))
        {
            jogdadorX = "o";
            CPU = "x";
            escolha.SetActive(false);//Desativa o canvas "escolha"
            jogoPrincipal.SetActive(true);//Ativa o canvas do jogo principal
            escolheu = true;

        }
        else if ((Input.GetButtonDown("Fire1") && EventSystem.current.currentSelectedGameObject.name == "Xis"))
        {
            jogdadorX = "x";
            CPU = "o";
            escolha.SetActive(false);
            jogoPrincipal.SetActive(true);
            escolheu = true;
        }
        //Checar Condições de Vitoria
        if (xo1n == 2 && xo2n == 2 && xo3n == 2)//Verifica se a CPU venceu
        {
            vitoria.SetActive(true);//Ativa o GameObject "vitoria"
            textoVitoria.SetText("A CPU venceu!");//Escreve no TMP_Text
            reiniciar.SetActive(true);//Ativa o botão de reiniciar
            jogoTerminado = true;//Torna verdadeira a variavel, impossibilitando o jogo de continuar até que seja reiniciado
        }
        else if (xo1n == 2 && xo5n == 2 && xo9n == 2)
        {
            vitoria.SetActive(true);
            textoVitoria.SetText("A CPU venceu!");
            reiniciar.SetActive(true);
            jogoTerminado = true;
        }
        else if (xo1n == 2 && xo4n == 2 && xo7n == 2)
        {
            vitoria.SetActive(true);
            textoVitoria.SetText("A CPU venceu!");
            reiniciar.SetActive(true);
            jogoTerminado = true;
        }
        else if (xo2n == 2 && xo5n == 2 && xo8n == 2)
        {
            vitoria.SetActive(true);
            textoVitoria.SetText("A CPU venceu!");
            reiniciar.SetActive(true);
            jogoTerminado = true;
        }
        else if (xo3n == 2 && xo6n == 2 && xo9n == 2)
        {
            vitoria.SetActive(true);
            textoVitoria.SetText("A CPU venceu!");
            reiniciar.SetActive(true);
            jogoTerminado = true;
        }
        else if (xo3n == 2 && xo5n == 2 && xo7n == 2)
        {
            vitoria.SetActive(true);
            textoVitoria.SetText("A CPU venceu!");
            reiniciar.SetActive(true);
            jogoTerminado = true;

        }
        else if (xo4n == 2 && xo5n == 2 && xo6n == 2)
        {
            vitoria.SetActive(true);
            textoVitoria.SetText("A CPU venceu!");
            reiniciar.SetActive(true);
            jogoTerminado = true;

        }
        else if (xo7n == 2 && xo8n == 2 && xo9n == 2)
        {
            vitoria.SetActive(true);
            textoVitoria.SetText("A CPU venceu!");
            reiniciar.SetActive(true);
            jogoTerminado = true;

        }

        //Movimentos do Jogador
        if ((Input.GetButtonDown("Fire1") && turnoPLayer && EventSystem.current.currentSelectedGameObject.name == "EspacoCE" && xo1n == 0 &&jogoTerminado==false))
        {
            xo1.SetText(jogdadorX);//Insere o "x" na posição indicada
            turnoPLayer = false;//Indica que o turno do jogador acabou
            xo1n++;//Indica que o jogador ocupou esse espaço específico
        }
        if ((Input.GetButtonDown("Fire1") && turnoPLayer && EventSystem.current.currentSelectedGameObject.name == "EspacoCM" && xo2n == 0 && jogoTerminado == false))
        {
            xo2.SetText(jogdadorX);
            turnoPLayer = false;
            xo2n++;
        }
        if ((Input.GetButtonDown("Fire1") && turnoPLayer && EventSystem.current.currentSelectedGameObject.name == "EspacoCD" && xo3n == 0 && jogoTerminado == false))
        {
            xo3.SetText(jogdadorX);
            turnoPLayer = false;
            xo3n++;
        }
        if ((Input.GetButtonDown("Fire1") && turnoPLayer && EventSystem.current.currentSelectedGameObject.name == "EspacoME" && xo4n == 0 && jogoTerminado == false))
        {
            xo4.SetText(jogdadorX);
            turnoPLayer = false;
            xo4n++;
        }
        if ((Input.GetButtonDown("Fire1") && turnoPLayer && EventSystem.current.currentSelectedGameObject.name == "EspacoMM" && xo5n == 0 && jogoTerminado == false))
        {
            xo5.SetText(jogdadorX);
            turnoPLayer = false;
            xo5n++;
        }
        if ((Input.GetButtonDown("Fire1") && turnoPLayer && EventSystem.current.currentSelectedGameObject.name == "EspacoMD" && xo6n == 0 && jogoTerminado == false))
        {
            xo6.SetText(jogdadorX);
            turnoPLayer = false;
            xo6n++;
        }
        if ((Input.GetButtonDown("Fire1") && turnoPLayer && EventSystem.current.currentSelectedGameObject.name == "EspacoBE" && xo7n == 0 && jogoTerminado == false))
        {
            xo7.SetText(jogdadorX);
            turnoPLayer = false;
            xo7n++;
        }
        if ((Input.GetButtonDown("Fire1") && turnoPLayer && EventSystem.current.currentSelectedGameObject.name == "EspacoBM" && xo8n == 0 && jogoTerminado == false))
        {
            xo8.SetText(jogdadorX);
            turnoPLayer = false;
            xo8n++;
        }
        if ((Input.GetButtonDown("Fire1") && turnoPLayer && EventSystem.current.currentSelectedGameObject.name == "EspacoBD" && xo9n == 0 && jogoTerminado == false))
        {
            xo9.SetText(jogdadorX);
            turnoPLayer = false;
            xo9n++;
        }
        //Checar condição de vitoria(Joggador)
        if (xo1n == 1 && xo2n == 1 && xo3n == 1)//Verifica se o jogador venceu
        {
            vitoria.SetActive(true);//Ativa o GameObject"vitoria"
            textoVitoria.SetText("O jogador venceu!");//Insere o texto no TMP_Text
            reiniciar.SetActive(true);//Ativa o botão de reiniciar
            jogoTerminado = true;//Indica que o jogo acabou
        }
        else if (xo1n == 1 && xo5n == 1 && xo9n == 1)
        {
            vitoria.SetActive(true);
            textoVitoria.SetText("O jogador venceu!");
            reiniciar.SetActive(true);
            jogoTerminado = true;
        }
        else if (xo1n == 1 && xo4n == 1 && xo7n == 1)
        {
            vitoria.SetActive(true);
            textoVitoria.SetText("O jogador venceu!");
            reiniciar.SetActive(true);
            jogoTerminado = true;
        }
        else if (xo2n == 1 && xo5n == 1 && xo8n == 1)
        {
            vitoria.SetActive(true);
            textoVitoria.SetText("O jogador venceu!");
            reiniciar.SetActive(true);
            jogoTerminado = true;
        }
        else if (xo3n == 1 && xo6n == 1 && xo9n == 1)
        {
            vitoria.SetActive(true);
            textoVitoria.SetText("O jogador venceu!");
            reiniciar.SetActive(true);
            jogoTerminado = true;
        }
        else if (xo3n == 1 && xo5n == 1 && xo7n == 1)
        {
            vitoria.SetActive(true);
            textoVitoria.SetText("O jogador venceu!");
            reiniciar.SetActive(true);
            jogoTerminado = true;
        }
        else if (xo4n == 1 && xo5n == 1 && xo6n == 1)
        {
            vitoria.SetActive(true);
            textoVitoria.SetText("O jogador venceu!");
            reiniciar.SetActive(true);
            jogoTerminado = true;
        }
        else if (xo4n == 1 && xo5n == 1 && xo6n == 1)
        {
            vitoria.SetActive(true);
            textoVitoria.SetText("O jogador venceu!");
            reiniciar.SetActive(true);
            jogoTerminado = true;
        }
        else if (xo7n == 1 && xo8n == 1 && xo9n == 1)
        {
            vitoria.SetActive(true);
            textoVitoria.SetText("O jogador venceu!");
            reiniciar.SetActive(true);
            jogoTerminado = true;
        }
        //CPU(no primeiro turno, sempre tenta se posicionar no meio)
		//Verifica se é o turno do jogador, se o espaço está vazio, se o jogador já escolheu "x" ou "o" e se o jogo acabou
        if (turnoPLayer == false && xo5n == 0 && escolheu && jogoTerminado == false)
        {
            xo5.SetText(CPU);//Insere "x" ou "o"
            turnoPLayer = true;//Torna a bool verdadeira, indicando que é o turno do jogador
            xo5n += 2;//É adicionado +2 para diferenciar do jogador
        }
        //CPU verifica se está ganhando
        if (turnoPLayer == false && xo1n == 0 && escolheu && jogoTerminado == false)
        {
			//Verifica se dois espaços adjacentes ao espaço atual foram preenchidos pela CPU
            if ((xo2n==2 && xo3n==2)||(xo4n ==2 && xo7n==2)||(xo5n==2 && xo9n==2))
            {
            xo1.SetText(CPU);
            turnoPLayer = true;
                xo1n += 2;
            }
        }
        if (turnoPLayer == false && xo3n == 0 && escolheu && jogoTerminado == false)
        {
            if ((xo2n == 2 && xo1n == 2) || (xo6n == 2 && xo9n == 2) || (xo5n == 2 && xo7n == 2))
            {
                xo3.SetText(CPU);
                turnoPLayer = true;
                xo3n += 2;
            }
        }
        if (turnoPLayer == false && xo7n == 0 && escolheu && jogoTerminado == false)
        {
            if ((xo1n == 2 && xo4n == 2) || (xo5n == 2 && xo3n == 2) || (xo8n == 2 && xo9n == 2))
            {
                xo7.SetText(CPU);
                turnoPLayer = true;
                xo7n += 2;
            }
        }
        if (turnoPLayer == false && xo9n == 0 && escolheu && jogoTerminado == false)
        {
            if ((xo7n == 2 && xo8n == 2) || (xo6n == 2 && xo3n == 2) || (xo5n == 2 && xo1n == 2))
            {
                xo9.SetText(CPU);
                turnoPLayer = true;
                xo9n += 2;
            }
        }
        if (turnoPLayer == false && xo2n == 0 && escolheu && jogoTerminado == false)
        {
            if ((xo1n == 2 && xo3n == 2) || (xo5n == 2 && xo8n == 2))
            {
                xo2.SetText(CPU);
                turnoPLayer = true;
                xo2n += 2;
            }
        }
        if (turnoPLayer == false && xo4n == 0 && escolheu && jogoTerminado == false)
        {
            if ((xo1n == 2 && xo7n == 2) || (xo5n == 2 && xo6n == 2))
            {
                xo4.SetText(CPU);
                turnoPLayer = true;
                xo4n += 2;
            }
        }
        if (turnoPLayer == false && xo6n == 0 && escolheu && jogoTerminado == false)
        {
            if ((xo3n == 2 && xo9n == 2) || (xo5n == 2 && xo4n == 2))
            {
                xo6.SetText(CPU);
                turnoPLayer = true;
                xo6n += 2;
            }
        }
        if (turnoPLayer == false && xo8n == 0 && escolheu && jogoTerminado == false)
        {
            if ((xo7n == 2 && xo9n == 2) || (xo5n == 2 && xo2n == 2))
            {
                xo8.SetText(CPU);
                turnoPLayer = true;
                xo8n += 2;
            }
        }
        //CPU verifica se está perdendo
        if (turnoPLayer == false && xo1n == 0 && escolheu && jogoTerminado == false)
        {
			//Verifica se os espaços adjacentes ao espaço atual foram preenchidos pelo jogador
            if ((xo2n == 1 && xo3n == 1) || (xo4n == 1 && xo7n == 1) || (xo5n == 1 && xo9n == 1))
            {
                xo1.SetText(CPU);
                turnoPLayer = true;
                xo1n += 2;
            }
        }
        if (turnoPLayer == false && xo3n == 0 && escolheu && jogoTerminado == false)
        {
             if ((xo2n == 1 && xo1n == 1) || (xo6n == 1 && xo9n == 1) || (xo5n == 1 && xo7n == 1))
            {
                xo3.SetText(CPU);
                turnoPLayer = true;
                xo3n += 2;
            }
        }
        if (turnoPLayer == false && xo7n == 0 && escolheu && jogoTerminado == false)
        {
             if ((xo1n == 1 && xo4n == 1) || (xo5n == 1 && xo3n == 1) || (xo8n == 1 && xo9n == 1))
            {
                xo7.SetText(CPU);
                turnoPLayer = true;
                xo7n += 2;
            }
        }
        if (turnoPLayer == false && xo9n == 0 && escolheu && jogoTerminado == false)
        {
             if ((xo7n == 1 && xo8n == 1) || (xo6n == 1 && xo3n == 1) || (xo5n == 1 && xo1n == 1))
            {
                xo9.SetText(CPU);
                turnoPLayer = true;
                xo9n += 2;
            }
        }
        if (turnoPLayer == false && xo2n == 0 && escolheu && jogoTerminado == false)
        {
             if ((xo1n == 1 && xo3n == 1) || (xo5n == 1 && xo8n == 1))
            {
                xo2.SetText(CPU);
                turnoPLayer = true;
                xo2n += 2;
            }
        }
        if (turnoPLayer == false && xo4n == 0 && escolheu && jogoTerminado == false)
        {
             if ((xo1n == 1 && xo7n == 1) || (xo5n == 1 && xo6n == 1))
            {
                xo4.SetText(CPU);
                turnoPLayer = true;
                xo4n += 2;
            }
        }
        if (turnoPLayer == false && xo6n == 0 && escolheu && jogoTerminado == false)
        {
             if ((xo3n == 1 && xo9n == 1) || (xo5n == 1 && xo4n == 1))
            {
                xo6.SetText(CPU);
                turnoPLayer = true;
                xo6n += 2;
            }
        }
        if (turnoPLayer == false && xo8n == 0 && escolheu && jogoTerminado == false)
        {
             if ((xo7n == 1 && xo9n == 1) || (xo5n == 1 && xo2n == 1))
            {
                xo8.SetText(CPU);
                turnoPLayer = true;
                xo8n += 2;
            }
        }
		//Caso a CPU não esteja ganhando ou perdendo, ela preencherá espaços priorizando os cantos
        if (turnoPLayer == false && xo3n == 0 && escolheu && jogoTerminado == false)
        {
            xo3.SetText(CPU);
            turnoPLayer = true;
            xo3n += 2;
        }
        if (turnoPLayer == false && xo7n == 0 && escolheu && jogoTerminado == false)
        {
            xo7.SetText(CPU);
            turnoPLayer = true;
            xo7n += 2;
        }
        if (turnoPLayer == false && xo9n == 0 && escolheu && jogoTerminado == false)
        {
            xo9.SetText(CPU);
            turnoPLayer = true;
            xo9n += 2;
        }
        if (turnoPLayer == false && xo1n == 0 && escolheu && jogoTerminado == false)
        {
            xo1.SetText(CPU);
            turnoPLayer = true;
            xo1n += 2;
        }
        if (turnoPLayer == false && xo2n == 0 && escolheu && jogoTerminado == false)
        {
            xo2.SetText(CPU);
            turnoPLayer = true;
            xo2n += 2;
        }
        if (turnoPLayer == false && xo4n == 0 && escolheu && jogoTerminado == false)
        {
            xo4.SetText(CPU);
            turnoPLayer = true;
            xo4n += 2;
        }
        if (turnoPLayer == false && xo5n == 0 && escolheu && jogoTerminado == false)
        {
            xo5.SetText(CPU);
            turnoPLayer = true;
            xo5n += 2;
        }
        if (turnoPLayer == false && xo6n == 0 && escolheu && jogoTerminado == false)
        {
            xo6.SetText(CPU);
            turnoPLayer = true;
            xo6n += 2;
        }
        if (turnoPLayer == false && xo8n == 0 && escolheu && jogoTerminado == false)
        {
            xo8.SetText(CPU);
            turnoPLayer = true;
            xo8n += 2;
        }
        //Checar empate
		//Caso todos os espaços estejam preenchidos com um numero igual ou maior que 1, é declarado um empate
        if (xo1n >= 1 && xo2n >= 1 && xo3n >= 1 && xo4n >= 1 && xo5n >= 1 && xo6n >= 1 && xo7n >= 1 && xo8n >= 1 && xo9n >= 1)
        {
            vitoria.SetActive(true);
            textoVitoria.SetText("Empate");
            reiniciar.SetActive(true);
            jogoTerminado = true;
        }

    }
}
