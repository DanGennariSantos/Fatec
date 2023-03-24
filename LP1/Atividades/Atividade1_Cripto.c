#include <stdio.h>
#include <string.h>

void cripto(char texto1[], char texto2[]) {
    char controle1[15] = "zciavutsrlponm";
    char controle2[15] = "9e76543210GDMB";
    int i, j, tamanho;

    tamanho = strlen(texto1);
    for (i = 0; i < tamanho; i++) {
        for (j = 0; j < 15; j++) {
            if (texto1[i] == controle1[j]) {
                texto2[i] = controle2[j];
                break;
            }
            else if (texto1[i] == controle2[j]) {
                texto2[i] = controle1[j];
                break;
            }
            else {
                texto2[i] = texto1[i];
            }
        }
    }
    texto2[tamanho] = '\0';
}

int main() {
    char texto1[9], texto2[9], texto3[9];
    printf("Digite uma palavra de ate 8 caracteres: ");
    scanf("%[^\n]", texto1);

    cripto(texto1, texto2);
    cripto(texto2, texto3);

    printf("O texto criptografado eh: %s\n", texto2);
    printf("E o texto descriptografado eh: %s\n", texto3);

    return 0;
}

