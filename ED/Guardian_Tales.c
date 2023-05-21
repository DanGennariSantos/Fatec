#include <stdio.h>
#include <stdlib.h>
#include <time.h>
//#include <unistd.h>
#include <string.h>
#include <ctype.h>
#include "Guardian_Tales.h"

#define MAXJOGADORES 20

int main(void) {

    srand(time(NULL));
    printf ("---> Bem-vindo ao Guardian Tales---<\n");

    Jogador jogadores[MAXJOGADORES];

// Atribuição de valores para 9 jogadores

    // Jogador 1
    strcpy(jogadores[0].nome, "Danilo");
    jogadores[0].pontuacao = 87;
    jogadores[0].data.dia = 1;
    jogadores[0].data.mes = 1;
    jogadores[0].data.ano = 2023;

    // Jogador 2
    strcpy(jogadores[1].nome, "Danielly");
    jogadores[1].pontuacao = 91;
    jogadores[1].data.dia = 2;
    jogadores[1].data.mes = 1;
    jogadores[1].data.ano = 2023;

    // Jogador 3
    strcpy(jogadores[2].nome, "Pedro");
    jogadores[2].pontuacao = 55;
    jogadores[2].data.dia = 3;
    jogadores[2].data.mes = 1;
    jogadores[2].data.ano = 2023;

    // Jogador 4
    strcpy(jogadores[3].nome, "Ana");
    jogadores[3].pontuacao = 68;
    jogadores[3].data.dia = 4;
    jogadores[3].data.mes = 10;
    jogadores[3].data.ano = 2022;

    // Jogador 5
    strcpy(jogadores[4].nome, "Sergio");
    jogadores[4].pontuacao = 70;
    jogadores[4].data.dia = 5;
    jogadores[4].data.mes = 1;
    jogadores[4].data.ano = 2023;

    // Jogador 6
    strcpy(jogadores[5].nome, "Mariana");
    jogadores[5].pontuacao = 13;
    jogadores[5].data.dia = 6;
    jogadores[5].data.mes = 1;
    jogadores[5].data.ano = 2023;

    // Jogador 7
    strcpy(jogadores[6].nome, "Carlos");
    jogadores[6].pontuacao = 35;
    jogadores[6].data.dia = 7;
    jogadores[6].data.mes = 1;
    jogadores[6].data.ano = 2023;

    // Jogador 8
    strcpy(jogadores[7].nome, "Breno");
    jogadores[7].pontuacao = 76;
    jogadores[7].data.dia = 7;
    jogadores[7].data.mes = 10;
    jogadores[7].data.ano = 2022;

    // Jogador 9
    strcpy(jogadores[8].nome, "Gessica");
    jogadores[8].pontuacao = 75;
    jogadores[8].data.dia = 7;
    jogadores[8].data.mes = 1;
    jogadores[8].data.ano = 2022;

    // Jogador 10
    strcpy(jogadores[9].nome, "Diego");
    jogadores[9].pontuacao = 90;
    jogadores[9].data.dia = 7;
    jogadores[9].data.mes = 6;
    jogadores[9].data.ano = 2020;

    // Jogador 11
    strcpy(jogadores[10].nome, "Paloma");
    jogadores[10].pontuacao = 77;
    jogadores[10].data.dia = 7;
    jogadores[10].data.mes = 1;
    jogadores[10].data.ano = 2021;

    // Jogador 12
    strcpy(jogadores[11].nome, "Milena");
    jogadores[11].pontuacao = 88;
    jogadores[11].data.dia = 7;
    jogadores[11].data.mes = 1;
    jogadores[11].data.ano = 2022;

    // Jogador 13
    strcpy(jogadores[12].nome, "Alan");
    jogadores[12].pontuacao = 74;
    jogadores[12].data.dia = 15;
    jogadores[12].data.mes = 5;
    jogadores[12].data.ano = 2022;

    // Jogador 14
    strcpy(jogadores[13].nome, "Erick");
    jogadores[13].pontuacao = 8;
    jogadores[13].data.dia = 18;
    jogadores[13].data.mes = 1;
    jogadores[13].data.ano = 2023;

    // Jogador 15
    strcpy(jogadores[14].nome, "Cris");
    jogadores[14].pontuacao = 15;
    jogadores[14].data.dia = 20;
    jogadores[14].data.mes = 2;
    jogadores[14].data.ano = 2023;

    // Jogador 16
    strcpy(jogadores[15].nome, "Delnice");
    jogadores[15].pontuacao = 20;
    jogadores[15].data.dia = 26;
    jogadores[15].data.mes = 3;
    jogadores[15].data.ano = 2023;

    // Jogador 17
    strcpy(jogadores[16].nome, "Cesar");
    jogadores[16].pontuacao = 18;
    jogadores[16].data.dia = 7;
    jogadores[16].data.mes = 1;
    jogadores[16].data.ano = 2023;

    // Jogador 18
    strcpy(jogadores[17].nome, "Dimas");
    jogadores[17].pontuacao = 61;
    jogadores[17].data.dia = 29;
    jogadores[17].data.mes = 1;
    jogadores[17].data.ano = 2023;

    // Jogador 19
    strcpy(jogadores[18].nome, "");

    proxJogador(jogadores, &numJogadores);
    ChamarMenu(jogadores);

    return 0;
}

void ChamarMenu(Jogador *jogadores) {

    int opcao = 0;

    while (opcao != 8){

        printf ("\n---------------Menu----------------\n");
        printf ("\n1 - Jogar");
        printf ("\n2 - Mostrar pontuacao mais alta");
        printf ("\n3 - Mostrar pontuacao mais baixa");
        printf ("\n4 - Mostrar os dados de um ranqueado");
        printf ("\n5 - Mostrar o numero de jogadores ranqueados");
        printf ("\n6 - Mostrar o ranking");
        printf ("\n7 - Remover um jogador");
        printf ("\n8 - Fim\n");
        printf ("\n-----------------------------------\n");
        printf ("\nSelecione uma opcao: ");
        scanf (" %d", &opcao);

        switch (opcao) {
            case 1:
                Jogar(jogadores, &numJogadores);
                break;
            case 2:
                MostrarAlta(jogadores);
                break;
            case 3:
                MostrarBaixa(jogadores);
                break;
            case 4:
                MostrarDados(jogadores);
                break;
            case 5:
                MostrarNumJogadores(jogadores);
                break;
            case 6:
                MostrarRanking(jogadores);
                break;
            case 7:
                RemoverJogador(jogadores, &numJogadores);
                break;
            case 8:
                Finalizar();
                break;
            default:
                printf ("\nOpcao invalida! Digite um valor entre 1 e 8.\n");
        }
    }
}

//--------------------------------------------------------------------------------------
void Jogar(Jogador *jogadores, int *numJogadores)
{
    //printf("\nEstou na funcao jogar \\o/\n");

    int aux = *numJogadores;
    Jogador novoJogador = lerJogador();
    printf("\nSua pontuacao: %i\n", novoJogador.pontuacao);

    if (*numJogadores < MAXJOGADORES)
    {
        jogadores[aux] = novoJogador;
        (*numJogadores)++;

    } else
        {
        int posicaoPiorJogador = EncontrarPiorJogador(jogadores, numJogadores);

        if (novoJogador.pontuacao > jogadores[posicaoPiorJogador].pontuacao)
            jogadores[posicaoPiorJogador] = novoJogador;

            else
            printf("O ranking atingiu o limite de jogadores.\n");
        }
}

//--------------------------------------------------------------------------------------
void MostrarAlta(Jogador *jogadores) {
    //printf("\nEstou na funcao MostarAlta \\o/\n");

    int maiorPontuacao = jogadores[0].pontuacao;

    for (int i = 0; i < numJogadores; i++) {//até o numero de jogadores. Lembre-se que o jogador[0] é o Jogador 1
        if (jogadores[i].pontuacao > maiorPontuacao) {
            maiorPontuacao = jogadores[i].pontuacao;
        }
    }
    printf("A maior pontuacao eh: %d\n", maiorPontuacao);
}

//--------------------------------------------------------------------------------------
void MostrarBaixa(Jogador *jogadores) {

    int piorJogador = EncontrarPiorJogador(jogadores, &numJogadores);//ver a função EncontrarPiorJogador

    if (piorJogador != -1)
        printf("A menor pontuacao eh: %d\n", jogadores[piorJogador].pontuacao);

    else
        printf("Nao ha jogadores ranqueados.\n");
}

//--------------------------------------------------------------------------------------
void MostrarDados(Jogador *jogadores)
{
    //printf("\nEstou na funcao MostrarDados \\o/\n");

    char nome[MAXNOME];
    printf("Digite o nome do jogador para mostrar os dados: ");
    scanf(" %[^\n]", nome);

    //int numJogadores = proxJogador(jogadores, &numJogadores);
    int posicao = EncontrarJogador(jogadores, &numJogadores, nome);

    if (posicao != -1) {
        exibirPessoa(jogadores[posicao]);
    } else
        printf("Jogador nao encontrado!\n");
}

//--------------------------------------------------------------------------------------
void MostrarNumJogadores(Jogador *jogadores) {
    //printf("\nEstou na funcao MostrarJogador \\o/\n");

    printf("O numero de jogadores ranqueados eh: %d\n", numJogadores);
    }

//--------------------------------------------------------------------------------------
void MostrarRanking(Jogador *jogadores)
{
    Jogador aux;

    for (int i = 0; i < numJogadores - 1; i++) {
        for (int j = i + 1; j < numJogadores; j++) {
            if (jogadores[j].pontuacao > jogadores[i].pontuacao)
            //quero a pontuação do jogador[i] no jogador[j]
            //mas não quero perder os dados do jogador[j]
            //por isso, usei o aux, para armazenar momentaneamente os dados do jogador [i]
            {
                aux = jogadores[i];
                jogadores[i] = jogadores[j];
                jogadores[j] = aux;
            }
        }
    }

    // Exibir os jogadores em ordem de classificação
    printf("Ranking de jogadores:\n");
    for (int i = 0; i < numJogadores; i++) {
        printf("\nPosicao %d:", i + 1);
        exibirPessoa(jogadores[i]);
    }
}

//--------------------------------------------------------------------------------------
void RemoverJogador(Jogador *jogadores, int *numJogadores)
{
    //printf("\nEstou na funcao RemoverJogador \\o/\n");
    char nome[MAXNOME];
    printf("Digite o nome do jogador a ser removido: ");
    scanf(" %[^\n]", nome);

    int aux = proxJogador(jogadores, numJogadores);
    int posicao = EncontrarJogador(jogadores, numJogadores, nome);
    if (posicao != -1)
    {
        int i;
        for (i = posicao; i < *numJogadores - 1; i++)//loop a partir do jogador encontrado
            {
            jogadores[i] = jogadores[i + 1];//todos jogadores após o encontrado dão um passinho pra trás
            }
        strcpy(jogadores[aux-1].nome,"");
        printf("Jogador removido com sucesso!\n");
        (*numJogadores)--;

    } else
        printf("Jogador nao encontrado!\n");
}

//--------------------------------------------------------------------------------------
void Finalizar() {
    printf("\nJogo finalizado...\n");
    exit(0);
}

//--------------------------------------------------------------------------------------
Jogador lerJogador() {
    Jogador pessoa;
    char dataString[11];

    printf("\nDigite o nome: ");
    scanf (" %[^\n]", pessoa.nome);

    pessoa.pontuacao = gerarAleatorio();

    printf("Digite a data do jogo [dd mm aaaa]: ");
    scanf(" %[^\n]", dataString);
    sscanf(dataString,"%d %d %d", &pessoa.data.dia, &pessoa.data.mes, &pessoa.data.ano);

    return pessoa;
}

//--------------------------------------------------------------------------------------
void exibirPessoa(Jogador pessoa) {
    printf("\nNome: %s", pessoa.nome);
    printf("\t\tPontuacao: %i", pessoa.pontuacao);
    printf("\tData: %i/%i/%i\n", pessoa.data.dia, pessoa.data.mes, pessoa.data.ano);
}

//--------------------------------------------------------------------------------------
int gerarAleatorio(){
    return rand() % 100; //Número aleatório entre 0 e 99.
}

//--------------------------------------------------------------------------------------
int proxJogador(Jogador *jogadores, int *numJogadores){
    int i;

    for (i = 0; i < MAXJOGADORES; i++){
        if (strcmp(jogadores[i].nome, "") == 0) {
            break;
        }
    }
    strcpy(jogadores[i+1].nome,"");
    *numJogadores = i;
    return i;
}

//----------------------------------------------------------------------------------------
int EncontrarJogador(Jogador *jogadores, int *numJogadores, char *nome)
{
    for (int i = 0; i < *numJogadores; i++) {
        if (strcmp(jogadores[i].nome, nome) == 0) {
            return i; // Retorna o índice do jogador encontrado
        }
    }
    return -1; // Retorna -1 se o jogador não for encontrado
}

//--------------------------------------------------------------------------------------
int EncontrarPiorJogador(Jogador *jogadores, int *numJogadores) {
    int posicaoPior = 0;
    int menorPontuacao = jogadores[0].pontuacao;

    for (int i = 1; i < *numJogadores; i++) {
        if (jogadores[i].pontuacao < menorPontuacao) {
            menorPontuacao = jogadores[i].pontuacao;
            posicaoPior = i;
        }
    }
    return posicaoPior;
}
