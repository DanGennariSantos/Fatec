//beecrowd 1171
#include <stdio.h>

typedef struct {
    int numero;
    int qtd;
} TNUMERO;

//-------------------------Algortimo de ordena��o por sele��o----------------
void selecao(TNUMERO *vetor, int tamanho) {
    int i, j, minimo;

    // Percorre o vetor
    for (i = 0; i < tamanho-1; i++) {
        // Encontra o elemento m�nimo no vetor n�o ordenado
        minimo = i;
        for (j = i + 1; j < tamanho; j++)
            if (vetor[j].numero < vetor[minimo].numero)
                minimo = j;

        // Troca o elemento m�nimo com o primeiro elemento n�o ordenado
        TNUMERO auxiliar = vetor[minimo];
        vetor[minimo] = vetor[i];
        vetor[i] = auxiliar;
    }
}
//--------------------------Pesquisa Bin�ria--------------------------------
int pesquisaBinaria(TNUMERO *vetor, int inicio, int fim, int numero) {
    while (inicio <= fim) {
        int meio = (inicio + fim) / 2;

        if (vetor[meio].numero == numero) {
            return meio;
        } else if (vetor[meio].numero < numero) {
            inicio = meio + 1;
        } else {
            fim = meio - 1;
        }
    }

    return -1; // Retorna -1 se o caractere n�o for encontrado
}

void main()
{
    int qtdEntradas;
    printf("Informe a quantidade de entradas: ");
    scanf("%i", &qtdEntradas);

    TNUMERO entrada[qtdEntradas];
    for (int i = 0; i < qtdEntradas; i++)
    {
        printf("Informe o valor [%i]: ", i + 1);
        scanf("%i", &entrada[i].numero);
    }

    TNUMERO saida[qtdEntradas];
    int j = 0;
    for (int i = 0; i < qtdEntradas; i++)
    {
        selecao(saida, qtdEntradas);

        //pesquisar se o n�mero j� existe no vetor
        int indice = pesquisaBinaria(saida, 0, j, entrada[i].numero);

        //se o n�mero N�O existe no vetor, inclu�-lo numa nova posi��o (�ndice) no vetor sa�da
        if (indice == -1)
        {
            saida[j].numero = entrada[i].numero;
            saida[j].qtd = 1;
            j++;
        }

        //se o n�mero j� existe no vetor, somar na quantidade
        else
        {
            saida[indice].qtd++; //incrementa a quantidade do numero encontrado
        }

    }

    //outro for para imprimir em ordem crescente de numero
    for (int i = 0; i < j; i++){
        if (saida[i].qtd > 0)
        printf("%d aparece %d vez(es)\n", saida[i].numero, saida[i].qtd);
    }
}
