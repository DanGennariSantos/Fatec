#ifndef GUARDIAN_TALES_H
#define GUARDIAN_TALES_H

//----------------TAD-------------

typedef struct {
    int dia;
    int mes;
    int ano;
} Data;

typedef struct {
    char nome[30];
    int pontuacao;
    Data data;
} Jogador;

Jogador lerJogador();

//--------------funções------------

void ChamarMenu(Jogador *jogadores);
void Jogar(Jogador *jogadores);
void MostrarAlta(Jogador *jogadores);
void MostrarBaixa(Jogador *jogadores);
void MostrarDados();
void MostrarNumJogadores(Jogador *jogadores);
void MostrarRanking(Jogador *jogadores);
void RemoverJogador();
void Finalizar();
int gerarAleatorio();
int proxJogador(Jogador *jogadores);

void exibirPessoa(Jogador pessoa);

#endif
