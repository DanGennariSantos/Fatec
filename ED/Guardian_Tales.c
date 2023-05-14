#include <stdio.h>
#include <stdlib.h>
#include <time.h>
#include <unistd.h>
#include "Guardian_Tales.h"

#define MAXJOGADORES 20

int main(void) {

    srand(time(NULL));
    printf ("---> Bem-vindo ao Guardian Tales---<\n");

    Jogador jogadores[MAXJOGADORES];

// Atribuição de valores para 9 jogadores

    // Jogador 1
    strcpy(jogadores[0].nome, "Danilo");
    jogadores[0].pontuacao = 82;
    jogadores[0].data.dia = 1;
    jogadores[0].data.mes = 1;
    jogadores[0].data.ano = 2023;

    // Jogador 2
    strcpy(jogadores[1].nome, "Danielly");
    jogadores[1].pontuacao = 86;
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
    jogadores[4].pontuacao = 75;
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
    strcpy(jogadores[7].nome, "Fernanda");
    jogadores[7].pontuacao = 54;
    jogadores[7].data.dia = 8;
    jogadores[7].data.mes = 2;
    jogadores[7].data.ano = 2023;

    ChamarMenu(jogadores);

    return 0;
}

void ChamarMenu(Jogador *jogadores) {

    int opcao;

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
        scanf ("%d", &opcao);

        switch (opcao) {
            case 1:
                Jogar(jogadores);
                break;
            case 2:
                MostrarAlta(jogadores);
                break;
            case 3:
                MostrarBaixa(jogadores);
                break;
            case 4:
                MostrarDados();
                break;
            case 5:
                MostrarNumJogadores(jogadores);
                break;
            case 6:
                MostrarRanking(jogadores);
                break;
            case 7:
                RemoverJogador();
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
void Jogar(Jogador *jogadores) {
    printf("\nEstou na funcao jogar \\o/\n");

    int numJogadores = proxJogador(jogadores);
    jogadores[numJogadores] = lerJogador();

    printf("\nSua pontuacao: %i\n", jogadores[numJogadores].pontuacao);
    }

//--------------------------------------------------------------------------------------
void MostrarAlta(Jogador *jogadores) {
    printf("\nEstou na funcao MostarAlta \\o/\n");

    int maiorPontuacao = jogadores[0].pontuacao;
    Jogador jogadorAlta = jogadores[0];

    for (int i = 0; i < proxJogador(jogadores); i++) {
        if (jogadores[i].pontuacao > maiorPontuacao) {
            maiorPontuacao = jogadores[i].pontuacao;
            jogadorAlta = jogadores[i];
        }
    }
    printf("A maior pontuacao eh: %d\n", maiorPontuacao);
}

//--------------------------------------------------------------------------------------
void MostrarBaixa(Jogador *jogadores) {
    printf("\nEstou na funcao MostrarBaixa \\o/\n");

    int menorPontuacao = jogadores[0].pontuacao;
    Jogador jogadorBaixa = jogadores[0];

    for (int i = 0; i < proxJogador(jogadores); i++) {
        if (jogadores[i].pontuacao < menorPontuacao) {
            menorPontuacao = jogadores[i].pontuacao;
            jogadorBaixa = jogadores[i];
        }
    }
    printf("A menor pontuacao eh: %d\n", menorPontuacao);
}

//--------------------------------------------------------------------------------------
void MostrarDados() {
    printf("\nEstou na funcao MostrarDados \\o/\n");
    }

//--------------------------------------------------------------------------------------
void MostrarNumJogadores(Jogador *jogadores) {
    printf("\nEstou na funcao MostrarJogador \\o/\n");

    int numJogadores = proxJogador(jogadores);
    printf("O numero de jogadores ranqueados eh: %d\n", numJogadores);
    }

//--------------------------------------------------------------------------------------
void MostrarRanking(Jogador *jogadores) {
    printf("\nEstou na funcao MostrarRanking \\o/\n");

    // Ordenar jogadores por pontuação
    int numJogadores = proxJogador(jogadores);
    Jogador temp;

    for (int i = 0; i < numJogadores - 1; i++) {
        for (int j = i + 1; j < numJogadores; j++) {
            if (jogadores[j].pontuacao > jogadores[i].pontuacao) {
                temp = jogadores[i];
                jogadores[i] = jogadores[j];
                jogadores[j] = temp;
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
void RemoverJogador() {
    printf("\nEstou na funcao RemoverJogador \\o/\n");
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
int proxJogador(Jogador *jogadores){
    int i;

    for (i = 0; i < MAXJOGADORES; i++){
        if (strcmp(jogadores[i].nome, "") == 0) {
            break;
        }
    }
    strcpy(jogadores[i+1].nome,"");
    return i;
}
