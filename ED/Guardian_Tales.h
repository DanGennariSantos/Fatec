#ifndef GUARDIAN_TALES_H
#define GUARDIAN_TALES_H

#define MAXNOME 30

//----------------TAD-------------

typedef struct {
    int dia;
    int mes;
    int ano;
} Data;

typedef struct {
    char nome[MAXNOME];
    int pontuacao;
    Data data;
} Jogador;

Jogador lerJogador();
int numJogadores = 0;

//--------------funções------------

void ChamarMenu(Jogador *jogadores);
void Jogar(Jogador *jogadores, int *numJogadores);
void MostrarAlta(Jogador *jogadores);
void MostrarBaixa(Jogador *jogadores);
void MostrarDados(Jogador *jogadores);
void MostrarNumJogadores(Jogador *jogadores);
void MostrarRanking(Jogador *jogadores);
void RemoverJogador(Jogador *jogadores, int *numJogadores);
void Finalizar();
int gerarAleatorio();
int proxJogador(Jogador *jogadores, int *numJogadores);
int EncontrarJogador(Jogador *jogadores, int *numJogadores, char *nome);
void exibirPessoa(Jogador pessoa);
int EncontrarPiorJogador(Jogador *jogadores, int *numJogadores);

#endif
