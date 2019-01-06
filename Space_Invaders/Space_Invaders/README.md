2º Projeto de Linguagens de Programação II 2018/2019

Antonio Louro  (a21702439)

Hugo Martins   (a21701372)

Pedro Oliveira (a21705187)

Repositório: https://github.com/psioliveira/LP2_P2_Space_Invaders

António: Enemy, Neutral, Player, Program, Scenario, Slot

Hugo: Enemy, ConsoleRenderer2D, IEntity, Player, Scenario, README.md

Pedro: Enemy, ConsoleRenderer2D, IEntity, IRenderer2D, Neutral, Player, Program,
       Scenario, Slot

Descrição da solução: O objetivo deste projeto foi recriar o jogo "Space Invaders" 
e aplicou-se os seguintes requesitos técnicos mínimos:

-O uso de duas threads, a principal que executa o Game Loop, e o outro para ler
o input do jogador.


-O "Game Loop" que neste projeto verifica se há input do jogador, atualizar o jogo 
e imprime as alterações.


Este programa começa ao atribuir uma thread para ler os inputs do jogador e outro
para gerir as ações do jogo, principalmente inicializando todas as instâncias do 
jogo e coloca-as numa matriz para ser renderizada pelo 'IRenderer2D.cs'.
As classes 'Player.cs', 'Enemy.cs' e 'Scenario.cs' fazem parte da mesma interface do
projeto.

A classe 'Enemy.cs' tem a função de atribuir que tipo de inimigo é, a sua respetiva 
pontuação após matar e a que velocidade se mexem. 

A classe 'Player.cs' tem a função de mexer de acordo com o input do jogador e verifica se morreu.

As classes 'ConsoleRenderer2D.cs', 'IRender2D.cs', 'IEntity.cs' 'Scenario.cs' e 
'Slot.cs' têm a função de criar e renderizar o cenário.

Conclusão: Não conseguimos acabar o projeto devido ao seguinte:

-O Game Loop, Update e a Inteligência artificial dos inimigos não foram finalizados.
-O Renderer não pode ser chamado devido ao Game Loop não estar devidamente pronto.

No entanto, nós aprendemos a aplicar threads para executarem certas funções que
atribuímos, porém tivemos dificuldades em compreender como realizar o update e o game loop.