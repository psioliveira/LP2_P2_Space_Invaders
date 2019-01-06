2� Projeto de Linguagens de Programa��o II 2018/2019

Antonio Louro  (a21702439)

Hugo Martins   (a21701372)

Pedro Oliveira (a21705187)

Reposit�rio: https://github.com/psioliveira/LP2_P2_Space_Invaders

Ant�nio: Enemy, Neutral, Player, Program, Scenario, Slot

Hugo: Enemy, ConsoleRenderer2D, IEntity, Player, Scenario, README.md

Pedro: Enemy, ConsoleRenderer2D, IEntity, IRenderer2D, Neutral, Player, Program,
       Scenario, Slot

Descri��o da solu��o: O objetivo deste projeto foi recriar o jogo "Space Invaders" 
e aplicou-se os seguintes requesitos t�cnicos m�nimos:

-O uso de duas threads, a principal que executa o Game Loop, e o outro para ler
o input do jogador.


-O "Game Loop" que neste projeto verifica se h� input do jogador, atualizar o jogo 
e imprime as altera��es.


Este programa come�a ao atribuir uma thread para ler os inputs do jogador e outro
para gerir as a��es do jogo, principalmente inicializando todas as inst�ncias do 
jogo e coloca-as numa matriz para ser renderizada pelo 'IRenderer2D.cs'.
As classes 'Player.cs', 'Enemy.cs' e 'Scenario.cs' fazem parte da mesma interface do
projeto.

A classe 'Enemy.cs' tem a fun��o de atribuir que tipo de inimigo �, a sua respetiva 
pontua��o ap�s matar e a que velocidade se mexem. 

A classe 'Player.cs' tem a fun��o de mexer de acordo com o input do jogador e verifica se morreu.

As classes 'ConsoleRenderer2D.cs', 'IRender2D.cs', 'IEntity.cs' 'Scenario.cs' e 
'Slot.cs' t�m a fun��o de criar e renderizar o cen�rio.

Conclus�o: N�o conseguimos acabar o projeto devido ao seguinte:

-O Game Loop, Update e a Intelig�ncia artificial dos inimigos n�o foram finalizados.
-O Renderer n�o pode ser chamado devido ao Game Loop n�o estar devidamente pronto.

No entanto, n�s aprendemos a aplicar threads para executarem certas fun��es que
atribu�mos, por�m tivemos dificuldades em compreender como realizar o update e o game loop.