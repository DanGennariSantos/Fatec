#include <stdio.h>
#include <string.h>
#include <stdlib.h>>

void removeDigito(char texto1[]){

    int tamanho = strlen(texto1) - 2;
    char defeito[2] = {texto1[0], '\0'};
    char texto2[tamanho + 1];
    int i;
    int j = 0;

    for (i = 2; i <= tamanho; i++ )
    {
        char numTemp[2] = {texto1[i], '\0'};

        if ((atoll(numTemp)) != atoll(defeito))
        {
           texto2[j] = texto1[i];
           j++;
        }
    }

    texto2[j] = '\0';

    long long int saida = atoll (texto2);
    printf("Valor corrigido: ");
    printf("%lld\n", saida);
}


int main(void)
{
    char entrada[203];
    char fim[] = "0 0\n";

    printf("Insira o digito que deu defeito e o respectivo valor: ");
    fgets(entrada, sizeof(entrada), stdin);


    while ((strcmp(entrada, fim)) != 0)
        {
        removeDigito (entrada);

        printf("Insira o digito que deu defeito e o respectivo valor: ");
        fgets(entrada, sizeof(entrada), stdin);
        }

    printf ("\nPrograma encerrado...\n");
    return 0;
}
