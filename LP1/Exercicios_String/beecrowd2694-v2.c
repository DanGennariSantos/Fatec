#include <stdio.h>
#include <ctype.h>
#include <stdlib.h>

int main() {
    char string[15];
    char caracter;
    int nLinhas;

    printf("Insira o numero de linhas: ");
    scanf("%i", &nLinhas);

    for (int i = 1; i <= nLinhas; i++){
        printf("Insira o valor da linha %i: ", i);
        scanf("%s", string);

        int soma = 0;
        int num = 0;

        for (int j = 0; j < 15; j++) {
            if (isdigit(string[j])) { //fun��o 'isdigit()' verifica se o caracter � numerico ou n�o

                caracter = string[j];
                num = num * 10 + atoi(&caracter);
                //alternativa 1: num = num * 10 + ((int)string[i] - 48):
                    //48 converte o valor do caracter para numerico. Ver tabela ascii.

                //alternativa 2: num = num * 10 + (string[i] - '0'):
                    //subtrair por '0' tamb�m converte um caracter para numerico, assim como a fun��o atoi.

            } else {
                soma += num;
                num = 0;
            }
        }
        // adiciona o �ltimo n�mero encontrado � soma
        soma += num;

        printf("A soma dos numeros da lina %i eh: ", i);
        printf("%d\n", soma);

    }

    return 0;
}

