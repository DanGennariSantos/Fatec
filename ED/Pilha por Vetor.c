#include <stdio.h>
#include <stdlib.h>

typedef struct hotel Hotel;

typedef struct hospede Hospede;

void cria (Hotel* p);
void push (Hotel* p);
int pop (Hotel* p);
int vazia (Hotel* p);

#define MAX 10

struct hospede {
    int codigo;
    float peso;
    char sexo;
};

struct hotel {
    int n;
    Hospede vet[MAX];
};

void cria (Hotel* p)
{
    p->n = 0; /* inicializa com zero elementos */
}

/*  Para inserir um elemento na pilha, usa-se a pr�xima posi��o livre do vetor. Deve-se
    ainda assegurar que exista espa�o para a inser��o do novo elemento, tendo em vista que trata-se de um vetor com dimens�o fixa. */

void push (Hotel* p)
{
    int numero;
    float pesoInformado;
    char sexoInformado;

    if (p->n == MAX) { /* capacidade esgotada */
        printf("-->> Capacidade da pilha estourou.\n");
        return;
    }

    printf("\nInserir novo codigo no hotel:\n");
    printf("Informe o codigo a ser colocado no hotel: ");
    scanf("%d", &numero);
    printf("\nInforme o peso: ");
    scanf("%f", &pesoInformado);
    printf("\nInforme o sexo: ");
    scanf(" %c", &sexoInformado);

    /* insere elemento na pr�xima posi��o livre */
    p->vet[p->n].codigo = numero;
    p->vet[p->n].peso = pesoInformado;
    p->vet[p->n].sexo = sexoInformado;
    p->n++;
}

/*  A fun��o pop retira o elemento do topo da pilha, fornecendo seu valor como retorno.  Podemos tamb�m verificar se a pilha est� ou n�o vazia.  */

int pop (Hotel* p)
{
    int v;
    if (vazia(p)) {
        printf("-->> Hotel vazio.\n");
        return 0;//exit(1); /* aborta programa */
    }
    /* retira elemento do topo */
    v = p->vet[p->n-1].codigo;
    p->n--;
    printf("-->> Elemento retirado do topo do hotel.\n");
    return v;
}

/*  A fun��o pop retira o elemento do topo da pilha, fornecendo seu valor como retorno, para ser usado, se necess�rio.  Pode-se tamb�m verificar se a pilha est� ou n�o vazia.  */

void mostraTopo (Hotel* p)
{
    int v;
    if (vazia(p)) {
        printf("-->> Hotel vazio.\n");
        return;
    }
    /* mostra elemento do topo */
    printf("-->> Elemento no topo do hotel = Codigo: %d, Peso: %f, Sexo: %c\n",p->vet[p->n-1].codigo, p->vet[p->n-1].peso, p->vet[p->n-1].sexo);
}

/*  A fun��o que verifica se a pilha est� vazia pode ser dada por:  */
int vazia (Hotel* p)
{
    return (p->n == 0);
}

int main(void)
{
	int opt;
	Hotel vetor;

	cria(&vetor);

    while(opt != 5)
    {
        printf("\nDigite a opcao\n");
        printf("1 - Inserir novo elemento\n");
		printf("2 - Remover elemento\n");
		printf("3 - Ver elemento do topo\n");
		printf("4 - Inicializar pilha\n");
		printf("5 - Sair\n");

		printf("\nDigite a opcao desejada: ");
		scanf("%d", &opt);

		if(opt == 1)
            push(&vetor);
        if(opt == 2)
            pop(&vetor);
        if(opt == 3)
            mostraTopo(&vetor);
        if(opt == 4)
            cria(&vetor);
    }
	return 0;
}


