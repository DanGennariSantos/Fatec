#include <stdio.h>
#include <string.h>
#include <stdlib.h>
#include <time.h>
#include <unistd.h>

#define MAX_DIGITOS 20

int gerarAleatorio(){
    srand(time(NULL));
    return rand() % 10;
}

void exibirNumero(int numero){
    printf("Memorize o numero: %d\n", numero);
    sleep(3);
    system("cls");
}

int chutar(){
    int chute;
    printf("Forneca o seu chute: ");
    scanf("%d", &chute);
    return chute;
}

void main (){

    int num1 = gerarAleatorio();
    char num1Str[2];
    sprintf (num1Str, "%d", num1);

    char memoria1[MAX_DIGITOS] = "";
    strcat(memoria1, num1Str);

    exibirNumero(num1);

    int chute1 = chutar();
    char chute1Str[3];
    sprintf (chute1Str, "%d", chute1);

    //printf("Chute do Jogador 1 eh: %s\n", chute1Str);

    if (strcmp(chute1Str,memoria1) == 0)
        printf("Jogador 1 acertou!\n");
    else
        printf("Jogador 1 errou!\n");



}
